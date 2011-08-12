namespace StockTool
{
    partial class FrmSingleStock
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnQuote = new System.Windows.Forms.Button();
            this.flowLayoutPanelCode = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.lblROC = new System.Windows.Forms.Label();
            this.lblROClbl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPricelbl = new System.Windows.Forms.Label();
            this.lblChangelbl = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblChartAnay = new System.Windows.Forms.LinkLabel();
            this.pictureBoxChart = new System.Windows.Forms.PictureBox();
            this.lblHighlbl = new System.Windows.Forms.Label();
            this.lblLowlbl = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.flowLayoutPanelCode.SuspendLayout();
            this.tableLayoutPanelData.SuspendLayout();
            this.panelPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCode.Location = new System.Drawing.Point(3, 8);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 12);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "股票代號:";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCode.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCode.Location = new System.Drawing.Point(65, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 23);
            this.txtCode.TabIndex = 1;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // btnQuote
            // 
            this.btnQuote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuote.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuote.Location = new System.Drawing.Point(171, 3);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(75, 23);
            this.btnQuote.TabIndex = 2;
            this.btnQuote.Text = "查詢(&Q)";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flowLayoutPanelCode
            // 
            this.flowLayoutPanelCode.Controls.Add(this.lblCode);
            this.flowLayoutPanelCode.Controls.Add(this.txtCode);
            this.flowLayoutPanelCode.Controls.Add(this.btnQuote);
            this.flowLayoutPanelCode.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanelCode.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelCode.Name = "flowLayoutPanelCode";
            this.flowLayoutPanelCode.Size = new System.Drawing.Size(360, 29);
            this.flowLayoutPanelCode.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanelData
            // 
            this.tableLayoutPanelData.ColumnCount = 4;
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelData.Controls.Add(this.lblROC, 3, 2);
            this.tableLayoutPanelData.Controls.Add(this.lblROClbl, 2, 2);
            this.tableLayoutPanelData.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanelData.Controls.Add(this.panelPrice, 0, 1);
            this.tableLayoutPanelData.Controls.Add(this.lblChangelbl, 2, 1);
            this.tableLayoutPanelData.Controls.Add(this.lblChange, 3, 1);
            this.tableLayoutPanelData.Controls.Add(this.lblChartAnay, 2, 9);
            this.tableLayoutPanelData.Controls.Add(this.pictureBoxChart, 2, 3);
            this.tableLayoutPanelData.Controls.Add(this.lblHighlbl, 0, 3);
            this.tableLayoutPanelData.Controls.Add(this.lblLowlbl, 0, 4);
            this.tableLayoutPanelData.Controls.Add(this.lblHigh, 1, 3);
            this.tableLayoutPanelData.Controls.Add(this.lblLow, 1, 4);
            this.tableLayoutPanelData.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 10;
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.Size = new System.Drawing.Size(360, 202);
            this.tableLayoutPanelData.TabIndex = 5;
            // 
            // lblROC
            // 
            this.lblROC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblROC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblROC.Location = new System.Drawing.Point(255, 40);
            this.lblROC.Name = "lblROC";
            this.lblROC.Size = new System.Drawing.Size(102, 20);
            this.lblROC.TabIndex = 7;
            this.lblROC.Text = "0.000%";
            this.lblROC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblROClbl
            // 
            this.lblROClbl.AutoSize = true;
            this.lblROClbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblROClbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblROClbl.Location = new System.Drawing.Point(183, 40);
            this.lblROClbl.Name = "lblROClbl";
            this.lblROClbl.Size = new System.Drawing.Size(66, 20);
            this.lblROClbl.TabIndex = 6;
            this.lblROClbl.Text = "升跌(%)";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.tableLayoutPanelData.SetColumnSpan(this.lblName, 4);
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(354, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "請輸入編號";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelPrice
            // 
            this.tableLayoutPanelData.SetColumnSpan(this.panelPrice, 2);
            this.panelPrice.Controls.Add(this.lblPrice);
            this.panelPrice.Controls.Add(this.lblPricelbl);
            this.panelPrice.Location = new System.Drawing.Point(0, 20);
            this.panelPrice.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrice.Name = "panelPrice";
            this.tableLayoutPanelData.SetRowSpan(this.panelPrice, 2);
            this.panelPrice.Size = new System.Drawing.Size(180, 40);
            this.panelPrice.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(41, 10);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(135, 27);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "N/A";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPricelbl
            // 
            this.lblPricelbl.AutoSize = true;
            this.lblPricelbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPricelbl.Location = new System.Drawing.Point(3, 3);
            this.lblPricelbl.Name = "lblPricelbl";
            this.lblPricelbl.Size = new System.Drawing.Size(29, 12);
            this.lblPricelbl.TabIndex = 2;
            this.lblPricelbl.Text = "現價";
            // 
            // lblChangelbl
            // 
            this.lblChangelbl.AutoSize = true;
            this.lblChangelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChangelbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblChangelbl.Location = new System.Drawing.Point(183, 20);
            this.lblChangelbl.Name = "lblChangelbl";
            this.lblChangelbl.Size = new System.Drawing.Size(66, 20);
            this.lblChangelbl.TabIndex = 4;
            this.lblChangelbl.Text = "升跌";
            // 
            // lblChange
            // 
            this.lblChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChange.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(255, 20);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(102, 20);
            this.lblChange.TabIndex = 5;
            this.lblChange.Text = "0.000";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChartAnay
            // 
            this.lblChartAnay.AutoSize = true;
            this.tableLayoutPanelData.SetColumnSpan(this.lblChartAnay, 2);
            this.lblChartAnay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChartAnay.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblChartAnay.Location = new System.Drawing.Point(183, 180);
            this.lblChartAnay.Name = "lblChartAnay";
            this.lblChartAnay.Size = new System.Drawing.Size(174, 22);
            this.lblChartAnay.TabIndex = 8;
            this.lblChartAnay.TabStop = true;
            this.lblChartAnay.Text = "圖表分析";
            this.lblChartAnay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChartAnay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChart_LinkClicked);
            // 
            // pictureBoxChart
            // 
            this.pictureBoxChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelData.SetColumnSpan(this.pictureBoxChart, 2);
            this.pictureBoxChart.Location = new System.Drawing.Point(183, 63);
            this.pictureBoxChart.Name = "pictureBoxChart";
            this.tableLayoutPanelData.SetRowSpan(this.pictureBoxChart, 6);
            this.pictureBoxChart.Size = new System.Drawing.Size(174, 114);
            this.pictureBoxChart.TabIndex = 9;
            this.pictureBoxChart.TabStop = false;
            // 
            // lblHighlbl
            // 
            this.lblHighlbl.AutoSize = true;
            this.lblHighlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHighlbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHighlbl.Location = new System.Drawing.Point(3, 60);
            this.lblHighlbl.Name = "lblHighlbl";
            this.lblHighlbl.Size = new System.Drawing.Size(66, 20);
            this.lblHighlbl.TabIndex = 10;
            this.lblHighlbl.Text = "最高";
            // 
            // lblLowlbl
            // 
            this.lblLowlbl.AutoSize = true;
            this.lblLowlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowlbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLowlbl.Location = new System.Drawing.Point(3, 80);
            this.lblLowlbl.Name = "lblLowlbl";
            this.lblLowlbl.Size = new System.Drawing.Size(66, 20);
            this.lblLowlbl.TabIndex = 11;
            this.lblLowlbl.Text = "最低";
            // 
            // lblHigh
            // 
            this.lblHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHigh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(75, 60);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(102, 20);
            this.lblHigh.TabIndex = 12;
            this.lblHigh.Text = "N/A";
            this.lblHigh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLow
            // 
            this.lblLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.Location = new System.Drawing.Point(75, 80);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(102, 20);
            this.lblLow.TabIndex = 13;
            this.lblLow.Text = "N/A";
            this.lblLow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmSingleStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.tableLayoutPanelData);
            this.Controls.Add(this.flowLayoutPanelCode);
            this.Name = "FrmSingleStock";
            this.Text = "個股查詢";
            this.Deactivate += new System.EventHandler(this.FrmSingleStock_Deactivate);
            this.Load += new System.EventHandler(this.FrmSingleStock_Load);
            this.Activated += new System.EventHandler(this.FrmSingleStock_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSingleStock_FormClosed);
            this.flowLayoutPanelCode.ResumeLayout(false);
            this.flowLayoutPanelCode.PerformLayout();
            this.tableLayoutPanelData.ResumeLayout(false);
            this.tableLayoutPanelData.PerformLayout();
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panelPrice;
        private System.Windows.Forms.Label lblPricelbl;
        private System.Windows.Forms.Label lblChangelbl;
        private System.Windows.Forms.Label lblROClbl;
        private System.Windows.Forms.Label lblROC;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.LinkLabel lblChartAnay;
        private System.Windows.Forms.PictureBox pictureBoxChart;
        private System.Windows.Forms.Label lblHighlbl;
        private System.Windows.Forms.Label lblLowlbl;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLow;
    }
}