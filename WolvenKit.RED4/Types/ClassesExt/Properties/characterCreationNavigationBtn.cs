namespace WolvenKit.RED4.Types;

public partial class characterCreationNavigationBtn
{
    [RED("supportsHoldInput")]
    public new CBool SupportsHoldInput
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}
