using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
