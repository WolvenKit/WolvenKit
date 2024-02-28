using System;
using Microsoft.Build.Framework;
using WolvenKit.Core.Interfaces;

namespace WolvenKit
{
    public class SerilogWrapper : ILoggerService
    {
        private static ILoggerService? s_instance = null;
        public LoggerVerbosity LoggerVerbosity { get; private set; } = LoggerVerbosity.Normal;

        public void SetLoggerVerbosity(LoggerVerbosity verbosity) => LoggerVerbosity = verbosity;

        public SerilogWrapper() => s_instance = this;

        public static ILoggerService Instance => s_instance ??= new SerilogWrapper();

        // error
        public void Error(string msg) => Serilog.Log.Error(msg);
        public void Error(Exception exception) => LogExtended(exception);
        private void LogExtended(Exception ex) => Serilog.Log.Error($"Message: {ex.Message}\nSource: {ex.Source}\nStackTrace: {ex.StackTrace}");

        // warning
        public void Warning(string msg) => Serilog.Log.Warning(msg);

        // information
        public void Info(string msg) => Serilog.Log.Information(msg);
        public void Success(string msg) => Serilog.Log.ForContext(Core.Constants.IsSuccess, true).Information(msg); //TODO

        // debug
        public void Debug(string msg) => Serilog.Log.Debug(msg);


    }
}
