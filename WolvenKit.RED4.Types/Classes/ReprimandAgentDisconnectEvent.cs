using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReprimandAgentDisconnectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("agentID")] 
		public entEntityID AgentID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public ReprimandAgentDisconnectEvent()
		{
			AgentID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
