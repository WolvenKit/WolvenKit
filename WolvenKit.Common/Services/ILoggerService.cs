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
        ObservableCollection<InterpretedLogMessage> ExtendedLog { get; }

        void Clear();
        void LogString(string value);
        void LogExtended(SystemLogFlag sflag, ToolFlag lflag, string cmdName, string value);

    }
}
