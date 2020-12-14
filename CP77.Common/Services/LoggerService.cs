using Catel.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Services
{
    public enum Logtype
    {
        Normal,
        Error,
        Important,
        Success,
        Wcc
    }

    public class LogStringEventArgs
    {
        public LogStringEventArgs(string message, Logtype logtype)
        {
            Message = message;
            Logtype = logtype;
        }
        public string Message { get; private set; }
        public Logtype Logtype { get; private set; }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class LoggerService : ObservableObject, ILoggerService
    {
        public LoggerService()
        {
            ErrorLog = new ObservableCollection<InterpretedLogMessage>();
        }

        private const int LOGLENGTH = 16384;

        #region Properties
        public ObservableCollection<InterpretedLogMessage> ErrorLog { get; set; }

        #region Log
        private string _errorLogStr;
        public string ErrorLogStr
        {
            get => _errorLogStr;
            set
            {
                if (_errorLogStr != value)
                {
                    _errorLogStr = value;
                    RaisePropertyChanged(nameof(ErrorLogStr));

                    // clean old log
                    if (_errorLogStr.Length > LOGLENGTH)
                        _errorLogStr = "";
                }
            }
        }

        private string _log;
        public string Log
        {
            get => _log;
            set
            {
                if (_log != value)
                {
                    _log = value;
                    RaisePropertyChanged(nameof(Log));
                }
            }
        }
        #endregion
        #region progress
        private Tuple<float, string> _progress;
        public Tuple<float,string> Progress
        {
            get => _progress;
            set
            {
                if (_progress != value)
                {
                    _progress = value;
                    RaisePropertyChanged(nameof(Progress));
                }
            }
        }
        #endregion

        public Logtype Logtype { get; private set; } = Logtype.Normal;
        #endregion

        #region Overrides
        public override string ToString() => Log;
        #endregion

        #region Methods
        public event EventHandler<LogStringEventArgs> OnStringLogged;
        public event PropertyChangingEventHandler PropertyChanging;

        /// <summary>
        /// Log string
        /// </summary>
        /// <param name="value"></param>
        public void LogString(string value, Logtype type = Logtype.Normal)
        {
            var datestring = DateTime.Now.ToString("G");
            var text = $"[{datestring}] {value}\r";

            Logtype = type;
            Log = text;// + "\r\n";
            OnStringLogged?.Invoke(this, new LogStringEventArgs(text, type));

            if (type == Logtype.Error)
                ErrorLogStr += text + "\r\n";
        }
        /// <summary>
        /// Log progress value
        /// </summary>
        /// <param name="value"></param>
        public void LogProgress(float value)
        {
            Progress = new Tuple<float, string>(value, "");
        }
        /// <summary>
        /// Log progress value
        /// </summary>
        /// <param name="value"></param>
        public void LogProgress(float value, string str)
        {
            Progress = new Tuple<float, string>(value, str);
        }
        /// <summary>
        /// Log progress incrementally
        /// </summary>
        /// <param name="value"></param>
        public void LogProgressInc(float value, string str)
        {
            Progress = new Tuple<float, string>(Progress.Item1 + value, str);
        }


        /// <summary>
        /// Log an Interpretable LogMessage
        /// </summary>
        public void LogExtended(SystemLogFlag sflag, ToolLogFlag tool, string cmdName, string value)
        {
            if (sflag == SystemLogFlag.SLF_Interpretable)
            {
                InterpretLogMessage(sflag, tool, cmdName, value);
            }
        }

        /// <summary>
        /// Interpret a wcc_lite command output string
        /// </summary>
        /// <param name="sflag"></param>
        /// <param name="cmdName"></param>
        /// <param name="value"></param>
        private void InterpretLogMessage(SystemLogFlag sflag, ToolLogFlag tool ,string cmdName, string value)
        {
            if (tool == ToolLogFlag.TLF_Radish)
            {
                var data = new RADLogMessage
                {
                    SystemFlag = sflag,
                    CommandName = cmdName,
                    Tool = tool
                };
                InterpretRADMessage(ref data, value);
                if (data.Flag != WccLogFlag.WLF_Info)
                    ErrorLog.Add(data);
            }
            else
            {
                var data = new WCCLogMessage
                {
                    SystemFlag = sflag,
                    CommandName = cmdName,
                    Tool = tool
                };
                InterpretWCCMessage(ref data, value);
                //if (data.Flag != WccLogFlag.WLF_Info)
                    ErrorLog.Add(data);
            }
        }

        private void InterpretRADMessage(ref RADLogMessage data, string value)
        {
            try
            {
                // read Flag
                int flagEnd = value.IndexOf(' ');
                string wflag = value?.Substring(0, flagEnd);
                value = value?.Remove(0, flagEnd + 1);
                data.Flag = GetRFlagFromString(wflag);

                // read LogMessage
                string message = value?.Substring(1);
                data.Value = message;

            }
            catch (Exception)
            {
                data.Flag = WccLogFlag.WLF_Info;
                data.Value = value;
                //ExtendedLog.Add(data);
            }
        }

        private void InterpretWCCMessage(ref WCCLogMessage data, string value)
        {
            try
            {
                // read timestamp
                int flagEnd = value.IndexOf(']');
                string timestamp = value?.Substring(1, flagEnd - 1);
                value = value?.Remove(0, flagEnd + 1);
                data.Timestamp = timestamp;

                // read WccFlag
                flagEnd = value.IndexOf(']');
                string wflag = value?.Substring(1, flagEnd - 1);
                value = value?.Remove(0, flagEnd + 1);
                data.Flag = GetWFlagFromString(wflag);

                // read Module
                flagEnd = value.IndexOf(']');
                string module = value?.Substring(1, flagEnd - 1);
                value = value?.Remove(0, flagEnd + 1);
                data.WccModule = module;

                // read LogMessage
                string message = value?.Substring(1);
                data.Value = message;

                // whitelist errors and downgrade to warnings
                if (message.Contains("wintab32.dll") && data.Flag == WccLogFlag.WLF_Error)
                    data.Flag = WccLogFlag.WLF_Warning;
                // downgrade some warnings to info
                if (message.Contains("Failed to load existing cooking data base from") && data.Flag == WccLogFlag.WLF_Warning)
                    data.Flag = WccLogFlag.WLF_Info;
            }
            catch (Exception)
            {
                data.Flag = WccLogFlag.WLF_Info;
                data.WccModule = "Verbose";
                data.Value = value;
                //ExtendedLog.Add(data);
            }
        }


        private WccLogFlag GetWFlagFromString(string wflag)
        {
            switch (wflag)
            {
                case "Warning": return WccLogFlag.WLF_Warning;
                case "Error": return WccLogFlag.WLF_Error;
                case "Info": return WccLogFlag.WLF_Info;
                default: return WccLogFlag.WLF_Info;
            }
        }
        private WccLogFlag GetRFlagFromString(string rflag)
        {
            switch (rflag)
            {
                case "WARNING": return WccLogFlag.WLF_Warning;
                case "ERROR": return WccLogFlag.WLF_Error;
                case "INFO": return WccLogFlag.WLF_Info;
                default: return WccLogFlag.WLF_Info;
            }
        }

        public void Clear()
        {
            Log = "";
            ErrorLog.Clear();
        }
        #endregion



    }
}
