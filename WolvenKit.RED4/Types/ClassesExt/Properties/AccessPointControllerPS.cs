namespace WolvenKit.RED4.Types;

public partial class AccessPointControllerPS
{
    [OrdinalOverride(Before = 107)]
    [RED("netrunnerChargesProvided")]
    public CInt32 NetrunnerChargesProvided
    {
        get => GetPropertyValue<CInt32>();
        set => SetPropertyValue<CInt32>(value);
    }
}