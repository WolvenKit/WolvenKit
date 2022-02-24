using CP77.CR2W;
using gpm.Installer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReactiveUI;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.ProjectManagement;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Services;
using WolvenKit.ViewModels;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.HomePage.Pages;
using WolvenKit.ViewModels.Shared;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Tools;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.HomePage;
using WolvenKit.Views.HomePage.Pages;
using WolvenKit.Views.Shell;
using WolvenKit.Views.Tools;
using WolvenKit.Views.Wizards;

namespace WolvenKit
{
    internal static class GenericHost
    {
        public static IHostBuilder CreateHostBuilder() => Host
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
                    services.AddSingleton<Core.Services.IProgressService<double>, System.ProgressService<double>>();

                    services.AddSingleton<MySink>();
                    services.AddSingleton<ILoggerService, SerilogWrapper>();

                    // singletons
                    services.AddSingleton<IHashService, HashService>();
                    services.AddSingleton<ITweakDBService, TweakDBService>();
                    services.AddSingleton<IRecentlyUsedItemsService, RecentlyUsedItemsService>();
                    services.AddSingleton<IProjectManager, ProjectManager>();
                    services.AddSingleton<IWatcherService, WatcherService>();

                    services.AddSingleton<IArchiveManager, ArchiveManager>();
                    services.AddSingleton<MockGameController>();

                    // red4 modding tools
                    services.AddSingleton<Red4ParserService>();
                    services.AddSingleton<MeshTools>();

                    services.AddSingleton<IModTools, ModTools>();
                    services.AddSingleton<RED4Controller>();

                    // red3 modding tools
                    //services.AddSingleton<Red3ModTools>();
                    //services.AddSingleton<Tw3Controller>();

                    services.AddSingleton<IGameControllerFactory, GameControllerFactory>();

                    services.AddSingleton<AppViewModel>();
                    services.AddSingleton<IViewFor<AppViewModel>, MainView>();

                    // TODO replace with this once gpm.Installer updates
                    services.AddGpmInstaller();

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

                    //services.AddTransient<CreateClassDialogViewModel>();
                    //services.AddTransient<IViewFor<CreateClassDialogViewModel>, CreateClassDialog>();

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
                .UseEnvironment(Environments.Development);
    }
}
