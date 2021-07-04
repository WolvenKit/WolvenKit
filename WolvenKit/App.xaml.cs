using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Catel.IoC;
using Catel.Logging;
using Catel.Messaging;
using CP77.CR2W;
using HandyControl.Tools;
using NodeNetwork;
using Orchestra.Services;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools.Oodle;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Initialization;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Modkit.RED3;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.CR2W;
using WolvenKit.Views;
using WolvenManager.Installer.Services;

namespace WolvenKit
{
    public partial class App : Application
    {
        // Determines if the application is in design mode.
        public static bool IsInDesignMode => !(Current is App) || (bool)DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue;

        // Constructor #1
        static App() { }

        // Constructor #2
        public App()
        {
            // Set application licenses.
            Initializations.InitializeLicenses();


            var serviceLocator = ServiceLocator.Default;


            // Orchestra
            serviceLocator.RegisterType<IAboutInfoService, AboutInfoService>();
            serviceLocator.RegisterType<INotificationService, NotificationService>();


            // Wkit
            var config = SettingsManager.Load();
            serviceLocator.RegisterInstance(typeof(ISettingsManager), config);

            serviceLocator.RegisterType<IProgressService<double>, ProgressService<double>>();
            serviceLocator.RegisterType<ILoggerService, CatelLoggerService>();
            serviceLocator.RegisterType<IUpdateService, UpdateService>();

            // singletons
            serviceLocator.RegisterType<IApplicationInitializationService, ApplicationInitializationService>();
            serviceLocator.RegisterType<IHashService, HashService>();

            serviceLocator.RegisterTypeAndInstantiate<IProjectManager, ProjectManager>();
            serviceLocator.RegisterTypeAndInstantiate<IWatcherService, WatcherService>();
            serviceLocator.RegisterType<MockGameController>();

            serviceLocator.RegisterType<Red4ParserService>();
            serviceLocator.RegisterType<TargetTools>();      //Cp77FileService
            serviceLocator.RegisterType<RIG>();              //Cp77FileService
            serviceLocator.RegisterType<MeshTools>();        //RIG, Cp77FileService

            serviceLocator.RegisterType<ModTools>();         //Cp77FileService, ILoggerService, IProgress, IHashService, Mesh, Target

            serviceLocator.RegisterType<Cp77Controller>();

            // red3 modding tools
            serviceLocator.RegisterType<Red3ModTools>();
            serviceLocator.RegisterType<Tw3Controller>();




            serviceLocator.RegisterType<IGameControllerFactory, GameControllerFactory>();

        }

        // Application OnStartup Override.
        protected override async void OnStartup(StartupEventArgs e)
        {
            // Startup speed boosting (HC)
            ApplicationHelper.StartProfileOptimization();

            // Set service locator.
            var serviceLocator = ServiceLocator.Default;

            serviceLocator.RegisterType<IRibbonService, RibbonService>();

#if DEBUG
            LogManager.AddDebugListener(false);
            VMHelpers.InDebug = true;
#endif

            StaticReferences.Logger.Info("Starting application");

            Initializations.InitializeWebview2();

            StaticReferences.Logger.Info("Initializing MVVM");
            Initializations.InitializeMVVM();

            StaticReferences.Logger.Info("Initializing Theme Helper");
            Initializations.InitializeThemeHelper();

            StaticReferences.Logger.Info("Initializing Shell");
            await Initializations.InitializeShell();
            var growl = ServiceLocator.Default.ResolveType<INotificationService>();
            var settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            Helpers.ShowFirstTimeSetup(settings, growl);

            StaticReferences.Logger.Info("Initializing Discord RPC API");
            DiscordHelper.InitializeDiscordRPC();

            StaticReferences.Logger.Info("Initializing Github API");
            Initializations.InitializeGitHub();

            StaticReferences.Logger.Info("Calling base.OnStartup");
            base.OnStartup(e); // Some things can only be initialized after base.OnStartup(e);

            StaticReferences.Logger.Info("Initializing NodeNetwork.");
            NNViewRegistrar.RegisterSplat();

            StaticReferences.Logger.Info("Initializing Notifications.");
            NotificationHelper.InitializeNotificationHelper();

            StaticReferences.Logger.Info("Check for new updates");
            //Helpers.CheckForUpdates();
            Initializations.InitializeBk();

            //Window window = new Window();
            //window.AllowsTransparency = true;
            //window.Background = new SolidColorBrush(Colors.Transparent);
            //window.Content = new HomePageView();
            //window.WindowStyle = WindowStyle.None;
            //window.Show();

            // Create WebView Data Folder.
            //Directory.CreateDirectory(@"C:\WebViewData");
            // Message system for video tool.
        }
    }
}
