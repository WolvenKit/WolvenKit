using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShouldNPCRetreatFromMaxTacEncounter : PreventionConditionAbstract
	{
		[Ordinal(0)] 
		[RED("agentRegistry")] 
		public CHandle<PoliceAgentRegistry> AgentRegistry
		{
			get => GetPropertyValue<CHandle<PoliceAgentRegistry>>();
			set => SetPropertyValue<CHandle<PoliceAgentRegistry>>(value);
		}

		[Ordinal(1)] 
		[RED("threatLocation")] 
		public AITrackedLocation ThreatLocation
		{
			get => GetPropertyValue<AITrackedLocation>();
			set => SetPropertyValue<AITrackedLocation>(value);
		}

		public ShouldNPCRetreatFromMaxTacEncounter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
