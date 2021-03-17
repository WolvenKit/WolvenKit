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
			get => GetProperty(ref _highLevelState);
			set => SetProperty(ref _highLevelState, value);
		}

		[Ordinal(2)] 
		[RED("highLevelStateValid")] 
		public CBool HighLevelStateValid
		{
			get => GetProperty(ref _highLevelStateValid);
			set => SetProperty(ref _highLevelStateValid, value);
		}

		[Ordinal(3)] 
		[RED("upperBodyState")] 
		public CEnum<gamedataNPCUpperBodyState> UpperBodyState
		{
			get => GetProperty(ref _upperBodyState);
			set => SetProperty(ref _upperBodyState, value);
		}

		[Ordinal(4)] 
		[RED("upperBodyStateValid")] 
		public CBool UpperBodyStateValid
		{
			get => GetProperty(ref _upperBodyStateValid);
			set => SetProperty(ref _upperBodyStateValid, value);
		}

		[Ordinal(5)] 
		[RED("stanceState")] 
		public CEnum<gamedataNPCStanceState> StanceState
		{
			get => GetProperty(ref _stanceState);
			set => SetProperty(ref _stanceState, value);
		}

		[Ordinal(6)] 
		[RED("stanceStateValid")] 
		public CBool StanceStateValid
		{
			get => GetProperty(ref _stanceStateValid);
			set => SetProperty(ref _stanceStateValid, value);
		}

		[Ordinal(7)] 
		[RED("hitReactionModeState")] 
		public CEnum<EHitReactionMode> HitReactionModeState
		{
			get => GetProperty(ref _hitReactionModeState);
			set => SetProperty(ref _hitReactionModeState, value);
		}

		[Ordinal(8)] 
		[RED("hitReactionModeStateValid")] 
		public CBool HitReactionModeStateValid
		{
			get => GetProperty(ref _hitReactionModeStateValid);
			set => SetProperty(ref _hitReactionModeStateValid, value);
		}

		[Ordinal(9)] 
		[RED("defenseMode")] 
		public CEnum<gamedataDefenseMode> DefenseMode
		{
			get => GetProperty(ref _defenseMode);
			set => SetProperty(ref _defenseMode, value);
		}

		[Ordinal(10)] 
		[RED("defenseModeValid")] 
		public CBool DefenseModeValid
		{
			get => GetProperty(ref _defenseModeValid);
			set => SetProperty(ref _defenseModeValid, value);
		}

		[Ordinal(11)] 
		[RED("locomotionMode")] 
		public CEnum<gamedataLocomotionMode> LocomotionMode
		{
			get => GetProperty(ref _locomotionMode);
			set => SetProperty(ref _locomotionMode, value);
		}

		[Ordinal(12)] 
		[RED("locomotionModeValid")] 
		public CBool LocomotionModeValid
		{
			get => GetProperty(ref _locomotionModeValid);
			set => SetProperty(ref _locomotionModeValid, value);
		}

		[Ordinal(13)] 
		[RED("behaviorState")] 
		public CEnum<gamedataNPCBehaviorState> BehaviorState
		{
			get => GetProperty(ref _behaviorState);
			set => SetProperty(ref _behaviorState, value);
		}

		[Ordinal(14)] 
		[RED("behaviorStateValid")] 
		public CBool BehaviorStateValid
		{
			get => GetProperty(ref _behaviorStateValid);
			set => SetProperty(ref _behaviorStateValid, value);
		}

		[Ordinal(15)] 
		[RED("phaseState")] 
		public CEnum<ENPCPhaseState> PhaseState
		{
			get => GetProperty(ref _phaseState);
			set => SetProperty(ref _phaseState, value);
		}

		[Ordinal(16)] 
		[RED("phaseStateValid")] 
		public CBool PhaseStateValid
		{
			get => GetProperty(ref _phaseStateValid);
			set => SetProperty(ref _phaseStateValid, value);
		}

		public NPCStateChangeSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
