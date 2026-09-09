using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.Common.Services
{
    public class LogEntry : ObservableObject
    {
        public LogEntry(string message, LogType level, DateTime timeStamp)
        {
            Message = message;
            Level = level;
            TimeStamp = timeStamp;
        }

        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
        public LogType Level { get; set; }

        public override string ToString() => $"[{TimeStamp}] [{Level}] {Message}";
    }
}
