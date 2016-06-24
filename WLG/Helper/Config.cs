using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLGSDK;

namespace WLG.Helper
{
    [Serializable]
    public static class Config
    {
        private static bool m_LoggedIn = false;
        private static bool m_Running = true;
        private static bool m_ConsoleRunning = true;
        private static bool m_UIRunning = true;
        private static EnumLogLevel m_Loglevel = EnumLogLevel.Error | EnumLogLevel.Warning | EnumLogLevel.Info | EnumLogLevel.Message | EnumLogLevel.MessageBox | EnumLogLevel.Trace;
        private static string m_LogFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lavahayn Technology","WLG","log.wlg"); 
#if Debug
        m_Loglevel |= EnumLogLevel.Debug
#endif
        public static bool LoggedIn { get { return m_LoggedIn; } set { m_LoggedIn = value; } }
        public static bool Running { get { return m_Running; } set { m_Running = value; } }
        public static bool UIRunning { get { return m_UIRunning; } set { m_UIRunning = value; } }
        public static bool ConsoleRunning { get { return m_ConsoleRunning; } set { m_ConsoleRunning = value; } }

        public static EnumLogLevel Loglevel { get { return m_Loglevel; } }

        public static string LogFilePath { get { return m_LogFilePath; } }
    }
}
