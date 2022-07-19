using System;
using System.IO;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProtoBuf.Meta;
using ReactiveUI;
using Serilog;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using WolvenKit.Common.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Interaction;
using WolvenKit.RED4.Archive;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Dialogs;

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
            if (!Oodle.Load())
            {
                throw new FileNotFoundException($"oo2ext_7_win64.dll not found.");
            }
        }

        // Application OnStartup Override.
        protected override async void OnStartup(StartupEventArgs e)
        {
            Interactions.ShowFirstTimeSetup.RegisterHandler(interaction =>
            {
                var dialog = new DialogHostView();
                dialog.ViewModel.HostedViewModel = Locator.Current.GetService<FirstSetupWizardViewModel>();

                return Observable.Start(() =>
                {
                    var result = dialog.ShowDialog() == true;
                    interaction.SetOutput(result);
                }, RxApp.MainThreadScheduler);
            });

            var settings = Locator.Current.GetService<ISettingsManager>();
            var loggerService = Locator.Current.GetService<ILoggerService>();


            // Startup speed boosting (HC)
            //ApplicationHelper.StartProfileOptimization();

            loggerService.Info("Starting application");
            await Initializations.InitializeWebview2(loggerService);

            loggerService.Info("Initializing red database");
            Initializations.InitializeThemeHelper();


            // main app viewmodel
            loggerService.Info("Initializing Shell");
            Initializations.InitializeShell(settings);


            loggerService.Info("Initializing Discord RPC API");
            DiscordHelper.InitializeDiscordRPC();

            // Some things can only be initialized after base.OnStartup(e);
            base.OnStartup(e);

            //loggerService.Info("Initializing NodeNetwork.");
            //NNViewRegistrar.RegisterSplat();
        }

        private IServiceProvider Container { get; set; }

        private IHost _host;

        private void Init()
        {
            // Set application licenses.
            Initializations.InitializeLicenses();
            //protobuf
            RuntimeTypeModel.Default[typeof(IGameArchive)].AddSubType(20, typeof(Archive));

            _host = GenericHost.CreateHostBuilder().Build();

            // Since MS DI container is a different type,
            // we need to re-register the built container with Splat again
            Container = _host.Services;
            Container.UseMicrosoftDependencyResolver();

            var path = Path.Combine(ISettingsManager.GetAppData(), "applog.txt");
            var outputTemplate = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}";

            Log.Logger = new LoggerConfiguration()
              .MinimumLevel.Debug()
              .WriteTo.Console()
              .WriteTo.MySink(_host.Services.GetService<MySink>())
              .WriteTo.File(path, outputTemplate: outputTemplate, rollingInterval: RollingInterval.Day)
              .CreateLogger();
        }

        //https://stackoverflow.com/a/46804709/16407587
        private void SetupExceptionHandling()
        {
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                LogUnhandledException((Exception)e.ExceptionObject, "AppDomain.CurrentDomain.UnhandledException");

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
                _logger.Error(exception);
                //Application.Current.Shutdown();
            }
        }
    }
}
