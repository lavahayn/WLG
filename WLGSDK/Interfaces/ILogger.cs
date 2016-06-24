using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLGSDK;

namespace WLGSDK.Interfaces
{
    public interface ILogger
    {
        void Log(string message);
        void Log(EnumLogLevel loglevel, string message);


    }
}
