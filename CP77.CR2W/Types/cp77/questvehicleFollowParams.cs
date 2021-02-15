using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questvehicleFollowParams : questVehicleSpecificCommandParams
	{
		[Ordinal(3)] [RED("targetEntRef")] public gameEntityReference TargetEntRef { get; set; }
		[Ordinal(4)] [RED("distanceMin")] public CFloat DistanceMin { get; set; }
		[Ordinal(5)] [RED("distanceMax")] public CFloat DistanceMax { get; set; }
		[Ordinal(6)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(7)] [RED("stopWhenTargetReached")] public CBool StopWhenTargetReached { get; set; }
		[Ordinal(8)] [RED("useTraffic")] public CBool UseTraffic { get; set; }
		[Ordinal(9)] [RED("trafficTryNeighborsForStart")] public CBool TrafficTryNeighborsForStart { get; set; }
		[Ordinal(10)] [RED("trafficTryNeighborsForEnd")] public CBool TrafficTryNeighborsForEnd { get; set; }

		public questvehicleFollowParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
