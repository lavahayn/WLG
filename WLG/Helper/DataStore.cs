using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLGSDK.Interfaces;

namespace WLG.Helper
{
    [Serializable]
    class DataStore
    {
        public static DateTime RunDate { get; set; }
        public static ILogger StaticLogger { get; internal set; }
    }
}
