//https://docs.microsoft.com/en-us/dotnet/core/extensions/custom-logging-provider

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Options;

namespace WolvenKit.CLI.Services
{
    public sealed class ColorConsoleLoggerProvider : ILoggerProvider
    {
        private readonly IDisposable _onChangeToken;
        private ColorConsoleLoggerConfiguration _currentConfig;
        private readonly ConcurrentDictionary<string, ColorConsoleLogger> _loggers = new();

        public ColorConsoleLoggerProvider(
            IOptionsMonitor<ColorConsoleLoggerConfiguration> config)
        {
            _currentConfig = config.CurrentValue;
            _onChangeToken = config.OnChange(updatedConfig => _currentConfig = updatedConfig);
        }

        public ILogger CreateLogger(string categoryName) =>
            _loggers.GetOrAdd(categoryName, name => new ColorConsoleLogger(name, _currentConfig));

        public void Dispose()
        {
            _loggers.Clear();
            _onChangeToken.Dispose();
        }
    }


    public static class ColorConsoleLoggerExtensions
    {
        public static ILoggingBuilder AddColorConsoleLogger(
            this ILoggingBuilder builder)
        {
            builder.AddConfiguration();

            builder.Services.TryAddEnumerable(
                ServiceDescriptor.Singleton<ILoggerProvider, ColorConsoleLoggerProvider>());

            LoggerProviderOptions.RegisterProviderOptions
                <ColorConsoleLoggerConfiguration, ColorConsoleLoggerProvider>(builder.Services);

            return builder;
        }

        public static ILoggingBuilder AddColorConsoleLogger(
            this ILoggingBuilder builder,
            Action<ColorConsoleLoggerConfiguration> configure)
        {
            builder.AddColorConsoleLogger();
            builder.Services.Configure(configure);

            return builder;
        }
    }


    public class ColorConsoleLoggerConfiguration
    {
        public int EventId { get; set; }

        public Dictionary<LogLevel, ConsoleColor> LogLevels { get; set; } = new()
        {
            [LogLevel.Information] = ConsoleColor.Green
        };
    }


    public class ColorConsoleLogger : ILogger
    {
        private readonly string _name;
        private readonly ColorConsoleLoggerConfiguration _config;

        public ColorConsoleLogger(
            string name,
            ColorConsoleLoggerConfiguration config) => (_name, _config) = (name, config);

        public IDisposable BeginScope<TState>(TState state) => default;

        public bool IsEnabled(LogLevel logLevel) =>
            _config.LogLevels.ContainsKey(logLevel);


        public void Log<TState>(
            LogLevel logLevel,
            EventId eventId,
            TState state,
            Exception exception,
            Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            var logLevelStr = "";
            logLevelStr = logLevel switch
            {
                LogLevel.Trace => "Trace",
                LogLevel.Debug => "Debug",
                LogLevel.Information => "Success",
                LogLevel.Warning => "Information",
                LogLevel.Error => "Warning",
                LogLevel.Critical => "Error",
                LogLevel.None => "None",
                _ => throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, null),
            };
            if (_config.EventId == 0 || _config.EventId == eventId.Id)
            {
                var originalColor = Console.ForegroundColor;

                Console.ForegroundColor = _config.LogLevels[logLevel];




                Console.WriteLine($"[{eventId.Id,2}: {logLevelStr,-12}] - {formatter(state, exception)}");

                //Console.WriteLine($"     {_name} - {formatter(state, exception)}");
                Console.ForegroundColor = originalColor;
            }
        }
    }
}
