namespace WolvenKit.RED4.Types;

public partial class gameLightComponent
{
    [RED("autoHideRange")]
    public CFloat AutoHideRange
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}
