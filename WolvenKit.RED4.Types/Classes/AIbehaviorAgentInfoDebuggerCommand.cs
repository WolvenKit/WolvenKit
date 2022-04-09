using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorAgentInfoDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("agentName")] 
		public CString AgentName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<AIbehaviorAgentInfoDebuggerCommandEntry> Entries
		{
			get => GetPropertyValue<CArray<AIbehaviorAgentInfoDebuggerCommandEntry>>();
			set => SetPropertyValue<CArray<AIbehaviorAgentInfoDebuggerCommandEntry>>(value);
		}

		public AIbehaviorAgentInfoDebuggerCommand()
		{
			EntityId = new();
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
