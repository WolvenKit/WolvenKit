using System;
using WolvenKit.Core;

namespace WolvenKit.Common.Services
{
    public class LogEntry : ObservableObject
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

        public override string ToString() => $"[{TimeStamp}] [{Level}] {Message}";
    }
}
