using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorMonitorTaskNodeDefinition : AIbehaviorTaskNodeDefinition
	{
		[Ordinal(2)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIbehaviorMonitorTaskNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
