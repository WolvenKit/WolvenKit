using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorStoryTierConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("tier")] public CEnum<gameStoryTier> Tier { get; set; }
		[Ordinal(2)] [RED("storyTier")] public CHandle<AIArgumentMapping> StoryTier { get; set; }

		public AIbehaviorStoryTierConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
