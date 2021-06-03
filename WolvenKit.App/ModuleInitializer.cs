using System;
using System.IO;
using Catel.IoC;
using CP77.CR2W;
using Orchestra.Services;
using WolvenKit.Bundles;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools.Oodle;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.RED3;
using WolvenKit.MVVM.Model;
using WolvenKit.RED4.CR2W;
using WolvenKit.Modkit.RED4.Materials;
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
        serviceLocator.RegisterType<IApplicationInitializationService, ApplicationInitializationService>();


        var dir = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
        var destFileName = Path.Combine(dir, "oo2ext_7_win64.dll");
        if (!OodleLoadLib.Load(destFileName))
        {
            throw new MissingCompressionException($"oo2ext_7_win64.dll not found in {dir}");
        }
        serviceLocator.RegisterType<IHashService, HashService>();

        serviceLocator.RegisterTypeAndInstantiate<IProjectManager, ProjectManager>();
        serviceLocator.RegisterTypeAndInstantiate<IWatcherService, WatcherService>();
        serviceLocator.RegisterType<MockGameController>();

        serviceLocator.RegisterType<IWolvenkitFileService, Cp77FileService>();


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
