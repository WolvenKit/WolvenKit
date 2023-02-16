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
                    services.AddSingleton<IHashService, HashService>();
                    services.AddSingleton<MySink>();
                    services.AddSingleton<ILoggerService, SerilogWrapper>(); // can this be transient?
                    services.AddSingleton<ExtendedScriptService>();
                    services.AddSingleton<ITweakDBService, TweakDBService>();

                    services.AddTransient<INotificationService, NotificationService>();
                    services.AddTransient<IProgressService<double>, ProgressService<double>>();
                    services.AddTransient<Red4ParserService>();
                    services.AddTransient<IArchiveManager, ArchiveManager>();
                    services.AddTransient<IRecentlyUsedItemsService, RecentlyUsedItemsService>();
                    services.AddTransient<IProjectManager, ProjectManager>();
                    services.AddTransient<IWatcherService, WatcherService>();
                    services.AddTransient<GeometryCacheService>();
                    services.AddTransient<ILocKeyService, LocKeyService>(); // singleton?
                    services.AddTransient<MeshTools>();
                    services.AddTransient<IModTools, ModTools>();
                    services.AddTransient<MockGameController>();
                    services.AddTransient<RED4Controller>();
                    services.AddTransient<IGameControllerFactory, GameControllerFactory>();
                    services.AddTransient<IPluginService, PluginService>();
                    

                    // factories
                    services.AddTransient<IPageViewModelFactory, PageViewModelFactory>();
                    services.AddTransient<IDialogViewModelFactory, DialogViewModelFactory>();
                    services.AddTransient<IDocumentTabViewmodelFactory, DocumentTabViewmodelFactory>();
                    // IDocumentTabViewmodelFactory
                    services.AddTransient<IChunkViewmodelFactory, ChunkViewmodelFactory>();
                    // IChunkViewmodelFactory
                    services.AddTransient<IPaneViewModelFactory, PaneViewModelFactory>();
                    //IDocumentTabViewmodelFactory, IPaneViewModelFactory, IChunkViewmodelFactory
                    services.AddTransient<IDocumentViewmodelFactory, DocumentViewmodelFactory>();       

                    

                    // register views
                    #region shell

                    services.AddTransient<AppViewModel>();
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

                    services.AddTransient<TextureImportViewModel>();
                    services.AddTransient<IViewFor<TextureImportViewModel>, TextureImportView>();

                    services.AddTransient<TextureExportViewModel>();
                    services.AddTransient<IViewFor<TextureExportViewModel>, TextureExportView>();

                    #endregion

                    #region documents

                    services.AddTransient<AssetBrowserViewModel>();
                    services.AddTransient<IViewFor<AssetBrowserViewModel>, AssetBrowserView>();

                    services.AddTransient<LogViewModel>();
                    services.AddTransient<IViewFor<LogViewModel>, LogView>();

                    services.AddTransient<ProjectExplorerViewModel>();
                    services.AddTransient<IViewFor<ProjectExplorerViewModel>, ProjectExplorerView>();

                    services.AddTransient<PropertiesViewModel>();
                    services.AddTransient<IViewFor<PropertiesViewModel>, PropertiesView>();

                    services.AddTransient<TweakBrowserViewModel>();
                    services.AddTransient<IViewFor<TweakBrowserViewModel>, TweakBrowserView>();

                    services.AddTransient<LocKeyBrowserViewModel>();
                    services.AddTransient<IViewFor<LocKeyBrowserViewModel>, LocKeyBrowserView>();

                    #endregion

                    #region tools

                    services.AddTransient<AudioPlayerViewModel>();
                    services.AddTransient<IViewFor<AudioPlayerViewModel>, AudioPlayerView>();

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
