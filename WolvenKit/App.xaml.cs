using System;
using System.ComponentModel;
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
using WolvenKit.Functionality.WKitGlobal.Helpers;
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
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.HomePage.Pages;
using WolvenKit.ViewModels.Shared;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Editor;
using WolvenKit.Views.Documents;
using WolvenKit.Views.HomePage;
using WolvenKit.Views.HomePage.Pages;
using WolvenKit.Views.Wizards;
using WolvenKit.Common.Interfaces;
using WolvenKit.Views.Tools;
using WolvenKit.ViewModels.Tools;

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
        }

        // Application OnStartup Override.
        protected override void OnStartup(StartupEventArgs e)
        {

            // Startup speed boosting (HC)
            ApplicationHelper.StartProfileOptimization();

            var settings = Locator.Current.GetService<ISettingsManager>();
            var loggerService = Locator.Current.GetService<ILoggerService>();

            loggerService.Info("Starting application");

            Initializations.InitializeWebview2(loggerService);

            loggerService.Info("Initializing Theme Helper");
            Initializations.InitializeThemeHelper();

            loggerService.Info("Initializing Shell");
            /*await*/ Initializations.InitializeShell(settings);
            
            loggerService.Info("Initializing Discord RPC API");
            DiscordHelper.InitializeDiscordRPC();

            loggerService.Info("Initializing Github API");
            Initializations.InitializeGitHub();

            // Some things can only be initialized after base.OnStartup(e);
            loggerService.Info("Calling base.OnStartup");
            base.OnStartup(e); 

            loggerService.Info("Initializing NodeNetwork.");
            NNViewRegistrar.RegisterSplat();


            Initializations.InitializeBk(settings);


        }

        private IServiceProvider Container { get; set; }
        private IHost _host;

        private void Init()
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

                    services.AddSingleton<IArchiveManager, ArchiveManager>();
                    services.AddSingleton<MockGameController>();

                    // red4 modding tools
                    services.AddSingleton<Red4ParserService>();
                    services.AddSingleton<RIG>();
                    services.AddSingleton<MeshTools>();

                    services.AddSingleton<IModTools, ModTools>();
                    services.AddSingleton< RED4Controller>();

                    // red3 modding tools
                    //services.AddSingleton<Red3ModTools>();
                    //services.AddSingleton<Tw3Controller>();

                    services.AddSingleton<IGameControllerFactory, GameControllerFactory>();

                    services.AddSingleton<AppViewModel>();
                    services.AddSingleton<IViewFor<AppViewModel>, MainView>();

                    // register views
                    #region shell

                    services.AddSingleton<RibbonViewModel>();
                    services.AddSingleton<IViewFor<RibbonViewModel>, RibbonView>();

                    services.AddSingleton<StatusBarViewModel>();
                    services.AddSingleton<IViewFor<StatusBarViewModel>, StatusBarView>();

                    #endregion

                    #region dialogs

                    services.AddTransient<DialogHostViewModel>();
                    services.AddTransient<IViewFor<DialogHostViewModel>, DialogHostView>();

                    services.AddTransient<AddChunkDialogViewModel>();
                    services.AddTransient<IViewFor<AddChunkDialogViewModel>, AddChunkDialog>();

                    services.AddTransient<InputDialogViewModel>();
                    services.AddTransient<IViewFor<InputDialogViewModel>, InputDialogView>();

                    //services.AddSingleton<MaterialsRepositoryDialogViewModel>();
                    //services.AddSingleton<IViewFor<MaterialsRepositoryDialogViewModel>, MaterialsRepositoryDialog>();

                    services.AddTransient<RenameDialogViewModel>();
                    services.AddTransient<IViewFor<RenameDialogViewModel>, RenameDialog>();

                    services.AddTransient<NewFileViewModel>();
                    services.AddTransient<IViewFor<NewFileViewModel>, NewFileView>();

                    #endregion

                    #region documents

                    services.AddSingleton<AssetBrowserViewModel>();
                    services.AddTransient<IViewFor<AssetBrowserViewModel>, AssetBrowserView>();

                    services.AddSingleton<LogViewModel>();
                    services.AddTransient<IViewFor<LogViewModel>, LogView>();

                    services.AddSingleton<ProjectExplorerViewModel>();
                    services.AddTransient<IViewFor<ProjectExplorerViewModel>, ProjectExplorerView>();

                    services.AddSingleton<PropertiesViewModel>();
                    services.AddTransient<IViewFor<PropertiesViewModel>, PropertiesView>();

                    #endregion

                    #region tools

                    //services.AddTransient<CodeEditorViewModel>();
                    //services.AddTransient<IViewFor<CodeEditorViewModel>, CodeEditorView>();

                    //services.AddTransient<VisualEditorViewModel>();
                    //services.AddTransient<IViewFor<VisualEditorViewModel>, VisualEditorView>();

                    services.AddSingleton<ImportExportViewModel>();
                    services.AddTransient<IViewFor<ImportExportViewModel>, ImportExportView>();

                    #endregion

                    #region homepage

                    services.AddSingleton<HomePageViewModel>();
                    services.AddTransient<IViewFor<HomePageViewModel>, HomePageView>();

                    services.AddTransient<DebugPageViewModel>();
                    services.AddTransient<IViewFor<DebugPageViewModel>, DebugPageView>();

                    services.AddTransient<GithubPageViewModel>();
                    services.AddTransient<IViewFor<GithubPageViewModel>, GithubPageView>();

                    services.AddTransient<SettingsPageViewModel>();
                    services.AddTransient<IViewFor<SettingsPageViewModel>, SettingsPageView>();

                    services.AddTransient<WebsitePageViewModel>();
                    services.AddTransient<IViewFor<WebsitePageViewModel>, WebsitePageView>();

                    services.AddTransient<WelcomePageViewModel>();
                    services.AddTransient<IViewFor<WelcomePageViewModel>, WelcomePageView>();

                    services.AddTransient<WikiPageViewModel>();
                    services.AddTransient<IViewFor<WikiPageViewModel>, WikiPageView>();

                    #endregion

                    #region shared

                    //services.AddSingleton<RecentlyUsedItemsViewModel>();
                    //services.AddSingleton<IViewFor<RecentlyUsedItemsViewModel>, RecentlyUsedItemsView>();

                    #endregion

                    #region wizards

                    services.AddTransient<BugReportWizardViewModel>();
                    services.AddTransient<IViewFor<BugReportWizardViewModel>, BugReportWizardView>();

                    services.AddTransient<FeedbackWizardViewModel>();
                    services.AddTransient<IViewFor<FeedbackWizardViewModel>, FeedbackWizardView>();

                    services.AddTransient<FirstSetupWizardViewModel>();
                    services.AddTransient<IViewFor<FirstSetupWizardViewModel>, FirstSetupWizardView>();

                    services.AddTransient<InstallerWizardViewModel>();
                    services.AddTransient<IViewFor<InstallerWizardViewModel>, InstallerWizardView>();

                    services.AddTransient<ProjectWizardViewModel>();
                    services.AddTransient<IViewFor<ProjectWizardViewModel>, ProjectWizardView>();

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
