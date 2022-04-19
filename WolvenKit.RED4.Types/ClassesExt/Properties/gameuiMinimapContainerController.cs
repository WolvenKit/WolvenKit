namespace WolvenKit.RED4.Types;

public partial class gameuiMinimapContainerController
{
    [OrdinalOverride(After = 35)]
    [RED("messageCounter")]
    public inkWidgetReference MessageCounter
    {
        get => GetPropertyValue<inkWidgetReference>();
        set => SetPropertyValue<inkWidgetReference>(value);
    }
}
