using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLG.Helper
{
    [Serializable]
    public static class Config
    {
        private static bool m_LoggedIn = false;

        public static bool LoggedIn { get { return m_LoggedIn; }  set { m_LoggedIn = value; } }
    }
}
