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
using WLGSDK;

namespace WLG.UI
{
    public partial class UILogin : DraggableForm
    {
        public EnumDragDropState DragState { get; private set; }

        public Point FirstPoint { get; private set; }

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

    }
}
