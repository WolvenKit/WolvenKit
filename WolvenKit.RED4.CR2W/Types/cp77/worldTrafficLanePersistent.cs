using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLanePersistent : CVariable
	{
		[Ordinal(0)] [RED("outLanes")] public CArray<worldTrafficConnectivityOutLane> OutLanes { get; set; }
		[Ordinal(1)] [RED("inLanes")] public CArray<worldTrafficConnectivityInLane> InLanes { get; set; }
		[Ordinal(2)] [RED("outline")] public CArray<Vector3> Outline { get; set; }
		[Ordinal(3)] [RED("accumulatedLengths")] public CArray<CFloat> AccumulatedLengths { get; set; }
		[Ordinal(4)] [RED("crowdCreationInfo")] public worldTrafficLaneCrowdCreationInfo CrowdCreationInfo { get; set; }
		[Ordinal(5)] [RED("maxSpeed")] public CUInt8 MaxSpeed { get; set; }
		[Ordinal(6)] [RED("deadEndStart")] public CFloat DeadEndStart { get; set; }
		[Ordinal(7)] [RED("length")] public CFloat Length { get; set; }
		[Ordinal(8)] [RED("width")] public CFloat Width { get; set; }
		[Ordinal(9)] [RED("area")] public CFloat Area { get; set; }
		[Ordinal(10)] [RED("flags")] public CUInt16 Flags { get; set; }
		[Ordinal(11)] [RED("subGraphId")] public CUInt16 SubGraphId { get; set; }
		[Ordinal(12)] [RED("playerGPSInfo")] public worldTrafficLanePlayerGPSInfo PlayerGPSInfo { get; set; }
		[Ordinal(13)] [RED("neighborGroupIndex")] public CUInt16 NeighborGroupIndex { get; set; }
		[Ordinal(14)] [RED("nodeRefHash")] public CUInt64 NodeRefHash { get; set; }
		[Ordinal(15)] [RED("laneNumber")] public CUInt16 LaneNumber { get; set; }
		[Ordinal(16)] [RED("seqNumber")] public CUInt16 SeqNumber { get; set; }
		[Ordinal(17)] [RED("isReversed")] public CBool IsReversed { get; set; }
		[Ordinal(18)] [RED("roadMaterials")] public CArray<worldRoadMaterialInfo> RoadMaterials { get; set; }
		[Ordinal(19)] [RED("polygon")] public CArray<Vector2> Polygon { get; set; }

		public worldTrafficLanePersistent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
