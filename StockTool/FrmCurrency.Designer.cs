namespace StockTool
{
    partial class FrmCurrency
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlCommonCurrency = new System.Windows.Forms.TabControl();
            this.tabPageCommonCurrency = new System.Windows.Forms.TabPage();
            this.dgvCurrencyList = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.tabControlCommonCurrency.SuspendLayout();
            this.tabPageCommonCurrency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCommonCurrency
            // 
            this.tabControlCommonCurrency.Controls.Add(this.tabPageCommonCurrency);
            this.tabControlCommonCurrency.Location = new System.Drawing.Point(13, 13);
            this.tabControlCommonCurrency.Name = "tabControlCommonCurrency";
            this.tabControlCommonCurrency.SelectedIndex = 0;
            this.tabControlCommonCurrency.Size = new System.Drawing.Size(274, 357);
            this.tabControlCommonCurrency.TabIndex = 0;
            // 
            // tabPageCommonCurrency
            // 
            this.tabPageCommonCurrency.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCommonCurrency.Controls.Add(this.dgvCurrencyList);
            this.tabPageCommonCurrency.Controls.Add(this.cmbCurrency);
            this.tabPageCommonCurrency.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommonCurrency.Name = "tabPageCommonCurrency";
            this.tabPageCommonCurrency.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommonCurrency.Size = new System.Drawing.Size(266, 331);
            this.tabPageCommonCurrency.TabIndex = 0;
            this.tabPageCommonCurrency.Text = "常用貨幣";
            // 
            // dgvCurrencyList
            // 
            this.dgvCurrencyList.AllowUserToAddRows = false;
            this.dgvCurrencyList.AllowUserToDeleteRows = false;
            this.dgvCurrencyList.AllowUserToOrderColumns = true;
            this.dgvCurrencyList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrencyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrencyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrencyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCode,
            this.colPrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrencyList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCurrencyList.Location = new System.Drawing.Point(7, 33);
            this.dgvCurrencyList.Name = "dgvCurrencyList";
            this.dgvCurrencyList.ReadOnly = true;
            this.dgvCurrencyList.RowHeadersVisible = false;
            this.dgvCurrencyList.RowTemplate.Height = 20;
            this.dgvCurrencyList.Size = new System.Drawing.Size(253, 292);
            this.dgvCurrencyList.TabIndex = 1;
            // 
            // colName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colName.HeaderText = "貨幣";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 70;
            // 
            // colCode
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCode.HeaderText = "代號";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 70;
            // 
            // colPrice
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = "N/A";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPrice.HeaderText = "現價";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 70;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(7, 7);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(121, 20);
            this.cmbCurrency.TabIndex = 0;
            this.cmbCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // FrmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 382);
            this.Controls.Add(this.tabControlCommonCurrency);
            this.Name = "FrmCurrency";
            this.Text = "匯率";
            this.SizeChanged += new System.EventHandler(this.FrmCurrency_SizeChanged);
            this.tabControlCommonCurrency.ResumeLayout(false);
            this.tabPageCommonCurrency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCommonCurrency;
        private System.Windows.Forms.TabPage tabPageCommonCurrency;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.DataGridView dgvCurrencyList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}