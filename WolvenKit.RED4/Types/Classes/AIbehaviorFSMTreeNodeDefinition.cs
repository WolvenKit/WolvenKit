using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorFSMTreeNodeDefinition : AIbehaviorTreeNodeDefinition
	{
		[Ordinal(0)] 
		[RED("states")] 
		public CArray<CHandle<AIbehaviorFSMStateDefinition>> States
		{
			get => GetPropertyValue<CArray<CHandle<AIbehaviorFSMStateDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<AIbehaviorFSMStateDefinition>>>(value);
		}

		[Ordinal(1)] 
		[RED("transitions")] 
		public CArray<CHandle<AIbehaviorFSMTransitionDefinition>> Transitions
		{
			get => GetPropertyValue<CArray<CHandle<AIbehaviorFSMTransitionDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<AIbehaviorFSMTransitionDefinition>>>(value);
		}

		[Ordinal(2)] 
		[RED("initialState")] 
		public CHandle<AIbehaviorFSMStateDefinition> InitialState
		{
			get => GetPropertyValue<CHandle<AIbehaviorFSMStateDefinition>>();
			set => SetPropertyValue<CHandle<AIbehaviorFSMStateDefinition>>(value);
		}

		public AIbehaviorFSMTreeNodeDefinition()
		{
			States = new();
			Transitions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
