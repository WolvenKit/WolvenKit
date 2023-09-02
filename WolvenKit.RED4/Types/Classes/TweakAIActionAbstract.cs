using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class TweakAIActionAbstract : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("actionRecord")] 
		public CWeakHandle<gamedataAIAction_Record> ActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIAction_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("actionDebugName")] 
		public CString ActionDebugName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("actionActivationTimeStamp")] 
		public CFloat ActionActivationTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("startActionTimeStamp")] 
		public CFloat StartActionTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("hasGracefulInterruptionConditions")] 
		public CBool HasGracefulInterruptionConditions
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("gracefulInterruptionCheckRandomizedInterval")] 
		public CFloat GracefulInterruptionCheckRandomizedInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("gracefullyInterrupted")] 
		public CBool GracefullyInterrupted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("actionPhase")] 
		public CEnum<EAIActionPhase> ActionPhase
		{
			get => GetPropertyValue<CEnum<EAIActionPhase>>();
			set => SetPropertyValue<CEnum<EAIActionPhase>>(value);
		}

		[Ordinal(8)] 
		[RED("phaseRecord")] 
		public CWeakHandle<gamedataAIActionPhase_Record> PhaseRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionPhase_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionPhase_Record>>(value);
		}

		[Ordinal(9)] 
		[RED("nextPhaseConditionCount")] 
		public CInt32 NextPhaseConditionCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("repeatPhaseConditionCount")] 
		public CInt32 RepeatPhaseConditionCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("phaseActivationTimeStamp")] 
		public CFloat PhaseActivationTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("phaseConditionSuccessfulCheckTimeStamp")] 
		public CFloat PhaseConditionSuccessfulCheckTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("phaseConditionCheckTimeStamp")] 
		public CFloat PhaseConditionCheckTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("phaseConditionCheckRandomizedInterval")] 
		public CFloat PhaseConditionCheckRandomizedInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("phaseIteration")] 
		public CUInt32 PhaseIteration
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(16)] 
		[RED("phaseDuration")] 
		public CFloat PhaseDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("phaseAnimationDuration")] 
		public CFloat PhaseAnimationDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("lookatEvents")] 
		public CArray<CHandle<entLookAtAddEvent>> LookatEvents
		{
			get => GetPropertyValue<CArray<CHandle<entLookAtAddEvent>>>();
			set => SetPropertyValue<CArray<CHandle<entLookAtAddEvent>>>(value);
		}

		[Ordinal(19)] 
		[RED("movePolicy")] 
		public CHandle<movePolicies> MovePolicy
		{
			get => GetPropertyValue<CHandle<movePolicies>>();
			set => SetPropertyValue<CHandle<movePolicies>>(value);
		}

		[Ordinal(20)] 
		[RED("generalSubActionsResults", 8)] 
		public CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> GeneralSubActionsResults
		{
			get => GetPropertyValue<CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>>>();
			set => SetPropertyValue<CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>>>(value);
		}

		[Ordinal(21)] 
		[RED("phaseSubActionsResults", 8)] 
		public CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> PhaseSubActionsResults
		{
			get => GetPropertyValue<CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>>>();
			set => SetPropertyValue<CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>>>(value);
		}

		[Ordinal(22)] 
		[RED("phaseSubActionsCount")] 
		public CInt32 PhaseSubActionsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("generalSubActionsCount")] 
		public CInt32 GeneralSubActionsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("repeatPhaseConditionsCount")] 
		public CInt32 RepeatPhaseConditionsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("tickForActionDurationOnly")] 
		public CBool TickForActionDurationOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("tickForActionDurationActivePhase")] 
		public CEnum<EAIActionPhase> TickForActionDurationActivePhase
		{
			get => GetPropertyValue<CEnum<EAIActionPhase>>();
			set => SetPropertyValue<CEnum<EAIActionPhase>>(value);
		}

		[Ordinal(27)] 
		[RED("hasTicketDeactivationConditions")] 
		public CBool HasTicketDeactivationConditions
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("isActionImmediate")] 
		public CBool IsActionImmediate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("lookatActivated")] 
		public CBool LookatActivated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("ticketsCommited")] 
		public CBool TicketsCommited
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("ticketsAcknowledged")] 
		public CBool TicketsAcknowledged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("failureStatus")] 
		public CBool FailureStatus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("animationLoaded")] 
		public CBool AnimationLoaded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("initializedAfterActivation")] 
		public CBool InitializedAfterActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("shouldCallGetActionRecordAgain")] 
		public CBool ShouldCallGetActionRecordAgain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TweakAIActionAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
