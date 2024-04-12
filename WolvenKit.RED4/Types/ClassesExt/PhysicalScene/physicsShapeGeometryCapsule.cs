namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsShapeGeometryCapsule : physicsShapeGeometryBase
{
    [Ordinal(1)]
    [RED("radius")]
    [REDProperty(IsIgnored = true)]
    public CFloat Radius
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(2)]
    [RED("height")]
    [REDProperty(IsIgnored = true)]
    public CFloat Height
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    public physicsShapeGeometryCapsule()
    {
        ShapeType = physicsEPhysicsShapeGeometryType.Capsule;
    }
}