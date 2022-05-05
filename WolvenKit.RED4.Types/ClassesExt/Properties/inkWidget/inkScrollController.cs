namespace WolvenKit.RED4.Types;

public partial class inkScrollController
{
    [OrdinalOverride(After = 7)]
    [RED("contentSmallerThanViewport")]
    public CBool ContentSmallerThanViewport
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}
