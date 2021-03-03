using Catel.IoC;
using Orchestra.Services;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.MVVM.Views.PropertyGridEditors;

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
        serviceLocator.RegisterType<IRibbonService, RibbonService>();
        serviceLocator.RegisterType<IApplicationInitializationService, ApplicationInitializationService>();
        serviceLocator.RegisterType<IHashService, HashService>();
        serviceLocator.RegisterType<ILoggerService, LoggerService>();

        serviceLocator.RegisterType<ICollectionEditor, CollectionEditor>();
        serviceLocator.RegisterType<IExpandableObjectEditor, ExpandableObjectEditor>();
    }

    #endregion Methods
}
