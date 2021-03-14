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
			get
			{
				if (_agentID == null)
				{
					_agentID = (entEntityID) CR2WTypeManager.Create("entEntityID", "agentID", cr2w, this);
				}
				return _agentID;
			}
			set
			{
				if (_agentID == value)
				{
					return;
				}
				_agentID = value;
				PropertySet(this);
			}
		}

		public ReprimandAgentDisconnectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
