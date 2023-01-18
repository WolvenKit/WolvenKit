namespace WolvenKit.RED4.Types;

public partial class animAnimNode_LookAtController
{
    [Ordinal(1002)]
    [RED("debugDrawingEnabled")]
    public CBool DebugDrawingEnabled
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}