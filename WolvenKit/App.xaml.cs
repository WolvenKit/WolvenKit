using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReactiveUI;
using Serilog;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using WolvenKit.App;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Interfaces;
using WolvenKit.Helpers;
using WolvenKit.RED4.CR2W;
using WolvenKit.Views.Dialogs.Windows;

namespace WolvenKit
{
    public partial class AppImpl //: Application
    {
        // Determines if the application is in design mode.
        //public static bool IsInDesignMode => !(Current is App) || (bool)DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue;

        // Constructor #1
        static AppImpl()
        {
            
        }

        // Constructor #2
        public AppImpl()
        {
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);

            Init();

            SetupExceptionHandling();

            // load oodle
            var settingsManager = Locator.Current.GetService<ISettingsManager>();
            if (settingsManager?.IsHealthy() == true && !Oodle.Load(settingsManager.GetRED4OodleDll()))
            {
                throw new FileNotFoundException($"{Core.Constants.Oodle} not found.");
            }
        }

        // Application OnStartup Override.
        protected override void OnStartup(StartupEventArgs e)
        {
            Interactions.ShowFirstTimeSetup = () => {
                var dialog = new FirstSetupView();

                var result = dialog.ShowDialog() == true;
                return result;
            };

            var settings = Locator.Current.GetService<ISettingsManager>();
            var loggerService = Locator.Current.GetService<ILoggerService>();

            loggerService.Info("Starting application");
            loggerService.Info($"Version: {settings.GetVersionNumber()}");

            loggerService.Debug("Initializing red database");
            Initializations.InitializeThemeHelper();

            Initializations.InitializeSyntaxHighlighting();

            // main app viewmodel
            loggerService.Debug("Initializing Shell");
            Initializations.InitializeShell(settings);


            loggerService.Debug("Initializing Discord RPC API");
            DiscordHelper.InitializeDiscordRPC();

            RedImage.LoggerService = loggerService;

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            Log.Information("Exiting application...");
            Log.CloseAndFlush();

            base.OnExit(e);
        }

        private IServiceProvider Container { get; set; }

        private IHost _host;

        private void Init()
        {
            // Set application licenses.
            Initializations.InitializeLicenses();
            //protobuf
            //RuntimeTypeModel.Default[typeof(IGameArchive)].AddSubType(20, typeof(Archive));

            _host = GenericHost.CreateHostBuilder().Build();

            // Since MS DI container is a different type,
            // we need to re-register the built container with Splat again
            Container = _host.Services;
            Container.UseMicrosoftDependencyResolver();

            MoveOldLogs();

            var path = Path.Combine(ISettingsManager.GetLogsDir(), "applog.txt");
            var outputTemplate = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}";

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
#if DEBUG

                .WriteTo.Async(a => a.Console(), bufferSize: 1000)
#endif
                .WriteTo.MySink(_host.Services.GetService<MySink>())
                .WriteTo.Async(
                    a => a.File(
                        path,
                        outputTemplate: outputTemplate,
                        rollingInterval: RollingInterval.Day,
                        fileSizeLimitBytes: 100 * 1000 * 1024, // MaxFileSize: 100 MB
                        retainedFileCountLimit: 10,
                        buffered: true, // Allow internal buffering.
                        flushToDiskInterval: TimeSpan.FromMinutes(1)), // Write once per minute.
                    bufferSize: 1000)
                .CreateLogger();
        }

        private void MoveOldLogs()
        {
            var logFolder = ISettingsManager.GetLogsDir();

            var existingLogs = Directory.GetFiles(logFolder, "*.txt");
            
            foreach (var file in Directory.GetFiles(ISettingsManager.GetAppData(), "applog*.txt", SearchOption.TopDirectoryOnly))
            {
                var fileName = Path.GetFileName(file);
                var destFileName = Path.Combine(logFolder, fileName);

                var rotatingIndex = 1;

                while (existingLogs.Contains(destFileName))
                {
                    destFileName = Path.Combine(logFolder, $"{fileName.Replace(".txt", "")}_{rotatingIndex:D3}.txt");
                    rotatingIndex++;
                }

                FileHelper.SafeMove(file, destFileName);
            }
        }

        //https://stackoverflow.com/a/46804709/16407587
        private void SetupExceptionHandling()
        {
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                LogUnhandledException((Exception)e.ExceptionObject, "AppDomain.CurrentDomain.UnhandledException");
                if (e.IsTerminating) // And we have no choice but to exit, flush/write any pending logs.
                {
                    Log.CloseAndFlush();
                }
            };

            DispatcherUnhandledException += (s, e) =>
            {
                LogUnhandledException(e.Exception, "Application.Current.DispatcherUnhandledException");
                e.Handled = true;
            };

            TaskScheduler.UnobservedTaskException += (s, e) =>
            {
                LogUnhandledException(e.Exception, "TaskScheduler.UnobservedTaskException");
                e.SetObserved();
            };

            RxApp.DefaultExceptionHandler = new DefaultObserverExceptionHandler();
        }

        /// <summary>
        /// This isn't great but can used until each TaskCommand ThrownExceptions can be properly subscribed to.
        /// </summary>
        // https://www.reactiveui.net/docs/handbook/default-exception-handler/
        public class DefaultObserverExceptionHandler : IObserver<Exception>
        {
            public void OnNext(Exception ex)
            {
                if (Debugger.IsAttached) // If we're debugging, break.
                {
                    Debugger.Break();
                }

                LogUnhandledException(ex, "RxApp.DefaultExceptionHandler");
            }

            public void OnError(Exception ex)
            {
                if (Debugger.IsAttached) // If we're debugging, break.
                {
                    Debugger.Break();
                }

                LogUnhandledException(ex, "RxApp.DefaultExceptionHandler");
            }

            public void OnCompleted()
            {
                if (Debugger.IsAttached) // If we're debugging, break.
                {
                    Debugger.Break();
                }
            }
        }

        private static void LogUnhandledException(Exception exception, string source)
        {
            var _logger = Splat.Locator.Current.GetService<ILoggerService>();
            if (_logger == null)
            {
                return;
            }

            var message = $"Unhandled exception ({source})";
            try
            {
                var assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName();
                message = string.Format("Unhandled exception in {0} v{1}", assemblyName.Name, assemblyName.Version);
                _logger.Error(message);
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
            finally
            {
                var isInner = false;
                while (exception != null)
                {
                    if (isInner)
                    {
                        _logger.Error("--------- InnerException ---------");
                    }
                    _logger.Error(exception);

                    exception = exception.InnerException;
                    isInner = true;
                }
                //Application.Current.Shutdown();
            }
        }
    }
}
