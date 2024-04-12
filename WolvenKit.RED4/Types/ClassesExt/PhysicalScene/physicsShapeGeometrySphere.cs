namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsShapeGeometrySphere : physicsShapeGeometryBase
{
    [Ordinal(1)]
    [RED("radius")]
    [REDProperty(IsIgnored = true)]
    public CFloat Radius
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    public physicsShapeGeometrySphere()
    {
        ShapeType = physicsEPhysicsShapeGeometryType.Sphere;
    }
}