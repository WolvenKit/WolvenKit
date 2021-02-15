using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMoveAlongTrafficPathActionNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("joinTrafficSettings")] public CHandle<AIArgumentMapping> JoinTrafficSettings { get; set; }
		[Ordinal(2)] [RED("ignoreTrafficSpots")] public CHandle<AIArgumentMapping> IgnoreTrafficSpots { get; set; }
		[Ordinal(3)] [RED("useCrowdAnimationGraph")] public CHandle<AIArgumentMapping> UseCrowdAnimationGraph { get; set; }
		[Ordinal(4)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
		[Ordinal(5)] [RED("workspotExitPositionWS")] public CHandle<AIArgumentMapping> WorkspotExitPositionWS { get; set; }
		[Ordinal(6)] [RED("workspotReturnPositionVector")] public CHandle<AIArgumentMapping> WorkspotReturnPositionVector { get; set; }
		[Ordinal(7)] [RED("workspotExitTangent")] public CHandle<AIArgumentMapping> WorkspotExitTangent { get; set; }
		[Ordinal(8)] [RED("trafficLaneReturnTangent")] public CHandle<AIArgumentMapping> TrafficLaneReturnTangent { get; set; }
		[Ordinal(9)] [RED("trafficLaneExitTangent")] public CHandle<AIArgumentMapping> TrafficLaneExitTangent { get; set; }

		public AIbehaviorMoveAlongTrafficPathActionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
