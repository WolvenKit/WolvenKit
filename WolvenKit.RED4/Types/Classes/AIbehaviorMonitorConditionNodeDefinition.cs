using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorMonitorConditionNodeDefinition : AIbehaviorConditionNodeDefinition
	{
		[Ordinal(3)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIbehaviorMonitorConditionNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
