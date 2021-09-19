using System;
using DynamicData;
using ReactiveUI;

namespace WolvenKit.Common.Services
{
    public class LogEntry : ReactiveObject
    {
        public LogEntry(string message, Logtype level, DateTime timeStamp)
        {
            Message = message;
            Level = level;
            TimeStamp = timeStamp;
        }

        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
        public Logtype Level { get; set; }

        public override string ToString() => $"[{Level}] [{TimeStamp}] {Message}";
    }


    public interface ILoggerService
    {
        public void Log(string msg, Logtype type = Logtype.Normal);

        public void Info(string s);

        public void Warning(string s);

        public void Error(string msg);

        public void Important(string msg);

        public void Success(string msg);



        public IObservable<IChangeSet<LogEntry>> Connect();


        public void Error(Exception exception);
    }
}
