using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCStatesComponent : gameAINetStateComponent
	{
		[Ordinal(5)] 
		[RED("aimingLookatEvent")] 
		public CHandle<entLookAtAddEvent> AimingLookatEvent
		{
			get => GetPropertyValue<CHandle<entLookAtAddEvent>>();
			set => SetPropertyValue<CHandle<entLookAtAddEvent>>(value);
		}

		[Ordinal(6)] 
		[RED("highLevelAnimFeatureName")] 
		public CName HighLevelAnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("upperBodyAnimFeatureName")] 
		public CName UpperBodyAnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("stanceAnimFeatureName")] 
		public CName StanceAnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("statFlagDefensiveState")] 
		public CHandle<gameStatModifierData_Deprecated> StatFlagDefensiveState
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(10)] 
		[RED("prevNPCStanceState")] 
		public CEnum<gamedataNPCStanceState> PrevNPCStanceState
		{
			get => GetPropertyValue<CEnum<gamedataNPCStanceState>>();
			set => SetPropertyValue<CEnum<gamedataNPCStanceState>>(value);
		}

		[Ordinal(11)] 
		[RED("previousHighLevelState")] 
		public CEnum<gamedataNPCHighLevelState> PreviousHighLevelState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(12)] 
		[RED("prevHitReactionMode")] 
		public CEnum<EHitReactionMode> PrevHitReactionMode
		{
			get => GetPropertyValue<CEnum<EHitReactionMode>>();
			set => SetPropertyValue<CEnum<EHitReactionMode>>(value);
		}

		[Ordinal(13)] 
		[RED("bulkyStaggerMinRecordID")] 
		public TweakDBID BulkyStaggerMinRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(14)] 
		[RED("staggerMinRecordID")] 
		public TweakDBID StaggerMinRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(15)] 
		[RED("unstoppableRecordID")] 
		public TweakDBID UnstoppableRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(16)] 
		[RED("unstoppableTwitchMinRecordID")] 
		public TweakDBID UnstoppableTwitchMinRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(17)] 
		[RED("unstoppableTwitchNoneRecordID")] 
		public TweakDBID UnstoppableTwitchNoneRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(18)] 
		[RED("forceImpactRecordID")] 
		public TweakDBID ForceImpactRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(19)] 
		[RED("forceStaggerRecordID")] 
		public TweakDBID ForceStaggerRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(20)] 
		[RED("forceKnockdownRecordID")] 
		public TweakDBID ForceKnockdownRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(21)] 
		[RED("fragileRecordID")] 
		public TweakDBID FragileRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(22)] 
		[RED("weakRecordID")] 
		public TweakDBID WeakRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(23)] 
		[RED("toughRecordID")] 
		public TweakDBID ToughRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(24)] 
		[RED("bulkyRecordID")] 
		public TweakDBID BulkyRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(25)] 
		[RED("regularRecordID")] 
		public TweakDBID RegularRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(26)] 
		[RED("keepRecentThreatAfterRelaxedDuration")] 
		public CFloat KeepRecentThreatAfterRelaxedDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCStatesComponent()
		{
			HighLevelAnimFeatureName = "highLevelState";
			UpperBodyAnimFeatureName = "upperBodyState";
			StanceAnimFeatureName = "stanceState";
			PrevNPCStanceState = Enums.gamedataNPCStanceState.Invalid;
			PreviousHighLevelState = Enums.gamedataNPCHighLevelState.Invalid;
			PrevHitReactionMode = Enums.EHitReactionMode.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
