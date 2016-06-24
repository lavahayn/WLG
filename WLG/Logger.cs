using System;
using System.IO;
using WLG.Helper;
using WLGSDK;
using WLGSDK.Interfaces;

namespace WLG
{
    internal class Logger : ILogger
    {
        public Logger()
        {
        }

        public void Log(string message)
        {
            Log(Config.Loglevel, message);
        }

        public void Log(EnumLogLevel loglevel, string message)
        {
            FileInfo logFile = new FileInfo(Config.LogFilePath);
        }
    }
}