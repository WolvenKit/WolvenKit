using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Services
{
    public interface ILoggerService : INotifyPropertyChanged, INotifyPropertyChanging
    {
        event EventHandler<LogStringEventArgs> OnStringLogged;

        string Log { get; }
        ObservableCollection<InterpretedLogMessage> ErrorLog { get; }

        void Clear();
        void LogString(string value, Logtype type);
        void LogExtended(SystemLogFlag sflag, ToolLogFlag lflag, string cmdName, string value);


        void LogProgress(float value);
        void LogProgress(float value, string str);
        void LogProgressInc(float value, string str);
    }
}
