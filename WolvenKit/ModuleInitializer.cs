using Catel.IoC;
using CP77.CR2W.Resources;
using Orchestra.Services;
using WolvenKit.Common.Services;
using WolvenKit.Services;

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

        serviceLocator.RegisterType<IRibbonService, RibbonService>();
        serviceLocator.RegisterType<IApplicationInitializationService, ApplicationInitializationService>();
        serviceLocator.RegisterType<IHashService, HashService>();
        ServiceLocator.Default.RegisterType<ILoggerService, LoggerService>();
        ServiceLocator.Default.RegisterType<IAppSettingsService, AppSettingsService>();

        var hashService = ServiceLocator.Default.ResolveType<IHashService>();
        hashService.ReloadLocally();
    }
}