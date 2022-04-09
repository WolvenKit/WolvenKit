using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorStoryTierConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("tier")] 
		public CEnum<gameStoryTier> Tier
		{
			get => GetPropertyValue<CEnum<gameStoryTier>>();
			set => SetPropertyValue<CEnum<gameStoryTier>>(value);
		}

		[Ordinal(2)] 
		[RED("storyTier")] 
		public CHandle<AIArgumentMapping> StoryTier
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorStoryTierConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
