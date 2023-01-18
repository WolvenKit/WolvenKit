namespace WolvenKit.RED4.Types;

public partial class ExplosiveTriggerDeviceControllerPS
{
    [OrdinalOverride(Before = 110)]
    [RED("reactOnlyOnPlayer")]
    public CBool ReactOnlyOnPlayer
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}