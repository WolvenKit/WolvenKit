using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShouldRetreatBehaviorStop : PreventionConditionAbstract
	{
		[Ordinal(0)] 
		[RED("agentRegistry")] 
		public CHandle<PoliceAgentRegistry> AgentRegistry
		{
			get => GetPropertyValue<CHandle<PoliceAgentRegistry>>();
			set => SetPropertyValue<CHandle<PoliceAgentRegistry>>(value);
		}

		public ShouldRetreatBehaviorStop()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
