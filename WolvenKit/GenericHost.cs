using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReactiveUI;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using WolvenKit.App;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.ProjectManagement;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Services;
using WolvenKit.ViewModels;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.HomePage.Pages;
using WolvenKit.ViewModels.Shared;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Tools;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Dialogs.Windows;
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
                .ConfigureAppConfiguration((hostingContext, configuration) =>
                {
                    var assemblyFolder = Path.GetDirectoryName(System.AppContext.BaseDirectory);

                    configuration.SetBasePath(assemblyFolder);
                    configuration.AddJsonFile("appsettings.json");
                })
                .ConfigureServices(services =>
                {
                    services.UseMicrosoftDependencyResolver();
                    var resolver = Locator.CurrentMutable;
                    resolver.InitializeSplat();
                    resolver.InitializeReactiveUI();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<INotificationService, NotificationService>();
                    services.AddSingleton(typeof(ISettingsManager), SettingsManager.Load());
                    services.AddSingleton<Core.Services.IProgressService<double>, System.ProgressService<double>>();
                    services.AddSingleton<MySink>();
                    services.AddSingleton<ILoggerService, SerilogWrapper>();

                    // singletons
                    services.AddSingleton<IHashService, HashService>();

                    services.AddSingleton<Red4ParserService>();

                    services.AddSingleton<IArchiveManager, ArchiveManager>();

                    services.AddSingleton<IRecentlyUsedItemsService, RecentlyUsedItemsService>();
                    services.AddSingleton<IProjectManager, ProjectManager>();
                    services.AddSingleton<IWatcherService, WatcherService>();


                    services.AddSingleton<GeometryCacheService>();

                    services.AddSingleton<TweakDBService>();
                    services.AddSingleton<ITweakDBService>(x => x.GetRequiredService<TweakDBService>());

                    services.AddSingleton<LocKeyService>();
                    services.AddSingleton<ILocKeyService>(x => x.GetRequiredService<LocKeyService>());


                    services.AddSingleton<MeshTools>();

                    services.AddSingleton<ModTools>();
                    services.AddSingleton<IModTools>(x => x.GetRequiredService<ModTools>());
                    services.AddSingleton<MockGameController>();
                    services.AddSingleton<RED4Controller>();

                    services.AddSingleton<IGameControllerFactory, GameControllerFactory>();

                    services.AddSingleton<AppViewModel>();
                    services.AddSingleton<IViewFor<AppViewModel>, MainView>();

                    services.AddSingleton<IPluginService, PluginService>();

                    services.AddSingleton<ScriptService>();


                    // register views
                    #region shell

                    services.AddSingleton<RibbonViewModel>();
                    services.AddSingleton<IViewFor<RibbonViewModel>, RibbonView>();

                    services.AddSingleton<MenuBarViewModel>();
                    services.AddSingleton<IViewFor<MenuBarViewModel>, MenuBarView>();

                    services.AddSingleton<StatusBarViewModel>();
                    services.AddSingleton<IViewFor<StatusBarViewModel>, StatusBarView>();

                    #endregion

                    #region dialogs

                    services.AddTransient<InputDialogViewModel>();
                    services.AddTransient<IViewFor<InputDialogViewModel>, InputDialogView>();

                    services.AddTransient<RenameDialogViewModel>();
                    services.AddTransient<IViewFor<RenameDialogViewModel>, RenameDialog>();

                    services.AddTransient<LaunchProfilesViewModel>();
                    services.AddTransient<IViewFor<LaunchProfilesViewModel>, LaunchProfilesView>();

                    services.AddTransient<MaterialsRepositoryViewModel>();
                    services.AddTransient<IViewFor<MaterialsRepositoryViewModel>, MaterialsRepositoryView>();

                    services.AddTransient<NewFileViewModel>();
                    services.AddTransient<IViewFor<NewFileViewModel>, NewFileView>();

                    services.AddTransient<SoundModdingViewModel>();
                    services.AddTransient<IViewFor<SoundModdingViewModel>, SoundModdingView>();

                    services.AddTransient<FirstSetupViewModel>();
                    services.AddTransient<IViewFor<FirstSetupViewModel>, FirstSetupView>();

                    services.AddTransient<InstallerWizardViewModel>();
                    services.AddTransient<IViewFor<InstallerWizardViewModel>, InstallerWizardView>();

                    services.AddTransient<ProjectWizardViewModel>();
                    services.AddTransient<IViewFor<ProjectWizardViewModel>, ProjectWizardView>();

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

                    services.AddSingleton<TweakBrowserViewModel>();
                    services.AddTransient<IViewFor<TweakBrowserViewModel>, TweakBrowserView>();

                    services.AddSingleton<LocKeyBrowserViewModel>();
                    services.AddTransient<IViewFor<LocKeyBrowserViewModel>, LocKeyBrowserView>();

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

                    services.AddTransient<ModsViewModel>();
                    services.AddTransient<IViewFor<ModsViewModel>, ModsView>();

                    services.AddTransient<PluginsToolViewModel>();
                    services.AddTransient<IViewFor<PluginsToolViewModel>, PluginsToolView>();

                    #endregion

                    #region shared

                    //services.AddSingleton<RecentlyUsedItemsViewModel>();
                    //services.AddSingleton<IViewFor<RecentlyUsedItemsViewModel>, RecentlyUsedItemsView>();

                    #endregion

                    // bind options
                    services.AddOptions<Globals>().Bind(hostContext.Configuration.GetSection("Globals"));

                })
                .UseEnvironment(Environments.Development);
    }
}
