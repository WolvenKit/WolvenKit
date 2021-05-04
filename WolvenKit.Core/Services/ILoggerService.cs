using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WolvenKit.Common.Services
{
    public interface ILoggerService : INotifyPropertyChanged, INotifyPropertyChanging
    {
        #region Events

        event EventHandler<LogStringEventArgs> OnStringLogged;

        #endregion Events

        #region Properties

        ObservableCollection<InterpretedLogMessage> ErrorLog { get; }
        string ErrorLogStr { get; }
        string Log { get; }
        public Tuple<float, string> Progress { get; }

        #endregion Properties

        #region Methods

        void Clear();

        void LogExtended(SystemLogFlag sflag, ToolLogFlag lflag, string cmdName, string value);

        void LogProgress(float value);

        void LogProgress(float value, string str);

        void LogProgressInc(float value, string str);

        void LogString(string value, Logtype type = Logtype.Normal);

        #endregion Methods
    }
}
