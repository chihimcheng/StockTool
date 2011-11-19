using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using stockMgr;
using Him.Financial.Stock;

namespace StockTool
{
    public partial class FrmOptionPricing : Form
    {
        private readonly StockMgr _stockMgr;

        public FrmOptionPricing(StockMgr stockMgr)
        {
            _stockMgr = stockMgr;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double underlyingPrice, exePrice, time, volatility, interest, dividened;
            OptionType optType;
            if (!double.TryParse(txtUnderlyingPrice.Text, out underlyingPrice))
            {
                MessageBox.Show("現價輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtExePrice.Text, out exePrice))
            {
                MessageBox.Show("行使價輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtTime.Text, out time))
            {
                MessageBox.Show("餘下時間輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtVolatility.Text, out volatility))
            {
                MessageBox.Show("波幅輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtInterest.Text, out interest))
            {
                MessageBox.Show("利率輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtDividend.Text, out dividened))
            {
                MessageBox.Show("股息率輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbCall.Checked)
                optType = OptionType.CALL;
            else
                optType = OptionType.PUT;
            lblOptPrice.Text = OptionPricer.BlackScholesPricing(underlyingPrice, exePrice, time, volatility / 100D, interest / 100D, dividened / 100D, optType).ToString("0.000");
        }

        private void txtUnderlyingPrice_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnderlyingPrice.Text) && txtUnderlyingPrice.Text[0] == '=' && txtUnderlyingPrice.Text.Length > 1)
            {
                StockData stock = new StockData(stockMgr.StockData.CodeFromString(txtUnderlyingPrice.Text.Substring(1)));
                try
                {
                    _stockMgr.GetQuote(stock);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtUnderlyingPrice.Text = stock.close.ToString("0.000");
            }
        }

        private void txtTime_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTime.Text) && txtTime.Text[0] == '=' && txtTime.Text.Length > 1)
            {
                try
                {
                    string[] num = txtTime.Text.Substring(1).Split(new char[] { '/' });
                    txtTime.Text = (double.Parse(num[0]) / double.Parse(num[1])).ToString();
                }
                catch
                {
                    MessageBox.Show("餘下時間輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtVolatility_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVolatility.Text) && txtVolatility.Text[0] == '=' && txtVolatility.Text.Length > 1)
            {
                double volatility = double.NaN;
                string code;
                int numOfDays;
                int indexComma = txtVolatility.Text.IndexOf(',');
                if (indexComma > 0)
                {
                    code = txtVolatility.Text.Substring(1, indexComma - 1);
                    if (!int.TryParse(txtVolatility.Text.Substring(indexComma + 1), out numOfDays))
                        MessageBox.Show("波幅輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    code = txtVolatility.Text.Substring(1);
                    numOfDays = 365;
                }

                try
                {
                    volatility = _stockMgr.GetVolatility(code, numOfDays);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtVolatility.Text = (volatility * 100).ToString("0.000");
            }
        }
    }
}
