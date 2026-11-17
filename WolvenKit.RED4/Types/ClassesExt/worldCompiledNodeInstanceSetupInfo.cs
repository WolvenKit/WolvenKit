using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types;

public partial class worldCompiledNodeInstanceSetupInfo
{
    [RED("transform")]
    [REDProperty(IsIgnored = true)]
    public Transform Transform
    {
        get => GetPropertyValue<Transform>();
        set => SetPropertyValue<Transform>(value);
    }

    [RED("scale")]
    [REDProperty(IsIgnored = true)]
    public Vector3 Scale
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }

    [RED("secondaryRefPointPosition")]
    [REDProperty(IsIgnored = true)]
    public Vector3 SecondaryRefPointPosition
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }

    [RED("streamingRefPoint")]
    [REDProperty(IsIgnored = true)]
    public Vector3 StreamingRefPoint
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }

    [RED("preboostStreamingRefPoint")]
    [REDProperty(IsIgnored = true)]
    public Vector3 PreboostStreamingRefPoint
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }

    [RED("patchedNode")]
    [REDProperty(IsIgnored = true)]
    public NodeRef PatchedNode
    {
        get => GetPropertyValue<NodeRef>();
        set => SetPropertyValue<NodeRef>(value);
    }

    [RED("globalNodeId")]
    [REDProperty(IsIgnored = true)]
    public worldGlobalNodeID GlobalNodeId
    {
        get => GetPropertyValue<worldGlobalNodeID>();
        set => SetPropertyValue<worldGlobalNodeID>(value);
    }

    [RED("proxyMeshId")]
    [REDProperty(IsIgnored = true)]
    public worldGlobalNodeID ProxyMeshId
    {
        get => GetPropertyValue<worldGlobalNodeID>();
        set => SetPropertyValue<worldGlobalNodeID>(value);
    }

    [RED("externalInplaceResourceHash")]
    [REDProperty(IsIgnored = true)]
    public CResourceReference<worldCookedPrefabData> ExternalInplaceResourceHash
    {
        get => GetPropertyValue<CResourceReference<worldCookedPrefabData>>();
        set => SetPropertyValue<CResourceReference<worldCookedPrefabData>>(value);
    }

    [RED("secondaryRefPointDistance")]
    [REDProperty(IsIgnored = true)]
    public CFloat SecondaryRefPointDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("streamingDistance")]
    [REDProperty(IsIgnored = true)]
    public CFloat StreamingDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("nodeIdx")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 NodeIdx
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [RED("nodeFlags")]
    [REDProperty(IsIgnored = true)]
    public CBitField<ENodeFlags> NodeFlags
    {
        get => GetPropertyValue<CBitField<ENodeFlags>>();
        set => SetPropertyValue<CBitField<ENodeFlags>>(value);
    }

    [RED("streamingPriority")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 StreamingPriority
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [RED("todvisMask")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 TodvisMask
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [RED("instanceIndex")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 InstanceIndex
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("dataGroup")]
    [REDProperty(IsIgnored = true)]
    public CEnum<worldStreamingDataGroup> DataGroup
    {
        get => GetPropertyValue<CEnum<worldStreamingDataGroup>>();
        set => SetPropertyValue<CEnum<worldStreamingDataGroup>>(value);
    }

    partial void PostConstruct()
    {
        Transform = new Transform();
        Scale = new Vector3();
        SecondaryRefPointPosition = new Vector3();
        StreamingRefPoint = new Vector3();
        PreboostStreamingRefPoint = new Vector3();
        GlobalNodeId = new worldGlobalNodeID();
        ProxyMeshId = new worldGlobalNodeID();
    }
}
