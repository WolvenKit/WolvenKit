namespace WolvenKit.RED4.Types;

public partial class gameuiCrosshairContainerController
{
    [OrdinalOverride(After = 9)]
    [RED("sprintWidget")]
    public inkWidgetReference SprintWidget
    {
        get => GetPropertyValue<inkWidgetReference>();
        set => SetPropertyValue<inkWidgetReference>(value);
    }
}
