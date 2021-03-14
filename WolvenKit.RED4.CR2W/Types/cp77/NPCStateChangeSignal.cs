using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCStateChangeSignal : gameTaggedSignalUserData
	{
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private CBool _highLevelStateValid;
		private CEnum<gamedataNPCUpperBodyState> _upperBodyState;
		private CBool _upperBodyStateValid;
		private CEnum<gamedataNPCStanceState> _stanceState;
		private CBool _stanceStateValid;
		private CEnum<EHitReactionMode> _hitReactionModeState;
		private CBool _hitReactionModeStateValid;
		private CEnum<gamedataDefenseMode> _defenseMode;
		private CBool _defenseModeValid;
		private CEnum<gamedataLocomotionMode> _locomotionMode;
		private CBool _locomotionModeValid;
		private CEnum<gamedataNPCBehaviorState> _behaviorState;
		private CBool _behaviorStateValid;
		private CEnum<ENPCPhaseState> _phaseState;
		private CBool _phaseStateValid;

		[Ordinal(1)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get
			{
				if (_highLevelState == null)
				{
					_highLevelState = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "highLevelState", cr2w, this);
				}
				return _highLevelState;
			}
			set
			{
				if (_highLevelState == value)
				{
					return;
				}
				_highLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("highLevelStateValid")] 
		public CBool HighLevelStateValid
		{
			get
			{
				if (_highLevelStateValid == null)
				{
					_highLevelStateValid = (CBool) CR2WTypeManager.Create("Bool", "highLevelStateValid", cr2w, this);
				}
				return _highLevelStateValid;
			}
			set
			{
				if (_highLevelStateValid == value)
				{
					return;
				}
				_highLevelStateValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("upperBodyState")] 
		public CEnum<gamedataNPCUpperBodyState> UpperBodyState
		{
			get
			{
				if (_upperBodyState == null)
				{
					_upperBodyState = (CEnum<gamedataNPCUpperBodyState>) CR2WTypeManager.Create("gamedataNPCUpperBodyState", "upperBodyState", cr2w, this);
				}
				return _upperBodyState;
			}
			set
			{
				if (_upperBodyState == value)
				{
					return;
				}
				_upperBodyState = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("upperBodyStateValid")] 
		public CBool UpperBodyStateValid
		{
			get
			{
				if (_upperBodyStateValid == null)
				{
					_upperBodyStateValid = (CBool) CR2WTypeManager.Create("Bool", "upperBodyStateValid", cr2w, this);
				}
				return _upperBodyStateValid;
			}
			set
			{
				if (_upperBodyStateValid == value)
				{
					return;
				}
				_upperBodyStateValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stanceState")] 
		public CEnum<gamedataNPCStanceState> StanceState
		{
			get
			{
				if (_stanceState == null)
				{
					_stanceState = (CEnum<gamedataNPCStanceState>) CR2WTypeManager.Create("gamedataNPCStanceState", "stanceState", cr2w, this);
				}
				return _stanceState;
			}
			set
			{
				if (_stanceState == value)
				{
					return;
				}
				_stanceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("stanceStateValid")] 
		public CBool StanceStateValid
		{
			get
			{
				if (_stanceStateValid == null)
				{
					_stanceStateValid = (CBool) CR2WTypeManager.Create("Bool", "stanceStateValid", cr2w, this);
				}
				return _stanceStateValid;
			}
			set
			{
				if (_stanceStateValid == value)
				{
					return;
				}
				_stanceStateValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("hitReactionModeState")] 
		public CEnum<EHitReactionMode> HitReactionModeState
		{
			get
			{
				if (_hitReactionModeState == null)
				{
					_hitReactionModeState = (CEnum<EHitReactionMode>) CR2WTypeManager.Create("EHitReactionMode", "hitReactionModeState", cr2w, this);
				}
				return _hitReactionModeState;
			}
			set
			{
				if (_hitReactionModeState == value)
				{
					return;
				}
				_hitReactionModeState = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hitReactionModeStateValid")] 
		public CBool HitReactionModeStateValid
		{
			get
			{
				if (_hitReactionModeStateValid == null)
				{
					_hitReactionModeStateValid = (CBool) CR2WTypeManager.Create("Bool", "hitReactionModeStateValid", cr2w, this);
				}
				return _hitReactionModeStateValid;
			}
			set
			{
				if (_hitReactionModeStateValid == value)
				{
					return;
				}
				_hitReactionModeStateValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("defenseMode")] 
		public CEnum<gamedataDefenseMode> DefenseMode
		{
			get
			{
				if (_defenseMode == null)
				{
					_defenseMode = (CEnum<gamedataDefenseMode>) CR2WTypeManager.Create("gamedataDefenseMode", "defenseMode", cr2w, this);
				}
				return _defenseMode;
			}
			set
			{
				if (_defenseMode == value)
				{
					return;
				}
				_defenseMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("defenseModeValid")] 
		public CBool DefenseModeValid
		{
			get
			{
				if (_defenseModeValid == null)
				{
					_defenseModeValid = (CBool) CR2WTypeManager.Create("Bool", "defenseModeValid", cr2w, this);
				}
				return _defenseModeValid;
			}
			set
			{
				if (_defenseModeValid == value)
				{
					return;
				}
				_defenseModeValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("locomotionMode")] 
		public CEnum<gamedataLocomotionMode> LocomotionMode
		{
			get
			{
				if (_locomotionMode == null)
				{
					_locomotionMode = (CEnum<gamedataLocomotionMode>) CR2WTypeManager.Create("gamedataLocomotionMode", "locomotionMode", cr2w, this);
				}
				return _locomotionMode;
			}
			set
			{
				if (_locomotionMode == value)
				{
					return;
				}
				_locomotionMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("locomotionModeValid")] 
		public CBool LocomotionModeValid
		{
			get
			{
				if (_locomotionModeValid == null)
				{
					_locomotionModeValid = (CBool) CR2WTypeManager.Create("Bool", "locomotionModeValid", cr2w, this);
				}
				return _locomotionModeValid;
			}
			set
			{
				if (_locomotionModeValid == value)
				{
					return;
				}
				_locomotionModeValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("behaviorState")] 
		public CEnum<gamedataNPCBehaviorState> BehaviorState
		{
			get
			{
				if (_behaviorState == null)
				{
					_behaviorState = (CEnum<gamedataNPCBehaviorState>) CR2WTypeManager.Create("gamedataNPCBehaviorState", "behaviorState", cr2w, this);
				}
				return _behaviorState;
			}
			set
			{
				if (_behaviorState == value)
				{
					return;
				}
				_behaviorState = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("behaviorStateValid")] 
		public CBool BehaviorStateValid
		{
			get
			{
				if (_behaviorStateValid == null)
				{
					_behaviorStateValid = (CBool) CR2WTypeManager.Create("Bool", "behaviorStateValid", cr2w, this);
				}
				return _behaviorStateValid;
			}
			set
			{
				if (_behaviorStateValid == value)
				{
					return;
				}
				_behaviorStateValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("phaseState")] 
		public CEnum<ENPCPhaseState> PhaseState
		{
			get
			{
				if (_phaseState == null)
				{
					_phaseState = (CEnum<ENPCPhaseState>) CR2WTypeManager.Create("ENPCPhaseState", "phaseState", cr2w, this);
				}
				return _phaseState;
			}
			set
			{
				if (_phaseState == value)
				{
					return;
				}
				_phaseState = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("phaseStateValid")] 
		public CBool PhaseStateValid
		{
			get
			{
				if (_phaseStateValid == null)
				{
					_phaseStateValid = (CBool) CR2WTypeManager.Create("Bool", "phaseStateValid", cr2w, this);
				}
				return _phaseStateValid;
			}
			set
			{
				if (_phaseStateValid == value)
				{
					return;
				}
				_phaseStateValid = value;
				PropertySet(this);
			}
		}

		public NPCStateChangeSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
