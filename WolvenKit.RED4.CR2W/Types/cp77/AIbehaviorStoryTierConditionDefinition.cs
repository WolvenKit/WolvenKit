using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorStoryTierConditionDefinition : AIbehaviorConditionDefinition
	{
		private CEnum<gameStoryTier> _tier;
		private CHandle<AIArgumentMapping> _storyTier;

		[Ordinal(1)] 
		[RED("tier")] 
		public CEnum<gameStoryTier> Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}

		[Ordinal(2)] 
		[RED("storyTier")] 
		public CHandle<AIArgumentMapping> StoryTier
		{
			get => GetProperty(ref _storyTier);
			set => SetProperty(ref _storyTier, value);
		}

		public AIbehaviorStoryTierConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
