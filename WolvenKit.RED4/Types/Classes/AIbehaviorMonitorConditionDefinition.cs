using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorMonitorConditionDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<AIbehaviorConditionDefinition> Condition
		{
			get => GetPropertyValue<CHandle<AIbehaviorConditionDefinition>>();
			set => SetPropertyValue<CHandle<AIbehaviorConditionDefinition>>(value);
		}

		[Ordinal(1)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIbehaviorMonitorConditionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
