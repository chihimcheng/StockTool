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
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.lblMa10lbl = new System.Windows.Forms.Label();
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
            this.lblVolumelbl = new System.Windows.Forms.Label();
            this.lblMthHighlbl = new System.Windows.Forms.Label();
            this.lblMthLowlbl = new System.Windows.Forms.Label();
            this.lblWk52Lowlbl = new System.Windows.Forms.Label();
            this.lblWk52Highlbl = new System.Windows.Forms.Label();
            this.lblMa20lbl = new System.Windows.Forms.Label();
            this.lblMa50lbl = new System.Windows.Forms.Label();
            this.lblRsi10lbl = new System.Windows.Forms.Label();
            this.lblRsi14lbl = new System.Windows.Forms.Label();
            this.lblRsi20lbl = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblMthHigh = new System.Windows.Forms.Label();
            this.lblMthLow = new System.Windows.Forms.Label();
            this.lblWk52High = new System.Windows.Forms.Label();
            this.lblWk52Low = new System.Windows.Forms.Label();
            this.lblMa10 = new System.Windows.Forms.Label();
            this.lblMa20 = new System.Windows.Forms.Label();
            this.lblMa50 = new System.Windows.Forms.Label();
            this.lblRsi10 = new System.Windows.Forms.Label();
            this.lblRsi14 = new System.Windows.Forms.Label();
            this.lblRsi20 = new System.Windows.Forms.Label();
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
            this.flowLayoutPanelCode.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelCode.Name = "flowLayoutPanelCode";
            this.flowLayoutPanelCode.Size = new System.Drawing.Size(360, 29);
            this.flowLayoutPanelCode.TabIndex = 0;
            // 
            // tableLayoutPanelData
            // 
            this.tableLayoutPanelData.ColumnCount = 4;
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelData.Controls.Add(this.lblRsi20, 3, 12);
            this.tableLayoutPanelData.Controls.Add(this.lblRsi14, 3, 11);
            this.tableLayoutPanelData.Controls.Add(this.lblMa10lbl, 0, 10);
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
            this.tableLayoutPanelData.Controls.Add(this.lblVolumelbl, 0, 5);
            this.tableLayoutPanelData.Controls.Add(this.lblMthHighlbl, 0, 6);
            this.tableLayoutPanelData.Controls.Add(this.lblMthLowlbl, 0, 7);
            this.tableLayoutPanelData.Controls.Add(this.lblWk52Lowlbl, 0, 9);
            this.tableLayoutPanelData.Controls.Add(this.lblWk52Highlbl, 0, 8);
            this.tableLayoutPanelData.Controls.Add(this.lblMa20lbl, 0, 11);
            this.tableLayoutPanelData.Controls.Add(this.lblRsi10lbl, 2, 10);
            this.tableLayoutPanelData.Controls.Add(this.lblMa50lbl, 0, 12);
            this.tableLayoutPanelData.Controls.Add(this.lblRsi14lbl, 2, 11);
            this.tableLayoutPanelData.Controls.Add(this.lblRsi20lbl, 2, 12);
            this.tableLayoutPanelData.Controls.Add(this.lblVolume, 1, 5);
            this.tableLayoutPanelData.Controls.Add(this.lblMthHigh, 1, 6);
            this.tableLayoutPanelData.Controls.Add(this.lblMthLow, 1, 7);
            this.tableLayoutPanelData.Controls.Add(this.lblWk52High, 1, 8);
            this.tableLayoutPanelData.Controls.Add(this.lblWk52Low, 1, 9);
            this.tableLayoutPanelData.Controls.Add(this.lblMa10, 1, 10);
            this.tableLayoutPanelData.Controls.Add(this.lblMa20, 1, 11);
            this.tableLayoutPanelData.Controls.Add(this.lblMa50, 1, 12);
            this.tableLayoutPanelData.Controls.Add(this.lblRsi10, 3, 10);
            this.tableLayoutPanelData.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 13;
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
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.Size = new System.Drawing.Size(360, 260);
            this.tableLayoutPanelData.TabIndex = 1;
            // 
            // lblMa10lbl
            // 
            this.lblMa10lbl.AutoSize = true;
            this.lblMa10lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMa10lbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMa10lbl.Location = new System.Drawing.Point(3, 200);
            this.lblMa10lbl.Name = "lblMa10lbl";
            this.lblMa10lbl.Size = new System.Drawing.Size(66, 20);
            this.lblMa10lbl.TabIndex = 20;
            this.lblMa10lbl.Text = "10天平均價";
            // 
            // lblROC
            // 
            this.lblROC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblROC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblROC.Location = new System.Drawing.Point(255, 40);
            this.lblROC.Name = "lblROC";
            this.lblROC.Size = new System.Drawing.Size(102, 20);
            this.lblROC.TabIndex = 5;
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
            this.lblROClbl.TabIndex = 4;
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
            this.panelPrice.TabIndex = 1;
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
            this.lblPricelbl.TabIndex = 0;
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
            this.lblChangelbl.TabIndex = 2;
            this.lblChangelbl.Text = "升跌";
            // 
            // lblChange
            // 
            this.lblChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChange.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(255, 20);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(102, 20);
            this.lblChange.TabIndex = 3;
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
            this.lblChartAnay.Size = new System.Drawing.Size(174, 20);
            this.lblChartAnay.TabIndex = 32;
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
            this.lblHighlbl.TabIndex = 6;
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
            this.lblLowlbl.TabIndex = 8;
            this.lblLowlbl.Text = "最低";
            // 
            // lblHigh
            // 
            this.lblHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHigh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(75, 60);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(102, 20);
            this.lblHigh.TabIndex = 7;
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
            this.lblLow.TabIndex = 9;
            this.lblLow.Text = "N/A";
            this.lblLow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVolumelbl
            // 
            this.lblVolumelbl.AutoSize = true;
            this.lblVolumelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVolumelbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblVolumelbl.Location = new System.Drawing.Point(3, 100);
            this.lblVolumelbl.Name = "lblVolumelbl";
            this.lblVolumelbl.Size = new System.Drawing.Size(66, 20);
            this.lblVolumelbl.TabIndex = 10;
            this.lblVolumelbl.Text = "成交量";
            // 
            // lblMthHighlbl
            // 
            this.lblMthHighlbl.AutoSize = true;
            this.lblMthHighlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMthHighlbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMthHighlbl.Location = new System.Drawing.Point(3, 120);
            this.lblMthHighlbl.Name = "lblMthHighlbl";
            this.lblMthHighlbl.Size = new System.Drawing.Size(66, 20);
            this.lblMthHighlbl.TabIndex = 12;
            this.lblMthHighlbl.Text = "一個月最高";
            // 
            // lblMthLowlbl
            // 
            this.lblMthLowlbl.AutoSize = true;
            this.lblMthLowlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMthLowlbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMthLowlbl.Location = new System.Drawing.Point(3, 140);
            this.lblMthLowlbl.Name = "lblMthLowlbl";
            this.lblMthLowlbl.Size = new System.Drawing.Size(66, 20);
            this.lblMthLowlbl.TabIndex = 14;
            this.lblMthLowlbl.Text = "一個月最低";
            // 
            // lblWk52Lowlbl
            // 
            this.lblWk52Lowlbl.AutoSize = true;
            this.lblWk52Lowlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWk52Lowlbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWk52Lowlbl.Location = new System.Drawing.Point(3, 180);
            this.lblWk52Lowlbl.Name = "lblWk52Lowlbl";
            this.lblWk52Lowlbl.Size = new System.Drawing.Size(66, 20);
            this.lblWk52Lowlbl.TabIndex = 18;
            this.lblWk52Lowlbl.Text = "52週最低";
            // 
            // lblWk52Highlbl
            // 
            this.lblWk52Highlbl.AutoSize = true;
            this.lblWk52Highlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWk52Highlbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWk52Highlbl.Location = new System.Drawing.Point(3, 160);
            this.lblWk52Highlbl.Name = "lblWk52Highlbl";
            this.lblWk52Highlbl.Size = new System.Drawing.Size(66, 20);
            this.lblWk52Highlbl.TabIndex = 16;
            this.lblWk52Highlbl.Text = "52週最高";
            // 
            // lblMa20lbl
            // 
            this.lblMa20lbl.AutoSize = true;
            this.lblMa20lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMa20lbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMa20lbl.Location = new System.Drawing.Point(3, 220);
            this.lblMa20lbl.Name = "lblMa20lbl";
            this.lblMa20lbl.Size = new System.Drawing.Size(66, 20);
            this.lblMa20lbl.TabIndex = 22;
            this.lblMa20lbl.Text = "20天平均價";
            // 
            // lblMa50lbl
            // 
            this.lblMa50lbl.AutoSize = true;
            this.lblMa50lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMa50lbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMa50lbl.Location = new System.Drawing.Point(3, 240);
            this.lblMa50lbl.Name = "lblMa50lbl";
            this.lblMa50lbl.Size = new System.Drawing.Size(66, 20);
            this.lblMa50lbl.TabIndex = 24;
            this.lblMa50lbl.Text = "50天平均價";
            // 
            // lblRsi10lbl
            // 
            this.lblRsi10lbl.AutoSize = true;
            this.lblRsi10lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRsi10lbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRsi10lbl.Location = new System.Drawing.Point(183, 200);
            this.lblRsi10lbl.Name = "lblRsi10lbl";
            this.lblRsi10lbl.Size = new System.Drawing.Size(66, 20);
            this.lblRsi10lbl.TabIndex = 26;
            this.lblRsi10lbl.Text = "RSI (10天)";
            // 
            // lblRsi14lbl
            // 
            this.lblRsi14lbl.AutoSize = true;
            this.lblRsi14lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRsi14lbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRsi14lbl.Location = new System.Drawing.Point(183, 220);
            this.lblRsi14lbl.Name = "lblRsi14lbl";
            this.lblRsi14lbl.Size = new System.Drawing.Size(66, 20);
            this.lblRsi14lbl.TabIndex = 28;
            this.lblRsi14lbl.Text = "RSI (14天)";
            // 
            // lblRsi20lbl
            // 
            this.lblRsi20lbl.AutoSize = true;
            this.lblRsi20lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRsi20lbl.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRsi20lbl.Location = new System.Drawing.Point(183, 240);
            this.lblRsi20lbl.Name = "lblRsi20lbl";
            this.lblRsi20lbl.Size = new System.Drawing.Size(66, 20);
            this.lblRsi20lbl.TabIndex = 30;
            this.lblRsi20lbl.Text = "RSI (20天)";
            // 
            // lblVolume
            // 
            this.lblVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVolume.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(75, 100);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(102, 20);
            this.lblVolume.TabIndex = 11;
            this.lblVolume.Text = "N/A";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMthHigh
            // 
            this.lblMthHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMthHigh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMthHigh.Location = new System.Drawing.Point(75, 120);
            this.lblMthHigh.Name = "lblMthHigh";
            this.lblMthHigh.Size = new System.Drawing.Size(102, 20);
            this.lblMthHigh.TabIndex = 13;
            this.lblMthHigh.Text = "N/A";
            this.lblMthHigh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMthLow
            // 
            this.lblMthLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMthLow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMthLow.Location = new System.Drawing.Point(75, 140);
            this.lblMthLow.Name = "lblMthLow";
            this.lblMthLow.Size = new System.Drawing.Size(102, 20);
            this.lblMthLow.TabIndex = 15;
            this.lblMthLow.Text = "N/A";
            this.lblMthLow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblWk52High
            // 
            this.lblWk52High.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWk52High.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWk52High.Location = new System.Drawing.Point(75, 160);
            this.lblWk52High.Name = "lblWk52High";
            this.lblWk52High.Size = new System.Drawing.Size(102, 20);
            this.lblWk52High.TabIndex = 17;
            this.lblWk52High.Text = "N/A";
            this.lblWk52High.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblWk52Low
            // 
            this.lblWk52Low.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWk52Low.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWk52Low.Location = new System.Drawing.Point(75, 180);
            this.lblWk52Low.Name = "lblWk52Low";
            this.lblWk52Low.Size = new System.Drawing.Size(102, 20);
            this.lblWk52Low.TabIndex = 19;
            this.lblWk52Low.Text = "N/A";
            this.lblWk52Low.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMa10
            // 
            this.lblMa10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMa10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa10.Location = new System.Drawing.Point(75, 200);
            this.lblMa10.Name = "lblMa10";
            this.lblMa10.Size = new System.Drawing.Size(102, 20);
            this.lblMa10.TabIndex = 21;
            this.lblMa10.Text = "N/A";
            this.lblMa10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMa20
            // 
            this.lblMa20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMa20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa20.Location = new System.Drawing.Point(75, 220);
            this.lblMa20.Name = "lblMa20";
            this.lblMa20.Size = new System.Drawing.Size(102, 20);
            this.lblMa20.TabIndex = 23;
            this.lblMa20.Text = "N/A";
            this.lblMa20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMa50
            // 
            this.lblMa50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMa50.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa50.Location = new System.Drawing.Point(75, 240);
            this.lblMa50.Name = "lblMa50";
            this.lblMa50.Size = new System.Drawing.Size(102, 20);
            this.lblMa50.TabIndex = 25;
            this.lblMa50.Text = "N/A";
            this.lblMa50.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRsi10
            // 
            this.lblRsi10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRsi10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRsi10.Location = new System.Drawing.Point(255, 200);
            this.lblRsi10.Name = "lblRsi10";
            this.lblRsi10.Size = new System.Drawing.Size(102, 20);
            this.lblRsi10.TabIndex = 27;
            this.lblRsi10.Text = "N/A";
            this.lblRsi10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRsi14
            // 
            this.lblRsi14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRsi14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRsi14.Location = new System.Drawing.Point(255, 220);
            this.lblRsi14.Name = "lblRsi14";
            this.lblRsi14.Size = new System.Drawing.Size(102, 20);
            this.lblRsi14.TabIndex = 29;
            this.lblRsi14.Text = "N/A";
            this.lblRsi14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRsi20
            // 
            this.lblRsi20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRsi20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRsi20.Location = new System.Drawing.Point(255, 240);
            this.lblRsi20.Name = "lblRsi20";
            this.lblRsi20.Size = new System.Drawing.Size(102, 20);
            this.lblRsi20.TabIndex = 31;
            this.lblRsi20.Text = "N/A";
            this.lblRsi20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmSingleStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(384, 322);
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
        private System.Windows.Forms.Label lblVolumelbl;
        private System.Windows.Forms.Label lblMthHighlbl;
        private System.Windows.Forms.Label lblMthLowlbl;
        private System.Windows.Forms.Label lblWk52Highlbl;
        private System.Windows.Forms.Label lblWk52Lowlbl;
        private System.Windows.Forms.Label lblMa10lbl;
        private System.Windows.Forms.Label lblMa20lbl;
        private System.Windows.Forms.Label lblRsi10lbl;
        private System.Windows.Forms.Label lblMa50lbl;
        private System.Windows.Forms.Label lblRsi14lbl;
        private System.Windows.Forms.Label lblRsi20lbl;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblMthHigh;
        private System.Windows.Forms.Label lblMthLow;
        private System.Windows.Forms.Label lblRsi20;
        private System.Windows.Forms.Label lblRsi14;
        private System.Windows.Forms.Label lblWk52High;
        private System.Windows.Forms.Label lblWk52Low;
        private System.Windows.Forms.Label lblMa10;
        private System.Windows.Forms.Label lblMa20;
        private System.Windows.Forms.Label lblMa50;
        private System.Windows.Forms.Label lblRsi10;
    }
}