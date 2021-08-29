using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorFSMTreeNodeDefinition : AIbehaviorTreeNodeDefinition
	{
		private CArray<CHandle<AIbehaviorFSMStateDefinition>> _states;
		private CArray<CHandle<AIbehaviorFSMTransitionDefinition>> _transitions;
		private CHandle<AIbehaviorFSMStateDefinition> _initialState;

		[Ordinal(0)] 
		[RED("states")] 
		public CArray<CHandle<AIbehaviorFSMStateDefinition>> States
		{
			get => GetProperty(ref _states);
			set => SetProperty(ref _states, value);
		}

		[Ordinal(1)] 
		[RED("transitions")] 
		public CArray<CHandle<AIbehaviorFSMTransitionDefinition>> Transitions
		{
			get => GetProperty(ref _transitions);
			set => SetProperty(ref _transitions, value);
		}

		[Ordinal(2)] 
		[RED("initialState")] 
		public CHandle<AIbehaviorFSMStateDefinition> InitialState
		{
			get => GetProperty(ref _initialState);
			set => SetProperty(ref _initialState, value);
		}
	}
}
