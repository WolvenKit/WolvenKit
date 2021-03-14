using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAgentInfoDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		private entEntityID _entityId;
		private CString _agentName;
		private CBool _isSelected;
		private CArray<AIbehaviorAgentInfoDebuggerCommandEntry> _entries;

		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get
			{
				if (_entityId == null)
				{
					_entityId = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityId", cr2w, this);
				}
				return _entityId;
			}
			set
			{
				if (_entityId == value)
				{
					return;
				}
				_entityId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("agentName")] 
		public CString AgentName
		{
			get
			{
				if (_agentName == null)
				{
					_agentName = (CString) CR2WTypeManager.Create("String", "agentName", cr2w, this);
				}
				return _agentName;
			}
			set
			{
				if (_agentName == value)
				{
					return;
				}
				_agentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get
			{
				if (_isSelected == null)
				{
					_isSelected = (CBool) CR2WTypeManager.Create("Bool", "isSelected", cr2w, this);
				}
				return _isSelected;
			}
			set
			{
				if (_isSelected == value)
				{
					return;
				}
				_isSelected = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<AIbehaviorAgentInfoDebuggerCommandEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<AIbehaviorAgentInfoDebuggerCommandEntry>) CR2WTypeManager.Create("array:AIbehaviorAgentInfoDebuggerCommandEntry", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		public AIbehaviorAgentInfoDebuggerCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
