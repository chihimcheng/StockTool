namespace StockTool
{
    partial class FrmProfolioAddTransaction
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblContractCode = new System.Windows.Forms.Label();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtContractCode = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.tableLayoutPanel.SetColumnSpan(this.cmbType, 2);
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "一般投資",
            "期貨/期權合約"});
            this.cmbType.Location = new System.Drawing.Point(3, 3);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 20);
            this.cmbType.TabIndex = 0;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.cmbType, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btnAdd, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.lblCode, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblContractCode, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblTransactionDate, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblAmount, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.lblPayment, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.lblDescription, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.txtCode, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.txtContractCode, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.txtAmount, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.txtPayment, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.txtDescription, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.dtpDate, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(368, 246);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(290, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 22);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "加入(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCode
            // 
            this.lblCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(3, 36);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 12);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "編號:";
            // 
            // lblContractCode
            // 
            this.lblContractCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblContractCode.AutoSize = true;
            this.lblContractCode.Location = new System.Drawing.Point(3, 68);
            this.lblContractCode.Name = "lblContractCode";
            this.lblContractCode.Size = new System.Drawing.Size(56, 12);
            this.lblContractCode.TabIndex = 3;
            this.lblContractCode.Text = "合約代號:";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Location = new System.Drawing.Point(3, 100);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(56, 12);
            this.lblTransactionDate.TabIndex = 5;
            this.lblTransactionDate.Text = "交易日期:";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(3, 132);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(32, 12);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "數量:";
            // 
            // lblPayment
            // 
            this.lblPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(3, 164);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(56, 12);
            this.lblPayment.TabIndex = 9;
            this.lblPayment.Text = "交易金額:";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 196);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(32, 12);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "詳情:";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCode.Location = new System.Drawing.Point(93, 31);
            this.txtCode.MaxLength = 127;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 2;
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // txtContractCode
            // 
            this.txtContractCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtContractCode.Location = new System.Drawing.Point(93, 63);
            this.txtContractCode.MaxLength = 127;
            this.txtContractCode.Name = "txtContractCode";
            this.txtContractCode.Size = new System.Drawing.Size(100, 22);
            this.txtContractCode.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAmount.Location = new System.Drawing.Point(93, 127);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 8;
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPayment.Location = new System.Drawing.Point(93, 159);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 22);
            this.txtPayment.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(93, 189);
            this.txtDescription.MaxLength = 255;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(272, 26);
            this.txtDescription.TabIndex = 12;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(93, 95);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 22);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.Value = new System.DateTime(2011, 11, 22, 23, 30, 11, 0);
            // 
            // FrmProfolioAddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FrmProfolioAddTransaction";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "加入交易";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblContractCode;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtContractCode;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}