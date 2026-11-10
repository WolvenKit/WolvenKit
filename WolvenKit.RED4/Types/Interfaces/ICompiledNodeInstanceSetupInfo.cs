namespace WolvenKit.RED4.Types;

public interface ICompiledNodeInstanceSetupInfo : IRedType
{
    Transform Transform { get; set; }
    Vector3 Scale { get; set; }
    Vector3 SecondaryRefPointPosition { get; set; }
    Vector3 StreamingRefPoint { get; set; }
    Vector3 PreboostStreamingRefPoint { get; set; }
    NodeRef PatchedNode { get; set; }
    worldGlobalNodeID GlobalNodeId { get; set; }
    worldGlobalNodeID ProxyMeshId { get; set; }
    CUInt64 NodeIdx { get; set; }
    CUInt64 StreamingPriority { get; set; }
    CUInt64 TodvisMask { get; set; }
    CEnum<Enums.worldStreamingDataGroup> DataGroup { get; set; }
}
