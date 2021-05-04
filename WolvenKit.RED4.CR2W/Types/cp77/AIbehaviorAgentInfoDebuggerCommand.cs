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
			get => GetProperty(ref _entityId);
			set => SetProperty(ref _entityId, value);
		}

		[Ordinal(1)] 
		[RED("agentName")] 
		public CString AgentName
		{
			get => GetProperty(ref _agentName);
			set => SetProperty(ref _agentName, value);
		}

		[Ordinal(2)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<AIbehaviorAgentInfoDebuggerCommandEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		public AIbehaviorAgentInfoDebuggerCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
