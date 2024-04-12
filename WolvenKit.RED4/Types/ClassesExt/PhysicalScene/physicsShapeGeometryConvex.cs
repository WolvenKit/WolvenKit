namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsShapeGeometryConvex : physicsShapeGeometryBase
{
    [Ordinal(1)]
    [RED("vertexPositions")]
    [REDProperty(IsIgnored = true)]
    public CArray<Vector3> VertexPositions
    {
        get => GetPropertyValue<CArray<Vector3>>();
        set => SetPropertyValue<CArray<Vector3>>(value);
    }

    [Ordinal(2)]
    [RED("vertexCount")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 VertexCount
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(3)]
    [RED("indices")]
    [REDProperty(IsIgnored = true)]
    public CArray<CUInt32> Indices
    {
        get => GetPropertyValue<CArray<CUInt32>>();
        set => SetPropertyValue<CArray<CUInt32>>(value);
    }

    public physicsShapeGeometryConvex()
    {
        ShapeType = physicsEPhysicsShapeGeometryType.Convex;
    }
}