using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCStateChangeSignal : gameTaggedSignalUserData
	{
		[Ordinal(1)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(2)] 
		[RED("highLevelStateValid")] 
		public CBool HighLevelStateValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("upperBodyState")] 
		public CEnum<gamedataNPCUpperBodyState> UpperBodyState
		{
			get => GetPropertyValue<CEnum<gamedataNPCUpperBodyState>>();
			set => SetPropertyValue<CEnum<gamedataNPCUpperBodyState>>(value);
		}

		[Ordinal(4)] 
		[RED("upperBodyStateValid")] 
		public CBool UpperBodyStateValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("stanceState")] 
		public CEnum<gamedataNPCStanceState> StanceState
		{
			get => GetPropertyValue<CEnum<gamedataNPCStanceState>>();
			set => SetPropertyValue<CEnum<gamedataNPCStanceState>>(value);
		}

		[Ordinal(6)] 
		[RED("stanceStateValid")] 
		public CBool StanceStateValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("hitReactionModeState")] 
		public CEnum<EHitReactionMode> HitReactionModeState
		{
			get => GetPropertyValue<CEnum<EHitReactionMode>>();
			set => SetPropertyValue<CEnum<EHitReactionMode>>(value);
		}

		[Ordinal(8)] 
		[RED("hitReactionModeStateValid")] 
		public CBool HitReactionModeStateValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("defenseMode")] 
		public CEnum<gamedataDefenseMode> DefenseMode
		{
			get => GetPropertyValue<CEnum<gamedataDefenseMode>>();
			set => SetPropertyValue<CEnum<gamedataDefenseMode>>(value);
		}

		[Ordinal(10)] 
		[RED("defenseModeValid")] 
		public CBool DefenseModeValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("locomotionMode")] 
		public CEnum<gamedataLocomotionMode> LocomotionMode
		{
			get => GetPropertyValue<CEnum<gamedataLocomotionMode>>();
			set => SetPropertyValue<CEnum<gamedataLocomotionMode>>(value);
		}

		[Ordinal(12)] 
		[RED("locomotionModeValid")] 
		public CBool LocomotionModeValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("behaviorState")] 
		public CEnum<gamedataNPCBehaviorState> BehaviorState
		{
			get => GetPropertyValue<CEnum<gamedataNPCBehaviorState>>();
			set => SetPropertyValue<CEnum<gamedataNPCBehaviorState>>(value);
		}

		[Ordinal(14)] 
		[RED("behaviorStateValid")] 
		public CBool BehaviorStateValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("phaseState")] 
		public CEnum<ENPCPhaseState> PhaseState
		{
			get => GetPropertyValue<CEnum<ENPCPhaseState>>();
			set => SetPropertyValue<CEnum<ENPCPhaseState>>(value);
		}

		[Ordinal(16)] 
		[RED("phaseStateValid")] 
		public CBool PhaseStateValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCStateChangeSignal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
