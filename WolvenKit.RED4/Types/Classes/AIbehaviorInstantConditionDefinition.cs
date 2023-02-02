using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorInstantConditionDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<AIbehaviorConditionDefinition> Condition
		{
			get => GetPropertyValue<CHandle<AIbehaviorConditionDefinition>>();
			set => SetPropertyValue<CHandle<AIbehaviorConditionDefinition>>(value);
		}

		public AIbehaviorInstantConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
