using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Services
{
   

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class LoggerService : ObservableObject, ILoggerService, INotifyPropertyChanged
    {
        public LoggerService()
        {
            ExtendedLog = new ObservableCollection<InterpretedLogMessage>();
        }

        

        #region Properties
        public ObservableCollection<InterpretedLogMessage> ExtendedLog { get; set; }
        public string Log { get; set; } = "Log initialized.\n\r";
        #endregion

        #region Overrides
        public override string ToString() => Log;
        #endregion

        #region Methods
        /// <summary>
        /// Log an string
        /// </summary>
        /// <param name="value"></param>
        public void LogString(string value)
        {

            Log = value;// + "\r\n";
            OnPropertyChanged(nameof(Log));
        }
        /// <summary>
        /// Log an Interpretable LogMessage
        /// </summary>
        public void LogExtended(SystemLogFlag sflag, ToolFlag tool, string cmdName, string value)
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
        private void InterpretLogMessage(SystemLogFlag sflag, ToolFlag tool ,string cmdName, string value)
        {
            if (tool == ToolFlag.TLF_Radish)
            {
                var data = new RADLogMessage
                {
                    SystemFlag = sflag,
                    CommandName = cmdName,
                    Tool = tool
                };
                InterpretRADMessage(ref data, value);
                if (data.Flag != LogFlag.WLF_Info)
                    ExtendedLog.Add(data);
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
                if (data.Flag != LogFlag.WLF_Info)
                    ExtendedLog.Add(data);
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
                data.Flag = LogFlag.WLF_Info;
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
                data.Flag = LogFlag.WLF_Info;
                data.WccModule = "Verbose";
                data.Value = value;
                //ExtendedLog.Add(data);
            }
        }


        private LogFlag GetWFlagFromString(string wflag)
        {
            switch (wflag)
            {
                case "Warning": return LogFlag.WLF_Warning;
                case "Error": return LogFlag.WLF_Error;
                case "Info": return LogFlag.WLF_Info;
                default: return LogFlag.WLF_Info;
            }
        }
        private LogFlag GetRFlagFromString(string rflag)
        {
            switch (rflag)
            {
                case "WARNING": return LogFlag.WLF_Warning;
                case "ERROR": return LogFlag.WLF_Error;
                case "INFO": return LogFlag.WLF_Info;
                default: return LogFlag.WLF_Info;
            }
        }

        public void Clear()
        {
            Log = "";
            ExtendedLog.Clear();
        }
        #endregion



    }
}
