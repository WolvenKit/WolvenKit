using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questvehicleFollowParams : questVehicleSpecificCommandParams
	{
		[Ordinal(0)]  [RED("distanceMax")] public CFloat DistanceMax { get; set; }
		[Ordinal(1)]  [RED("distanceMin")] public CFloat DistanceMin { get; set; }
		[Ordinal(2)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(3)]  [RED("stopWhenTargetReached")] public CBool StopWhenTargetReached { get; set; }
		[Ordinal(4)]  [RED("targetEntRef")] public gameEntityReference TargetEntRef { get; set; }
		[Ordinal(5)]  [RED("trafficTryNeighborsForEnd")] public CBool TrafficTryNeighborsForEnd { get; set; }
		[Ordinal(6)]  [RED("trafficTryNeighborsForStart")] public CBool TrafficTryNeighborsForStart { get; set; }
		[Ordinal(7)]  [RED("useTraffic")] public CBool UseTraffic { get; set; }

		public questvehicleFollowParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
