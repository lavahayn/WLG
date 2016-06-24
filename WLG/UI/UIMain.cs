using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WLG.UI
{
    public partial class UIMain : Form
    {
        public UIMain()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            UIStatus frmStatus = new UIStatus();
            frmStatus.ShowDialog();
        }

        private void wLGImWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo wlgWebProcess = new ProcessStartInfo("http://lavahayn.de/");
            Process.Start(wlgWebProcess);
        }

        private void UIMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            UILogin loginForm = new UILogin();
            DialogResult dialogResult = loginForm.ShowDialog();
            switch (dialogResult)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    Visible = true;
                    break;
                case DialogResult.Cancel:
                    Close();
                    break;
                case DialogResult.Abort:
                    Close();
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    Visible = true;
                    break;
                case DialogResult.No:
                    Close();
                    break;
                default:
                    break;
            }
        }
    }
}
