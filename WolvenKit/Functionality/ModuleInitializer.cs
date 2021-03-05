using Catel.IoC;
using CP77.CR2W.Types;
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

        // Register PropertyEditor services here to the UI
        serviceLocator.RegisterType<ICollectionEditor, REDArrayEditor>();
        serviceLocator.RegisterType<IExpandableObjectEditor, ExpandableObjectEditor>();

        serviceLocator.RegisterType(typeof(ITextEditor<double>), typeof(TextEditor<CDouble>));
        serviceLocator.RegisterType(typeof(ITextEditor<float>), typeof(TextEditor<CFloat>));
        serviceLocator.RegisterType(typeof(ITextEditor<string>), typeof(TextEditor<CString>));

        serviceLocator.RegisterType(typeof(ITextEditor<ulong>), typeof(TextEditor<CUInt64>));
        serviceLocator.RegisterType(typeof(ITextEditor<long>), typeof(TextEditor<CInt64>));

        serviceLocator.RegisterType(typeof(ITextEditor<uint>), typeof(TextEditor<CUInt32>));
        serviceLocator.RegisterType(typeof(ITextEditor<int>), typeof(TextEditor<CInt32>));

        serviceLocator.RegisterType(typeof(ITextEditor<ushort>), typeof(TextEditor<CUInt16>));
        serviceLocator.RegisterType(typeof(ITextEditor<short>), typeof(TextEditor<CInt16>));

        serviceLocator.RegisterType(typeof(ITextEditor<byte>), typeof(TextEditor<CUInt8>));
        serviceLocator.RegisterType(typeof(ITextEditor<sbyte>), typeof(TextEditor<CInt8>));


        serviceLocator.RegisterType(typeof(IBoolEditor), typeof(BoolEditor));
        serviceLocator.RegisterType(typeof(IEnumEditor), typeof(EnumEditor));


    }

    #endregion Methods
}
