using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using System.Threading;
using stockMgr;

namespace StockTool
{
    public partial class FrmIndex : Form
    {
        private StockMgr _stockMgr;
        private ArrayList _indexLists = new ArrayList();
        private string _status = "";
        private Thread _refleshThread = null;
        private Mutex _refleshMutex = new Mutex();
        private delegate void _UpdateStatusDelegate(string status);

        private void _UpdateStatus(string status)
        {
            _status = status;
            ((MdiStockTool)MdiParent).writeStatusBar(this, status);
        }

        public FrmIndex(StockMgr mgr)
        {
            _stockMgr = mgr;
            InitializeComponent();

            try
            {
                XmlDocument xmlConfig = new XmlDocument();
                xmlConfig.Load("StockTool.config");
                XmlElement config = (XmlElement)xmlConfig.GetElementsByTagName("configuration")[0];
                XmlElement indexLists = (XmlElement)config.GetElementsByTagName("index_lists")[0];
                XmlNodeList lists = indexLists.GetElementsByTagName("list");
                foreach (XmlElement list in lists)
                {
                    KeyValuePair<string, ArrayList> newList = new KeyValuePair<string, ArrayList>(list.GetAttribute("name").Trim(), new ArrayList());
                    XmlNodeList items = list.GetElementsByTagName("item");
                    foreach (XmlElement item in items)
                        newList.Value.Add(new KeyValuePair<string, string>(item.GetAttribute("code").Trim(), item.GetAttribute("name").Trim()));
                    _indexLists.Add(newList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(DateTime.Now.ToString() + " Loading config file error");
            }

            foreach (KeyValuePair<string, ArrayList> list in _indexLists)
                cmbIndexType.Items.Add(list.Key);
        }

        private void refleshData()
        {
            if (_refleshMutex.WaitOne(0))
            {
                _UpdateStatusDelegate updateStatusDele = new _UpdateStatusDelegate(_UpdateStatus);
                Invoke(updateStatusDele, new object[] { "更新中..." });

                StockData[] stocks = new StockData[dgvStockList.Rows.Count];
                for (int i = 0; i < dgvStockList.Rows.Count; i++)
                    stocks[i] = new StockData((string)dgvStockList.Rows[i].Cells["colName"].Tag);

                _stockMgr.RefreshHKIndice();
                try
                {
                    _stockMgr.GetQuote(stocks);
                }
                catch (ThreadAbortException)
                {
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                for (int i = 0; i < dgvStockList.Rows.Count; i++)
                {
                    dgvStockList.Rows[i].DefaultCellStyle.BackColor = StockTool.Layout.getRocColor(stocks[i].ROC);
                    dgvStockList.Rows[i].Cells["colPrice"].Value = stocks[i].close;
                    dgvStockList.Rows[i].Cells["colChange"].Value = stocks[i].change;
                    dgvStockList.Rows[i].Cells["colROC"].Value = stocks[i].ROC;
                    if (!float.IsNaN(stocks[i].low) && !float.IsNaN(stocks[i].high))
                        dgvStockList.Rows[i].Cells["colTodayHL"].Value = stocks[i].low.ToString("F3") + " - " + stocks[i].high.ToString("F3");
                    else
                        dgvStockList.Rows[i].Cells["colTodayHL"].Value = null;
                }
                Invoke(updateStatusDele, new object[] { "" });
                _refleshMutex.ReleaseMutex();
                _refleshThread = null;
            }
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {
            if (cmbIndexType.Items.Count > 0)
                cmbIndexType.Text = (string)cmbIndexType.Items[0];
        }

        private void frmIndex_SizeChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownReflesh_ValueChanged_1(object sender, EventArgs e)
        {
            if (numericUpDownRefresh.Value == 0)
            {
                timerReflesh.Enabled = false;
            }
            else
            {
                timerReflesh.Interval = (int)numericUpDownRefresh.Value * 1000;
                timerReflesh.Enabled = true;
            }
        }

        private void timerReflesh_Tick(object sender, EventArgs e)
        {
            refleshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDownRefresh.Value > 0)
            {
                timerReflesh.Stop();
                timerReflesh.Start();
            }
            if (_refleshThread == null)
            {
                _refleshThread = new Thread(refleshData);
                _refleshThread.Start();
            }
        }

        private void cmbIndexType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStockList.Rows.Clear();
            ArrayList items = ((KeyValuePair<string, ArrayList>)_indexLists[cmbIndexType.SelectedIndex]).Value;
            if (items.Count > 0)
            {
                dgvStockList.Rows.Add(items.Count);
                for (int i = 0; i < items.Count; i++)
                {
                    dgvStockList.Rows[i].Cells["colName"].Value = ((KeyValuePair<string, string>)items[i]).Value;
                    dgvStockList.Rows[i].Cells["colName"].Tag = ((KeyValuePair<string, string>)items[i]).Key;
                }
                if (_refleshThread == null)
                {
                    _refleshThread = new Thread(refleshData);
                    _refleshThread.Start();
                }
            }
        }

        private void dgvStockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1)
                return;
            FrmSingleStock singleStockView = new FrmSingleStock(_stockMgr, (string)dgvStockList.Rows[i].Cells["colName"].Tag);
            singleStockView.MdiParent = this.MdiParent;
            singleStockView.Show();
        }

        private void FrmIndex_Activated(object sender, EventArgs e)
        {
            ((MdiStockTool)MdiParent).writeStatusBar(this, _status);
        }

        private void FrmIndex_Deactivate(object sender, EventArgs e)
        {
            ((MdiStockTool)MdiParent).writeStatusBar(this, "");
        }

        private void FrmIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MdiStockTool)MdiParent).writeStatusBar(this, "");
        }
    }
}
