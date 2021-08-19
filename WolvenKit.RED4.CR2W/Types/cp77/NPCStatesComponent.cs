using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCStatesComponent : gameAINetStateComponent
	{
		private CHandle<entLookAtAddEvent> _aimingLookatEvent;
		private CName _highLevelAnimFeatureName;
		private CName _upperBodyAnimFeatureName;
		private CName _stanceAnimFeatureName;
		private CHandle<gameStatModifierData_Deprecated> _statFlagDefensiveState;
		private CEnum<gamedataNPCStanceState> _prevNPCStanceState;
		private CEnum<gamedataNPCHighLevelState> _previousHighLevelState;
		private CEnum<EHitReactionMode> _prevHitReactionMode;
		private TweakDBID _bulkyStaggerMinRecordID;
		private TweakDBID _staggerMinRecordID;
		private TweakDBID _unstoppableRecordID;
		private TweakDBID _unstoppableTwitchMinRecordID;
		private TweakDBID _unstoppableTwitchNoneRecordID;
		private TweakDBID _forceImpactRecordID;
		private TweakDBID _forceStaggerRecordID;
		private TweakDBID _forceKnockdownRecordID;
		private TweakDBID _fragileRecordID;
		private TweakDBID _weakRecordID;
		private TweakDBID _toughRecordID;
		private TweakDBID _bulkyRecordID;
		private TweakDBID _regularRecordID;
		private CBool _inCombat;

		[Ordinal(5)] 
		[RED("aimingLookatEvent")] 
		public CHandle<entLookAtAddEvent> AimingLookatEvent
		{
			get => GetProperty(ref _aimingLookatEvent);
			set => SetProperty(ref _aimingLookatEvent, value);
		}

		[Ordinal(6)] 
		[RED("highLevelAnimFeatureName")] 
		public CName HighLevelAnimFeatureName
		{
			get => GetProperty(ref _highLevelAnimFeatureName);
			set => SetProperty(ref _highLevelAnimFeatureName, value);
		}

		[Ordinal(7)] 
		[RED("upperBodyAnimFeatureName")] 
		public CName UpperBodyAnimFeatureName
		{
			get => GetProperty(ref _upperBodyAnimFeatureName);
			set => SetProperty(ref _upperBodyAnimFeatureName, value);
		}

		[Ordinal(8)] 
		[RED("stanceAnimFeatureName")] 
		public CName StanceAnimFeatureName
		{
			get => GetProperty(ref _stanceAnimFeatureName);
			set => SetProperty(ref _stanceAnimFeatureName, value);
		}

		[Ordinal(9)] 
		[RED("statFlagDefensiveState")] 
		public CHandle<gameStatModifierData_Deprecated> StatFlagDefensiveState
		{
			get => GetProperty(ref _statFlagDefensiveState);
			set => SetProperty(ref _statFlagDefensiveState, value);
		}

		[Ordinal(10)] 
		[RED("prevNPCStanceState")] 
		public CEnum<gamedataNPCStanceState> PrevNPCStanceState
		{
			get => GetProperty(ref _prevNPCStanceState);
			set => SetProperty(ref _prevNPCStanceState, value);
		}

		[Ordinal(11)] 
		[RED("previousHighLevelState")] 
		public CEnum<gamedataNPCHighLevelState> PreviousHighLevelState
		{
			get => GetProperty(ref _previousHighLevelState);
			set => SetProperty(ref _previousHighLevelState, value);
		}

		[Ordinal(12)] 
		[RED("prevHitReactionMode")] 
		public CEnum<EHitReactionMode> PrevHitReactionMode
		{
			get => GetProperty(ref _prevHitReactionMode);
			set => SetProperty(ref _prevHitReactionMode, value);
		}

		[Ordinal(13)] 
		[RED("bulkyStaggerMinRecordID")] 
		public TweakDBID BulkyStaggerMinRecordID
		{
			get => GetProperty(ref _bulkyStaggerMinRecordID);
			set => SetProperty(ref _bulkyStaggerMinRecordID, value);
		}

		[Ordinal(14)] 
		[RED("staggerMinRecordID")] 
		public TweakDBID StaggerMinRecordID
		{
			get => GetProperty(ref _staggerMinRecordID);
			set => SetProperty(ref _staggerMinRecordID, value);
		}

		[Ordinal(15)] 
		[RED("unstoppableRecordID")] 
		public TweakDBID UnstoppableRecordID
		{
			get => GetProperty(ref _unstoppableRecordID);
			set => SetProperty(ref _unstoppableRecordID, value);
		}

		[Ordinal(16)] 
		[RED("unstoppableTwitchMinRecordID")] 
		public TweakDBID UnstoppableTwitchMinRecordID
		{
			get => GetProperty(ref _unstoppableTwitchMinRecordID);
			set => SetProperty(ref _unstoppableTwitchMinRecordID, value);
		}

		[Ordinal(17)] 
		[RED("unstoppableTwitchNoneRecordID")] 
		public TweakDBID UnstoppableTwitchNoneRecordID
		{
			get => GetProperty(ref _unstoppableTwitchNoneRecordID);
			set => SetProperty(ref _unstoppableTwitchNoneRecordID, value);
		}

		[Ordinal(18)] 
		[RED("forceImpactRecordID")] 
		public TweakDBID ForceImpactRecordID
		{
			get => GetProperty(ref _forceImpactRecordID);
			set => SetProperty(ref _forceImpactRecordID, value);
		}

		[Ordinal(19)] 
		[RED("forceStaggerRecordID")] 
		public TweakDBID ForceStaggerRecordID
		{
			get => GetProperty(ref _forceStaggerRecordID);
			set => SetProperty(ref _forceStaggerRecordID, value);
		}

		[Ordinal(20)] 
		[RED("forceKnockdownRecordID")] 
		public TweakDBID ForceKnockdownRecordID
		{
			get => GetProperty(ref _forceKnockdownRecordID);
			set => SetProperty(ref _forceKnockdownRecordID, value);
		}

		[Ordinal(21)] 
		[RED("fragileRecordID")] 
		public TweakDBID FragileRecordID
		{
			get => GetProperty(ref _fragileRecordID);
			set => SetProperty(ref _fragileRecordID, value);
		}

		[Ordinal(22)] 
		[RED("weakRecordID")] 
		public TweakDBID WeakRecordID
		{
			get => GetProperty(ref _weakRecordID);
			set => SetProperty(ref _weakRecordID, value);
		}

		[Ordinal(23)] 
		[RED("toughRecordID")] 
		public TweakDBID ToughRecordID
		{
			get => GetProperty(ref _toughRecordID);
			set => SetProperty(ref _toughRecordID, value);
		}

		[Ordinal(24)] 
		[RED("bulkyRecordID")] 
		public TweakDBID BulkyRecordID
		{
			get => GetProperty(ref _bulkyRecordID);
			set => SetProperty(ref _bulkyRecordID, value);
		}

		[Ordinal(25)] 
		[RED("regularRecordID")] 
		public TweakDBID RegularRecordID
		{
			get => GetProperty(ref _regularRecordID);
			set => SetProperty(ref _regularRecordID, value);
		}

		[Ordinal(26)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get => GetProperty(ref _inCombat);
			set => SetProperty(ref _inCombat, value);
		}

		public NPCStatesComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
