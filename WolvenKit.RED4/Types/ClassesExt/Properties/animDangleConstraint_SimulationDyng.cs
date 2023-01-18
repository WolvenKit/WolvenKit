namespace WolvenKit.RED4.Types;

public partial class animDangleConstraint_SimulationDyng
{
    [Ordinal(999)]
    [RED("drawDebugConstraint")]
    public CBool DrawDebugConstraint
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    partial void PostConstruct()
    {
        DrawDebugText = true;
        DrawDebugAxis = true;
        DrawDebugCollisionCapsule = true;
        DrawDebugCollisionShapes = true;
        DrawDebugConstraint = true;
    }
}