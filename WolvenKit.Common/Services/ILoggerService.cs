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
    public interface ILoggerService
    {
       

        string Log { get; }
        ObservableCollection<InterpretedLogMessage> ErrorLog { get; }

        void Clear();
        void LogString(string value, Logtype type);
        void LogExtended(SystemLogFlag sflag, ToolLogFlag lflag, string cmdName, string value);

    }
}
