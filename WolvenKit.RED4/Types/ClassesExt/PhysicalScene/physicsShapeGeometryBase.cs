namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsShapeGeometryBase : ISerializable
{
    [Ordinal(0)]
    [RED("shapeType")]
    [REDProperty(IsIgnored = true)]
    public CEnum<physicsEPhysicsShapeGeometryType> ShapeType
    {
        get => GetPropertyValue<CEnum<physicsEPhysicsShapeGeometryType>>();
        set => SetPropertyValue<CEnum<physicsEPhysicsShapeGeometryType>>(value);
    }
}