namespace WolvenKit.RED4.Types;

public partial class RadioSetup
{
    [OrdinalOverride(Before = 1)]
    [RED("radioSetup")]
    public CName RadioSetup_
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}