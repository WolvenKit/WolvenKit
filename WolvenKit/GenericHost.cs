using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReactiveUI;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using WolvenKit.App;
using WolvenKit.App.Controllers;
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.HomePage.Pages;
using WolvenKit.App.ViewModels.Importers;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Services;
using WolvenKit.ViewModels;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Dialogs.Windows;
using WolvenKit.Views.Exporters;
using WolvenKit.Views.HomePage;
using WolvenKit.Views.HomePage.Pages;
using WolvenKit.Views.Importers;
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
                    // services
                    services.AddSingleton(typeof(ISettingsManager), SettingsManager.Load());    
                    services.AddSingleton<IHashService, HashService>();                         // can this be transient?
                    services.AddSingleton<CRUIDService>();                                      // can this be transient?
                    services.AddSingleton<MySink>();                                            // can this be transient?
                    services.AddSingleton<ILoggerService, SerilogWrapper>();                    // can this be transient?
                    services.AddSingleton<ITweakDBService, TweakDBService>();

                    // scripting
                    services.AddSingleton<IHookService, AppHookService>();
                    services.AddSingleton<AppScriptService>();
                    services.AddTransient<ImportExportHelper>();

                    services.AddTransient<INotificationService, NotificationService>();
                    services.AddSingleton<IProgressService<double>, ProgressService<double>>();
                    services.AddTransient<Red4ParserService>();
                    services.AddSingleton<IArchiveManager, ArchiveManager>();
                    services.AddTransient<ILocKeyService, LocKeyServiceExt>();                  // can this be transient?
                    services.AddSingleton<IRecentlyUsedItemsService, RecentlyUsedItemsService>();
                    services.AddSingleton<IProjectManager, ProjectManager>();
                    services.AddSingleton<IWatcherService, WatcherService>();
                    services.AddTransient<GeometryCacheService>();
                    services.AddTransient<MeshTools>();
                    services.AddTransient<IModTools, ModTools>();
                    services.AddTransient<MockGameController>();
                    services.AddTransient<RED4Controller>();
                    services.AddTransient<IGameControllerFactory, GameControllerFactory>();
                    services.AddSingleton<IPluginService, PluginService>();

                    // factories
                    services.AddTransient<IPageViewModelFactory, PageViewModelFactory>();
                    services.AddTransient<IDialogViewModelFactory, DialogViewModelFactory>();
                    services.AddTransient<IDocumentTabViewmodelFactory, DocumentTabViewmodelFactory>();
                    services.AddTransient<IChunkViewmodelFactory, ChunkViewmodelFactory>();             // IDocumentTabViewmodelFactory
                    services.AddTransient<IPaneViewModelFactory, PaneViewModelFactory>();               // IChunkViewmodelFactory
                    services.AddTransient<INodeWrapperFactory, NodeWrapperFactory>();
                    services.AddTransient<IDocumentViewmodelFactory, DocumentViewmodelFactory>();       //IDocumentTabViewmodelFactory, IPaneViewModelFactory, IChunkViewmodelFactory

                    // register views
                    #region shell

                    services.AddSingleton<AppViewModel>();
                    services.AddTransient<IViewFor<AppViewModel>, MainView>();

                    services.AddTransient<RibbonViewModel>();
                    services.AddTransient<IViewFor<RibbonViewModel>, RibbonView>();

                    services.AddTransient<MenuBarViewModel>();
                    services.AddTransient<IViewFor<MenuBarViewModel>, MenuBarView>();

                    services.AddTransient<StatusBarViewModel>();
                    services.AddTransient<IViewFor<StatusBarViewModel>, StatusBarView>();

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

                    services.AddTransient<ChooseCollectionViewModel>();
                    services.AddTransient<IViewFor<ChooseCollectionViewModel>, ChooseCollectionView>();


                    // Importers

                    services.AddTransient<ImportViewModel>();
                    services.AddTransient<IViewFor<ImportViewModel>, ImportView>();

                    services.AddTransient<ExportViewModel>();
                    services.AddTransient<IViewFor<ExportViewModel>, ExportView>();

                    #endregion

                    #region documents

                    services.AddTransient<AssetBrowserViewModel>();
                    services.AddTransient<IViewFor<AssetBrowserViewModel>, AssetBrowserView>();

                    services.AddTransient<LogViewModel>();
                    services.AddTransient<IViewFor<LogViewModel>, LogView>();

                    services.AddSingleton<ProjectExplorerViewModel>();
                    services.AddTransient<IViewFor<ProjectExplorerViewModel>, ProjectExplorerView>();

                    services.AddSingleton<PropertiesViewModel>();
                    services.AddTransient<IViewFor<PropertiesViewModel>, PropertiesView>();

                    services.AddTransient<TweakBrowserViewModel>();
                    services.AddTransient<IViewFor<TweakBrowserViewModel>, TweakBrowserView>();

                    services.AddTransient<LocKeyBrowserViewModel>();
                    services.AddTransient<IViewFor<LocKeyBrowserViewModel>, LocKeyBrowserView>();

                    #endregion

                    #region tools

                    services.AddTransient<AudioPlayerViewModel>();
                    services.AddTransient<IViewFor<AudioPlayerViewModel>, AudioPlayerView>();

                    services.AddTransient<HashToolViewModel>();
                    services.AddTransient<IViewFor<HashToolViewModel>, HashToolView>();

                    #endregion

                    #region homepage

                    services.AddTransient<HomePageViewModel>();
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

                    // bind options
                    services.AddOptions<Globals>().Bind(hostContext.Configuration.GetSection("Globals"));

                })
                .UseEnvironment(Environments.Development);
    }
}
