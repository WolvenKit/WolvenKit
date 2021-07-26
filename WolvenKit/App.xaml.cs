using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Catel;
using Catel.IoC;
using Catel.Logging;
using Catel.Messaging;
using Catel.MVVM;
using CP77.CR2W;
using HandyControl.Tools;
using NodeNetwork;
using ProtoBuf.Meta;
using WolvenKit.Common;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools.Oodle;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Initialization;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Modkit.RED3;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
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

            //protobuf
            RuntimeTypeModel.Default[typeof(IGameArchive)].AddSubType(20, typeof(Archive));


            var serviceLocator = ServiceLocator.Default;


            // Orchestra


            // Wkit

            serviceLocator.RegisterType<INotificationService, NotificationService>();


            var config = SettingsManager.Load();
            serviceLocator.RegisterInstance(typeof(ISettingsManager), config);

            serviceLocator.RegisterType<IProgressService<double>, ProgressService<double>>();
            serviceLocator.RegisterType<ILoggerService, CatelLoggerService>();
            serviceLocator.RegisterType<IUpdateService, UpdateService>();

            // singletons
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
    }
}
