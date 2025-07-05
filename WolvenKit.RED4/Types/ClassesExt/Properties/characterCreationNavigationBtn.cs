namespace WolvenKit.RED4.Types;

public partial class characterCreationNavigationBtn
{
    [RED("supportsHoldInput")]
    public CBool SupportsHoldInput
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}
