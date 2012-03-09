using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;
using stockMgr;
using Profolio;

namespace StockTool
{
    public partial class MdiStockTool : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern uint SetThreadExecutionState(uint esFlags);

        private StockMgr _stockMgr = new StockMgr();
        private ProfolioMgr _profolioMgr;

        delegate void writeStatusBarCallback(Form sender, string msg);
        public void writeStatusBar(Form sender, string msg)
        {
            if (statusStrip.InvokeRequired)
            {
                writeStatusBarCallback d = new writeStatusBarCallback(writeStatusBar);
                Invoke(d, new object[] { sender, msg });
            }
            else
            {
                if (this.ActiveMdiChild == sender)
                {
                    statusStrip.Items[0].Text = msg;
                    statusStrip.Refresh();
                }
            }
        }

        public MdiStockTool()
        {
            InitializeComponent();
            try
            {
                _profolioMgr = new ProfolioMgr();
            }
            catch
            {
                _profolioMgr = null;
                組合管理ToolStripMenuItem.Enabled = false;
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "監視清單 (*.list)|*.list|所有檔案 (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                if (FileName.EndsWith(".list"))
                {
                    FrmList monList = new FrmList(_stockMgr,FileName);
                    monList.MdiParent = this;
                    monList.Show();
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = this.ActiveControl;
            if (control is ContainerControl)
                control = ((ContainerControl)control).ActiveControl;
            if (control is TextBox)
            {
                ((TextBox)control).Cut();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = this.ActiveControl;
            if (control is ContainerControl)
                control = ((ContainerControl)control).ActiveControl;
            if (control is TextBox)
            {
                ((TextBox)control).Copy();
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = this.ActiveControl;
            if (control is ContainerControl)
                control = ((ContainerControl)control).ActiveControl;
            if (control is TextBox)
            {
                ((TextBox)control).Paste();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = this.ActiveControl;
            if (control is ContainerControl)
                control = ((ContainerControl)control).ActiveControl;
            if (control is TextBox)
            {
                ((TextBox)control).SelectAll();
            }
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mdiStockTool_Load(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlConfig = new XmlDocument();
                xmlConfig.Load("StockTool.config");
                XmlElement config = (XmlElement)xmlConfig.GetElementsByTagName("configuration")[0];
                XmlElement startup = (XmlElement)config.GetElementsByTagName("startup")[0];
                XmlNodeList size = startup.GetElementsByTagName("size");
                if (size.Count > 0)
                {
                    int width = int.Parse(((XmlElement)size[0]).GetAttribute("width"));
                    int height = int.Parse(((XmlElement)size[0]).GetAttribute("height"));
                    Size = new Size(width, height);
                }
                XmlNodeList startmonlists = startup.GetElementsByTagName("monlist");
                for (int i = 0; i < startmonlists.Count; i++)
                {
                    string path = ((XmlElement)startmonlists[i]).GetAttribute("path").Trim();
                    TimeSpan on, off, utcOffset, curTime = DateTime.UtcNow.TimeOfDay;
                    utcOffset = TimeSpan.Parse(((XmlElement)startmonlists[i]).GetAttribute("utc_offset"));
                    on = TimeSpan.Parse(((XmlElement)startmonlists[i]).GetAttribute("on")) - utcOffset;
                    off = TimeSpan.Parse(((XmlElement)startmonlists[i]).GetAttribute("off")) - utcOffset;
                    on = on.Subtract(new TimeSpan(on.Days, 0, 0, 0));
                    off = off.Subtract(new TimeSpan(off.Days, 0, 0, 0));
                    if ((on < off && curTime > on && curTime < off) || (on > off && (curTime > on || curTime < off)))
                    {
                        FrmList monList = new FrmList(_stockMgr, path);
                        monList.MdiParent = this;
                        monList.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(DateTime.Now.ToString() + " Loading config file error");
            }
        }

        private void MdiStockTool_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void MdiStockTool_DragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in filenames)
            {
                if (file.EndsWith(".list"))
                {
                    FrmList monList = new FrmList(_stockMgr, file);
                    monList.MdiParent = this;
                    monList.Show();
                }
            }
        }

        private void 監視清單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmList monList = new FrmList(_stockMgr);
            monList.MdiParent = this;
            monList.Show();
        }

        private void 個股查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSingleStock frmSingleStock = new FrmSingleStock(_stockMgr);
            frmSingleStock.MdiParent = this;
            frmSingleStock.Show();
        }

        private void 指數IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIndex frmIndex = new FrmIndex(_stockMgr);
            frmIndex.MdiParent = this;
            frmIndex.Show();
        }

        private void 匯率ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCurrency frmCurrency = new FrmCurrency(_stockMgr);
            frmCurrency.MdiParent = this;
            frmCurrency.Show();
        }

        private void 加入交易ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfolioAddTransaction frmProfAddTran = new FrmProfolioAddTransaction(_profolioMgr);
            frmProfAddTran.MdiParent = this;
            frmProfAddTran.Show();
        }

        private void 交易查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQueryTransaction frmQueryTransaction = new FrmQueryTransaction(_stockMgr, _profolioMgr);
            frmQueryTransaction.MdiParent = this;
            frmQueryTransaction.Show();
        }

        private void 最上層顯示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = 最上層顯示ToolStripMenuItem.Checked;
        }

        private void 關閉螢幕保護ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setThreadExecutionStateTimer.Enabled = 關閉螢幕保護ToolStripMenuItem.Checked;
        }

        private void 期權計算機ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOptionPricing frmOptionPricing = new FrmOptionPricing(_stockMgr);
            frmOptionPricing.MdiParent = this;
            frmOptionPricing.Show();
        }

        private void 認股證計算機ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.rabowarrants.hk/SpecialProductsSiteHK/zh_HK/products/warrant-calculator.do");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBox()).ShowDialog();
        }

        private void setThreadExecutionStateTimer_Tick(object sender, EventArgs e)
        {
            SetThreadExecutionState(0x0002);
        }
    }
}
