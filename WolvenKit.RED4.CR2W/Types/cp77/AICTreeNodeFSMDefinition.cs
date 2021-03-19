using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeFSMDefinition : AICTreeNodeCompositeDefinition
	{
		private CUInt16 _defaultState;
		private CArray<AIFSMTransitionDefinition> _transitions;
		private CArray<AIFSMEventTransitionsListDefinition> _onEventTransitions;
		private CArray<AIFSMStateDefinition> _states;
		private AISharedVarTableDefinition _sharedVars;

		[Ordinal(0)] 
		[RED("defaultState")] 
		public CUInt16 DefaultState
		{
			get => GetProperty(ref _defaultState);
			set => SetProperty(ref _defaultState, value);
		}

		[Ordinal(1)] 
		[RED("transitions")] 
		public CArray<AIFSMTransitionDefinition> Transitions
		{
			get => GetProperty(ref _transitions);
			set => SetProperty(ref _transitions, value);
		}

		[Ordinal(2)] 
		[RED("onEventTransitions")] 
		public CArray<AIFSMEventTransitionsListDefinition> OnEventTransitions
		{
			get => GetProperty(ref _onEventTransitions);
			set => SetProperty(ref _onEventTransitions, value);
		}

		[Ordinal(3)] 
		[RED("states")] 
		public CArray<AIFSMStateDefinition> States
		{
			get => GetProperty(ref _states);
			set => SetProperty(ref _states, value);
		}

		[Ordinal(4)] 
		[RED("sharedVars")] 
		public AISharedVarTableDefinition SharedVars
		{
			get => GetProperty(ref _sharedVars);
			set => SetProperty(ref _sharedVars, value);
		}

		public AICTreeNodeFSMDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
