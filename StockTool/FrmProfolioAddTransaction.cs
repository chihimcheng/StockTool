using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Profolio;

namespace StockTool
{
    public partial class FrmProfolioAddTransaction : Form
    {
        private ProfolioMgr _profolioMgr;

        public FrmProfolioAddTransaction(ProfolioMgr profolioMgr)
        {
            _profolioMgr = profolioMgr;
            InitializeComponent();
            cmbType.SelectedIndex = 0;
            lblContractCode.Enabled = false;
            txtContractCode.Enabled = false;
            dtpDate.Value = DateTime.Now;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.Text == "一般投資")
            {
                lblContractCode.Enabled = false;
                txtContractCode.Enabled = false;
            }
            else if (cmbType.Text == "期貨/期權合約")
            {
                lblContractCode.Enabled = true;
                txtContractCode.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Transaction newTran = null;
            if (cmbType.Text == "期貨/期權合約")
            {
                newTran = new FutureTransaction();
                ((FutureTransaction)newTran).contractCode = txtContractCode.Text;
            }
            else
                newTran = new Transaction();
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("編號輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            newTran.code = txtCode.Text;
            newTran.date = dtpDate.Value.Date;
            if (!string.IsNullOrEmpty(txtAmount.Text) && !double.TryParse(txtAmount.Text, out newTran.amount))
            {
                MessageBox.Show("數量輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(txtPayment.Text) && !double.TryParse(txtPayment.Text, out newTran.payment))
            {
                MessageBox.Show("交易金額輸入錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            newTran.description = txtDescription.Text;

            try
            {
                _profolioMgr.AddTransaction(newTran);
            }
            catch
            {
                MessageBox.Show("交易加入失敗！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("交易加入成功", "加入交易", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text))
                txtCode.Text = stockMgr.StockData.CodeFromString(txtCode.Text);
        }
    }
}
