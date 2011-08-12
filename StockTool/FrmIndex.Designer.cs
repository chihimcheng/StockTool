namespace StockTool
{
    partial class FrmIndex
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
            if (_refleshThread != null)
                _refleshThread.Abort();
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStockList = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colROC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTodayHL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbIndexType = new System.Windows.Forms.ComboBox();
            this.lblAutoRefresh = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timerReflesh = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownRefresh = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelRefresh = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefresh)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanelRefresh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockList
            // 
            this.dgvStockList.AllowUserToAddRows = false;
            this.dgvStockList.AllowUserToDeleteRows = false;
            this.dgvStockList.AllowUserToOrderColumns = true;
            this.dgvStockList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colPrice,
            this.colChange,
            this.colROC,
            this.colTodayHL});
            this.tableLayoutPanel.SetColumnSpan(this.dgvStockList, 2);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStockList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockList.Location = new System.Drawing.Point(3, 29);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.ReadOnly = true;
            this.dgvStockList.RowHeadersVisible = false;
            this.dgvStockList.RowTemplate.Height = 20;
            this.dgvStockList.Size = new System.Drawing.Size(602, 365);
            this.dgvStockList.TabIndex = 1;
            this.dgvStockList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockList_CellDoubleClick);
            // 
            // colName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colName.HeaderText = "名稱";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 70;
            // 
            // colPrice
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrice.HeaderText = "現價";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 80;
            // 
            // colChange
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colChange.DefaultCellStyle = dataGridViewCellStyle4;
            this.colChange.HeaderText = "升跌";
            this.colChange.Name = "colChange";
            this.colChange.ReadOnly = true;
            this.colChange.Width = 70;
            // 
            // colROC
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            this.colROC.DefaultCellStyle = dataGridViewCellStyle5;
            this.colROC.HeaderText = "升跌(%)";
            this.colROC.Name = "colROC";
            this.colROC.ReadOnly = true;
            this.colROC.Width = 70;
            // 
            // colTodayHL
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "N/A";
            this.colTodayHL.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTodayHL.HeaderText = "今日波幅";
            this.colTodayHL.Name = "colTodayHL";
            this.colTodayHL.ReadOnly = true;
            this.colTodayHL.Width = 120;
            // 
            // cmbIndexType
            // 
            this.cmbIndexType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIndexType.FormattingEnabled = true;
            this.cmbIndexType.Location = new System.Drawing.Point(3, 3);
            this.cmbIndexType.Name = "cmbIndexType";
            this.cmbIndexType.Size = new System.Drawing.Size(121, 20);
            this.cmbIndexType.TabIndex = 2;
            this.cmbIndexType.SelectedIndexChanged += new System.EventHandler(this.cmbIndexType_SelectedIndexChanged);
            // 
            // lblAutoRefresh
            // 
            this.lblAutoRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAutoRefresh.AutoSize = true;
            this.lblAutoRefresh.Location = new System.Drawing.Point(3, 8);
            this.lblAutoRefresh.Name = "lblAutoRefresh";
            this.lblAutoRefresh.Size = new System.Drawing.Size(92, 12);
            this.lblAutoRefresh.TabIndex = 4;
            this.lblAutoRefresh.Text = "自動更新間距(s):";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Location = new System.Drawing.Point(530, 400);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "更新(&R)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timerReflesh
            // 
            this.timerReflesh.Interval = 5000;
            this.timerReflesh.Tick += new System.EventHandler(this.timerReflesh_Tick);
            // 
            // numericUpDownRefresh
            // 
            this.numericUpDownRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownRefresh.Location = new System.Drawing.Point(101, 3);
            this.numericUpDownRefresh.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownRefresh.Name = "numericUpDownRefresh";
            this.numericUpDownRefresh.Size = new System.Drawing.Size(49, 22);
            this.numericUpDownRefresh.TabIndex = 7;
            this.numericUpDownRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownRefresh.ValueChanged += new System.EventHandler(this.numericUpDownReflesh_ValueChanged_1);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.Controls.Add(this.cmbIndexType, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btnRefresh, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.dgvStockList, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelRefresh, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(608, 426);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // flowLayoutPanelRefresh
            // 
            this.flowLayoutPanelRefresh.Controls.Add(this.lblAutoRefresh);
            this.flowLayoutPanelRefresh.Controls.Add(this.numericUpDownRefresh);
            this.flowLayoutPanelRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRefresh.Location = new System.Drawing.Point(0, 397);
            this.flowLayoutPanelRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelRefresh.Name = "flowLayoutPanelRefresh";
            this.flowLayoutPanelRefresh.Size = new System.Drawing.Size(527, 29);
            this.flowLayoutPanelRefresh.TabIndex = 7;
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FrmIndex";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "指數";
            this.Deactivate += new System.EventHandler(this.FrmIndex_Deactivate);
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.Activated += new System.EventHandler(this.FrmIndex_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIndex_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefresh)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanelRefresh.ResumeLayout(false);
            this.flowLayoutPanelRefresh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockList;
        private System.Windows.Forms.ComboBox cmbIndexType;
        private System.Windows.Forms.Label lblAutoRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timerReflesh;
        private System.Windows.Forms.NumericUpDown numericUpDownRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colROC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTodayHL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRefresh;
    }
}