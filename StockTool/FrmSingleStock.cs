using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using stockMgr;

namespace StockTool
{
    public partial class FrmSingleStock : Form
    {
        private readonly StockMgr _stockMgr;
        private string _status = "";
        private Thread _refleshThread = null;
        private Mutex _refleshMutex = new Mutex();
        private delegate void _UpdateDataDelegate(ExtentedStockData stock);
        private delegate void _UpdateStatusDelegate(string status);

        private void _UpdateData(ExtentedStockData stock)
        {
            lblName.Text = stock.name;
            lblPrice.Text = stock.close.ToString("F3");
            lblChange.Text = stock.change.ToString("F3");
            lblROC.Text = stock.ROC.ToString("F3") + "%";
            Color changeColor;
            if (stock.change > 0)
                changeColor = Color.LimeGreen;
            else if (stock.change < 0)
                changeColor = Color.Red;
            else
                changeColor = Color.Black;
            lblPrice.ForeColor = changeColor;
            lblChange.ForeColor = changeColor;
            lblROC.ForeColor = changeColor;
            lblHigh.Text = float.IsNaN(stock.high) ? "N/A" : stock.high.ToString("0.000");
            lblLow.Text = float.IsNaN(stock.low) ? "N/A" : stock.low.ToString("0.000");
            lblVolume.Text = stock.volume.ToString("N0");
            lblMthHigh.Text = float.IsNaN(stock.mthHigh) ? "N/A" : stock.mthHigh.ToString("0.000");
            lblMthLow.Text = float.IsNaN(stock.mthLow) ? "N/A" : stock.mthLow.ToString("0.000");
            lblWk52High.Text = float.IsNaN(stock.wk52High) ? "N/A" : stock.wk52High.ToString("0.000");
            lblWk52Low.Text = float.IsNaN(stock.wk52Low) ? "N/A" : stock.wk52Low.ToString("0.000");
            lblMa10.Text = float.IsNaN(stock.ma10) ? "N/A" : stock.ma10.ToString("0.000");
            lblMa20.Text = float.IsNaN(stock.ma20) ? "N/A" : stock.ma20.ToString("0.000");
            lblMa50.Text = float.IsNaN(stock.ma50) ? "N/A" : stock.ma50.ToString("0.000");
            lblRsi10.Text = float.IsNaN(stock.rsi10) ? "N/A" : stock.rsi10.ToString("0.000");
            lblRsi14.Text = float.IsNaN(stock.rsi14) ? "N/A" : stock.rsi14.ToString("0.000");
            lblRsi20.Text = float.IsNaN(stock.rsi20) ? "N/A" : stock.rsi20.ToString("0.000");
            float imgScaleW = (float)pictureBoxChart.Width / stock.img.Width;
            float imgScaleH = (float)pictureBoxChart.Height / stock.img.Height;
            float imgScale = (imgScaleW < imgScaleH) ? imgScaleW : imgScaleH;
            pictureBoxChart.Image = new Bitmap(stock.img, (int)(stock.img.Width * imgScale), (int)(stock.img.Height * imgScale));
        }

        private void _UpdateStatus(string status)
        {
            _status = status;
            ((MdiStockTool)MdiParent).writeStatusBar(this, status);
        }

        public FrmSingleStock(StockMgr mgr)
        {
            _stockMgr = mgr;
            InitializeComponent();
        }

        public FrmSingleStock(StockMgr mgr, string code)
        {
            _stockMgr = mgr;
            InitializeComponent();
            txtCode.Text = code;
        }

        private void RefleshData()
        {
            if (_refleshMutex.WaitOne())
            {
                _UpdateStatusDelegate updateStatusDele = new _UpdateStatusDelegate(_UpdateStatus);
                Invoke(updateStatusDele, new object[] { "更新中..." });
                if (!String.IsNullOrEmpty(txtCode.Text))
                {
                    if (txtCode.Text[0] == '^')
                        _stockMgr.RefreshHKIndice();   //Will be remove later
                    ExtentedStockData stock = new ExtentedStockData((string)txtCode.Text.Clone());
                    if (txtCode.Text.EndsWith(".HK"))
                        lblChartAnay.Links[0].LinkData = "http://www.aastocks.com/tc/stock/DetailChart.aspx?&symbol=" + txtCode.Text.Substring(0, txtCode.Text.Length - 3);
                    else
                        lblChartAnay.Links[0].LinkData = "http://hk.finance.yahoo.com/q/ta?s=" + txtCode.Text;
                    try
                    {
                        _stockMgr.GetQuote(stock);
                        System.Net.HttpWebRequest imgRequest;
                        if (txtCode.Text.EndsWith(".HK"))
                            imgRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create("http://money18.on.cc/chart/d1/img/s_w_" + txtCode.Text.Substring(0, txtCode.Text.Length - 3) + ".jpg");
                        //imgRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create("http://ichart.finance.yahoo.com/t?s=" + txtCode.Text.Substring(1));
                        else
                            imgRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create("http://ichart.finance.yahoo.com/t?s=" + txtCode.Text);
                        System.Net.HttpWebResponse imgResponse = (System.Net.HttpWebResponse)imgRequest.GetResponse();
                        System.IO.Stream imgStream = imgResponse.GetResponseStream();
                        stock.img = Image.FromStream(imgStream);
                        imgStream.Close();
                        imgResponse.Close();

                        _UpdateDataDelegate updateDele = new _UpdateDataDelegate(_UpdateData);
                        Invoke(updateDele, new object[] { stock });
                    }
                    catch (ThreadAbortException)
                    {
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Invoke(updateStatusDele, new object[] { "" });
                _refleshThread = null;
                _refleshMutex.ReleaseMutex();
            }
        }

        private void FrmSingleStock_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCode.Text))
            {
                _refleshThread = new Thread(RefleshData);
                _refleshThread.Start();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtCode.Text = stockMgr.StockData.CodeFromString(txtCode.Text);
            if (_refleshThread == null)
            {
                _refleshThread = new Thread(RefleshData);
                _refleshThread.Start();
            }
            txtCode.Focus();
            txtCode.SelectionStart = 0;
            txtCode.SelectionLength = txtCode.Text.Length;
        }

        private void lblChart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(this, null);
                e.Handled = true;
            }
        }

        private void FrmSingleStock_Activated(object sender, EventArgs e)
        {
            ((MdiStockTool)MdiParent).writeStatusBar(this, _status);
        }

        private void FrmSingleStock_Deactivate(object sender, EventArgs e)
        {
            ((MdiStockTool)MdiParent).writeStatusBar(this, "");
        }

        private void FrmSingleStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MdiStockTool)MdiParent).writeStatusBar(this, "");
        }
    }
}
