namespace StockTool
{
    partial class FrmList
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (refleshThread != null)
                refleshThread.Abort();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
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
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colROC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTodayHL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timerReflesh = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownReflesh = new System.Windows.Forms.NumericUpDown();
            this.lblAutoReflesh = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelAutoRefresh = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReflesh)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanelAutoRefresh.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
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
            this.dgvStockList.Location = new System.Drawing.Point(3, 3);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.ReadOnly = true;
            this.dgvStockList.RowHeadersVisible = false;
            this.dgvStockList.RowTemplate.Height = 20;
            this.dgvStockList.Size = new System.Drawing.Size(602, 391);
            this.dgvStockList.TabIndex = 0;
            this.dgvStockList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockList_CellDoubleClick);
            // 
            // colCode
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCode.HeaderText = "編號";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 69;
            // 
            // colPrice
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = "N/A";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrice.HeaderText = "現價";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 70;
            // 
            // colChange
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = "0";
            this.colChange.DefaultCellStyle = dataGridViewCellStyle4;
            this.colChange.HeaderText = "升跌";
            this.colChange.Name = "colChange";
            this.colChange.ReadOnly = true;
            this.colChange.Width = 57;
            // 
            // colROC
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = "0";
            this.colROC.DefaultCellStyle = dataGridViewCellStyle5;
            this.colROC.HeaderText = "升跌(%)";
            this.colROC.Name = "colROC";
            this.colROC.ReadOnly = true;
            this.colROC.Width = 52;
            // 
            // colTodayHL
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "N/A";
            this.colTodayHL.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTodayHL.HeaderText = "今日波幅";
            this.colTodayHL.Name = "colTodayHL";
            this.colTodayHL.ReadOnly = true;
            this.colTodayHL.Width = 136;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Location = new System.Drawing.Point(530, 400);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "更新(&R)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timerReflesh
            // 
            this.timerReflesh.Interval = 5000;
            this.timerReflesh.Tick += new System.EventHandler(this.timerReflesh_Tick);
            // 
            // numericUpDownReflesh
            // 
            this.numericUpDownReflesh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownReflesh.Location = new System.Drawing.Point(101, 3);
            this.numericUpDownReflesh.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownReflesh.Name = "numericUpDownReflesh";
            this.numericUpDownReflesh.Size = new System.Drawing.Size(49, 22);
            this.numericUpDownReflesh.TabIndex = 2;
            this.numericUpDownReflesh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownReflesh.ValueChanged += new System.EventHandler(this.numericUpDownReflesh_ValueChanged);
            // 
            // lblAutoReflesh
            // 
            this.lblAutoReflesh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAutoReflesh.AutoSize = true;
            this.lblAutoReflesh.Location = new System.Drawing.Point(3, 8);
            this.lblAutoReflesh.Name = "lblAutoReflesh";
            this.lblAutoReflesh.Size = new System.Drawing.Size(92, 12);
            this.lblAutoReflesh.TabIndex = 1;
            this.lblAutoReflesh.Text = "自動更新間距(s):";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.Controls.Add(this.dgvStockList, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btnRefresh, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelAutoRefresh, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(608, 426);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // flowLayoutPanelAutoRefresh
            // 
            this.flowLayoutPanelAutoRefresh.Controls.Add(this.lblAutoReflesh);
            this.flowLayoutPanelAutoRefresh.Controls.Add(this.numericUpDownReflesh);
            this.flowLayoutPanelAutoRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAutoRefresh.Location = new System.Drawing.Point(0, 397);
            this.flowLayoutPanelAutoRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelAutoRefresh.Name = "flowLayoutPanelAutoRefresh";
            this.flowLayoutPanelAutoRefresh.Size = new System.Drawing.Size(527, 29);
            this.flowLayoutPanelAutoRefresh.TabIndex = 4;
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FrmList";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "監視清單";
            this.Deactivate += new System.EventHandler(this.FrmList_Deactivate);
            this.Load += new System.EventHandler(this.frmList_Load);
            this.Activated += new System.EventHandler(this.FrmList_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReflesh)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanelAutoRefresh.ResumeLayout(false);
            this.flowLayoutPanelAutoRefresh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timerReflesh;
        private System.Windows.Forms.NumericUpDown numericUpDownReflesh;
        private System.Windows.Forms.Label lblAutoReflesh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAutoRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colROC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTodayHL;
    }
}

