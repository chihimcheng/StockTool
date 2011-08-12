namespace StockTool
{
    partial class FrmOptionPricing
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblUnderlyingPrice = new System.Windows.Forms.Label();
            this.txtUnderlyingPrice = new System.Windows.Forms.TextBox();
            this.lblExePrice = new System.Windows.Forms.Label();
            this.txtExePrice = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtVolatility = new System.Windows.Forms.TextBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblDividend = new System.Windows.Forms.Label();
            this.txtDividend = new System.Windows.Forms.TextBox();
            this.lblOptPrice = new System.Windows.Forms.Label();
            this.lblOptPricelbl = new System.Windows.Forms.Label();
            this.lblVolatility = new System.Windows.Forms.Label();
            this.tableLayoutPanelOptType = new System.Windows.Forms.TableLayoutPanel();
            this.rbPut = new System.Windows.Forms.RadioButton();
            this.rbCall = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelOptType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.lblUnderlyingPrice, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtUnderlyingPrice, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblExePrice, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtExePrice, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblTime, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.btnOK, 3, 7);
            this.tableLayoutPanel.Controls.Add(this.txtTime, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.txtVolatility, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.lblInterest, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.txtInterest, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.lblDividend, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.txtDividend, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.lblOptPrice, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lblOptPricelbl, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.lblVolatility, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelOptType, 0, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(368, 246);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblUnderlyingPrice
            // 
            this.lblUnderlyingPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnderlyingPrice.AutoSize = true;
            this.lblUnderlyingPrice.Location = new System.Drawing.Point(3, 10);
            this.lblUnderlyingPrice.Name = "lblUnderlyingPrice";
            this.lblUnderlyingPrice.Size = new System.Drawing.Size(32, 12);
            this.lblUnderlyingPrice.TabIndex = 0;
            this.lblUnderlyingPrice.Text = "現價:";
            // 
            // txtUnderlyingPrice
            // 
            this.txtUnderlyingPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUnderlyingPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnderlyingPrice.Location = new System.Drawing.Point(95, 6);
            this.txtUnderlyingPrice.Name = "txtUnderlyingPrice";
            this.txtUnderlyingPrice.Size = new System.Drawing.Size(86, 21);
            this.txtUnderlyingPrice.TabIndex = 1;
            this.txtUnderlyingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnderlyingPrice.Leave += new System.EventHandler(this.txtUnderlyingPrice_Leave);
            // 
            // lblExePrice
            // 
            this.lblExePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExePrice.AutoSize = true;
            this.lblExePrice.Location = new System.Drawing.Point(3, 43);
            this.lblExePrice.Name = "lblExePrice";
            this.lblExePrice.Size = new System.Drawing.Size(44, 12);
            this.lblExePrice.TabIndex = 2;
            this.lblExePrice.Text = "行使價:";
            // 
            // txtExePrice
            // 
            this.txtExePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtExePrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExePrice.Location = new System.Drawing.Point(95, 39);
            this.txtExePrice.Name = "txtExePrice";
            this.txtExePrice.Size = new System.Drawing.Size(86, 21);
            this.txtExePrice.TabIndex = 3;
            this.txtExePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 76);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 12);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "餘下時間(yr):";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(290, 220);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "確定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtTime
            // 
            this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(95, 72);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(86, 21);
            this.txtTime.TabIndex = 5;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTime.Leave += new System.EventHandler(this.txtTime_Leave);
            // 
            // txtVolatility
            // 
            this.txtVolatility.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVolatility.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolatility.Location = new System.Drawing.Point(279, 6);
            this.txtVolatility.Name = "txtVolatility";
            this.txtVolatility.Size = new System.Drawing.Size(86, 21);
            this.txtVolatility.TabIndex = 7;
            this.txtVolatility.Text = "20";
            this.txtVolatility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVolatility.Leave += new System.EventHandler(this.txtVolatility_Leave);
            // 
            // lblInterest
            // 
            this.lblInterest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(187, 43);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(49, 12);
            this.lblInterest.TabIndex = 8;
            this.lblInterest.Text = "利率(%):";
            // 
            // txtInterest
            // 
            this.txtInterest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInterest.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.Location = new System.Drawing.Point(279, 39);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(86, 21);
            this.txtInterest.TabIndex = 9;
            this.txtInterest.Text = "5";
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDividend
            // 
            this.lblDividend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDividend.AutoSize = true;
            this.lblDividend.Location = new System.Drawing.Point(187, 76);
            this.lblDividend.Name = "lblDividend";
            this.lblDividend.Size = new System.Drawing.Size(61, 12);
            this.lblDividend.TabIndex = 10;
            this.lblDividend.Text = "股息率(%):";
            // 
            // txtDividend
            // 
            this.txtDividend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDividend.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDividend.Location = new System.Drawing.Point(279, 72);
            this.txtDividend.Name = "txtDividend";
            this.txtDividend.Size = new System.Drawing.Size(86, 21);
            this.txtDividend.TabIndex = 11;
            this.txtDividend.Text = "0";
            this.txtDividend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOptPrice
            // 
            this.lblOptPrice.AutoSize = true;
            this.lblOptPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOptPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptPrice.Location = new System.Drawing.Point(95, 145);
            this.lblOptPrice.Name = "lblOptPrice";
            this.lblOptPrice.Size = new System.Drawing.Size(86, 33);
            this.lblOptPrice.TabIndex = 15;
            this.lblOptPrice.Text = "N/A";
            this.lblOptPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOptPricelbl
            // 
            this.lblOptPricelbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOptPricelbl.AutoSize = true;
            this.lblOptPricelbl.Location = new System.Drawing.Point(3, 155);
            this.lblOptPricelbl.Name = "lblOptPricelbl";
            this.lblOptPricelbl.Size = new System.Drawing.Size(44, 12);
            this.lblOptPricelbl.TabIndex = 14;
            this.lblOptPricelbl.Text = "理論值:";
            // 
            // lblVolatility
            // 
            this.lblVolatility.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVolatility.AutoSize = true;
            this.lblVolatility.Location = new System.Drawing.Point(187, 10);
            this.lblVolatility.Name = "lblVolatility";
            this.lblVolatility.Size = new System.Drawing.Size(49, 12);
            this.lblVolatility.TabIndex = 6;
            this.lblVolatility.Text = "波幅(%):";
            // 
            // tableLayoutPanelOptType
            // 
            this.tableLayoutPanelOptType.ColumnCount = 2;
            this.tableLayoutPanel.SetColumnSpan(this.tableLayoutPanelOptType, 2);
            this.tableLayoutPanelOptType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOptType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOptType.Controls.Add(this.rbPut, 1, 0);
            this.tableLayoutPanelOptType.Controls.Add(this.rbCall, 0, 0);
            this.tableLayoutPanelOptType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOptType.Location = new System.Drawing.Point(0, 99);
            this.tableLayoutPanelOptType.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelOptType.Name = "tableLayoutPanelOptType";
            this.tableLayoutPanelOptType.RowCount = 1;
            this.tableLayoutPanelOptType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOptType.Size = new System.Drawing.Size(184, 33);
            this.tableLayoutPanelOptType.TabIndex = 12;
            // 
            // rbPut
            // 
            this.rbPut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbPut.AutoSize = true;
            this.rbPut.Location = new System.Drawing.Point(95, 8);
            this.rbPut.Name = "rbPut";
            this.rbPut.Size = new System.Drawing.Size(47, 16);
            this.rbPut.TabIndex = 1;
            this.rbPut.Text = "認沽";
            this.rbPut.UseVisualStyleBackColor = true;
            // 
            // rbCall
            // 
            this.rbCall.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbCall.AutoSize = true;
            this.rbCall.Checked = true;
            this.rbCall.Location = new System.Drawing.Point(3, 8);
            this.rbCall.Name = "rbCall";
            this.rbCall.Size = new System.Drawing.Size(47, 16);
            this.rbCall.TabIndex = 0;
            this.rbCall.TabStop = true;
            this.rbCall.Text = "認購";
            this.rbCall.UseVisualStyleBackColor = true;
            // 
            // FrmOptionPricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FrmOptionPricing";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "期權計算機";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanelOptType.ResumeLayout(false);
            this.tableLayoutPanelOptType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblExePrice;
        private System.Windows.Forms.Label lblUnderlyingPrice;
        private System.Windows.Forms.TextBox txtUnderlyingPrice;
        private System.Windows.Forms.TextBox txtExePrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblVolatility;
        private System.Windows.Forms.TextBox txtVolatility;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lblDividend;
        private System.Windows.Forms.TextBox txtDividend;
        private System.Windows.Forms.Label lblOptPricelbl;
        private System.Windows.Forms.Label lblOptPrice;
        private System.Windows.Forms.RadioButton rbCall;
        private System.Windows.Forms.RadioButton rbPut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOptType;
    }
}