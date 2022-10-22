using System;
using DynamicData;
using Microsoft.Build.Framework;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit
{
    public class SerilogWrapper : ILoggerService
    {
        public LoggerVerbosity LoggerVerbosity { get; private set; } = LoggerVerbosity.Normal;

        public IObservable<IChangeSet<LogEntry>> Connect() => throw new NotImplementedException();


        public void Error(string msg) => Serilog.Log.Error(msg);
        public void Error(Exception exception) => LogExtended(exception);

        public void Important(string msg) => Serilog.Log.Information(msg);
        public void Info(string msg) => Serilog.Log.Information(msg);
        public void SetLoggerVerbosity(LoggerVerbosity verbosity) => LoggerVerbosity = verbosity;
        public void Success(string msg) => Serilog.Log.ForContext("IsSuccess", true).Information(msg); //TODO

        public void Warning(string msg) => Serilog.Log.Warning(msg);

        private void LogExtended(Exception ex) => Serilog.Log.Error($"Message: {ex.Message}\nSource: {ex.Source}\nStackTrace: {ex.StackTrace}");

    }
}
