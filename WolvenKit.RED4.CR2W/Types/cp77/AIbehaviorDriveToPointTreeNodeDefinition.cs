using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveToPointTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		[Ordinal(1)] [RED("targetPosition")] public CHandle<AIArgumentMapping> TargetPosition { get; set; }
		[Ordinal(2)] [RED("secureTimeOut")] public CHandle<AIArgumentMapping> SecureTimeOut { get; set; }
		[Ordinal(3)] [RED("useTraffic")] public CHandle<AIArgumentMapping> UseTraffic { get; set; }
		[Ordinal(4)] [RED("speedInTraffic")] public CHandle<AIArgumentMapping> SpeedInTraffic { get; set; }
		[Ordinal(5)] [RED("forceGreenLights")] public CHandle<AIArgumentMapping> ForceGreenLights { get; set; }
		[Ordinal(6)] [RED("portals")] public CHandle<AIArgumentMapping> Portals { get; set; }
		[Ordinal(7)] [RED("trafficTryNeighborsForStart")] public CHandle<AIArgumentMapping> TrafficTryNeighborsForStart { get; set; }
		[Ordinal(8)] [RED("trafficTryNeighborsForEnd")] public CHandle<AIArgumentMapping> TrafficTryNeighborsForEnd { get; set; }

		public AIbehaviorDriveToPointTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
