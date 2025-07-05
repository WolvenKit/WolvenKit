using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorEventConditionDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<AIbehaviorConditionDefinition> Condition
		{
			get => GetPropertyValue<CHandle<AIbehaviorConditionDefinition>>();
			set => SetPropertyValue<CHandle<AIbehaviorConditionDefinition>>(value);
		}

		[Ordinal(1)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AIbehaviorEventConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
