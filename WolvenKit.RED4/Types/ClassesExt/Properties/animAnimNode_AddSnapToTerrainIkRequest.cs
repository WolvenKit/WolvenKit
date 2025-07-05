namespace WolvenKit.RED4.Types;

public partial class animAnimNode_AddSnapToTerrainIkRequest
{
    [Ordinal(12)]
    [RED("debug")]
    public CBool Debug
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}