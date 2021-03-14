using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionAbstract : AIbehaviortaskScript
	{
		private wCHandle<gamedataAIAction_Record> _actionRecord;
		private CString _actionDebugName;
		private CFloat _actionActivationTimeStamp;
		private CFloat _startActionTimeStamp;
		private CEnum<EAIActionPhase> _actionPhase;
		private wCHandle<gamedataAIActionPhase_Record> _phaseRecord;
		private CInt32 _nextPhaseConditionCount;
		private CInt32 _repeatPhaseConditionCount;
		private CFloat _phaseActivationTimeStamp;
		private CFloat _phaseConditionSuccessfulCheckTimeStamp;
		private CFloat _phaseConditionCheckTimeStamp;
		private CFloat _phaseConditionCheckRandomizedInterval;
		private CUInt32 _phaseIteration;
		private CFloat _phaseDuration;
		private CFloat _phaseAnimationDuration;
		private CArray<CHandle<entLookAtAddEvent>> _lookatEvents;
		private CHandle<movePolicies> _movePolicy;
		private CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> _generalSubActionsResults;
		private CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> _phaseSubActionsResults;
		private CBool _lookatActivated;
		private CBool _ticketsCommited;
		private CBool _ticketsAcknowledged;
		private CBool _failureStatus;
		private CBool _animationLoaded;
		private CBool _gracefullyInterrupted;
		private CBool _initializedAfterActivation;
		private CBool _shouldCallGetActionRecordAgain;

		[Ordinal(0)] 
		[RED("actionRecord")] 
		public wCHandle<gamedataAIAction_Record> ActionRecord
		{
			get
			{
				if (_actionRecord == null)
				{
					_actionRecord = (wCHandle<gamedataAIAction_Record>) CR2WTypeManager.Create("whandle:gamedataAIAction_Record", "actionRecord", cr2w, this);
				}
				return _actionRecord;
			}
			set
			{
				if (_actionRecord == value)
				{
					return;
				}
				_actionRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actionDebugName")] 
		public CString ActionDebugName
		{
			get
			{
				if (_actionDebugName == null)
				{
					_actionDebugName = (CString) CR2WTypeManager.Create("String", "actionDebugName", cr2w, this);
				}
				return _actionDebugName;
			}
			set
			{
				if (_actionDebugName == value)
				{
					return;
				}
				_actionDebugName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("actionActivationTimeStamp")] 
		public CFloat ActionActivationTimeStamp
		{
			get
			{
				if (_actionActivationTimeStamp == null)
				{
					_actionActivationTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "actionActivationTimeStamp", cr2w, this);
				}
				return _actionActivationTimeStamp;
			}
			set
			{
				if (_actionActivationTimeStamp == value)
				{
					return;
				}
				_actionActivationTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("startActionTimeStamp")] 
		public CFloat StartActionTimeStamp
		{
			get
			{
				if (_startActionTimeStamp == null)
				{
					_startActionTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "startActionTimeStamp", cr2w, this);
				}
				return _startActionTimeStamp;
			}
			set
			{
				if (_startActionTimeStamp == value)
				{
					return;
				}
				_startActionTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("actionPhase")] 
		public CEnum<EAIActionPhase> ActionPhase
		{
			get
			{
				if (_actionPhase == null)
				{
					_actionPhase = (CEnum<EAIActionPhase>) CR2WTypeManager.Create("EAIActionPhase", "actionPhase", cr2w, this);
				}
				return _actionPhase;
			}
			set
			{
				if (_actionPhase == value)
				{
					return;
				}
				_actionPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("phaseRecord")] 
		public wCHandle<gamedataAIActionPhase_Record> PhaseRecord
		{
			get
			{
				if (_phaseRecord == null)
				{
					_phaseRecord = (wCHandle<gamedataAIActionPhase_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionPhase_Record", "phaseRecord", cr2w, this);
				}
				return _phaseRecord;
			}
			set
			{
				if (_phaseRecord == value)
				{
					return;
				}
				_phaseRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("nextPhaseConditionCount")] 
		public CInt32 NextPhaseConditionCount
		{
			get
			{
				if (_nextPhaseConditionCount == null)
				{
					_nextPhaseConditionCount = (CInt32) CR2WTypeManager.Create("Int32", "nextPhaseConditionCount", cr2w, this);
				}
				return _nextPhaseConditionCount;
			}
			set
			{
				if (_nextPhaseConditionCount == value)
				{
					return;
				}
				_nextPhaseConditionCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("repeatPhaseConditionCount")] 
		public CInt32 RepeatPhaseConditionCount
		{
			get
			{
				if (_repeatPhaseConditionCount == null)
				{
					_repeatPhaseConditionCount = (CInt32) CR2WTypeManager.Create("Int32", "repeatPhaseConditionCount", cr2w, this);
				}
				return _repeatPhaseConditionCount;
			}
			set
			{
				if (_repeatPhaseConditionCount == value)
				{
					return;
				}
				_repeatPhaseConditionCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("phaseActivationTimeStamp")] 
		public CFloat PhaseActivationTimeStamp
		{
			get
			{
				if (_phaseActivationTimeStamp == null)
				{
					_phaseActivationTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "phaseActivationTimeStamp", cr2w, this);
				}
				return _phaseActivationTimeStamp;
			}
			set
			{
				if (_phaseActivationTimeStamp == value)
				{
					return;
				}
				_phaseActivationTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("phaseConditionSuccessfulCheckTimeStamp")] 
		public CFloat PhaseConditionSuccessfulCheckTimeStamp
		{
			get
			{
				if (_phaseConditionSuccessfulCheckTimeStamp == null)
				{
					_phaseConditionSuccessfulCheckTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "phaseConditionSuccessfulCheckTimeStamp", cr2w, this);
				}
				return _phaseConditionSuccessfulCheckTimeStamp;
			}
			set
			{
				if (_phaseConditionSuccessfulCheckTimeStamp == value)
				{
					return;
				}
				_phaseConditionSuccessfulCheckTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("phaseConditionCheckTimeStamp")] 
		public CFloat PhaseConditionCheckTimeStamp
		{
			get
			{
				if (_phaseConditionCheckTimeStamp == null)
				{
					_phaseConditionCheckTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "phaseConditionCheckTimeStamp", cr2w, this);
				}
				return _phaseConditionCheckTimeStamp;
			}
			set
			{
				if (_phaseConditionCheckTimeStamp == value)
				{
					return;
				}
				_phaseConditionCheckTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("phaseConditionCheckRandomizedInterval")] 
		public CFloat PhaseConditionCheckRandomizedInterval
		{
			get
			{
				if (_phaseConditionCheckRandomizedInterval == null)
				{
					_phaseConditionCheckRandomizedInterval = (CFloat) CR2WTypeManager.Create("Float", "phaseConditionCheckRandomizedInterval", cr2w, this);
				}
				return _phaseConditionCheckRandomizedInterval;
			}
			set
			{
				if (_phaseConditionCheckRandomizedInterval == value)
				{
					return;
				}
				_phaseConditionCheckRandomizedInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("phaseIteration")] 
		public CUInt32 PhaseIteration
		{
			get
			{
				if (_phaseIteration == null)
				{
					_phaseIteration = (CUInt32) CR2WTypeManager.Create("Uint32", "phaseIteration", cr2w, this);
				}
				return _phaseIteration;
			}
			set
			{
				if (_phaseIteration == value)
				{
					return;
				}
				_phaseIteration = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("phaseDuration")] 
		public CFloat PhaseDuration
		{
			get
			{
				if (_phaseDuration == null)
				{
					_phaseDuration = (CFloat) CR2WTypeManager.Create("Float", "phaseDuration", cr2w, this);
				}
				return _phaseDuration;
			}
			set
			{
				if (_phaseDuration == value)
				{
					return;
				}
				_phaseDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("phaseAnimationDuration")] 
		public CFloat PhaseAnimationDuration
		{
			get
			{
				if (_phaseAnimationDuration == null)
				{
					_phaseAnimationDuration = (CFloat) CR2WTypeManager.Create("Float", "phaseAnimationDuration", cr2w, this);
				}
				return _phaseAnimationDuration;
			}
			set
			{
				if (_phaseAnimationDuration == value)
				{
					return;
				}
				_phaseAnimationDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("lookatEvents")] 
		public CArray<CHandle<entLookAtAddEvent>> LookatEvents
		{
			get
			{
				if (_lookatEvents == null)
				{
					_lookatEvents = (CArray<CHandle<entLookAtAddEvent>>) CR2WTypeManager.Create("array:handle:entLookAtAddEvent", "lookatEvents", cr2w, this);
				}
				return _lookatEvents;
			}
			set
			{
				if (_lookatEvents == value)
				{
					return;
				}
				_lookatEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("movePolicy")] 
		public CHandle<movePolicies> MovePolicy
		{
			get
			{
				if (_movePolicy == null)
				{
					_movePolicy = (CHandle<movePolicies>) CR2WTypeManager.Create("handle:movePolicies", "movePolicy", cr2w, this);
				}
				return _movePolicy;
			}
			set
			{
				if (_movePolicy == value)
				{
					return;
				}
				_movePolicy = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("generalSubActionsResults", 8)] 
		public CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> GeneralSubActionsResults
		{
			get
			{
				if (_generalSubActionsResults == null)
				{
					_generalSubActionsResults = (CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>>) CR2WTypeManager.Create("[8]AIbehaviorUpdateOutcome", "generalSubActionsResults", cr2w, this);
				}
				return _generalSubActionsResults;
			}
			set
			{
				if (_generalSubActionsResults == value)
				{
					return;
				}
				_generalSubActionsResults = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("phaseSubActionsResults", 8)] 
		public CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> PhaseSubActionsResults
		{
			get
			{
				if (_phaseSubActionsResults == null)
				{
					_phaseSubActionsResults = (CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>>) CR2WTypeManager.Create("[8]AIbehaviorUpdateOutcome", "phaseSubActionsResults", cr2w, this);
				}
				return _phaseSubActionsResults;
			}
			set
			{
				if (_phaseSubActionsResults == value)
				{
					return;
				}
				_phaseSubActionsResults = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("lookatActivated")] 
		public CBool LookatActivated
		{
			get
			{
				if (_lookatActivated == null)
				{
					_lookatActivated = (CBool) CR2WTypeManager.Create("Bool", "lookatActivated", cr2w, this);
				}
				return _lookatActivated;
			}
			set
			{
				if (_lookatActivated == value)
				{
					return;
				}
				_lookatActivated = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("ticketsCommited")] 
		public CBool TicketsCommited
		{
			get
			{
				if (_ticketsCommited == null)
				{
					_ticketsCommited = (CBool) CR2WTypeManager.Create("Bool", "ticketsCommited", cr2w, this);
				}
				return _ticketsCommited;
			}
			set
			{
				if (_ticketsCommited == value)
				{
					return;
				}
				_ticketsCommited = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("ticketsAcknowledged")] 
		public CBool TicketsAcknowledged
		{
			get
			{
				if (_ticketsAcknowledged == null)
				{
					_ticketsAcknowledged = (CBool) CR2WTypeManager.Create("Bool", "ticketsAcknowledged", cr2w, this);
				}
				return _ticketsAcknowledged;
			}
			set
			{
				if (_ticketsAcknowledged == value)
				{
					return;
				}
				_ticketsAcknowledged = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("failureStatus")] 
		public CBool FailureStatus
		{
			get
			{
				if (_failureStatus == null)
				{
					_failureStatus = (CBool) CR2WTypeManager.Create("Bool", "failureStatus", cr2w, this);
				}
				return _failureStatus;
			}
			set
			{
				if (_failureStatus == value)
				{
					return;
				}
				_failureStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("animationLoaded")] 
		public CBool AnimationLoaded
		{
			get
			{
				if (_animationLoaded == null)
				{
					_animationLoaded = (CBool) CR2WTypeManager.Create("Bool", "animationLoaded", cr2w, this);
				}
				return _animationLoaded;
			}
			set
			{
				if (_animationLoaded == value)
				{
					return;
				}
				_animationLoaded = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("gracefullyInterrupted")] 
		public CBool GracefullyInterrupted
		{
			get
			{
				if (_gracefullyInterrupted == null)
				{
					_gracefullyInterrupted = (CBool) CR2WTypeManager.Create("Bool", "gracefullyInterrupted", cr2w, this);
				}
				return _gracefullyInterrupted;
			}
			set
			{
				if (_gracefullyInterrupted == value)
				{
					return;
				}
				_gracefullyInterrupted = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("initializedAfterActivation")] 
		public CBool InitializedAfterActivation
		{
			get
			{
				if (_initializedAfterActivation == null)
				{
					_initializedAfterActivation = (CBool) CR2WTypeManager.Create("Bool", "initializedAfterActivation", cr2w, this);
				}
				return _initializedAfterActivation;
			}
			set
			{
				if (_initializedAfterActivation == value)
				{
					return;
				}
				_initializedAfterActivation = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("shouldCallGetActionRecordAgain")] 
		public CBool ShouldCallGetActionRecordAgain
		{
			get
			{
				if (_shouldCallGetActionRecordAgain == null)
				{
					_shouldCallGetActionRecordAgain = (CBool) CR2WTypeManager.Create("Bool", "shouldCallGetActionRecordAgain", cr2w, this);
				}
				return _shouldCallGetActionRecordAgain;
			}
			set
			{
				if (_shouldCallGetActionRecordAgain == value)
				{
					return;
				}
				_shouldCallGetActionRecordAgain = value;
				PropertySet(this);
			}
		}

		public TweakAIActionAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
