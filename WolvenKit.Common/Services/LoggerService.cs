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

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class LoggerService : ObservableObject, ILoggerService, INotifyPropertyChanged
    {
        public LoggerService()
        {
            ErrorLog = new ObservableCollection<InterpretedLogMessage>();
        }

        

        #region Properties
        public ObservableCollection<InterpretedLogMessage> ErrorLog { get; set; }
        public string Log { get; set; } = "Log initialized.\n\r";
        public Logtype Logtype { get; set; } = Logtype.Normal;
        #endregion

        #region Overrides
        public override string ToString() => Log;
        #endregion

        #region Methods
        /// <summary>
        /// Log an string
        /// </summary>
        /// <param name="value"></param>
        public void LogString(string value, Logtype type = Logtype.Normal)
        {
            Logtype = type;
            Log = value;// + "\r\n";
            OnPropertyChanged(nameof(Log));
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
