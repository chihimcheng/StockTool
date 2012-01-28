using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Him.Collections.Generic;
using stockMgr;
using Profolio;

namespace StockTool
{
    public partial class FrmQueryTransaction : Form
    {
        private ProfolioMgr _profolioMgr;
        private StockMgr _stockMgr;
        private LinkedList<Transaction> _tran = null, _futureTran = null;
        private SortedDictionary<string, List<Transaction>> _tranDct = new SortedDictionary<string, List<Transaction>>();
        private SortedDictionary<string, SortedDictionary<string, List<FutureTransaction>>> _tranFutureDct = new SortedDictionary<string, SortedDictionary<string, List<FutureTransaction>>>();
        private SortedDictionary<string, Transaction> _netTran = new SortedDictionary<string,Transaction>();
        private SortedDictionary<string, FutureTransaction> _netTranFurture = new SortedDictionary<string, FutureTransaction>();
        private SortedDictionary<string, Transaction> _prevBalance = new SortedDictionary<string, Transaction>();
        private SortedDictionary<string, SortedDictionary<string, FutureTransaction>> _prevBalanceFuture = new SortedDictionary<string, SortedDictionary<string, FutureTransaction>>();
        private SortedDictionary<string, Transaction> _postBalance = new SortedDictionary<string, Transaction>();
        private SortedDictionary<string, SortedDictionary<string, FutureTransaction>> _postBalanceFuture = new SortedDictionary<string, SortedDictionary<string, FutureTransaction>>();
        private Thread _queryThread = null;
        private delegate void _UpdateTransactionCB(List<Transaction> transactions);
        private delegate void _UpdateReturnCB();

        public FrmQueryTransaction(StockMgr stockMgr, ProfolioMgr profolioMgr)
        {
            _stockMgr = stockMgr;
            _profolioMgr = profolioMgr;
            InitializeComponent();
        }

        private void _AddTransactionToDgvTransaction(Transaction tran)
        {
            dgvTransaction.Rows.Add();
            DataGridViewRow newRow = dgvTransaction.Rows[dgvTransaction.Rows.Count - 1];
            newRow.Cells["colTCode"].Value = tran.code;
            newRow.Cells["colTTranDate"].Value = tran.date.ToShortDateString();
            newRow.Cells["colTAmount"].Value = tran.amount;
            newRow.Cells["colTPayment"].Value = tran.payment;
            newRow.Cells["colTDescription"].Value = tran.description;
            if (tran.GetType() == typeof(FutureTransaction))
            {
                newRow.Cells["colTContractCode"].Value = ((FutureTransaction)tran).contractCode;
            }
        }

        private void _AddTransactionToDgvBalance(DataGridView dgvBalance, Transaction tran)
        {
            dgvBalance.Rows.Add();
            DataGridViewRow newRow = dgvBalance.Rows[dgvBalance.Rows.Count - 1];
            newRow.Cells[0].Value = tran.code;
            newRow.Cells[2].Value = tran.date.ToShortDateString();
            newRow.Cells[3].Value = tran.amount;
            newRow.Cells[4].Value = -tran.payment / tran.amount;
            newRow.Cells[5].Value = tran.payment;
            if (tran.GetType() == typeof(FutureTransaction))
            {
                newRow.Cells[1].Value = ((FutureTransaction)tran).contractCode;
            }
        }

        private void _AddReturnInfoToDgvReturn(ReturnInfo info)
        {
            dgvReturn.Rows.Add();
            DataGridViewRow newRow = dgvReturn.Rows[dgvReturn.Rows.Count - 1];
            newRow.Cells["colRCode"].Value = info.code;
            newRow.Cells["colREarning"].Value = info.earning;
            newRow.Cells["colRBreakEven"].Value = (!double.IsNaN(info.breakEven)) ? (object)info.breakEven : (object)"N/A";
            newRow.Cells["colRROI"].Value = info.ROI * 100;
        }

