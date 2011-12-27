namespace StockTool
{
    partial class FrmQueryTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpQueryTransaction = new System.Windows.Forms.TableLayoutPanel();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.lineSeparator1 = new StockTool.LineSeparator();
            this.flpSubmit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.ckbUpdatePrice = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpgTransaction = new System.Windows.Forms.TabPage();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.colTCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTContractCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTTranDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpgReturn = new System.Windows.Forms.TabPage();
            this.tlpReturn = new System.Windows.Forms.TableLayoutPanel();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.colRCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colREarning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRBreakEven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRROI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPostBalance = new System.Windows.Forms.DataGridView();
            this.colABCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colABContractCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colABDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colABAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colABPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colABValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrevBalance = new System.Windows.Forms.DataGridView();
            this.colPBCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPBContractCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPBDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPBAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPBPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPBValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrevBalance = new System.Windows.Forms.Label();
            this.lblPostBalance = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.tlpQueryTransaction.SuspendLayout();
            this.flpSubmit.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpgTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.tpgReturn.SuspendLayout();
            this.tlpReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpQueryTransaction
            // 
            this.tlpQueryTransaction.ColumnCount = 4;
            this.tlpQueryTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQueryTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpQueryTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQueryTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpQueryTransaction.Controls.Add(this.lblCode, 0, 0);
            this.tlpQueryTransaction.Controls.Add(this.lblDate, 0, 1);
            this.tlpQueryTransaction.Controls.Add(this.lblDateTo, 2, 1);
            this.tlpQueryTransaction.Controls.Add(this.txtCode, 1, 0);
            this.tlpQueryTransaction.Controls.Add(this.txtDateFrom, 1, 1);
            this.tlpQueryTransaction.Controls.Add(this.txtDateTo, 3, 1);
            this.tlpQueryTransaction.Controls.Add(this.lineSeparator1, 0, 3);
            this.tlpQueryTransaction.Controls.Add(this.flpSubmit, 0, 2);
            this.tlpQueryTransaction.Controls.Add(this.tabControl, 0, 4);
            this.tlpQueryTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQueryTransaction.Location = new System.Drawing.Point(8, 8);
            this.tlpQueryTransaction.Name = "tlpQueryTransaction";
            this.tlpQueryTransaction.RowCount = 5;
            this.tlpQueryTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpQueryTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpQueryTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpQueryTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tlpQueryTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQueryTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpQueryTransaction.Size = new System.Drawing.Size(368, 479);
            this.tlpQueryTransaction.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(3, 7);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 12);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "交易編號:";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 12);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "交易日期:";
            // 
            // lblDateTo
            // 
            this.lblDateTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(211, 33);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(17, 12);
            this.lblDateTo.TabIndex = 4;
            this.lblDateTo.Text = "至";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCode.Location = new System.Drawing.Point(76, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 1;
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDateFrom.Location = new System.Drawing.Point(76, 29);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(100, 22);
            this.txtDateFrom.TabIndex = 3;
            // 
            // txtDateTo
            // 
            this.txtDateTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDateTo.Location = new System.Drawing.Point(259, 29);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(100, 22);
            this.txtDateTo.TabIndex = 5;
            // 
            // lineSeparator1
            // 
            this.tlpQueryTransaction.SetColumnSpan(this.lineSeparator1, 4);
            this.lineSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineSeparator1.Location = new System.Drawing.Point(0, 81);
            this.lineSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.lineSeparator1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator1.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator1.Name = "lineSeparator1";
            this.lineSeparator1.Size = new System.Drawing.Size(368, 2);
            this.lineSeparator1.TabIndex = 7;
            // 
            // flpSubmit
            // 
            this.tlpQueryTransaction.SetColumnSpan(this.flpSubmit, 4);
            this.flpSubmit.Controls.Add(this.btnQuery);
            this.flpSubmit.Controls.Add(this.ckbUpdatePrice);
            this.flpSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSubmit.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpSubmit.Location = new System.Drawing.Point(0, 52);
            this.flpSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.flpSubmit.Name = "flpSubmit";
            this.flpSubmit.Size = new System.Drawing.Size(368, 29);
            this.flpSubmit.TabIndex = 6;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuery.Location = new System.Drawing.Point(290, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查詢(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // ckbUpdatePrice
            // 
            this.ckbUpdatePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckbUpdatePrice.AutoSize = true;
            this.ckbUpdatePrice.Checked = true;
            this.ckbUpdatePrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUpdatePrice.Location = new System.Drawing.Point(176, 6);
            this.ckbUpdatePrice.Name = "ckbUpdatePrice";
            this.ckbUpdatePrice.Size = new System.Drawing.Size(108, 16);
            this.ckbUpdatePrice.TabIndex = 0;
            this.ckbUpdatePrice.Text = "查詢時更新現價";
            this.ckbUpdatePrice.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tlpQueryTransaction.SetColumnSpan(this.tabControl, 4);
            this.tabControl.Controls.Add(this.tpgTransaction);
            this.tabControl.Controls.Add(this.tpgReturn);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 86);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(362, 390);
            this.tabControl.TabIndex = 21;
            // 
            // tpgTransaction
            // 
            this.tpgTransaction.Controls.Add(this.dgvTransaction);
            this.tpgTransaction.Location = new System.Drawing.Point(4, 22);
            this.tpgTransaction.Name = "tpgTransaction";
            this.tpgTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTransaction.Size = new System.Drawing.Size(354, 364);
            this.tpgTransaction.TabIndex = 0;
            this.tpgTransaction.Text = "交易";
            this.tpgTransaction.UseVisualStyleBackColor = true;
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTCode,
            this.colTContractCode,
            this.colTTranDate,
            this.colTAmount,
            this.colTPayment,
            this.colTDescription});
            this.dgvTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaction.Location = new System.Drawing.Point(3, 3);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.RowTemplate.Height = 20;
            this.dgvTransaction.Size = new System.Drawing.Size(348, 358);
            this.dgvTransaction.TabIndex = 20;
            // 
            // colTCode
            // 
            this.colTCode.HeaderText = "編號";
            this.colTCode.Name = "colTCode";
            this.colTCode.ReadOnly = true;
            this.colTCode.Width = 60;
            // 
            // colTContractCode
            // 
            this.colTContractCode.HeaderText = "合約代號";
            this.colTContractCode.Name = "colTContractCode";
            this.colTContractCode.ReadOnly = true;
            this.colTContractCode.Width = 80;
            // 
            // colTTranDate
            // 
            this.colTTranDate.HeaderText = "交易日期";
            this.colTTranDate.Name = "colTTranDate";
            this.colTTranDate.ReadOnly = true;
            this.colTTranDate.Width = 80;
            // 
            // colTAmount
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.colTAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTAmount.HeaderText = "數量";
            this.colTAmount.Name = "colTAmount";
            this.colTAmount.ReadOnly = true;
            this.colTAmount.Width = 60;
            // 
            // colTPayment
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colTPayment.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTPayment.HeaderText = "交易金額";
            this.colTPayment.Name = "colTPayment";
            this.colTPayment.ReadOnly = true;
            this.colTPayment.Width = 80;
            // 
            // colTDescription
            // 
            this.colTDescription.HeaderText = "詳情";
            this.colTDescription.Name = "colTDescription";
            this.colTDescription.ReadOnly = true;
            // 
            // tpgReturn
            // 
            this.tpgReturn.Controls.Add(this.tlpReturn);
            this.tpgReturn.Location = new System.Drawing.Point(4, 22);
            this.tpgReturn.Name = "tpgReturn";
            this.tpgReturn.Size = new System.Drawing.Size(354, 364);
            this.tpgReturn.TabIndex = 1;
            this.tpgReturn.Text = "回報分析";
            this.tpgReturn.UseVisualStyleBackColor = true;
            // 
            // tlpReturn
            // 
            this.tlpReturn.ColumnCount = 1;
            this.tlpReturn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReturn.Controls.Add(this.dgvReturn, 0, 5);
            this.tlpReturn.Controls.Add(this.dgvPostBalance, 0, 3);
            this.tlpReturn.Controls.Add(this.dgvPrevBalance, 0, 1);
            this.tlpReturn.Controls.Add(this.lblPrevBalance, 0, 0);
            this.tlpReturn.Controls.Add(this.lblPostBalance, 0, 2);
            this.tlpReturn.Controls.Add(this.lblReturn, 0, 4);
            this.tlpReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpReturn.Location = new System.Drawing.Point(0, 0);
            this.tlpReturn.Name = "tlpReturn";
            this.tlpReturn.RowCount = 6;
            this.tlpReturn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpReturn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpReturn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpReturn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpReturn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpReturn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpReturn.Size = new System.Drawing.Size(354, 364);
            this.tlpReturn.TabIndex = 0;
            // 
            // dgvReturn
            // 
            this.dgvReturn.AllowUserToAddRows = false;
            this.dgvReturn.AllowUserToDeleteRows = false;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRCode,
            this.colREarning,
            this.colRBreakEven,
            this.colRROI});
            this.dgvReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReturn.Location = new System.Drawing.Point(3, 265);
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.ReadOnly = true;
            this.dgvReturn.RowHeadersVisible = false;
            this.dgvReturn.RowTemplate.Height = 20;
            this.dgvReturn.Size = new System.Drawing.Size(348, 96);
            this.dgvReturn.TabIndex = 24;
            // 
            // colRCode
            // 
            this.colRCode.HeaderText = "編號";
            this.colRCode.Name = "colRCode";
            this.colRCode.ReadOnly = true;
            this.colRCode.Width = 60;
            // 
            // colREarning
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colREarning.DefaultCellStyle = dataGridViewCellStyle3;
            this.colREarning.HeaderText = "賺(蝕)";
            this.colREarning.Name = "colREarning";
            this.colREarning.ReadOnly = true;
            this.colREarning.Width = 60;
            // 
            // colRBreakEven
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.colRBreakEven.DefaultCellStyle = dataGridViewCellStyle4;
            this.colRBreakEven.HeaderText = "打和價";
            this.colRBreakEven.Name = "colRBreakEven";
            this.colRBreakEven.ReadOnly = true;
            this.colRBreakEven.Width = 80;
            // 
            // colRROI
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.colRROI.DefaultCellStyle = dataGridViewCellStyle5;
            this.colRROI.HeaderText = "回報率";
            this.colRROI.Name = "colRROI";
            this.colRROI.ReadOnly = true;
            this.colRROI.Width = 80;
            // 
            // dgvPostBalance
            // 
            this.dgvPostBalance.AllowUserToAddRows = false;
            this.dgvPostBalance.AllowUserToDeleteRows = false;
            this.dgvPostBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colABCode,
            this.colABContractCode,
            this.colABDate,
            this.colABAmount,
            this.colABPrice,
            this.colABValue});
            this.dgvPostBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPostBalance.Location = new System.Drawing.Point(3, 144);
            this.dgvPostBalance.Name = "dgvPostBalance";
            this.dgvPostBalance.RowHeadersVisible = false;
            this.dgvPostBalance.RowTemplate.Height = 20;
            this.dgvPostBalance.Size = new System.Drawing.Size(348, 95);
            this.dgvPostBalance.TabIndex = 22;
            // 
            // colABCode
            // 
            this.colABCode.HeaderText = "編號";
            this.colABCode.Name = "colABCode";
            this.colABCode.ReadOnly = true;
            this.colABCode.Width = 60;
            // 
            // colABContractCode
            // 
            this.colABContractCode.HeaderText = "合約代號";
            this.colABContractCode.Name = "colABContractCode";
            this.colABContractCode.ReadOnly = true;
            this.colABContractCode.Width = 80;
            // 
            // colABDate
            // 
            this.colABDate.HeaderText = "日期";
            this.colABDate.Name = "colABDate";
            this.colABDate.Width = 60;
            // 
            // colABAmount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.colABAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colABAmount.HeaderText = "數量";
            this.colABAmount.Name = "colABAmount";
            this.colABAmount.Width = 60;
            // 
            // colABPrice
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N3";
            dataGridViewCellStyle7.NullValue = null;
            this.colABPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.colABPrice.HeaderText = "市價";
            this.colABPrice.Name = "colABPrice";
            this.colABPrice.Width = 60;
            // 
            // colABValue
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.colABValue.DefaultCellStyle = dataGridViewCellStyle8;
            this.colABValue.HeaderText = "市值";
            this.colABValue.Name = "colABValue";
            this.colABValue.Width = 60;
            // 
            // dgvPrevBalance
            // 
            this.dgvPrevBalance.AllowUserToAddRows = false;
            this.dgvPrevBalance.AllowUserToDeleteRows = false;
            this.dgvPrevBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrevBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPBCode,
            this.colPBContractCode,
            this.colPBDate,
            this.colPBAmount,
            this.colPBPrice,
            this.colPBValue});
            this.dgvPrevBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrevBalance.Location = new System.Drawing.Point(3, 23);
            this.dgvPrevBalance.Name = "dgvPrevBalance";
            this.dgvPrevBalance.RowHeadersVisible = false;
            this.dgvPrevBalance.RowTemplate.Height = 20;
            this.dgvPrevBalance.Size = new System.Drawing.Size(348, 95);
            this.dgvPrevBalance.TabIndex = 21;
            this.dgvPrevBalance.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrevBalance_CellEndEdit);
            // 
            // colPBCode
            // 
            this.colPBCode.HeaderText = "編號";
            this.colPBCode.Name = "colPBCode";
            this.colPBCode.ReadOnly = true;
            this.colPBCode.Width = 60;
            // 
            // colPBContractCode
            // 
            this.colPBContractCode.HeaderText = "合約代號";
            this.colPBContractCode.Name = "colPBContractCode";
            this.colPBContractCode.ReadOnly = true;
            this.colPBContractCode.Width = 80;
            // 
            // colPBDate
            // 
            this.colPBDate.HeaderText = "日期";
            this.colPBDate.Name = "colPBDate";
            this.colPBDate.Width = 60;
            // 
            // colPBAmount
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.colPBAmount.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPBAmount.HeaderText = "數量";
            this.colPBAmount.Name = "colPBAmount";
            this.colPBAmount.Width = 60;
            // 
            // colPBPrice
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N3";
            dataGridViewCellStyle10.NullValue = null;
            this.colPBPrice.DefaultCellStyle = dataGridViewCellStyle10;
            this.colPBPrice.HeaderText = "市價";
            this.colPBPrice.Name = "colPBPrice";
            this.colPBPrice.Width = 60;
            // 
            // colPBValue
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.colPBValue.DefaultCellStyle = dataGridViewCellStyle11;
            this.colPBValue.HeaderText = "市值";
            this.colPBValue.Name = "colPBValue";
            this.colPBValue.Width = 60;
            // 
            // lblPrevBalance
            // 
            this.lblPrevBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrevBalance.AutoSize = true;
            this.lblPrevBalance.Location = new System.Drawing.Point(3, 4);
            this.lblPrevBalance.Name = "lblPrevBalance";
            this.lblPrevBalance.Size = new System.Drawing.Size(44, 12);
            this.lblPrevBalance.TabIndex = 0;
            this.lblPrevBalance.Text = "前買入:";
            // 
            // lblPostBalance
            // 
            this.lblPostBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPostBalance.AutoSize = true;
            this.lblPostBalance.Location = new System.Drawing.Point(3, 125);
            this.lblPostBalance.Name = "lblPostBalance";
            this.lblPostBalance.Size = new System.Drawing.Size(44, 12);
            this.lblPostBalance.TabIndex = 23;
            this.lblPostBalance.Text = "後平倉:";
            // 
            // lblReturn
            // 
            this.lblReturn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(3, 246);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(32, 12);
            this.lblReturn.TabIndex = 25;
            this.lblReturn.Text = "回報:";
            // 
            // FrmQueryTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 495);
            this.Controls.Add(this.tlpQueryTransaction);
            this.Name = "FrmQueryTransaction";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "交易查詢";
            this.tlpQueryTransaction.ResumeLayout(false);
            this.tlpQueryTransaction.PerformLayout();
            this.flpSubmit.ResumeLayout(false);
            this.flpSubmit.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpgTransaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.tpgReturn.ResumeLayout(false);
            this.tlpReturn.ResumeLayout(false);
            this.tlpReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpQueryTransaction;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.TextBox txtDateTo;
        private LineSeparator lineSeparator1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.FlowLayoutPanel flpSubmit;
        private System.Windows.Forms.CheckBox ckbUpdatePrice;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpgTransaction;
        private System.Windows.Forms.TabPage tpgReturn;
        private System.Windows.Forms.TableLayoutPanel tlpReturn;
        private System.Windows.Forms.Label lblPrevBalance;
        private System.Windows.Forms.DataGridView dgvPrevBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTContractCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTranDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPBCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPBContractCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPBDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPBAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPBPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPBValue;
        private System.Windows.Forms.DataGridView dgvPostBalance;
        private System.Windows.Forms.Label lblPostBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colABCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colABContractCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colABDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colABAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colABPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colABValue;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colREarning;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRBreakEven;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRROI;
    }
}