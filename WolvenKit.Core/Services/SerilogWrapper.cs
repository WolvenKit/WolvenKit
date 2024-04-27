using System;
using Microsoft.Build.Framework;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit
{
    public class SerilogWrapper : ILoggerService
    {
        public void Info(string msg) => Serilog.Log.Information(msg);
        public void Info(int code, string msg) => Serilog.Log.ForContext(Core.Constants.InfoCode, code).Information(msg);

        public void Warning(string msg) => Serilog.Log.Warning(msg);
        public void Warning(int code, string msg) => Serilog.Log.ForContext(Core.Constants.InfoCode, code).Warning(msg);

        public void Error(string msg) => Serilog.Log.Error(msg);
        public void Error(int code, string msg) => Serilog.Log.ForContext(Core.Constants.InfoCode, code).Error(msg);

        public void Success(string msg) => Serilog.Log
            .ForContext(Core.Constants.IsSuccess, true)
            .Information(msg);
        
        public void Success(int code, string msg) => Serilog.Log
            .ForContext(Core.Constants.IsSuccess, true)
            .ForContext(Core.Constants.InfoCode, code)
            .Information(msg);

        public void Debug(string msg) => Serilog.Log.Debug(msg);
        public void Debug(int code, string msg) => Serilog.Log.ForContext(Core.Constants.InfoCode, code).Debug(msg);

        public void Error(Exception ex)
        {
            if (ex is WolvenKitException { ErrorCode: >= 0 } wolvenKitException)
            {
                Error(wolvenKitException.ErrorCode, wolvenKitException);
            }
            else
            {
                Serilog.Log.Error(GetExceptionMessage(ex));
            }
        }
        public void Error(int code, Exception ex) => Serilog.Log.ForContext(Core.Constants.InfoCode, code).Error(GetExceptionMessage(ex));

        
        private string GetExceptionMessage(Exception ex) =>
            $"Message: {ex.Message}\nSource: {ex.Source}\nStackTrace: {ex.StackTrace}";

        public LoggerVerbosity LoggerVerbosity { get; private set; } = LoggerVerbosity.Normal;

        public void SetLoggerVerbosity(LoggerVerbosity verbosity) => LoggerVerbosity = verbosity;
    }
}
