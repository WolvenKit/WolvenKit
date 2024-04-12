namespace WolvenKit.RED4.Types.PhysicalScene;

using static WolvenKit.RED4.Types.Enums;

public class physicsPhysicsShape : physicsPhysicsBase
{
    [Ordinal(4)]
    [RED("parentId")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 ParentId
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(5)]
    [RED("tag")]
    [REDProperty(IsIgnored = true)]
    public CName Tag
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(6)]
    [RED("geometry")]
    [REDProperty(IsIgnored = true)]
    public CHandle<physicsShapeGeometryBase> Geometry
    {
        get => GetPropertyValue<CHandle<physicsShapeGeometryBase>>();
        set => SetPropertyValue<CHandle<physicsShapeGeometryBase>>(value);
    }

    [Ordinal(7)]
    [RED("localTransform")]
    [REDProperty(IsIgnored = true)]
    public CMatrix LocalTransform
    {
        get => GetPropertyValue<CMatrix>();
        set => SetPropertyValue<CMatrix>(value);
    }

    [Ordinal(8)]
    [RED("parentL2W")]
    [REDProperty(IsIgnored = true)]
    public CMatrix ParentL2W
    {
        get => GetPropertyValue<CMatrix>();
        set => SetPropertyValue<CMatrix>(value);
    }

    [Ordinal(9)]
    [RED("parentL2WInverted")]
    [REDProperty(IsIgnored = true)]
    public CMatrix ParentL2WInverted
    {
        get => GetPropertyValue<CMatrix>();
        set => SetPropertyValue<CMatrix>(value);
    }

    [Ordinal(10)]
    [RED("material")]
    [REDProperty(IsIgnored = true)]
    public CName Material
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(11)]
    [RED("materialApperanceOverrides")]
    [REDProperty(IsIgnored = true)]
    public CArray<physicsApperanceMaterial> MaterialApperanceOverrides
    {
        get => GetPropertyValue<CArray<physicsApperanceMaterial>>();
        set => SetPropertyValue<CArray<physicsApperanceMaterial>>(value);
    }

    [Ordinal(12)]
    [RED("isQueryShapeOnly")]
    [REDProperty(IsIgnored = true)]
    public CBool IsQueryShapeOnly
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(13)]
    [RED("isObstacle")]
    [REDProperty(IsIgnored = true)]
    public CBool IsObstacle
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(14)]
    [RED("volumeModifier")]
    [REDProperty(IsIgnored = true)]
    public CFloat VolumeModifier
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(15)]
    [RED("filterData")]
    [REDProperty(IsIgnored = true)]
    public CHandle<physicsFilterData> FilterData
    {
        get => GetPropertyValue<CHandle<physicsFilterData>>();
        set => SetPropertyValue<CHandle<physicsFilterData>>(value);
    }

    [Ordinal(16)]
    [RED("extractedScale")]
    [REDProperty(IsIgnored = true)]
    public Vector4 ExtractedScale
    {
        get => GetPropertyValue<Vector4>();
        set => SetPropertyValue<Vector4>(value);
    }

    public physicsPhysicsShape()
    {
        BaseType = physicsEPhysicsBaseType.Shape;
    }
}