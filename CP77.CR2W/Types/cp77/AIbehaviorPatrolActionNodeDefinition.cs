using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPatrolActionNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("path")] public CHandle<AIArgumentMapping> Path { get; set; }
		[Ordinal(2)] [RED("patrolProgress")] public CHandle<AIArgumentMapping> PatrolProgress { get; set; }
		[Ordinal(3)] [RED("startFromClosestPoint")] public CHandle<AIArgumentMapping> StartFromClosestPoint { get; set; }
		[Ordinal(4)] [RED("playStartAnimation")] public CHandle<AIArgumentMapping> PlayStartAnimation { get; set; }
		[Ordinal(5)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
		[Ordinal(6)] [RED("dependentWorkspotData")] public CHandle<AIArgumentMapping> DependentWorkspotData { get; set; }
		[Ordinal(7)] [RED("lookAtTarget")] public CHandle<AIArgumentMapping> LookAtTarget { get; set; }

		public AIbehaviorPatrolActionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
