using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIVehicleToNodeCommand : AIVehicleCommand
	{
		[Ordinal(6)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(7)] [RED("stopAtPathEnd")] public CBool StopAtPathEnd { get; set; }
		[Ordinal(8)] [RED("secureTimeOut")] public CFloat SecureTimeOut { get; set; }
		[Ordinal(9)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(10)] [RED("useTraffic")] public CBool UseTraffic { get; set; }
		[Ordinal(11)] [RED("speedInTraffic")] public CFloat SpeedInTraffic { get; set; }
		[Ordinal(12)] [RED("forceGreenLights")] public CBool ForceGreenLights { get; set; }
		[Ordinal(13)] [RED("portals")] public CHandle<vehiclePortalsList> Portals { get; set; }
		[Ordinal(14)] [RED("trafficTryNeighborsForStart")] public CBool TrafficTryNeighborsForStart { get; set; }
		[Ordinal(15)] [RED("trafficTryNeighborsForEnd")] public CBool TrafficTryNeighborsForEnd { get; set; }

		public AIVehicleToNodeCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
