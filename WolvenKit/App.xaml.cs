using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
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
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Editor;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.HomePage.Pages;
using WolvenKit.ViewModels.Shared;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Editor;
using WolvenKit.Views.Editor.VisualEditor;
using WolvenKit.Views.HomePage;
using WolvenKit.Views.HomePage.Pages;
using WolvenKit.Views.Wizards;

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

            var settings = Locator.Current.GetService<ISettingsManager>();
            var loggerService = Locator.Current.GetService<ILoggerService>();

            loggerService.Info("Starting application");

            Initializations.InitializeWebview2();

            loggerService.Info("Initializing MVVM");

            loggerService.Info("Initializing Theme Helper");
            Initializations.InitializeThemeHelper();


            loggerService.Info("Initializing Shell");
            /*await*/ Initializations.InitializeShell(settings);
            
            

            loggerService.Info("Initializing Discord RPC API");
            DiscordHelper.InitializeDiscordRPC();

            loggerService.Info("Initializing Github API");
            Initializations.InitializeGitHub();

            loggerService.Info("Calling base.OnStartup");
            base.OnStartup(e); // Some things can only be initialized after base.OnStartup(e);

            loggerService.Info("Initializing NodeNetwork.");
            NNViewRegistrar.RegisterSplat();

            loggerService.Info("Initializing Notifications.");

            loggerService.Info("Check for new updates");
            //Helpers.CheckForUpdates();
            Initializations.InitializeBk(settings);

            //Window window = new Window();
            //window.AllowsTransparency = true;
            //window.Background = new SolidColorBrush(Colors.Transparent);
            //window.Content = new HomePageView();
            //window.WindowStyle = WindowStyle.None;
            //window.Show();


        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }

        public IServiceProvider Container { get; private set; }
        private IHost _host;
        void Init()
        {
            // Set application licenses.
            Initializations.InitializeLicenses();
            //protobuf
            RuntimeTypeModel.Default[typeof(IGameArchive)].AddSubType(20, typeof(Archive));


            _host = Host
                .CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.UseMicrosoftDependencyResolver();
                    var resolver = Locator.CurrentMutable;
                    resolver.InitializeSplat();
                    resolver.InitializeReactiveUI();
                })
                //.ConfigureLogging(logging =>
                //{
                //    logging.AddSplat();
                //})
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<INotificationService, NotificationService>();
                    services.AddSingleton(typeof(ISettingsManager), SettingsManager.Load());
                    services.AddSingleton<IProgressService<double>, ProgressService<double>>();
                    services.AddSingleton<ILoggerService, ReactiveLoggerService>();
                    services.AddSingleton<IUpdateService, UpdateService>();

                    // singletons
                    services.AddSingleton<IHashService, HashService>();
                    services.AddSingleton<IRecentlyUsedItemsService, RecentlyUsedItemsService>();
                    services.AddSingleton<IProjectManager, ProjectManager>();
                    services.AddSingleton<IWatcherService, WatcherService>();


                    services.AddSingleton<MockGameController>();

                    // red4 modding tools
                    services.AddSingleton<Red4ParserService>();
                    services.AddSingleton<RIG>();
                    services.AddSingleton<MeshTools>();

                    services.AddSingleton<ModTools>();
                    services.AddSingleton<Cp77Controller>();

                    // red3 modding tools
                    services.AddSingleton<Red3ModTools>();
                    services.AddSingleton<Tw3Controller>();

                    services.AddSingleton<IGameControllerFactory, GameControllerFactory>();


                    // this passes IScreen resolution through to the previous viewmodel registration.
                    // this is to prevent multiple instances by mistake.
                    services.AddSingleton<WorkSpaceViewModel>();
                    //services.AddSingleton<IScreen, WorkSpaceViewModel>(x => x.GetRequiredService<WorkSpaceViewModel>());
                    services.AddSingleton<IViewFor<WorkSpaceViewModel>, MainView>();

                    // register views

                    #region dialogs

                    services.AddSingleton<AddChunkDialogViewModel>();
                    services.AddSingleton<IViewFor<AddChunkDialogViewModel>, AddChunkDialog>();

                    services.AddSingleton<InputDialogViewModel>();
                    services.AddSingleton<IViewFor<InputDialogViewModel>, InputDialogView>();

                    //services.AddSingleton<MaterialsRepositoryDialogViewModel>();
                    //services.AddSingleton<IViewFor<MaterialsRepositoryDialogViewModel>, MaterialsRepositoryDialog>();

                    services.AddSingleton<RenameDialogViewModel>();
                    services.AddSingleton<IViewFor<RenameDialogViewModel>, RenameDialog>();

                    #endregion

                    #region editor

                    services.AddSingleton<AssetBrowserViewModel>();
                    services.AddSingleton<IViewFor<AssetBrowserViewModel>, AssetBrowserView>();

                    services.AddSingleton<LogViewModel>();
                    services.AddSingleton<IViewFor<LogViewModel>, LogView>();

                    services.AddSingleton<ProjectExplorerViewModel>();
                    services.AddSingleton<IViewFor<ProjectExplorerViewModel>, ProjectExplorerView>();

                    services.AddSingleton<PropertiesViewModel>();
                    services.AddSingleton<IViewFor<PropertiesViewModel>, PropertiesView>();

                    services.AddSingleton<DocumentViewModel>();
                    services.AddSingleton<IViewFor<DocumentViewModel>, DocumentView>();

                    services.AddSingleton<CodeEditorViewModel>();
                    services.AddSingleton<IViewFor<CodeEditorViewModel>, CodeEditorView>();

                    services.AddSingleton<VisualEditorViewModel>();
                    services.AddSingleton<IViewFor<VisualEditorViewModel>, VisualEditorView>();

                    services.AddSingleton<ImportExportViewModel>();
                    services.AddSingleton<IViewFor<ImportExportViewModel>, ImportExportView>();

                    #endregion

                    #region homepage

                    services.AddSingleton<DebugPageViewModel>();
                    services.AddSingleton<IViewFor<DebugPageViewModel>, DebugPageView>();

                    services.AddSingleton<GithubPageViewModel>();
                    services.AddSingleton<IViewFor<GithubPageViewModel>, GithubPageView>();

                    services.AddSingleton<SettingsPageViewModel>();
                    services.AddSingleton<IViewFor<SettingsPageViewModel>, SettingsPageView>();

                    services.AddSingleton<WebsitePageViewModel>();
                    services.AddSingleton<IViewFor<WebsitePageViewModel>, WebsitePageView>();

                    services.AddSingleton<WelcomePageViewModel>();
                    services.AddSingleton<IViewFor<WelcomePageViewModel>, WelcomePageView>();

                    services.AddSingleton<WikiPageViewModel>();
                    services.AddSingleton<IViewFor<WikiPageViewModel>, WikiPageView>();

                    services.AddSingleton<HomePageViewModel>();
                    services.AddSingleton<IViewFor<HomePageViewModel>, HomePageView>();

                    #endregion

                    #region shared

                    //services.AddSingleton<RecentlyUsedItemsViewModel>();
                    //services.AddSingleton<IViewFor<RecentlyUsedItemsViewModel>, RecentlyUsedItemsView>();

                    #endregion

                    #region shell

                    services.AddSingleton<RibbonViewModel>();
                    services.AddSingleton<IViewFor<RibbonViewModel>, RibbonView>();

                    services.AddSingleton<StatusBarViewModel>();
                    services.AddSingleton<IViewFor<StatusBarViewModel>, StatusBarView>();

                    #endregion

                    #region wizards

                    services.AddSingleton<BugReportWizardViewModel>();
                    services.AddSingleton<IViewFor<BugReportWizardViewModel>, BugReportWizardView>();

                    services.AddSingleton<FeedbackWizardViewModel>();
                    services.AddSingleton<IViewFor<FeedbackWizardViewModel>, FeedbackWizardView>();

                    services.AddSingleton<FirstSetupWizardViewModel>();
                    services.AddSingleton<IViewFor<FirstSetupWizardViewModel>, FirstSetupWizardView>();

                    services.AddSingleton<InstallerWizardViewModel>();
                    services.AddSingleton<IViewFor<InstallerWizardViewModel>, InstallerWizardView>();

                    services.AddSingleton<ProjectWizardViewModel>();
                    services.AddSingleton<IViewFor<ProjectWizardViewModel>, ProjectWizardView>();

                    #endregion

                })
                .UseEnvironment(Environments.Development)
                .Build();

            // Since MS DI container is a different type,
            // we need to re-register the built container with Splat again
            Container = _host.Services;
            Container.UseMicrosoftDependencyResolver();
        }
    }
}
