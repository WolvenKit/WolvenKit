using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questvehicleToNodeParams : questVehicleSpecificCommandParams
	{
		[Ordinal(0)]  [RED("forceGreenLights")] public CBool ForceGreenLights { get; set; }
		[Ordinal(1)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(3)]  [RED("portals")] public CHandle<vehiclePortalsList> Portals { get; set; }
		[Ordinal(4)]  [RED("speedInTraffic")] public CFloat SpeedInTraffic { get; set; }
		[Ordinal(5)]  [RED("stopAtEnd")] public CBool StopAtEnd { get; set; }
		[Ordinal(6)]  [RED("trafficTryNeighborsForEnd")] public CBool TrafficTryNeighborsForEnd { get; set; }
		[Ordinal(7)]  [RED("trafficTryNeighborsForStart")] public CBool TrafficTryNeighborsForStart { get; set; }
		[Ordinal(8)]  [RED("useTraffic")] public CBool UseTraffic { get; set; }

		public questvehicleToNodeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
