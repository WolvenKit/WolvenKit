using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorStoryActionConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<AIbehaviorStoryActionType> Action
		{
			get => GetPropertyValue<CEnum<AIbehaviorStoryActionType>>();
			set => SetPropertyValue<CEnum<AIbehaviorStoryActionType>>(value);
		}

		public AIbehaviorStoryActionConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
