using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(0)]  [RED("dependentWorkspotData")] public CHandle<AIArgumentMapping> DependentWorkspotData { get; set; }
		[Ordinal(1)]  [RED("fastForwardAfterTeleport")] public CHandle<AIArgumentMapping> FastForwardAfterTeleport { get; set; }
		[Ordinal(2)]  [RED("repeatChild")] public CBool RepeatChild { get; set; }
		[Ordinal(3)]  [RED("spotInstance")] public CHandle<AIArgumentMapping> SpotInstance { get; set; }
		[Ordinal(4)]  [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }

		public AIbehaviorSelectWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
