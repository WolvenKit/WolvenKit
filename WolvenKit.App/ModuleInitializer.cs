using System;
using Catel.IoC;
using Orchestra.Services;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;

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

        serviceLocator.RegisterType<IGrowlNotificationService, GrowlNotificationService>();
        serviceLocator.RegisterInstance(typeof(IProgress<double>), new MockProgressService());
        serviceLocator.RegisterType<ILoggerService, CatelLoggerService>();

        // singletons

        //private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        serviceLocator.RegisterTypeAndInstantiate<IProjectManager, ProjectManager>();

        serviceLocator.RegisterTypeAndInstantiate<IWatcherService, WatcherService>();


        serviceLocator.RegisterType<IApplicationInitializationService, ApplicationInitializationService>();
        serviceLocator.RegisterType<IHashService, HashService>();
    }

    #endregion Methods
}
