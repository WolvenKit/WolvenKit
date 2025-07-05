using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorEventWithTagConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("consumeEvent")] 
		public CBool ConsumeEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorEventWithTagConditionDefinition()
		{
			ConsumeEvent = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
