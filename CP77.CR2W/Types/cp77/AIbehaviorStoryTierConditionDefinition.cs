using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorStoryTierConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("storyTier")] public CHandle<AIArgumentMapping> StoryTier { get; set; }
		[Ordinal(1)]  [RED("tier")] public CEnum<gameStoryTier> Tier { get; set; }

		public AIbehaviorStoryTierConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
