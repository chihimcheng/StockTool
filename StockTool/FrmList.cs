using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using stockMgr;

namespace StockTool
{
    public partial class FrmList : Form
    {
        private StockMgr _stockMgr;
        private string _filename;
        private string _status = "";
        private Thread refleshThread = null;
        private Mutex refleshMutex = new Mutex();
        private delegate void _UpdateStatusDelegate(string status);

        private void _UpdateStatus(string status)
        {
            _status = status;
            ((MdiStockTool)MdiParent).writeStatusBar(this, status);
        }

        public FrmList(StockMgr mgr)
        {
            _stockMgr = mgr;
            _filename = null;
            InitializeComponent();
        }

        public FrmList(StockMgr mgr, string filename)
        {
            _stockMgr = mgr;
            _filename = filename;
            InitializeComponent();
        }

        private void refleshData() 
        {
            if (refleshMutex.WaitOne(0))
            {
                _UpdateStatusDelegate updateStatusDele = new _UpdateStatusDelegate(_UpdateStatus);
                Invoke(updateStatusDele, new object[] { "更新中..." });
                StockData[] stocks = new StockData[dgvStockList.Rows.Count];
                for (int i = 0; i < dgvStockList.Rows.Count; i++)
                    stocks[i] = new StockData((string)dgvStockList.Rows[i].Cells["colCode"].Value);

                try
                {
                    _stockMgr.RefreshHKIndice();
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
                    dgvStockList.Rows[i].Cells["colCode"].ToolTipText = stocks[i].name;
                    dgvStockList.Rows[i].Cells["colPrice"].Value = stocks[i].close;
                    dgvStockList.Rows[i].Cells["colChange"].Value = stocks[i].change;
                    dgvStockList.Rows[i].Cells["colROC"].Value = stocks[i].ROC;
                    if (!float.IsNaN(stocks[i].low) && !float.IsNaN(stocks[i].high))
                        dgvStockList.Rows[i].Cells["colTodayHL"].Value = stocks[i].low.ToString("F3") + " - " + stocks[i].high.ToString("F3");
                    else
                        dgvStockList.Rows[i].Cells["colTodayHL"].Value = null;
                }
                Invoke(updateStatusDele, new object[] { "" });
                refleshThread = null;
                refleshMutex.ReleaseMutex();
            }
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_filename))
            {
                StreamReader sr = new StreamReader(_filename, System.Text.Encoding.Default);
                try
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] stockCodes = line.Split(' ');
                        for (int i = 0; i < stockCodes.Length; i++)
                        {
                            dgvStockList.Rows.Add();
                            dgvStockList.Rows[dgvStockList.Rows.Count - 1].Cells["colCode"].Value = stockMgr.StockData.CodeFromString(stockCodes[i]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
                finally
                {
                    sr.Close();
                }
                refleshThread = new Thread(refleshData);
                refleshThread.Start();
            }
        }

        private void numericUpDownReflesh_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownReflesh.Value == 0)
            {
                timerReflesh.Enabled = false;
            }
            else
            {
                timerReflesh.Interval = (int)numericUpDownReflesh.Value * 1000;
                timerReflesh.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDownReflesh.Value > 0)
            {
                timerReflesh.Stop();
                timerReflesh.Start();
            }

            if (refleshThread == null)
            {
                refleshThread = new Thread(refleshData);
                refleshThread.Start();
            }
        }

        private void timerReflesh_Tick(object sender, EventArgs e)
        {
            if (refleshThread == null)
            {
                refleshThread = new Thread(refleshData);
                refleshThread.Start();
            }
        }

        private void dgvStockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1)
                return;
            FrmSingleStock singleStockView = new FrmSingleStock(_stockMgr,(string)dgvStockList.Rows[i].Cells["colCode"].Value);
            singleStockView.MdiParent = this.MdiParent;
            singleStockView.Show();
        }

        private void FrmList_Activated(object sender, EventArgs e)
        {
            ((MdiStockTool)MdiParent).writeStatusBar(this, _status);
        }

        private void FrmList_Deactivate(object sender, EventArgs e)
        {
            ((MdiStockTool)MdiParent).writeStatusBar(this, "");
        }

        private void FrmList_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MdiStockTool)MdiParent).writeStatusBar(this, "");
        }        
    }
}
