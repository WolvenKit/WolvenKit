using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReprimandAgentDisconnectEvent : redEvent
	{
		private entEntityID _agentID;

		[Ordinal(0)] 
		[RED("agentID")] 
		public entEntityID AgentID
		{
			get => GetProperty(ref _agentID);
			set => SetProperty(ref _agentID, value);
		}

		public ReprimandAgentDisconnectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
