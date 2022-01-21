using System;
using System.IO;
using DynamicData;
using WolvenKit.Common;
using WolvenKit.Common.Services;

namespace WolvenKit.Functionality.Services
{
    public class ReactiveLoggerService : ILoggerService
    {
        private const int s_limit = 100000;

        private readonly SourceList<LogEntry> _log = new();
        public IObservable<IChangeSet<LogEntry>> Connect() => _log.Connect();

        public ReactiveLoggerService()
        {
            var outPath = Path.Combine(ISettingsManager.GetAppData(), "applog.txt");
            File.WriteAllText(outPath, string.Empty);
        }

        private void LogString(string msg, Logtype type)
        {
            var x = new LogEntry(msg, type, DateTime.Now);
            if (_log.Count > s_limit)
            {
                _log.RemoveAt(0);
            }
            _log.Add(x);

            // log to logfile
            var outPath = Path.Combine(ISettingsManager.GetAppData(), "applog.txt");
            using var w = File.AppendText(outPath);
            logToFile(x, w);
        }

        private void logToFile(LogEntry logEntry, TextWriter txtWriter)
        {
            try
            {
                var logmessage =
                    $"[{DateTime.Now.ToShortDateString()}, {DateTime.Now.ToLongTimeString()}] [{logEntry.Level}] {logEntry.Message}";
                txtWriter.WriteLine(logmessage);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        // Normal
        public void Log(string msg, Logtype type = Logtype.Normal) => LogString(msg, type);


        public void Success(string msg) => LogString(msg, Logtype.Success);

        public void Info(string s) => LogString(s, Logtype.Important);
        public void Important(string s) => LogString(s, Logtype.Important);

        public void Warning(string s) => LogString(s, Logtype.Error);

        public void Error(string msg) => LogString(msg, Logtype.Error);
        public void Error(Exception exception)
        {
            var msg =
                $"========================\r\n" +
                $"{exception.ToString()}" +
                $"\r\n========================";
            Error(msg);
        }
    }
}
