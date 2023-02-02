namespace WolvenKit.RED4.Types;

public partial class animAnimNode_Drag
{
    [Ordinal(16)]
    [RED("debugDrawingEnabled")]
    public CBool DebugDrawingEnabled
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}