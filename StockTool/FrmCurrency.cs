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
    public partial class FrmCurrency : Form
    {
        private StockMgr _stockMgr;
        private ArrayList _currencies = new ArrayList();
        private Thread _refleshThread = null;
        private Mutex _refleshMutex = new Mutex();

        public FrmCurrency(StockMgr stockMgr)
        {
            _stockMgr = stockMgr;
            InitializeComponent();

            try
            {
                XmlDocument xmlConfig = new XmlDocument();
                xmlConfig.Load("StockTool.config");
                XmlElement config = (XmlElement)xmlConfig.GetElementsByTagName("configuration")[0];
                XmlElement commonCurrency = (XmlElement)config.GetElementsByTagName("common_currency")[0];
                XmlNodeList currencyList = commonCurrency.GetElementsByTagName("currency");
                foreach (XmlElement currency in currencyList)
                {
                    KeyValuePair<string, string> newCurrency =
                        new KeyValuePair<string, string>(currency.GetAttribute("code").Trim(), currency.GetAttribute("name").Trim());
                    _currencies.Add(newCurrency);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(DateTime.Now.ToString() + " Loading config file error");
            }

            foreach (KeyValuePair<string, string> currency in _currencies)
                cmbCurrency.Items.Add(currency.Value + " (" + currency.Key + ")");
            cmbCurrency.Text = (string)cmbCurrency.Items[0];
        }

        private void refleshData(object baseCurrency)
        {
            if (!(baseCurrency is string))
                return;

            if (_refleshMutex.WaitOne(0))
            {
                StockData[] stocks = new StockData[dgvCurrencyList.Rows.Count];
                for (int i = 0; i < dgvCurrencyList.Rows.Count; i++)
                    stocks[i] = new StockData((string)dgvCurrencyList.Rows[i].Cells["colCode"].Value + (string)baseCurrency + "=X");

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

                for (int i = 0; i < dgvCurrencyList.Rows.Count; i++)
                    dgvCurrencyList.Rows[i].Cells["colPrice"].Value = stocks[i].close;
                _refleshThread = null;
                _refleshMutex.ReleaseMutex();
            }
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCurrencyList.Rows.Clear();
            dgvCurrencyList.Rows.Add(_currencies.Count);
            for (int i = 0; i < _currencies.Count; i++)
            {
                dgvCurrencyList.Rows[i].Cells["colCode"].Value = ((KeyValuePair<string, string>)_currencies[i]).Key;
                dgvCurrencyList.Rows[i].Cells["colName"].Value = ((KeyValuePair<string, string>)_currencies[i]).Value;
            }

            _refleshThread = new Thread(refleshData);
            _refleshThread.Start(((KeyValuePair<string, string>)_currencies[cmbCurrency.SelectedIndex]).Key);
        }

        private void FrmCurrency_SizeChanged(object sender, EventArgs e)
        {
            tabControlCommonCurrency.Size = new Size(this.Size.Width - 41, this.Size.Height - 63);
            dgvCurrencyList.Size = new Size(this.Size.Width - 62, this.Size.Height - 128);
        }
    }
}
