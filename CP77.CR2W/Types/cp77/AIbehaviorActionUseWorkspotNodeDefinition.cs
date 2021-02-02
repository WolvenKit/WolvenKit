using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionUseWorkspotNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("eventData")] public CHandle<AIArgumentMapping> EventData { get; set; }
		[Ordinal(1)]  [RED("playStartAnimationAfterwards")] public CHandle<AIArgumentMapping> PlayStartAnimationAfterwards { get; set; }
		[Ordinal(2)]  [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
		[Ordinal(3)]  [RED("dependentWorkspotData")] public CHandle<AIArgumentMapping> DependentWorkspotData { get; set; }
		[Ordinal(4)]  [RED("playExitAutomatically")] public CHandle<AIArgumentMapping> PlayExitAutomatically { get; set; }
		[Ordinal(5)]  [RED("markUninterruptable")] public CHandle<AIArgumentMapping> MarkUninterruptable { get; set; }

		public AIbehaviorActionUseWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
