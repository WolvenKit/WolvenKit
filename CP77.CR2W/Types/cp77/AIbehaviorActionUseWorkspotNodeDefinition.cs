using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionUseWorkspotNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("dependentWorkspotData")] public CHandle<AIArgumentMapping> DependentWorkspotData { get; set; }
		[Ordinal(1)]  [RED("eventData")] public CHandle<AIArgumentMapping> EventData { get; set; }
		[Ordinal(2)]  [RED("markUninterruptable")] public CHandle<AIArgumentMapping> MarkUninterruptable { get; set; }
		[Ordinal(3)]  [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
		[Ordinal(4)]  [RED("playExitAutomatically")] public CHandle<AIArgumentMapping> PlayExitAutomatically { get; set; }
		[Ordinal(5)]  [RED("playStartAnimationAfterwards")] public CHandle<AIArgumentMapping> PlayStartAnimationAfterwards { get; set; }

		public AIbehaviorActionUseWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
