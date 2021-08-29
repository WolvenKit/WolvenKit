using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReprimandAgentDisconnectEvent : redEvent
	{
		private entEntityID _agentID;

		[Ordinal(0)] 
		[RED("agentID")] 
		public entEntityID AgentID
		{
			get => GetProperty(ref _agentID);
			set => SetProperty(ref _agentID, value);
		}
	}
}
