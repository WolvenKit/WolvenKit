using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_StateMachine : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("states")] 
		public CArray<CHandle<animAnimNode_State>> States
		{
			get => GetPropertyValue<CArray<CHandle<animAnimNode_State>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimNode_State>>>(value);
		}

		[Ordinal(2)] 
		[RED("frozenState")] 
		public CHandle<animAnimNode_StateFrozen> FrozenState
		{
			get => GetPropertyValue<CHandle<animAnimNode_StateFrozen>>();
			set => SetPropertyValue<CHandle<animAnimNode_StateFrozen>>(value);
		}

		[Ordinal(3)] 
		[RED("transitions")] 
		public CArray<CHandle<animAnimStateTransitionDescription>> Transitions
		{
			get => GetPropertyValue<CArray<CHandle<animAnimStateTransitionDescription>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimStateTransitionDescription>>>(value);
		}

		[Ordinal(4)] 
		[RED("conditionalEntries")] 
		public CArray<CHandle<animAnimStateMachineConditionalEntry>> ConditionalEntries
		{
			get => GetPropertyValue<CArray<CHandle<animAnimStateMachineConditionalEntry>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimStateMachineConditionalEntry>>>(value);
		}

		[Ordinal(5)] 
		[RED("globalTransitions")] 
		public CArray<CHandle<animAnimStateTransitionDescription>> GlobalTransitions
		{
			get => GetPropertyValue<CArray<CHandle<animAnimStateTransitionDescription>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimStateTransitionDescription>>>(value);
		}

		[Ordinal(6)] 
		[RED("anyStateInterpolator")] 
		public CHandle<animIAnimStateTransitionInterpolator> AnyStateInterpolator
		{
			get => GetPropertyValue<CHandle<animIAnimStateTransitionInterpolator>>();
			set => SetPropertyValue<CHandle<animIAnimStateTransitionInterpolator>>(value);
		}

		[Ordinal(7)] 
		[RED("defaultStateIndex")] 
		public CUInt32 DefaultStateIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("notifyOnEnterState")] 
		public CBool NotifyOnEnterState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_StateMachine()
		{
			Id = uint.MaxValue;
			States = new();
			Transitions = new();
			ConditionalEntries = new();
			GlobalTransitions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
