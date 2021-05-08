using System;
using Catel.IoC;
using CP77.CR2W;
using Orchestra.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.RED3;
using WolvenKit.MVVM.Model;
using WolvenKit.RED4.MeshFile.Materials;
using AboutInfoService = WolvenKit.Functionality.Services.AboutInfoService;

/// <summary>
/// Used by the ModuleInit. All code inside the Initialize method is ran as soon as the assembly is loaded.
/// </summary>
public static class ModuleInitializer
{
    #region Methods

    /// <summary>
    /// Initializes the module.
    /// </summary>
    public static void Initialize()
    {
        var serviceLocator = ServiceLocator.Default;


        // Orchestra
        serviceLocator.RegisterType<IAboutInfoService, AboutInfoService>();

        // Wkit

        var config = SettingsManager.Load();
        serviceLocator.RegisterInstance(typeof(ISettingsManager), config);

        serviceLocator.RegisterType<IGrowlNotificationService, GrowlNotificationService>();
        serviceLocator.RegisterInstance(typeof(IProgress<double>), new MockProgressService());
        serviceLocator.RegisterType<ILoggerService, CatelLoggerService>();

        // singletons

        //private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        serviceLocator.RegisterTypeAndInstantiate<IProjectManager, ProjectManager>();

        serviceLocator.RegisterTypeAndInstantiate<IWatcherService, WatcherService>();


        serviceLocator.RegisterType<IApplicationInitializationService, ApplicationInitializationService>();
        serviceLocator.RegisterType<IHashService, HashService>();
        
        // red4 modding tools
        serviceLocator.RegisterType<ModTools>();
        serviceLocator.RegisterType<MaterialRepository>();
        serviceLocator.RegisterType<Cp77Controller>();

        // red3 modding tools
        serviceLocator.RegisterType<Red3ModTools>();
        serviceLocator.RegisterType<Tw3Controller>();

        serviceLocator.RegisterType<IGameControllerFactory, GameControllerFactory>();


    }

    #endregion Methods

}