        private void _UpdateDgvTransaction(List<Transaction> transactions)
        {
            foreach (Transaction tran in transactions)
                _AddTransactionToDgvTransaction(tran);
            double netTotal = 0;
            foreach (Transaction tran in _netTran.Values)
            {
                _AddTransactionToDgvTransaction(tran);
                dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightBlue;
                netTotal += tran.payment;
            }
            foreach (FutureTransaction ft in _netTranFurture.Values)
            {
                _AddTransactionToDgvTransaction(ft);
                dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightBlue;
                netTotal += ft.payment;
            }
            dgvTransaction.Rows.Add();
            DataGridViewRow newRow = dgvTransaction.Rows[dgvTransaction.Rows.Count - 1];
            newRow.Cells["colTCode"].Value = "TOTAL";
            newRow.Cells["colTPayment"].Value = netTotal;
            newRow.Cells["colTDescription"].Value = "總淨交易";
            newRow.DefaultCellStyle.BackColor = Color.LightPink;
        }

        private void _UpdateReturn()
        {
            foreach (KeyValuePair<string, Transaction> kwp in _prevBalance)
                _AddTransactionToDgvBalance(dgvPrevBalance, kwp.Value);
            foreach (KeyValuePair<string, SortedDictionary<string, FutureTransaction>> pbDict in _prevBalanceFuture)
            {
                foreach (KeyValuePair<string, FutureTransaction> kwp in pbDict.Value)
                    _AddTransactionToDgvBalance(dgvPrevBalance, kwp.Value);
            }
            foreach (KeyValuePair<string, Transaction> kwp in _postBalance)
                _AddTransactionToDgvBalance(dgvPostBalance, kwp.Value);
            foreach (KeyValuePair<string, SortedDictionary<string, FutureTransaction>> pbDict in _postBalanceFuture)
            {
                foreach (KeyValuePair<string, FutureTransaction> kwp in pbDict.Value)
                    _AddTransactionToDgvBalance(dgvPostBalance, kwp.Value);
            }

            //Process return
            _UpdateDgvReturn();
        }

