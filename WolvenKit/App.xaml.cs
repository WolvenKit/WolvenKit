using System;
using System.ComponentModel;
using System.Windows;
using Catel;
using Catel.IoC;
using Catel.Logging;
using Catel.MVVM;
using CP77.CR2W;
using HandyControl.Tools;
using NodeNetwork;
using ProtoBuf.Meta;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Initialization;
using WolvenKit.Functionality.ProjectManagement;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Modkit.RED3;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Shell;
using WolvenManager.Installer.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Splat.Microsoft.Extensions.DependencyInjection;
using Splat;

namespace WolvenKit
{
    public partial class App //: Application
    {
        // Determines if the application is in design mode.
        public static bool IsInDesignMode => !(Current is App) || (bool)DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue;

        // Constructor #1
        static App() { }

        // Constructor #2
        public App()
        {
            Init();

            ConfigureServices();            
        }

        private void ConfigureServices()
        {
            var serviceLocator = ServiceLocator.Default;
            serviceLocator.RegisterType<INotificationService, NotificationService>();

            var config = SettingsManager.Load();
            serviceLocator.RegisterInstance(typeof(ISettingsManager), config);

            serviceLocator.RegisterType<IProgressService<double>, ProgressService<double>>();

            //serviceLocator.RegisterType<ILoggerService, CatelLoggerService>();
            serviceLocator.RegisterType<ILoggerService, ReactiveLoggerService>();

            serviceLocator.RegisterType<IUpdateService, UpdateService>();

            // singletons
            serviceLocator.RegisterType<IHashService, HashService>();

            serviceLocator.RegisterType<IRecentlyUsedItemsService, RecentlyUsedItemsService>();
            serviceLocator.RegisterTypeAndInstantiate<IProjectManager, ProjectManager>();
            serviceLocator.RegisterTypeAndInstantiate<IWatcherService, WatcherService>();
            serviceLocator.RegisterType<MockGameController>();

            serviceLocator.RegisterType<Red4ParserService>();
            serviceLocator.RegisterType<RIG>();              //Cp77FileService
            serviceLocator.RegisterType<MeshTools>();        //RIG, Cp77FileService

            serviceLocator.RegisterType<ModTools>();         //Cp77FileService, ILoggerService, IProgress, IHashService, Mesh, Target

            serviceLocator.RegisterType<Cp77Controller>();

            // red3 modding tools
            serviceLocator.RegisterType<Red3ModTools>();
            serviceLocator.RegisterType<Tw3Controller>();




            serviceLocator.RegisterType<IGameControllerFactory, GameControllerFactory>();


            serviceLocator.RegisterType<WorkSpaceViewModel>();
            serviceLocator.RegisterType<IViewFor<WorkSpaceViewModel>, MainView>();
        }

        // Application OnStartup Override.
        protected override void OnStartup(StartupEventArgs e)
        {
            // check prerequisites
            // check Webview2
            string keyName = @"SOFTWARE\Wow6432Node\Microsoft\EdgeUpdate\ClientState\{F3017226-FE2A-4295-8BDF-00C3A9A7E4C5}";
            string keyvalue = "pv";
            StaticReferences.IsWebView2Enabled = Models.Commonfunctions.RegistryValueExists(Microsoft.Win32.RegistryHive.LocalMachine, keyName, keyvalue);

            // Startup speed boosting (HC)
            ApplicationHelper.StartProfileOptimization();

            var settings = ServiceLocator.Default.ResolveType<ISettingsManager>();


#if DEBUG
            LogManager.AddDebugListener(false);
#endif

            StaticReferences.Logger.Info("Starting application");

            Initializations.InitializeWebview2();

            StaticReferences.Logger.Info("Initializing MVVM");
            Initializations.InitializeMVVM();

            StaticReferences.Logger.Info("Initializing Theme Helper");
            Initializations.InitializeThemeHelper();

            InitializeCommands();


            StaticReferences.Logger.Info("Initializing Shell");
            /*await*/ Initializations.InitializeShell(settings);
            var growl = ServiceLocator.Default.ResolveType<INotificationService>();
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

            StaticReferences.Logger.Info("Check for new updates");
            //Helpers.CheckForUpdates();
            Initializations.InitializeBk(settings);

            //Window window = new Window();
            //window.AllowsTransparency = true;
            //window.Background = new SolidColorBrush(Colors.Transparent);
            //window.Content = new HomePageView();
            //window.WindowStyle = WindowStyle.None;
            //window.Show();


        }

