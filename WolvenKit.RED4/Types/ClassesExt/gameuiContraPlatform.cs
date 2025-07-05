namespace WolvenKit.RED4.Types;

public partial class gameuiContraPlatform : inkWidgetLogicController
{
    [RED("image")]
    public inkImageWidgetReference Image
    {
        get => GetPropertyValue<inkImageWidgetReference>();
        set => SetPropertyValue<inkImageWidgetReference>(value);
    }

    public gameuiContraPlatform()
    {
        PostConstruct();
    }

    partial void PostConstruct();
}