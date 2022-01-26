using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicData;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using Serilog;

namespace WolvenKit
{
    public class SerilogWrapper : ILoggerService
    {
        public IObservable<IChangeSet<LogEntry>> Connect() => throw new NotImplementedException();

        public void Log(string msg, Logtype type = Logtype.Normal) => throw new NotImplementedException();


        public void Error(string msg) => Serilog.Log.Error(msg);
        public void Error(Exception exception) => Serilog.Log.Error(exception.Message);

        public void Important(string msg) => Serilog.Log.Information(msg);
        public void Info(string msg) => Serilog.Log.Information(msg);

        public void Success(string msg) => Serilog.Log.Debug(msg); //TODO

        public void Warning(string msg) => Serilog.Log.Warning(msg);
    }
}