        private void InitializeCommands()
        {
            var _commandManager = ServiceLocator.Default.ResolveType<ICommandManager>();

            // global commands
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.Exit));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.About));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Settings), nameof(AppCommands.Settings.General));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.Options));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.BugReport));

            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.NewProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.PublishProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.OpenProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.OpenLink));

            // application-wide commands that viewmodels can subscribe to
            // Workspace Viewmodel
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.DelProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.SaveAsProject));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.SaveProject));

            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.SaveFile));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.SaveAll));


            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.ShowAbout));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.ShowFeedback));
            _commandManager.CreateCommandWithGesture(typeof(AppCommands.Application), nameof(AppCommands.Application.ShowSettings));

            _commandManager.CreateCommand(AppCommands.Application.ShowLog);
            _commandManager.CreateCommand(AppCommands.Application.ShowProjectExplorer);
            _commandManager.CreateCommand(AppCommands.Application.ShowImportUtility);
            _commandManager.CreateCommand(AppCommands.Application.ShowProperties);
            _commandManager.CreateCommand(AppCommands.Application.ShowPackageInstaller);
            _commandManager.CreateCommand(AppCommands.Application.ShowMimicsTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowCR2WEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowImportExportTool);

            _commandManager.CreateCommand(AppCommands.Application.ShowAssetBrowser);
            _commandManager.CreateCommand(AppCommands.Application.ShowBulkEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowCsvEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowHexEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowJournalEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowVisualEditor);
            _commandManager.CreateCommand(AppCommands.Application.ShowAnimationTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowAudioTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowVideoTool);

            _commandManager.CreateCommand(AppCommands.Application.ShowCodeEditor);

            _commandManager.CreateCommand(AppCommands.Application.ShowImporterTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowCR2WToTextTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowGameDebuggerTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowMenuCreatorTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowPluginManager);
            //_commandManager.CreateCommand(AppCommands.Application.ShowRadishTool);
            _commandManager.CreateCommand(AppCommands.Application.ShowWccTool);

            _commandManager.CreateCommand(AppCommands.Application.OpenFile);
            _commandManager.CreateCommand(AppCommands.Application.NewFile);
            _commandManager.CreateCommand(AppCommands.Application.PackMod);
            _commandManager.CreateCommand(AppCommands.Application.BackupMod);
            _commandManager.CreateCommand(AppCommands.Application.PublishMod);

            _commandManager.CreateCommand(AppCommands.ProjectExplorer.Refresh);
            _commandManager.CreateCommand(AppCommands.Application.FileSelected);

            _commandManager.CreateCommand(AppCommands.Application.ViewSelected);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }



        //public IServiceProvider Container { get; private set; }
        //private IHost _host;
        void Init()
        {
            // Set application licenses.
            Initializations.InitializeLicenses();
            //protobuf
            RuntimeTypeModel.Default[typeof(IGameArchive)].AddSubType(20, typeof(Archive));


            //_host = Host
            //    .CreateDefaultBuilder()
            //    .ConfigureServices(services =>
            //    {
            //        services.UseMicrosoftDependencyResolver();
            //        var resolver = Locator.CurrentMutable;
            //        resolver.InitializeSplat();
            //        resolver.InitializeReactiveUI();
            //    })
            //    //.ConfigureLogging(logging =>
            //    //{
            //    //    logging.AddSplat();
            //    //})
            //    .ConfigureServices((hostContext, services) =>
            //    {



            //        // this passes IScreen resolution through to the previous viewmodel registration.
            //        // this is to prevent multiple instances by mistake.
            //        services.AddSingleton<WorkSpaceViewModel>();
            //        //services.AddSingleton<IScreen, WorkSpaceViewModel>(x => x.GetRequiredService<WorkSpaceViewModel>());
            //        services.AddSingleton<IViewFor<WorkSpaceViewModel>, MainView>();




            //    })
            //    .UseEnvironment(Environments.Development)
            //    .Build();

            //// Since MS DI container is a different type,
            //// we need to re-register the built container with Splat again
            //Container = _host.Services;
            //Container.UseMicrosoftDependencyResolver();
        }
    }
}
