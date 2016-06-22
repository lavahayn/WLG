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

namespace WLG.UI
{
    public partial class UILogin : Form
    {
        public UILogin()
        {
            InitializeComponent();
        }

        private void UILogin_Load(object sender, EventArgs e)
        {

        }

        private void UILogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.LoggedIn = true;
        }

        private void UILogin_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
