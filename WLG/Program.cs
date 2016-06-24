using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WLG.Console;
using WLG.Helper;
using WLG.UI;
using WLGSDK;

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
            
                Application.Run(new MultiFormContext(new UIConsole(), new UIMain()));
        }

        private static void CollectRuntimeInfos()
        {
            DataStore.RunDate = DateTime.Now;
            DataStore.StaticLogger = new Logger();
        }
    }
}
