using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WLG.Helper;

namespace WLG.Console
{
    public partial class UIConsole : Form
    {
        public UIConsole()
        {
            InitializeComponent();
        }

        private void UIConsole_FormClosed(object sender, FormClosedEventArgs e)
        {
            Config.ConsoleRunning = false;
        }
    }
}
