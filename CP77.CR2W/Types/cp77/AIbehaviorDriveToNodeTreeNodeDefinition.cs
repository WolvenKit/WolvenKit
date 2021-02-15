using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveToNodeTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		[Ordinal(1)] [RED("useKinematic")] public CHandle<AIArgumentMapping> UseKinematic { get; set; }
		[Ordinal(2)] [RED("needDriver")] public CHandle<AIArgumentMapping> NeedDriver { get; set; }
		[Ordinal(3)] [RED("nodeRef")] public CHandle<AIArgumentMapping> NodeRef { get; set; }
		[Ordinal(4)] [RED("stopAtPathEnd")] public CHandle<AIArgumentMapping> StopAtPathEnd { get; set; }
		[Ordinal(5)] [RED("secureTimeOut")] public CHandle<AIArgumentMapping> SecureTimeOut { get; set; }
		[Ordinal(6)] [RED("isPlayer")] public CHandle<AIArgumentMapping> IsPlayer { get; set; }
		[Ordinal(7)] [RED("useTraffic")] public CHandle<AIArgumentMapping> UseTraffic { get; set; }
		[Ordinal(8)] [RED("speedInTraffic")] public CHandle<AIArgumentMapping> SpeedInTraffic { get; set; }
		[Ordinal(9)] [RED("forceGreenLights")] public CHandle<AIArgumentMapping> ForceGreenLights { get; set; }
		[Ordinal(10)] [RED("portals")] public CHandle<AIArgumentMapping> Portals { get; set; }
		[Ordinal(11)] [RED("trafficTryNeighborsForStart")] public CHandle<AIArgumentMapping> TrafficTryNeighborsForStart { get; set; }
		[Ordinal(12)] [RED("trafficTryNeighborsForEnd")] public CHandle<AIArgumentMapping> TrafficTryNeighborsForEnd { get; set; }

		public AIbehaviorDriveToNodeTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
