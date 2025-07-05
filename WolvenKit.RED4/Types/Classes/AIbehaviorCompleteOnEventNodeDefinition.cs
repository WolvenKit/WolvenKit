using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorCompleteOnEventNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("resultOnEvent")] 
		public CEnum<AIbehaviorCompletionStatus> ResultOnEvent
		{
			get => GetPropertyValue<CEnum<AIbehaviorCompletionStatus>>();
			set => SetPropertyValue<CEnum<AIbehaviorCompletionStatus>>(value);
		}

		public AIbehaviorCompleteOnEventNodeDefinition()
		{
			ResultOnEvent = Enums.AIbehaviorCompletionStatus.SUCCESS;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
