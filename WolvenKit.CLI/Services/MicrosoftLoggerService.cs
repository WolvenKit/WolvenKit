using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;

namespace WolvenKit.CLI
{
    public class MicrosoftLoggerService : ILoggerService
    {
        private readonly ILogger<MicrosoftLoggerService> _logger;

        public MicrosoftLoggerService(ILogger<MicrosoftLoggerService> logger)
        {
            _logger = logger;
        }

        public void LogString(string message, Logtype type)
        {
            switch (type)
            {
                case Logtype.Wcc:
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

        // Normal
        public void Log(string msg, Logtype type = Logtype.Normal) => LogString(msg, type);

        
        public void Success(string msg) => LogString(msg, Logtype.Success);

        public void Info(string s) => LogString(s, Logtype.Important);
        public void Important(string s) => LogString(s, Logtype.Important);

        public void Warning(string s) => _logger.LogError(s);

        public void Error(string msg) => LogString(msg, Logtype.Error);

    }
}
