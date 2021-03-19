using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StateMachine_ : animAnimNode_Base
	{
		private CArray<CHandle<animAnimNode_State>> _states;
		private CHandle<animAnimNode_StateFrozen> _frozenState;
		private CArray<CHandle<animAnimStateTransitionDescription>> _transitions;
		private CArray<CHandle<animAnimStateMachineConditionalEntry>> _conditionalEntries;
		private CArray<CHandle<animAnimStateTransitionDescription>> _globalTransitions;
		private CHandle<animIAnimStateTransitionInterpolator> _anyStateInterpolator;
		private CUInt32 _defaultStateIndex;
		private CBool _notifyOnEnterState;

		[Ordinal(11)] 
		[RED("states")] 
		public CArray<CHandle<animAnimNode_State>> States
		{
			get => GetProperty(ref _states);
			set => SetProperty(ref _states, value);
		}

		[Ordinal(12)] 
		[RED("frozenState")] 
		public CHandle<animAnimNode_StateFrozen> FrozenState
		{
			get => GetProperty(ref _frozenState);
			set => SetProperty(ref _frozenState, value);
		}

		[Ordinal(13)] 
		[RED("transitions")] 
		public CArray<CHandle<animAnimStateTransitionDescription>> Transitions
		{
			get => GetProperty(ref _transitions);
			set => SetProperty(ref _transitions, value);
		}

		[Ordinal(14)] 
		[RED("conditionalEntries")] 
		public CArray<CHandle<animAnimStateMachineConditionalEntry>> ConditionalEntries
		{
			get => GetProperty(ref _conditionalEntries);
			set => SetProperty(ref _conditionalEntries, value);
		}

		[Ordinal(15)] 
		[RED("globalTransitions")] 
		public CArray<CHandle<animAnimStateTransitionDescription>> GlobalTransitions
		{
			get => GetProperty(ref _globalTransitions);
			set => SetProperty(ref _globalTransitions, value);
		}

		[Ordinal(16)] 
		[RED("anyStateInterpolator")] 
		public CHandle<animIAnimStateTransitionInterpolator> AnyStateInterpolator
		{
			get => GetProperty(ref _anyStateInterpolator);
			set => SetProperty(ref _anyStateInterpolator, value);
		}

		[Ordinal(17)] 
		[RED("defaultStateIndex")] 
		public CUInt32 DefaultStateIndex
		{
			get => GetProperty(ref _defaultStateIndex);
			set => SetProperty(ref _defaultStateIndex, value);
		}

		[Ordinal(18)] 
		[RED("notifyOnEnterState")] 
		public CBool NotifyOnEnterState
		{
			get => GetProperty(ref _notifyOnEnterState);
			set => SetProperty(ref _notifyOnEnterState, value);
		}

		public animAnimNode_StateMachine_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
