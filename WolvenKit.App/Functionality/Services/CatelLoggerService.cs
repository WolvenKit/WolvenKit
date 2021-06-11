using System;
using Catel.Logging;

namespace WolvenKit.Common.Services
{
    public class CatelLoggerService : ILoggerService
    {
        private static readonly ILog s_log = LogManager.GetCurrentClassLogger();

        public CatelLoggerService()
        {
            
        }

        public CatelLoggerService(bool enableConsoleListener)
        {
            if (enableConsoleListener)
            {
                var logListener = new ConsoleLogListener
                {
                    IgnoreCatelLogging = true
                };
                LogManager.AddListener(logListener);
            }
        }

        public void LogString(string msg, Logtype type)
        {
            switch (type)
            {
                case Logtype.Normal:
                    s_log.Info(msg);
                    break;
                case Logtype.Error:
                    s_log.Error(msg);
                    break;
                case Logtype.Important:
                    s_log.Warning(msg);
                    break;
                case Logtype.Success:
                    s_log.Info(msg);
                    break;
                case Logtype.Wcc:
                    s_log.Info(msg);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public void Success(string msg) => LogString(msg, Logtype.Success);

        public void Log(string msg, Logtype type = Logtype.Normal) => LogString(msg, type);

        public void Error(string msg) => LogString(msg, Logtype.Error);

        public void Important(string msg) => LogString(msg, Logtype.Important);

        public void Info(string s) => Important(s);

        public void Warning(string s) => Important(s);
    }
}
