using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicData;
using ReactiveUI;
using WolvenKit.Common;

namespace WolvenKit.Common.Services
{
    public class LogEntry : ReactiveObject
    {
        public LogEntry(string message, Logtype level)
        {
            Message = message;
            Level = level;
        }

        public string Message { get; set; }

        public Logtype Level { get; set; }

        public override string ToString() => Message;
    }


    public interface ILoggerService
    {
        void LogString(string msg, Logtype type);

        public void Log(string msg, Logtype type = Logtype.Normal);

        public void Info(string s);

        public void Warning(string s);

        public void Error(string msg);

        public void Important(string msg);

        public void Success(string msg);



        public IObservable<IChangeSet<LogEntry>> Connect();




    }
}
