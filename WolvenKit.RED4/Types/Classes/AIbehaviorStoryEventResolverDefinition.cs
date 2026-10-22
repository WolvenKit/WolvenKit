using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorStoryEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		[Ordinal(0)] 
		[RED("storyTier")] 
		public CHandle<AIArgumentMapping> StoryTier
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorStoryEventResolverDefinition()
		{
			StoryTier = new AIArgumentMapping { Type = Enums.AIArgumentType.Enum, DefaultValue = new CVariant(), CustomTypeName = "gameStoryTier" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
