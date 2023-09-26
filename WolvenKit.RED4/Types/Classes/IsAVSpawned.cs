using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsAVSpawned : PreventionConditionAbstract
	{
		[Ordinal(0)] 
		[RED("agentRegistry")] 
		public CHandle<PoliceAgentRegistry> AgentRegistry
		{
			get => GetPropertyValue<CHandle<PoliceAgentRegistry>>();
			set => SetPropertyValue<CHandle<PoliceAgentRegistry>>(value);
		}

		[Ordinal(1)] 
		[RED("prevSys")] 
		public CHandle<PreventionSystem> PrevSys
		{
			get => GetPropertyValue<CHandle<PreventionSystem>>();
			set => SetPropertyValue<CHandle<PreventionSystem>>(value);
		}

		public IsAVSpawned()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