        private void _UpdateDgvReturn()
        {
            dgvReturn.Rows.Clear();
            SortedDictionary<string, ReturnInfo> returnInfo = new SortedDictionary<string, ReturnInfo>();
            foreach (string code in _prevBalance.Keys)
            {
                returnInfo.Add(code, new ReturnInfo(code));
            }
            foreach (string code in _prevBalanceFuture.Keys)
            {
                if (!returnInfo.ContainsKey(code))
                    returnInfo.Add(code, new ReturnInfo(code));
            }
            foreach (string code in _netTran.Keys)
            {
                if (!returnInfo.ContainsKey(code))
                    returnInfo.Add(code, new ReturnInfo(code));
            }
            foreach (string code in _netTranFurture.Keys)
            {
                if (!returnInfo.ContainsKey(code))
                    returnInfo.Add(code, new ReturnInfo(code));
            }

            ReturnInfo totalReturn = new ReturnInfo("TOTAL");
            totalReturn.breakEven = double.NaN;
            List<double> allPayments = new List<double>();
            List<DateTime> allDates = new List<DateTime>();
            foreach (KeyValuePair<string, ReturnInfo> kwpRet in returnInfo)
            {
                Transaction curPrevBalance, curNetTran, curPostBalance;
                FutureTransaction curNetTranFuture;
                SortedDictionary<string, FutureTransaction> curBalanceFutureDct;
                List<double> payments = new List<double>();
                List<DateTime> dates = new List<DateTime>();
                if (_prevBalance.TryGetValue(kwpRet.Key, out curPrevBalance))
                {
                    kwpRet.Value.earning += curPrevBalance.payment;
                    payments.Add(curPrevBalance.payment);
                    dates.Add(curPrevBalance.date);
                    allPayments.Add(curPrevBalance.payment);
                    allDates.Add(curPrevBalance.date);
                }
                if (_prevBalanceFuture.TryGetValue(kwpRet.Key, out curBalanceFutureDct))
                {
                    foreach (FutureTransaction ft in curBalanceFutureDct.Values)
                    {
                        kwpRet.Value.earning += ft.payment;
                        payments.Add(ft.payment);
                        dates.Add(ft.date);
                        allPayments.Add(ft.payment);
                        allDates.Add(ft.date);
                    }
                }
                if (_netTran.TryGetValue(kwpRet.Key, out curNetTran))
                {
                    kwpRet.Value.earning += curNetTran.payment;
                    foreach (Transaction t in _tranDct[kwpRet.Key])
                    {
                        payments.Add(t.payment);
                        dates.Add(t.date);
                        allPayments.Add(t.payment);
                        allDates.Add(t.date);
                    }
                }
                if (_netTranFurture.TryGetValue(kwpRet.Key, out curNetTranFuture))
                {
                    kwpRet.Value.earning += curNetTranFuture.payment;
                    foreach (List<FutureTransaction> ftLst in _tranFutureDct[kwpRet.Key].Values)
                    {
                        foreach (FutureTransaction ft in ftLst)
                        {
                            payments.Add(ft.payment);
                            dates.Add(ft.date);
                            allPayments.Add(ft.payment);
                            allDates.Add(ft.date);
                        }
                    }
                }
                if (_postBalanceFuture.TryGetValue(kwpRet.Key, out curBalanceFutureDct))
                {
                    foreach (FutureTransaction ft in curBalanceFutureDct.Values)
                    {
                        kwpRet.Value.earning += ft.payment;
                        payments.Add(ft.payment);
                        dates.Add(ft.date);
                        allPayments.Add(ft.payment);
                        allDates.Add(ft.date);
                    }
                }
                if (_postBalance.TryGetValue(kwpRet.Key, out curPostBalance))
                {
                    kwpRet.Value.breakEven = kwpRet.Value.earning / curPostBalance.amount;
                    kwpRet.Value.earning += curPostBalance.payment;
                    payments.Add(curPostBalance.payment);
                    dates.Add(curPostBalance.date);
                    allPayments.Add(curPostBalance.payment);
                    allDates.Add(curPostBalance.date);
                }
                else
                    kwpRet.Value.breakEven = double.NaN;
                kwpRet.Value.ROI = Him.Financial.Financial.XIRR(payments.ToArray(), dates.ToArray());
                totalReturn.earning += kwpRet.Value.earning;
            }
            totalReturn.ROI = Him.Financial.Financial.XIRR(allPayments.ToArray(), allDates.ToArray());
            foreach (ReturnInfo info in returnInfo.Values)
                _AddReturnInfoToDgvReturn(info);
            _AddReturnInfoToDgvReturn(totalReturn);
            dgvReturn.Rows[dgvReturn.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightPink;
        }

        private void _DoQuery(object param)
        {
            object[] plist = (object[])param;
            DateTime from = (DateTime)plist[0];
            DateTime to = (DateTime)plist[1];

            try
            {
                if (from != DateTime.MinValue)
                {
                    LinkedList<Transaction> oldTran = _profolioMgr.GetAggregatedTransaction(typeof(Transaction), txtCode.Text, DateTime.MinValue, from.AddDays(-1));
                    foreach (Transaction t in oldTran)
                    {
                        if (t.amount != 0)
                        {
                            _prevBalance.Add(t.code, t);
                            Transaction curPostBalance = new Transaction();
                            curPostBalance.code = t.code;
                            curPostBalance.date = to;
                            curPostBalance.amount = -t.amount;
                            _postBalance.Add(t.code, curPostBalance);
                        }
                    }
                    LinkedList<Transaction> oldFutureTran = _profolioMgr.GetAggregatedTransaction(typeof(FutureTransaction), txtCode.Text, DateTime.MinValue, from.AddDays(-1));
                    foreach (Transaction ft in oldFutureTran)
                    {
                        if (ft.amount != 0)
                        {
                            SortedDictionary<string, FutureTransaction> curPrevBalanceFutureDict;
                            if (!_prevBalanceFuture.TryGetValue(ft.code, out curPrevBalanceFutureDict))
                            {
                                curPrevBalanceFutureDict = new SortedDictionary<string, FutureTransaction>();
                                _prevBalanceFuture.Add(ft.code, curPrevBalanceFutureDict);
                            }
                            curPrevBalanceFutureDict.Add(((FutureTransaction)ft).contractCode, (FutureTransaction)ft);
                            SortedDictionary<string, FutureTransaction> curPostBalanceFutureDict;
                            if (!_postBalanceFuture.TryGetValue(ft.code, out curPostBalanceFutureDict))
                            {
                                curPostBalanceFutureDict = new SortedDictionary<string, FutureTransaction>();
                                _postBalanceFuture.Add(ft.code, curPostBalanceFutureDict);
                            }
                            FutureTransaction curPostFutureBalance = new FutureTransaction();
                            curPostFutureBalance.code = ft.code;
                            curPostFutureBalance.contractCode = ((FutureTransaction)ft).contractCode;
                            curPostFutureBalance.date = to;
                            curPostFutureBalance.amount = -ft.amount;
                            curPostBalanceFutureDict.Add(((FutureTransaction)ft).contractCode, curPostFutureBalance);
                        }
                    }
                }
                _tran = _profolioMgr.GetTransaction(typeof(Transaction), txtCode.Text, from, to);
                _futureTran = _profolioMgr.GetTransaction(typeof(FutureTransaction), txtCode.Text, from, to);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _UpdateTransactionCB updateTranCB = new _UpdateTransactionCB(_UpdateDgvTransaction);
            List<Transaction> updateTranCbData = new List<Transaction>();
            //Process transaction data
            {
                LinkedListNode<Transaction> t = _tran.First, ft = _futureTran.First;
                while (t != null || ft != null)
                {
                    if (ft == null || (t != null && t.Value.date <= ft.Value.date))
                    {
                        updateTranCbData.Add(t.Value);
                        List<Transaction> curTransactionLst;
                        if (!_tranDct.TryGetValue(t.Value.code, out curTransactionLst))
                        {
                            curTransactionLst = new List<Transaction>();
                            _tranDct.Add(t.Value.code, curTransactionLst);
                        }
                        curTransactionLst.Add(t.Value);
                        t = t.Next;
                    }
                    else
                    {
                        updateTranCbData.Add(ft.Value);
                        SortedDictionary<string, List<FutureTransaction>> curDct;
                        if (!_tranFutureDct.TryGetValue(ft.Value.code, out curDct))
                        {
                            curDct = new SortedDictionary<string, List<FutureTransaction>>();
                            _tranFutureDct.Add(ft.Value.code, curDct);
                        }
                        List<FutureTransaction> curTransactionFutureLst;
                        if (!curDct.TryGetValue(((FutureTransaction)ft.Value).contractCode, out curTransactionFutureLst))
                        {
                            curTransactionFutureLst = new List<FutureTransaction>();
                            curDct.Add(((FutureTransaction)ft.Value).contractCode, curTransactionFutureLst);
                        }
                        curTransactionFutureLst.Add((FutureTransaction)ft.Value);
                        ft = ft.Next;
                    }
                }
            }
            foreach (KeyValuePair<string, List<Transaction>> kwp in _tranDct)
            {
                Transaction curNetTran = new Transaction();
                curNetTran.code = kwp.Key;
                curNetTran.date = to;
                curNetTran.amount = 0;
                curNetTran.payment = 0;
                curNetTran.description = "淨交易";
                foreach (Transaction t in kwp.Value)
                {
                    curNetTran.amount += t.amount;
                    curNetTran.payment += t.payment;
                }
                _netTran.Add(curNetTran.code, curNetTran);
                if (curNetTran.amount != 0)
                {
                    Transaction curPostBalance;
                    if (!_postBalance.TryGetValue(curNetTran.code, out curPostBalance))
                    {
                        curPostBalance = new Transaction();
                        curPostBalance.code = curNetTran.code;
                        curPostBalance.date = to;
                        curPostBalance.amount = 0;
                        _postBalance.Add(curPostBalance.code, curPostBalance);
                    }
                    curPostBalance.amount -= curNetTran.amount;
                    if (curPostBalance.amount == 0) _postBalance.Remove(curPostBalance.code);
                }
            }
            foreach (KeyValuePair<string, SortedDictionary<string, List<FutureTransaction>>> kwp in _tranFutureDct)
            {
                FutureTransaction curNetTranFuture = new FutureTransaction();
                curNetTranFuture.code = kwp.Key;
                curNetTranFuture.contractCode = "淨期貨交易";
                curNetTranFuture.date = to;
                curNetTranFuture.amount = 0;
                curNetTranFuture.payment = 0;
                curNetTranFuture.description = "淨交易";
                foreach (KeyValuePair<string, List<FutureTransaction>> kwp2 in kwp.Value)
                {
                    double tmpAmount = 0;
                    double tmpPayment = 0;
                    foreach (FutureTransaction ft in kwp2.Value)
                    {
                        tmpAmount += ft.amount;
                        tmpPayment += ft.payment;
                    }
                    curNetTranFuture.amount += tmpAmount;
                    curNetTranFuture.payment += tmpPayment;
                    if (tmpAmount != 0)
                    {
                        SortedDictionary<string, FutureTransaction> curPostBalanceDct;
                        if (!_postBalanceFuture.TryGetValue(kwp.Key, out curPostBalanceDct))
                        {
                            curPostBalanceDct = new SortedDictionary<string, FutureTransaction>();
                            _postBalanceFuture.Add(kwp.Key, curPostBalanceDct);
                        }
                        FutureTransaction curPostBalance;
                        if (!curPostBalanceDct.TryGetValue(kwp2.Key, out curPostBalance))
                        {
                            curPostBalance = new FutureTransaction();
                            curPostBalance.code = kwp.Key;
                            curPostBalance.contractCode = kwp2.Key;
                            curPostBalance.date = to;
                            curPostBalance.amount = 0;
                            curPostBalanceDct.Add(kwp2.Key, curPostBalance);
                        }
                        curPostBalance.amount -= tmpAmount;
                        if (curPostBalance.amount == 0) curPostBalanceDct.Remove(kwp2.Key);
                        if (curPostBalanceDct.Count == 0) curPostBalanceDct.Remove(kwp.Key);
                    }
                }
                _netTranFurture.Add(curNetTranFuture.code, curNetTranFuture);
            }
            Invoke(updateTranCB, new object[] { updateTranCbData });

            //Process return data
            if (_prevBalance.Count > 0)
            {
                SortedDictionary<Pair<string, string>, double> asset = new SortedDictionary<Pair<string, string>, double>();
                foreach (string code in _prevBalance.Keys)
                    asset.Add(new Pair<string, string>(code, "-"), 0);
                try
                {
                    _profolioMgr.GetHistorialPrice(asset, from.AddDays(-1));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (KeyValuePair<Pair<string, string>, double> kwp in asset)
                {
                    Transaction curTran = _prevBalance[kwp.Key.First];
                    curTran.payment = -curTran.amount * kwp.Value;
                }
            }
            if (_prevBalanceFuture.Count > 0)
            {
                SortedDictionary<Pair<string, string>, double> asset = new SortedDictionary<Pair<string, string>, double>();
                foreach (KeyValuePair<string, SortedDictionary<string, FutureTransaction>> stock in _prevBalanceFuture)
                {
                    foreach (string contractCode in stock.Value.Keys)
                        asset.Add(new Pair<string, string>(stock.Key, contractCode), 0);
                }
                try
                {
                    _profolioMgr.GetHistorialPrice(asset, from.AddDays(-1));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (KeyValuePair<Pair<string, string>, double> kwp in asset)
                {
                    Transaction curTran = _prevBalanceFuture[kwp.Key.First][kwp.Key.Second];
                    curTran.payment = -curTran.amount * kwp.Value;
                }
            }
            if (_postBalance.Count > 0)
            {
                if (to < DateTime.Today)
                {
                    SortedDictionary<Pair<string, string>, double> asset = new SortedDictionary<Pair<string, string>, double>();
                    foreach (string code in _postBalance.Keys)
                        asset.Add(new Pair<string, string>(code, "-"), 0);
                    try
                    {
                        _profolioMgr.GetHistorialPrice(asset, to);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    foreach (KeyValuePair<Pair<string, string>, double> kwp in asset)
                    {
                        Transaction curTran = _postBalance[kwp.Key.First];
                        curTran.payment = -curTran.amount * kwp.Value;
                    }
                }
                else
                {
                    List<StockData> asset = new List<StockData>();
                    foreach (string code in _postBalance.Keys)
                    {
                        StockData stockData = new StockData();
                        stockData.code = code;
                        asset.Add(stockData);
                    }
                    try
                    {
                        _stockMgr.GetQuote(asset.ToArray());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    foreach (StockData stock in asset)
                    {
                        Transaction curTran = _postBalance[stock.code];
                        curTran.date = DateTime.Today;
                        curTran.payment = -curTran.amount * stock.close;
                    }
                }
            }
            if (_postBalanceFuture.Count > 0)
            {
                SortedDictionary<Pair<string, string>, double> asset = new SortedDictionary<Pair<string, string>, double>();
                foreach (KeyValuePair<string, SortedDictionary<string, FutureTransaction>> stock in _postBalanceFuture)
                {
                    foreach (string contractCode in stock.Value.Keys)
                        asset.Add(new Pair<string, string>(stock.Key, contractCode), 0);
                }
                try
                {
                    _profolioMgr.GetHistorialPrice(asset, to);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (KeyValuePair<Pair<string, string>, double> kwp in asset)
                {
                    Transaction curTran = _postBalanceFuture[kwp.Key.First][kwp.Key.Second];
                    if (to >= DateTime.Today) curTran.date = DateTime.Today;
                    curTran.payment = -curTran.amount * kwp.Value;
                }
            }
            Invoke(new _UpdateReturnCB(_UpdateReturn));
        }

        private void _Reset()
        {
            _tran = _futureTran = null;
            _netTran.Clear();
            _netTranFurture.Clear();
            _tranDct.Clear();
            _tranFutureDct.Clear();
            _prevBalance.Clear();
            _prevBalanceFuture.Clear();
            _postBalance.Clear();
            _postBalanceFuture.Clear();
            dgvTransaction.Rows.Clear();
            dgvPrevBalance.Rows.Clear();
            dgvPostBalance.Rows.Clear();
            dgvReturn.Rows.Clear();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            _Reset();
            DateTime from = DateTime.MinValue, to = DateTime.MaxValue;
            if (!string.IsNullOrEmpty(txtDateFrom.Text))
            {
                if (!DateTime.TryParse(txtDateFrom.Text, out from))
                {
                    MessageBox.Show("日期輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrEmpty(txtDateTo.Text))
            {
                if (!DateTime.TryParse(txtDateTo.Text, out to))
                {
                    MessageBox.Show("日期輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            object[] plist = new object[2];
            plist[0] = from;
            plist[1] = to;
            _queryThread = new Thread(_DoQuery);
            _queryThread.Start(plist);
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text))
                txtCode.Text = StockData.CodeFromString(txtCode.Text);
        }

        private void dgvPrevBalance_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("end edit");
        }
    }
}
