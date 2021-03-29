using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitReactionComponent : AIMandatoryComponents
	{
		private CFloat _impactDamageDuration;
		private CFloat _staggerDamageDuration;
		private CFloat _impactDamageDurationMelee;
		private CFloat _staggerDamageDurationMelee;
		private CFloat _knockdownDamageDuration;
		private CFloat _defeatedMinDuration;
		private CFloat _previousHitTime;
		private CEnum<animHitReactionType> _reactionType;
		private CHandle<animAnimFeature_HitReactionsData> _animHitReaction;
		private CHandle<animAnimFeature_HitReactionsData> _lastAnimHitReaction;
		private CHandle<ActionHitReactionScriptProxy> _hitReactionAction;
		private CArray<ScriptHitData> _previousAnimHitReactionArray;
		private CEnum<EAILastHitReactionPlayed> _lastHitReactionPlayed;
		private gameShapeData _hitShapeData;
		private CInt32 _animVariation;
		private CFloat _specificHitTimeout;
		private CFloat _quickMeleeCooldown;
		private CArray<CFloat> _dismembermentBodyPartDamageThreshold;
		private CArray<CFloat> _woundedBodyPartDamageThreshold;
		private CArray<CFloat> _defeatedBodyPartDamageThreshold;
		private CFloat _impactDamageThreshold;
		private CFloat _staggerDamageThreshold;
		private CFloat _knockdownDamageThreshold;
		private CFloat _knockdownImpulseThreshold;
		private CBool _immuneToKnockDown;
		private CFloat _hitComboReset;
		private CFloat _physicalImpulseReset;
		private CFloat _cumulatedDamages;
		private CArray<CFloat> _bodyPartWoundCumulatedDamages;
		private CArray<CFloat> _bodyPartDismemberCumulatedDamages;
		private CFloat _overrideHitReactionImpulse;
		private CFloat _cumulatedPhysicalImpulse;
		private CFloat _comboResetTime;
		private CFloat _ragdollImpulse;
		private CEnum<EAIHitIntensity> _hitIntensity;
		private CFloat _previousMeleeHitTimeStamp;
		private CFloat _previousRangedHitTimeStamp;
		private CFloat _previousBlockTimeStamp;
		private CFloat _previousParryTimeStamp;
		private CFloat _previousDodgeTimeStamp;
		private CInt32 _blockCount;
		private CInt32 _parryCount;
		private CInt32 _dodgeCount;
		private CUInt32 _hitCount;
		private CBool _defeatedHasBeenPlayed;
		private CBool _deathHasBeenPlayed;
		private CFloat _deathRegisteredTime;
		private CFloat _extendedDeathRegisteredTime;
		private CFloat _extendedDeathDelayRegisteredTime;
		private CFloat _disableDismembermentAfterDeathDelay;
		private CFloat _extendedHitReactionRegisteredTime;
		private CFloat _extendedHitReactionDelayRegisteredTime;
		private CBool _scatteredGuts;
		private CFloat _cumulativeDamageUpdateInterval;
		private CBool _cumulativeDamageUpdateRequested;
		private CUInt32 _currentStimId;
		private CHandle<gamedamageAttackData> _attackData;
		private Vector4 _hitPosition;
		private Vector4 _hitDirection;
		private CHandle<HitReactionBehaviorData> _lastHitReactionBehaviorData;
		private CName _lastStimName;
		private CName _deathStimName;
		private CInt32 _meleeHitCount;
		private CInt32 _strongMeleeHitCount;
		private CInt32 _maxHitChainForMelee;
		private CInt32 _maxHitChainForRanged;
		private CBool _isAlive;
		private CFloat _frameDamageHealthFactor;
		private CArrayFixedSize<CFloat> _hitCountData;
		private CInt32 _hitCountArrayEnd;
		private CInt32 _hitCountArrayCurrent;
		private CUInt32 _indicatorEnabledBlackboardId;
		private CBool _hitIndicatorEnabled;
		private CBool _hasBeenWounded;
		private CHandle<animAnimFeature_HitReactionsData> _hitReactionData;

		[Ordinal(5)] 
		[RED("impactDamageDuration")] 
		public CFloat ImpactDamageDuration
		{
			get => GetProperty(ref _impactDamageDuration);
			set => SetProperty(ref _impactDamageDuration, value);
		}

		[Ordinal(6)] 
		[RED("staggerDamageDuration")] 
		public CFloat StaggerDamageDuration
		{
			get => GetProperty(ref _staggerDamageDuration);
			set => SetProperty(ref _staggerDamageDuration, value);
		}

		[Ordinal(7)] 
		[RED("impactDamageDurationMelee")] 
		public CFloat ImpactDamageDurationMelee
		{
			get => GetProperty(ref _impactDamageDurationMelee);
			set => SetProperty(ref _impactDamageDurationMelee, value);
		}

		[Ordinal(8)] 
		[RED("staggerDamageDurationMelee")] 
		public CFloat StaggerDamageDurationMelee
		{
			get => GetProperty(ref _staggerDamageDurationMelee);
			set => SetProperty(ref _staggerDamageDurationMelee, value);
		}

		[Ordinal(9)] 
		[RED("knockdownDamageDuration")] 
		public CFloat KnockdownDamageDuration
		{
			get => GetProperty(ref _knockdownDamageDuration);
			set => SetProperty(ref _knockdownDamageDuration, value);
		}

		[Ordinal(10)] 
		[RED("defeatedMinDuration")] 
		public CFloat DefeatedMinDuration
		{
			get => GetProperty(ref _defeatedMinDuration);
			set => SetProperty(ref _defeatedMinDuration, value);
		}

		[Ordinal(11)] 
		[RED("previousHitTime")] 
		public CFloat PreviousHitTime
		{
			get => GetProperty(ref _previousHitTime);
			set => SetProperty(ref _previousHitTime, value);
		}

		[Ordinal(12)] 
		[RED("reactionType")] 
		public CEnum<animHitReactionType> ReactionType
		{
			get => GetProperty(ref _reactionType);
			set => SetProperty(ref _reactionType, value);
		}

		[Ordinal(13)] 
		[RED("animHitReaction")] 
		public CHandle<animAnimFeature_HitReactionsData> AnimHitReaction
		{
			get => GetProperty(ref _animHitReaction);
			set => SetProperty(ref _animHitReaction, value);
		}

		[Ordinal(14)] 
		[RED("lastAnimHitReaction")] 
		public CHandle<animAnimFeature_HitReactionsData> LastAnimHitReaction
		{
			get => GetProperty(ref _lastAnimHitReaction);
			set => SetProperty(ref _lastAnimHitReaction, value);
		}

		[Ordinal(15)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get => GetProperty(ref _hitReactionAction);
			set => SetProperty(ref _hitReactionAction, value);
		}

		[Ordinal(16)] 
		[RED("previousAnimHitReactionArray")] 
		public CArray<ScriptHitData> PreviousAnimHitReactionArray
		{
			get => GetProperty(ref _previousAnimHitReactionArray);
			set => SetProperty(ref _previousAnimHitReactionArray, value);
		}

		[Ordinal(17)] 
		[RED("lastHitReactionPlayed")] 
		public CEnum<EAILastHitReactionPlayed> LastHitReactionPlayed
		{
			get => GetProperty(ref _lastHitReactionPlayed);
			set => SetProperty(ref _lastHitReactionPlayed, value);
		}

		[Ordinal(18)] 
		[RED("hitShapeData")] 
		public gameShapeData HitShapeData
		{
			get => GetProperty(ref _hitShapeData);
			set => SetProperty(ref _hitShapeData, value);
		}

		[Ordinal(19)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get => GetProperty(ref _animVariation);
			set => SetProperty(ref _animVariation, value);
		}

		[Ordinal(20)] 
		[RED("specificHitTimeout")] 
		public CFloat SpecificHitTimeout
		{
			get => GetProperty(ref _specificHitTimeout);
			set => SetProperty(ref _specificHitTimeout, value);
		}

		[Ordinal(21)] 
		[RED("quickMeleeCooldown")] 
		public CFloat QuickMeleeCooldown
		{
			get => GetProperty(ref _quickMeleeCooldown);
			set => SetProperty(ref _quickMeleeCooldown, value);
		}

		[Ordinal(22)] 
		[RED("dismembermentBodyPartDamageThreshold")] 
		public CArray<CFloat> DismembermentBodyPartDamageThreshold
		{
			get => GetProperty(ref _dismembermentBodyPartDamageThreshold);
			set => SetProperty(ref _dismembermentBodyPartDamageThreshold, value);
		}

		[Ordinal(23)] 
		[RED("woundedBodyPartDamageThreshold")] 
		public CArray<CFloat> WoundedBodyPartDamageThreshold
		{
			get => GetProperty(ref _woundedBodyPartDamageThreshold);
			set => SetProperty(ref _woundedBodyPartDamageThreshold, value);
		}

		[Ordinal(24)] 
		[RED("defeatedBodyPartDamageThreshold")] 
		public CArray<CFloat> DefeatedBodyPartDamageThreshold
		{
			get => GetProperty(ref _defeatedBodyPartDamageThreshold);
			set => SetProperty(ref _defeatedBodyPartDamageThreshold, value);
		}

		[Ordinal(25)] 
		[RED("impactDamageThreshold")] 
		public CFloat ImpactDamageThreshold
		{
			get => GetProperty(ref _impactDamageThreshold);
			set => SetProperty(ref _impactDamageThreshold, value);
		}

		[Ordinal(26)] 
		[RED("staggerDamageThreshold")] 
		public CFloat StaggerDamageThreshold
		{
			get => GetProperty(ref _staggerDamageThreshold);
			set => SetProperty(ref _staggerDamageThreshold, value);
		}

		[Ordinal(27)] 
		[RED("knockdownDamageThreshold")] 
		public CFloat KnockdownDamageThreshold
		{
			get => GetProperty(ref _knockdownDamageThreshold);
			set => SetProperty(ref _knockdownDamageThreshold, value);
		}

		[Ordinal(28)] 
		[RED("knockdownImpulseThreshold")] 
		public CFloat KnockdownImpulseThreshold
		{
			get => GetProperty(ref _knockdownImpulseThreshold);
			set => SetProperty(ref _knockdownImpulseThreshold, value);
		}

		[Ordinal(29)] 
		[RED("immuneToKnockDown")] 
		public CBool ImmuneToKnockDown
		{
			get => GetProperty(ref _immuneToKnockDown);
			set => SetProperty(ref _immuneToKnockDown, value);
		}

		[Ordinal(30)] 
		[RED("hitComboReset")] 
		public CFloat HitComboReset
		{
			get => GetProperty(ref _hitComboReset);
			set => SetProperty(ref _hitComboReset, value);
		}

		[Ordinal(31)] 
		[RED("physicalImpulseReset")] 
		public CFloat PhysicalImpulseReset
		{
			get => GetProperty(ref _physicalImpulseReset);
			set => SetProperty(ref _physicalImpulseReset, value);
		}

		[Ordinal(32)] 
		[RED("cumulatedDamages")] 
		public CFloat CumulatedDamages
		{
			get => GetProperty(ref _cumulatedDamages);
			set => SetProperty(ref _cumulatedDamages, value);
		}

		[Ordinal(33)] 
		[RED("bodyPartWoundCumulatedDamages")] 
		public CArray<CFloat> BodyPartWoundCumulatedDamages
		{
			get => GetProperty(ref _bodyPartWoundCumulatedDamages);
			set => SetProperty(ref _bodyPartWoundCumulatedDamages, value);
		}

		[Ordinal(34)] 
		[RED("bodyPartDismemberCumulatedDamages")] 
		public CArray<CFloat> BodyPartDismemberCumulatedDamages
		{
			get => GetProperty(ref _bodyPartDismemberCumulatedDamages);
			set => SetProperty(ref _bodyPartDismemberCumulatedDamages, value);
		}

		[Ordinal(35)] 
		[RED("overrideHitReactionImpulse")] 
		public CFloat OverrideHitReactionImpulse
		{
			get => GetProperty(ref _overrideHitReactionImpulse);
			set => SetProperty(ref _overrideHitReactionImpulse, value);
		}

		[Ordinal(36)] 
		[RED("cumulatedPhysicalImpulse")] 
		public CFloat CumulatedPhysicalImpulse
		{
			get => GetProperty(ref _cumulatedPhysicalImpulse);
			set => SetProperty(ref _cumulatedPhysicalImpulse, value);
		}

		[Ordinal(37)] 
		[RED("comboResetTime")] 
		public CFloat ComboResetTime
		{
			get => GetProperty(ref _comboResetTime);
			set => SetProperty(ref _comboResetTime, value);
		}

		[Ordinal(38)] 
		[RED("ragdollImpulse")] 
		public CFloat RagdollImpulse
		{
			get => GetProperty(ref _ragdollImpulse);
			set => SetProperty(ref _ragdollImpulse, value);
		}

		[Ordinal(39)] 
		[RED("hitIntensity")] 
		public CEnum<EAIHitIntensity> HitIntensity
		{
			get => GetProperty(ref _hitIntensity);
			set => SetProperty(ref _hitIntensity, value);
		}

		[Ordinal(40)] 
		[RED("previousMeleeHitTimeStamp")] 
		public CFloat PreviousMeleeHitTimeStamp
		{
			get => GetProperty(ref _previousMeleeHitTimeStamp);
			set => SetProperty(ref _previousMeleeHitTimeStamp, value);
		}

		[Ordinal(41)] 
		[RED("previousRangedHitTimeStamp")] 
		public CFloat PreviousRangedHitTimeStamp
		{
			get => GetProperty(ref _previousRangedHitTimeStamp);
			set => SetProperty(ref _previousRangedHitTimeStamp, value);
		}

		[Ordinal(42)] 
		[RED("previousBlockTimeStamp")] 
		public CFloat PreviousBlockTimeStamp
		{
			get => GetProperty(ref _previousBlockTimeStamp);
			set => SetProperty(ref _previousBlockTimeStamp, value);
		}

		[Ordinal(43)] 
		[RED("previousParryTimeStamp")] 
		public CFloat PreviousParryTimeStamp
		{
			get => GetProperty(ref _previousParryTimeStamp);
			set => SetProperty(ref _previousParryTimeStamp, value);
		}

		[Ordinal(44)] 
		[RED("previousDodgeTimeStamp")] 
		public CFloat PreviousDodgeTimeStamp
		{
			get => GetProperty(ref _previousDodgeTimeStamp);
			set => SetProperty(ref _previousDodgeTimeStamp, value);
		}

		[Ordinal(45)] 
		[RED("blockCount")] 
		public CInt32 BlockCount
		{
			get => GetProperty(ref _blockCount);
			set => SetProperty(ref _blockCount, value);
		}

		[Ordinal(46)] 
		[RED("parryCount")] 
		public CInt32 ParryCount
		{
			get => GetProperty(ref _parryCount);
			set => SetProperty(ref _parryCount, value);
		}

		[Ordinal(47)] 
		[RED("dodgeCount")] 
		public CInt32 DodgeCount
		{
			get => GetProperty(ref _dodgeCount);
			set => SetProperty(ref _dodgeCount, value);
		}

		[Ordinal(48)] 
		[RED("hitCount")] 
		public CUInt32 HitCount
		{
			get => GetProperty(ref _hitCount);
			set => SetProperty(ref _hitCount, value);
		}

		[Ordinal(49)] 
		[RED("defeatedHasBeenPlayed")] 
		public CBool DefeatedHasBeenPlayed
		{
			get => GetProperty(ref _defeatedHasBeenPlayed);
			set => SetProperty(ref _defeatedHasBeenPlayed, value);
		}

		[Ordinal(50)] 
		[RED("deathHasBeenPlayed")] 
		public CBool DeathHasBeenPlayed
		{
			get => GetProperty(ref _deathHasBeenPlayed);
			set => SetProperty(ref _deathHasBeenPlayed, value);
		}

		[Ordinal(51)] 
		[RED("deathRegisteredTime")] 
		public CFloat DeathRegisteredTime
		{
			get => GetProperty(ref _deathRegisteredTime);
			set => SetProperty(ref _deathRegisteredTime, value);
		}

		[Ordinal(52)] 
		[RED("extendedDeathRegisteredTime")] 
		public CFloat ExtendedDeathRegisteredTime
		{
			get => GetProperty(ref _extendedDeathRegisteredTime);
			set => SetProperty(ref _extendedDeathRegisteredTime, value);
		}

		[Ordinal(53)] 
		[RED("extendedDeathDelayRegisteredTime")] 
		public CFloat ExtendedDeathDelayRegisteredTime
		{
			get => GetProperty(ref _extendedDeathDelayRegisteredTime);
			set => SetProperty(ref _extendedDeathDelayRegisteredTime, value);
		}

		[Ordinal(54)] 
		[RED("disableDismembermentAfterDeathDelay")] 
		public CFloat DisableDismembermentAfterDeathDelay
		{
			get => GetProperty(ref _disableDismembermentAfterDeathDelay);
			set => SetProperty(ref _disableDismembermentAfterDeathDelay, value);
		}

		[Ordinal(55)] 
		[RED("extendedHitReactionRegisteredTime")] 
		public CFloat ExtendedHitReactionRegisteredTime
		{
			get => GetProperty(ref _extendedHitReactionRegisteredTime);
			set => SetProperty(ref _extendedHitReactionRegisteredTime, value);
		}

		[Ordinal(56)] 
		[RED("extendedHitReactionDelayRegisteredTime")] 
		public CFloat ExtendedHitReactionDelayRegisteredTime
		{
			get => GetProperty(ref _extendedHitReactionDelayRegisteredTime);
			set => SetProperty(ref _extendedHitReactionDelayRegisteredTime, value);
		}

		[Ordinal(57)] 
		[RED("scatteredGuts")] 
		public CBool ScatteredGuts
		{
			get => GetProperty(ref _scatteredGuts);
			set => SetProperty(ref _scatteredGuts, value);
		}

		[Ordinal(58)] 
		[RED("cumulativeDamageUpdateInterval")] 
		public CFloat CumulativeDamageUpdateInterval
		{
			get => GetProperty(ref _cumulativeDamageUpdateInterval);
			set => SetProperty(ref _cumulativeDamageUpdateInterval, value);
		}

		[Ordinal(59)] 
		[RED("cumulativeDamageUpdateRequested")] 
		public CBool CumulativeDamageUpdateRequested
		{
			get => GetProperty(ref _cumulativeDamageUpdateRequested);
			set => SetProperty(ref _cumulativeDamageUpdateRequested, value);
		}

		[Ordinal(60)] 
		[RED("currentStimId")] 
		public CUInt32 CurrentStimId
		{
			get => GetProperty(ref _currentStimId);
			set => SetProperty(ref _currentStimId, value);
		}

		[Ordinal(61)] 
		[RED("attackData")] 
		public CHandle<gamedamageAttackData> AttackData
		{
			get => GetProperty(ref _attackData);
			set => SetProperty(ref _attackData, value);
		}

		[Ordinal(62)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetProperty(ref _hitPosition);
			set => SetProperty(ref _hitPosition, value);
		}

		[Ordinal(63)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetProperty(ref _hitDirection);
			set => SetProperty(ref _hitDirection, value);
		}

		[Ordinal(64)] 
		[RED("lastHitReactionBehaviorData")] 
		public CHandle<HitReactionBehaviorData> LastHitReactionBehaviorData
		{
			get => GetProperty(ref _lastHitReactionBehaviorData);
			set => SetProperty(ref _lastHitReactionBehaviorData, value);
		}

		[Ordinal(65)] 
		[RED("lastStimName")] 
		public CName LastStimName
		{
			get => GetProperty(ref _lastStimName);
			set => SetProperty(ref _lastStimName, value);
		}

		[Ordinal(66)] 
		[RED("deathStimName")] 
		public CName DeathStimName
		{
			get => GetProperty(ref _deathStimName);
			set => SetProperty(ref _deathStimName, value);
		}

		[Ordinal(67)] 
		[RED("meleeHitCount")] 
		public CInt32 MeleeHitCount
		{
			get => GetProperty(ref _meleeHitCount);
			set => SetProperty(ref _meleeHitCount, value);
		}

		[Ordinal(68)] 
		[RED("strongMeleeHitCount")] 
		public CInt32 StrongMeleeHitCount
		{
			get => GetProperty(ref _strongMeleeHitCount);
			set => SetProperty(ref _strongMeleeHitCount, value);
		}

		[Ordinal(69)] 
		[RED("maxHitChainForMelee")] 
		public CInt32 MaxHitChainForMelee
		{
			get => GetProperty(ref _maxHitChainForMelee);
			set => SetProperty(ref _maxHitChainForMelee, value);
		}

		[Ordinal(70)] 
		[RED("maxHitChainForRanged")] 
		public CInt32 MaxHitChainForRanged
		{
			get => GetProperty(ref _maxHitChainForRanged);
			set => SetProperty(ref _maxHitChainForRanged, value);
		}

		[Ordinal(71)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetProperty(ref _isAlive);
			set => SetProperty(ref _isAlive, value);
		}

		[Ordinal(72)] 
		[RED("frameDamageHealthFactor")] 
		public CFloat FrameDamageHealthFactor
		{
			get => GetProperty(ref _frameDamageHealthFactor);
			set => SetProperty(ref _frameDamageHealthFactor, value);
		}

		[Ordinal(73)] 
		[RED("hitCountData", 100)] 
		public CArrayFixedSize<CFloat> HitCountData
		{
			get => GetProperty(ref _hitCountData);
			set => SetProperty(ref _hitCountData, value);
		}

		[Ordinal(74)] 
		[RED("hitCountArrayEnd")] 
		public CInt32 HitCountArrayEnd
		{
			get => GetProperty(ref _hitCountArrayEnd);
			set => SetProperty(ref _hitCountArrayEnd, value);
		}

		[Ordinal(75)] 
		[RED("hitCountArrayCurrent")] 
		public CInt32 HitCountArrayCurrent
		{
			get => GetProperty(ref _hitCountArrayCurrent);
			set => SetProperty(ref _hitCountArrayCurrent, value);
		}

		[Ordinal(76)] 
		[RED("indicatorEnabledBlackboardId")] 
		public CUInt32 IndicatorEnabledBlackboardId
		{
			get => GetProperty(ref _indicatorEnabledBlackboardId);
			set => SetProperty(ref _indicatorEnabledBlackboardId, value);
		}

		[Ordinal(77)] 
		[RED("hitIndicatorEnabled")] 
		public CBool HitIndicatorEnabled
		{
			get => GetProperty(ref _hitIndicatorEnabled);
			set => SetProperty(ref _hitIndicatorEnabled, value);
		}

		[Ordinal(78)] 
		[RED("hasBeenWounded")] 
		public CBool HasBeenWounded
		{
			get => GetProperty(ref _hasBeenWounded);
			set => SetProperty(ref _hasBeenWounded, value);
		}

		[Ordinal(79)] 
		[RED("hitReactionData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitReactionData
		{
			get => GetProperty(ref _hitReactionData);
			set => SetProperty(ref _hitReactionData, value);
		}

		public HitReactionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
