namespace WolvenKit.RED4.Types;

public partial class gameuiContraMiniGameController : inkIWidgetController
{
    [RED("gameplayCanvas")]
    public inkWidgetReference GameplayCanvas
    {
        get => GetPropertyValue<inkWidgetReference>();
        set => SetPropertyValue<inkWidgetReference>(value);
    }

    public gameuiContraMiniGameController()
    {
        PostConstruct();
    }

    partial void PostConstruct();
}