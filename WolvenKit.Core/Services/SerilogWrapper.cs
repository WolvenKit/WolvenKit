using System;
using DynamicData;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit
{
    public class SerilogWrapper : ILoggerService
    {
        public IObservable<IChangeSet<LogEntry>> Connect() => throw new NotImplementedException();

        public void Log(string msg, Logtype type = Logtype.Normal) => throw new NotImplementedException();


        public void Error(string msg) => Serilog.Log.Error(msg);
        public void Error(Exception exception) => LogExtended(exception);

        public void Important(string msg) => Serilog.Log.Information(msg);
        public void Info(string msg) => Serilog.Log.Information(msg);

        public void Success(string msg) => Serilog.Log.Debug(msg); //TODO

        public void Warning(string msg) => Serilog.Log.Warning(msg);

        private void LogExtended(Exception ex) => Serilog.Log.Error($"Message: {ex.Message}\nSource: {ex.Source}\nStackTrace: {ex.StackTrace}");

    }
}
