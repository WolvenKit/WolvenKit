namespace WolvenKit.RED4.Types;

public partial class NewPerksCyberwareDetailsController : inkIWidgetController
{
    [RED("buttonHintsRoot")]
    public inkWidgetReference ButtonHintsRoot
    {
        get => GetPropertyValue<inkWidgetReference>();
        set => SetPropertyValue<inkWidgetReference>(value);
    }

    [RED("title")]
    public inkTextWidgetReference Title
    {
        get => GetPropertyValue<inkTextWidgetReference>();
        set => SetPropertyValue<inkTextWidgetReference>(value);
    }

    [RED("description")]
    public inkTextWidgetReference Description
    {
        get => GetPropertyValue<inkTextWidgetReference>();
        set => SetPropertyValue<inkTextWidgetReference>(value);
    }

    [RED("arrowLeft")]
    public inkWidgetReference ArrowLeft
    {
        get => GetPropertyValue<inkWidgetReference>();
        set => SetPropertyValue<inkWidgetReference>(value);
    }

    [RED("arrowRight")]
    public inkWidgetReference ArrowRight
    {
        get => GetPropertyValue<inkWidgetReference>();
        set => SetPropertyValue<inkWidgetReference>(value);
    }

    [RED("bars")]
    public CArray<inkWidgetReference> Bars
    {
        get => GetPropertyValue<CArray<inkWidgetReference>>();
        set => SetPropertyValue<CArray<inkWidgetReference>>(value);
    }

    [RED("libraryPath")]
    public inkWidgetLibraryReference LibraryPath
    {
        get => GetPropertyValue<inkWidgetLibraryReference>();
        set => SetPropertyValue<inkWidgetLibraryReference>(value);
    }

    public NewPerksCyberwareDetailsController()
    {
        PostConstruct();
    }

    partial void PostConstruct();
}