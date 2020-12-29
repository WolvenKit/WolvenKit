using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CP77.Common.Services
{
    public interface ILoggerService : INotifyPropertyChanged, INotifyPropertyChanging
    {
        event EventHandler<LogStringEventArgs> OnStringLogged;

        string Log { get; }
        public Tuple<float, string> Progress { get; }
        string ErrorLogStr { get; }
        ObservableCollection<InterpretedLogMessage> ErrorLog { get; }

        void Clear();
        void LogString(string value, Logtype type = Logtype.Normal);
        void LogExtended(SystemLogFlag sflag, ToolLogFlag lflag, string cmdName, string value);


        void LogProgress(float value);
        void LogProgress(float value, string str);
        void LogProgressInc(float value, string str);
    }
}
