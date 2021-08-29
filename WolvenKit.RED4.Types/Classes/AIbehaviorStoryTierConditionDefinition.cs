using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorStoryTierConditionDefinition : AIbehaviorConditionDefinition
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
	}
}
