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
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4;

/// <summary>
/// Used by the ModuleInit. All code inside the Initialize method is ran as soon as the assembly is loaded.
/// </summary>
public static class ModuleInitializer
{
    /// <summary>
    /// Initializes the module.
    /// </summary>
    public static void Initialize()
    {
        var serviceLocator = ServiceLocator.Default;


        // Orchestra
        serviceLocator.RegisterType<IAboutInfoService, AboutInfoService>();
        serviceLocator.RegisterType<INotificationService, NotificationService>();


        // Wkit
        var config = SettingsManager.Load();
        serviceLocator.RegisterInstance(typeof(ISettingsManager), config);

        serviceLocator.RegisterType< IProgressService<double>, ProgressService<double> > ();
        serviceLocator.RegisterType<ILoggerService, CatelLoggerService>();

        // singletons
        serviceLocator.RegisterType<IApplicationInitializationService, ApplicationInitializationService>();
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
}
