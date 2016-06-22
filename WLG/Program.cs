using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WLG.Helper;
using WLG.UI;

namespace WLG
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CollectRuntimeInfos();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UILogin());
            if (Config.LoggedIn)
            {
                Application.Run(new UIMain());
            }
        }

        private static void CollectRuntimeInfos()
        {
            DataStore.RunDate = DateTime.Now;
        }
    }
}
