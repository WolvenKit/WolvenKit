namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsShapeGeometryTriMesh : physicsShapeGeometryBase
{
    [Ordinal(1)]
    [RED("vertices")]
    [REDProperty(IsIgnored = true)]
    public CArray<Vector3> Vertices
    {
        get => GetPropertyValue<CArray<Vector3>>();
        set => SetPropertyValue<CArray<Vector3>>(value);
    }

    [Ordinal(2)]
    [RED("indices")]
    [REDProperty(IsIgnored = true)]
    public CArray<CUInt16> Indices
    {
        get => GetPropertyValue<CArray<CUInt16>>();
        set => SetPropertyValue<CArray<CUInt16>>(value);
    }

    [Ordinal(3)]
    [RED("physicalMaterials")]
    [REDProperty(IsIgnored = true)]
    public CArray<CName> PhysicalMaterials
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }

    [Ordinal(4)]
    [RED("physicalMaterialIndices")]
    [REDProperty(IsIgnored = true)]
    public CArray<CUInt16> PhysicalMaterialIndices
    {
        get => GetPropertyValue<CArray<CUInt16>>();
        set => SetPropertyValue<CArray<CUInt16>>(value);
    }

    public physicsShapeGeometryTriMesh()
    {
        ShapeType = physicsEPhysicsShapeGeometryType.TriMesh;
    }
}