using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeFSMDefinition : AICTreeNodeCompositeDefinition
	{
		[Ordinal(0)] 
		[RED("defaultState")] 
		public CUInt16 DefaultState
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("transitions")] 
		public CArray<AIFSMTransitionDefinition> Transitions
		{
			get => GetPropertyValue<CArray<AIFSMTransitionDefinition>>();
			set => SetPropertyValue<CArray<AIFSMTransitionDefinition>>(value);
		}

		[Ordinal(2)] 
		[RED("onEventTransitions")] 
		public CArray<AIFSMEventTransitionsListDefinition> OnEventTransitions
		{
			get => GetPropertyValue<CArray<AIFSMEventTransitionsListDefinition>>();
			set => SetPropertyValue<CArray<AIFSMEventTransitionsListDefinition>>(value);
		}

		[Ordinal(3)] 
		[RED("states")] 
		public CArray<AIFSMStateDefinition> States
		{
			get => GetPropertyValue<CArray<AIFSMStateDefinition>>();
			set => SetPropertyValue<CArray<AIFSMStateDefinition>>(value);
		}

		[Ordinal(4)] 
		[RED("sharedVars")] 
		public AISharedVarTableDefinition SharedVars
		{
			get => GetPropertyValue<AISharedVarTableDefinition>();
			set => SetPropertyValue<AISharedVarTableDefinition>(value);
		}

		public AICTreeNodeFSMDefinition()
		{
			Transitions = new();
			OnEventTransitions = new();
			States = new();
			SharedVars = new() { Table = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
