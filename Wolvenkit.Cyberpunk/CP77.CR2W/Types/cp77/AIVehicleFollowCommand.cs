using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIVehicleFollowCommand : AIVehicleCommand
	{
		[Ordinal(0)]  [RED("allowStubMovement")] public CBool AllowStubMovement { get; set; }
		[Ordinal(1)]  [RED("distanceMax")] public CFloat DistanceMax { get; set; }
		[Ordinal(2)]  [RED("distanceMin")] public CFloat DistanceMin { get; set; }
		[Ordinal(3)]  [RED("secureTimeOut")] public CFloat SecureTimeOut { get; set; }
		[Ordinal(4)]  [RED("stopWhenTargetReached")] public CBool StopWhenTargetReached { get; set; }
		[Ordinal(5)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(6)]  [RED("trafficTryNeighborsForEnd")] public CBool TrafficTryNeighborsForEnd { get; set; }
		[Ordinal(7)]  [RED("trafficTryNeighborsForStart")] public CBool TrafficTryNeighborsForStart { get; set; }
		[Ordinal(8)]  [RED("useTraffic")] public CBool UseTraffic { get; set; }

		public AIVehicleFollowCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
