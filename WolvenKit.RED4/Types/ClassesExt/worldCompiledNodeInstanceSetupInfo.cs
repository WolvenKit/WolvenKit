using WolvenKit.RED4.Archive.Buffer;

namespace WolvenKit.RED4.Types;

public partial class worldCompiledNodeInstanceSetupInfo
{
    [RED("transform")] // 0 - 32
    public Transform Transform
    {
        get => GetPropertyValue<Transform>();
        set => SetPropertyValue<Transform>(value);
    }

    [RED("scale")]  // 32 - 44
    public Vector3 Scale
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }

    [RED("secondaryRefPointPosition")] // 44 - 56
    public Vector3 SecondaryRefPointPosition
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }

    [RED("streamingRefPoint")] // 56 - 68
    public Vector3 StreamingRefPoint
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }

    [RED("uk08")] // 68 - 80
    public Vector3 Uk08
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }

    [RED("id")] // 80 - 88
    public CUInt64 Id
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [RED("globalNodeId")] // 88 - 96
    public worldGlobalNodeID GlobalNodeId
    {
        get => GetPropertyValue<worldGlobalNodeID>();
        set => SetPropertyValue<worldGlobalNodeID>(value);
    }

    [RED("uk09")] // 96 - 104
    public NodeRef Uk09
    {
        get => GetPropertyValue<NodeRef>();
        set => SetPropertyValue<NodeRef>(value);
    }

    [RED("cookedPrefabData")] // 104 - 112
    public CResourceReference<worldCookedPrefabData> CookedPrefabData
    {
        get => GetPropertyValue<CResourceReference<worldCookedPrefabData>>();
        set => SetPropertyValue<CResourceReference<worldCookedPrefabData>>(value);
    }

    [RED("secondaryRefPointDistance")] // 112 - 116
    public CFloat SecondaryRefPointDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("streamingDistance")] // 116 - 120
    public CFloat StreamingDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("nodeIndex")] // 120 - 122
    public CUInt16 NodeIndex
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("uk10")] // 122 - 124
    public CUInt16 Uk10
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("uk11")] // 124 - 126
    public CUInt16 Uk11
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("uk12")] // 126 - 128
    public CUInt16 Uk12
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("uk13")] // 128 - 136, new in 2.0
    public CUInt64 Uk13
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [RED("uk14")] // 136 - 144, new in 2.0
    public CUInt64 Uk14
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    partial void PostConstruct()
    {
        Transform = new();
        Scale = new();
        SecondaryRefPointPosition = new();
        StreamingRefPoint = new();
        Uk08 = new();
        GlobalNodeId = new();
    }

    public static worldCompiledNodeInstanceSetupInfo FromWorldNodeData(worldNodeData worldNodeData) =>
        new()
        {
            Transform = new Transform
            {
                Position = worldNodeData.Position, 
                Orientation = worldNodeData.Orientation
            },
            Scale = worldNodeData.Scale,
            SecondaryRefPointPosition = worldNodeData.Pivot,
            StreamingRefPoint = new Vector3
            {
                X = worldNodeData.Bounds.Min.X,
                Y = worldNodeData.Bounds.Min.Y,
                Z = worldNodeData.Bounds.Min.Z
            },
            Uk08 = new Vector3 
            {
                X = worldNodeData.Bounds.Max.X,
                Y = worldNodeData.Bounds.Max.Y,
                Z = worldNodeData.Bounds.Max.Z
            },
            Id = worldNodeData.Id,
            GlobalNodeId = new worldGlobalNodeID
            {
                Hash = (ulong)worldNodeData.QuestPrefabRefHash
            },
            Uk09 = worldNodeData.UkHash1,
            CookedPrefabData = worldNodeData.CookedPrefabData,
            SecondaryRefPointDistance = worldNodeData.MaxStreamingDistance,
            StreamingDistance = worldNodeData.UkFloat1,
            NodeIndex = worldNodeData.NodeIndex,
            Uk10 = worldNodeData.Uk10,
            Uk11 = worldNodeData.Uk11,
            Uk12 = worldNodeData.Uk12,
            Uk13 = worldNodeData.Uk13,
            Uk14 = worldNodeData.Uk14
        };
}