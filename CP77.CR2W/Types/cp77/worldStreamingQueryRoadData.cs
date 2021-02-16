using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStreamingQueryRoadData : CVariable
	{
		[Ordinal(0)] [RED("transform")] public Transform Transform { get; set; }
		[Ordinal(1)] [RED("splineData")] public CHandle<Spline> SplineData { get; set; }
		[Ordinal(2)] [RED("roadGlobalNodeId")] public worldGlobalNodeID RoadGlobalNodeId { get; set; }
		[Ordinal(3)] [RED("totalRoadWidth")] public CFloat TotalRoadWidth { get; set; }
		[Ordinal(4)] [RED("connectedRoadsStartIndex")] public CUInt16 ConnectedRoadsStartIndex { get; set; }
		[Ordinal(5)] [RED("connectedRoadsCount")] public CUInt16 ConnectedRoadsCount { get; set; }

		public worldStreamingQueryRoadData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
