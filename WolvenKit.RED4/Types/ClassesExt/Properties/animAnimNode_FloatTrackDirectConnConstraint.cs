namespace WolvenKit.RED4.Types;

public partial class animAnimNode_FloatTrackDirectConnConstraint
{
    [Ordinal(1001)]
    [RED("debug")]
    public CBool Debug
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}