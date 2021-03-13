using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIVehicleFollowCommand : AIVehicleCommand
	{
		[Ordinal(6)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(7)] [RED("secureTimeOut")] public CFloat SecureTimeOut { get; set; }
		[Ordinal(8)] [RED("distanceMin")] public CFloat DistanceMin { get; set; }
		[Ordinal(9)] [RED("distanceMax")] public CFloat DistanceMax { get; set; }
		[Ordinal(10)] [RED("stopWhenTargetReached")] public CBool StopWhenTargetReached { get; set; }
		[Ordinal(11)] [RED("useTraffic")] public CBool UseTraffic { get; set; }
		[Ordinal(12)] [RED("trafficTryNeighborsForStart")] public CBool TrafficTryNeighborsForStart { get; set; }
		[Ordinal(13)] [RED("trafficTryNeighborsForEnd")] public CBool TrafficTryNeighborsForEnd { get; set; }
		[Ordinal(14)] [RED("allowStubMovement")] public CBool AllowStubMovement { get; set; }

		public AIVehicleFollowCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
