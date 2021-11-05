using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using HandyControl.Tools;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProtoBuf.Meta;
using ReactiveUI;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Interaction;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Dialogs;

namespace WolvenKit
{
    public partial class App //: Application
    {
        // Determines if the application is in design mode.
        //public static bool IsInDesignMode => !(Current is App) || (bool)DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue;

        // Constructor #1
        static App()
        {

        }

        // Constructor #2
        public App()
        {
            Init();

            SetupExceptionHandling();
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
            ApplicationHelper.StartProfileOptimization();

            loggerService.Log("Starting application");
            await Initializations.InitializeWebview2(loggerService);

            loggerService.Log("Initializing red database");
            Initializations.InitializeThemeHelper();


            // main app viewmodel
            loggerService.Log("Initializing Shell");
            Initializations.InitializeShell(settings);


            loggerService.Log("Initializing Discord RPC API");
            DiscordHelper.InitializeDiscordRPC();

            loggerService.Log("Initializing Github API");
            Initializations.InitializeGitHub();

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

        private void LogUnhandledException(Exception exception, string source)
        {
            var _logger = Splat.Locator.Current.GetService<ILoggerService>();
            if (_logger == null)
            {
                return;
            }

            var message = $"Unhandled exception ({source})";
            try
            {
                System.Reflection.AssemblyName assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName();
                message = string.Format("Unhandled exception in {0} v{1}", assemblyName.Name, assemblyName.Version);
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
            finally
            {
                _logger.Error(exception);
            }
        }
    }
}
