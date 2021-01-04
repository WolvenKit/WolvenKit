using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPrepareReservedCrowdWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(0)]  [RED("joinTrafficSettings")] public CHandle<AIArgumentMapping> JoinTrafficSettings { get; set; }
		[Ordinal(1)]  [RED("overrideExit")] public CHandle<AIArgumentMapping> OverrideExit { get; set; }
		[Ordinal(2)]  [RED("returnPosition")] public CHandle<AIArgumentMapping> ReturnPosition { get; set; }
		[Ordinal(3)]  [RED("returnPositionVector")] public CHandle<AIArgumentMapping> ReturnPositionVector { get; set; }
		[Ordinal(4)]  [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
		[Ordinal(5)]  [RED("workspotExitTangent")] public CHandle<AIArgumentMapping> WorkspotExitTangent { get; set; }

		public AIbehaviorPrepareReservedCrowdWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
