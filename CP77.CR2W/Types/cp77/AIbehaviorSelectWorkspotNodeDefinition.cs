using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(0)]  [RED("spotInstance")] public CHandle<AIArgumentMapping> SpotInstance { get; set; }
		[Ordinal(1)]  [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
		[Ordinal(2)]  [RED("dependentWorkspotData")] public CHandle<AIArgumentMapping> DependentWorkspotData { get; set; }
		[Ordinal(3)]  [RED("fastForwardAfterTeleport")] public CHandle<AIArgumentMapping> FastForwardAfterTeleport { get; set; }
		[Ordinal(4)]  [RED("repeatChild")] public CBool RepeatChild { get; set; }

		public AIbehaviorSelectWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
