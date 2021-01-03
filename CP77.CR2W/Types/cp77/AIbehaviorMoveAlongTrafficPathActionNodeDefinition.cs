using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMoveAlongTrafficPathActionNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("ignoreTrafficSpots")] public CHandle<AIArgumentMapping> IgnoreTrafficSpots { get; set; }
		[Ordinal(1)]  [RED("joinTrafficSettings")] public CHandle<AIArgumentMapping> JoinTrafficSettings { get; set; }
		[Ordinal(2)]  [RED("trafficLaneExitTangent")] public CHandle<AIArgumentMapping> TrafficLaneExitTangent { get; set; }
		[Ordinal(3)]  [RED("trafficLaneReturnTangent")] public CHandle<AIArgumentMapping> TrafficLaneReturnTangent { get; set; }
		[Ordinal(4)]  [RED("useCrowdAnimationGraph")] public CHandle<AIArgumentMapping> UseCrowdAnimationGraph { get; set; }
		[Ordinal(5)]  [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
		[Ordinal(6)]  [RED("workspotExitPositionWS")] public CHandle<AIArgumentMapping> WorkspotExitPositionWS { get; set; }
		[Ordinal(7)]  [RED("workspotExitTangent")] public CHandle<AIArgumentMapping> WorkspotExitTangent { get; set; }
		[Ordinal(8)]  [RED("workspotReturnPositionVector")] public CHandle<AIArgumentMapping> WorkspotReturnPositionVector { get; set; }

		public AIbehaviorMoveAlongTrafficPathActionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
