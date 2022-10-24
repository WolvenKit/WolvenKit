using System;
using DynamicData;
using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.CLI.Services
{
    public class MicrosoftLoggerService : ILoggerService
    {
        private readonly ILogger<MicrosoftLoggerService> _logger;

        public LoggerVerbosity LoggerVerbosity { get; private set; } = LoggerVerbosity.Normal;

        public MicrosoftLoggerService(ILogger<MicrosoftLoggerService> logger) => _logger = logger;

        public IObservable<IChangeSet<LogEntry>> Connect() => throw new NotImplementedException();


        public void Debug(string msg) => LogString(msg, Logtype.Debug);

        public void Success(string msg) => LogString(msg, Logtype.Success);

        public void Info(string msg) => LogString(msg, Logtype.Important);

        public void Warning(string msg) => LogString(msg, Logtype.Warning);

        public void Error(string msg) => LogString(msg, Logtype.Error);

        public void Error(Exception exception)
        {
            switch (LoggerVerbosity)
            {
                case LoggerVerbosity.Quiet:
                    // log nothing
                    break;
                case LoggerVerbosity.Minimal:
                    // TODO more minimal?
                    Error(exception.Message);
                    break;
                case LoggerVerbosity.Normal:
                    Error(exception.Message);
                    break;
                case LoggerVerbosity.Detailed:
                case LoggerVerbosity.Diagnostic:
                    Error($"Message: {exception.Message}\nSource: {exception.Source}\nStackTrace: {exception.StackTrace}");
                    break;
                default:
                    break;
            }
        }


        private void LogString(string message, Logtype type)
        {
            if (LoggerVerbosity == LoggerVerbosity.Quiet)
            {
                return;
            }

            switch (type)
            {
                case Logtype.Debug:
                    _logger.LogDebug(message);
                    break;
                case Logtype.Normal:
                    _logger.LogDebug(message);
                    break;
                case Logtype.Success:
                    _logger.LogInformation(message);
                    break;
                case Logtype.Important:
                    _logger.LogWarning(message);
                    break;
                case Logtype.Warning:
                    _logger.LogError(message);
                    break;
                case Logtype.Error:
                    _logger.LogCritical(message);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public void SetLoggerVerbosity(LoggerVerbosity verbosity) => LoggerVerbosity = verbosity;

    }
}
