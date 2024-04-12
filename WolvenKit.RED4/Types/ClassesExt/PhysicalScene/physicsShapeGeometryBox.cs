namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsShapeGeometryBox : physicsShapeGeometryBase
{
    [Ordinal(1)]
    [RED("halfExtents")]
    [REDProperty(IsIgnored = true)]
    public Vector4 HalfExtents
    {
        get => GetPropertyValue<Vector4>();
        set => SetPropertyValue<Vector4>(value);
    }

    public physicsShapeGeometryBox()
    {
        ShapeType = physicsEPhysicsShapeGeometryType.Box;
    }
}