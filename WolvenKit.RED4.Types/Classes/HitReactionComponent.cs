using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitReactionComponent : AIMandatoryComponents
	{
		[Ordinal(5)] 
		[RED("impactDamageDuration")] 
		public CFloat ImpactDamageDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("staggerDamageDuration")] 
		public CFloat StaggerDamageDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("impactDamageDurationMelee")] 
		public CFloat ImpactDamageDurationMelee
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("staggerDamageDurationMelee")] 
		public CFloat StaggerDamageDurationMelee
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("knockdownDamageDuration")] 
		public CFloat KnockdownDamageDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("defeatedMinDuration")] 
		public CFloat DefeatedMinDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("previousHitTime")] 
		public CFloat PreviousHitTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("reactionType")] 
		public CEnum<animHitReactionType> ReactionType
		{
			get => GetPropertyValue<CEnum<animHitReactionType>>();
			set => SetPropertyValue<CEnum<animHitReactionType>>(value);
		}

		[Ordinal(13)] 
		[RED("animHitReaction")] 
		public CHandle<animAnimFeature_HitReactionsData> AnimHitReaction
		{
			get => GetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>();
			set => SetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>(value);
		}

		[Ordinal(14)] 
		[RED("lastAnimHitReaction")] 
		public CHandle<animAnimFeature_HitReactionsData> LastAnimHitReaction
		{
			get => GetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>();
			set => SetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>(value);
		}

		[Ordinal(15)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get => GetPropertyValue<CHandle<ActionHitReactionScriptProxy>>();
			set => SetPropertyValue<CHandle<ActionHitReactionScriptProxy>>(value);
		}

		[Ordinal(16)] 
		[RED("previousAnimHitReactionArray")] 
		public CArray<ScriptHitData> PreviousAnimHitReactionArray
		{
			get => GetPropertyValue<CArray<ScriptHitData>>();
			set => SetPropertyValue<CArray<ScriptHitData>>(value);
		}

		[Ordinal(17)] 
		[RED("lastHitReactionPlayed")] 
		public CEnum<EAILastHitReactionPlayed> LastHitReactionPlayed
		{
			get => GetPropertyValue<CEnum<EAILastHitReactionPlayed>>();
			set => SetPropertyValue<CEnum<EAILastHitReactionPlayed>>(value);
		}

		[Ordinal(18)] 
		[RED("hitShapeData")] 
		public gameShapeData HitShapeData
		{
			get => GetPropertyValue<gameShapeData>();
			set => SetPropertyValue<gameShapeData>(value);
		}

		[Ordinal(19)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("specificHitTimeout")] 
		public CFloat SpecificHitTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("quickMeleeCooldown")] 
		public CFloat QuickMeleeCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("dismembermentBodyPartDamageThreshold")] 
		public CArray<CFloat> DismembermentBodyPartDamageThreshold
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(23)] 
		[RED("woundedBodyPartDamageThreshold")] 
		public CArray<CFloat> WoundedBodyPartDamageThreshold
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(24)] 
		[RED("defeatedBodyPartDamageThreshold")] 
		public CArray<CFloat> DefeatedBodyPartDamageThreshold
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(25)] 
		[RED("impactDamageThreshold")] 
		public CFloat ImpactDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("staggerDamageThreshold")] 
		public CFloat StaggerDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("knockdownDamageThreshold")] 
		public CFloat KnockdownDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("knockdownImpulseThreshold")] 
		public CFloat KnockdownImpulseThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("immuneToKnockDown")] 
		public CBool ImmuneToKnockDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("hitComboReset")] 
		public CFloat HitComboReset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("physicalImpulseReset")] 
		public CFloat PhysicalImpulseReset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("cumulatedDamages")] 
		public CFloat CumulatedDamages
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("bodyPartWoundCumulatedDamages")] 
		public CArray<CFloat> BodyPartWoundCumulatedDamages
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(34)] 
		[RED("bodyPartDismemberCumulatedDamages")] 
		public CArray<CFloat> BodyPartDismemberCumulatedDamages
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(35)] 
		[RED("overrideHitReactionImpulse")] 
		public CFloat OverrideHitReactionImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("cumulatedPhysicalImpulse")] 
		public CFloat CumulatedPhysicalImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("comboResetTime")] 
		public CFloat ComboResetTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("ragdollImpulse")] 
		public CFloat RagdollImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("hitIntensity")] 
		public CEnum<EAIHitIntensity> HitIntensity
		{
			get => GetPropertyValue<CEnum<EAIHitIntensity>>();
			set => SetPropertyValue<CEnum<EAIHitIntensity>>(value);
		}

		[Ordinal(40)] 
		[RED("previousMeleeHitTimeStamp")] 
		public CFloat PreviousMeleeHitTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("previousRangedHitTimeStamp")] 
		public CFloat PreviousRangedHitTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(42)] 
		[RED("previousBlockTimeStamp")] 
		public CFloat PreviousBlockTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("previousParryTimeStamp")] 
		public CFloat PreviousParryTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("previousDodgeTimeStamp")] 
		public CFloat PreviousDodgeTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("blockCount")] 
		public CInt32 BlockCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(46)] 
		[RED("parryCount")] 
		public CInt32 ParryCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(47)] 
		[RED("dodgeCount")] 
		public CInt32 DodgeCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(48)] 
		[RED("hitCount")] 
		public CUInt32 HitCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(49)] 
		[RED("defeatedHasBeenPlayed")] 
		public CBool DefeatedHasBeenPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("deathHasBeenPlayed")] 
		public CBool DeathHasBeenPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("deathRegisteredTime")] 
		public CFloat DeathRegisteredTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("extendedDeathRegisteredTime")] 
		public CFloat ExtendedDeathRegisteredTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("extendedDeathDelayRegisteredTime")] 
		public CFloat ExtendedDeathDelayRegisteredTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("disableDismembermentAfterDeathDelay")] 
		public CFloat DisableDismembermentAfterDeathDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("extendedHitReactionRegisteredTime")] 
		public CFloat ExtendedHitReactionRegisteredTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("extendedHitReactionDelayRegisteredTime")] 
		public CFloat ExtendedHitReactionDelayRegisteredTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("scatteredGuts")] 
		public CBool ScatteredGuts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("cumulativeDamageUpdateInterval")] 
		public CFloat CumulativeDamageUpdateInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("cumulativeDamageUpdateRequested")] 
		public CBool CumulativeDamageUpdateRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("currentStimId")] 
		public CUInt32 CurrentStimId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(61)] 
		[RED("attackData")] 
		public CHandle<gamedamageAttackData> AttackData
		{
			get => GetPropertyValue<CHandle<gamedamageAttackData>>();
			set => SetPropertyValue<CHandle<gamedamageAttackData>>(value);
		}

		[Ordinal(62)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(63)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(64)] 
		[RED("lastHitReactionBehaviorData")] 
		public CHandle<HitReactionBehaviorData> LastHitReactionBehaviorData
		{
			get => GetPropertyValue<CHandle<HitReactionBehaviorData>>();
			set => SetPropertyValue<CHandle<HitReactionBehaviorData>>(value);
		}

		[Ordinal(65)] 
		[RED("lastStimName")] 
		public CName LastStimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(66)] 
		[RED("deathStimName")] 
		public CName DeathStimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(67)] 
		[RED("meleeHitCount")] 
		public CInt32 MeleeHitCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(68)] 
		[RED("strongMeleeHitCount")] 
		public CInt32 StrongMeleeHitCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(69)] 
		[RED("maxHitChainForMelee")] 
		public CInt32 MaxHitChainForMelee
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(70)] 
		[RED("maxHitChainForRanged")] 
		public CInt32 MaxHitChainForRanged
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(71)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("frameDamageHealthFactor")] 
		public CFloat FrameDamageHealthFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(73)] 
		[RED("hitCountData", 100)] 
		public CArrayFixedSize<CFloat> HitCountData
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(74)] 
		[RED("hitCountArrayEnd")] 
		public CInt32 HitCountArrayEnd
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(75)] 
		[RED("hitCountArrayCurrent")] 
		public CInt32 HitCountArrayCurrent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(76)] 
		[RED("indicatorEnabledBlackboardId")] 
		public CHandle<redCallbackObject> IndicatorEnabledBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(77)] 
		[RED("hitIndicatorEnabled")] 
		public CBool HitIndicatorEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(78)] 
		[RED("hasBeenWounded")] 
		public CBool HasBeenWounded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(79)] 
		[RED("hitReactionData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitReactionData
		{
			get => GetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>();
			set => SetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>(value);
		}

		public HitReactionComponent()
		{
			ImpactDamageDuration = 0.200000F;
			StaggerDamageDuration = 0.400000F;
			ImpactDamageDurationMelee = 0.250000F;
			StaggerDamageDurationMelee = 1.500000F;
			KnockdownDamageDuration = 2.500000F;
			PreviousAnimHitReactionArray = new();
			HitShapeData = new() { Result = new() { HitPositionEnter = new(), HitPositionExit = new() } };
			DismembermentBodyPartDamageThreshold = new();
			WoundedBodyPartDamageThreshold = new();
			DefeatedBodyPartDamageThreshold = new();
			HitComboReset = 2.000000F;
			PhysicalImpulseReset = 0.300000F;
			BodyPartWoundCumulatedDamages = new();
			BodyPartDismemberCumulatedDamages = new();
			PreviousMeleeHitTimeStamp = -1.000000F;
			PreviousRangedHitTimeStamp = -1.000000F;
			PreviousBlockTimeStamp = -1.000000F;
			PreviousParryTimeStamp = -1.000000F;
			DisableDismembermentAfterDeathDelay = 10.000000F;
			CumulativeDamageUpdateInterval = 0.250000F;
			HitPosition = new();
			HitDirection = new();
			MaxHitChainForMelee = 2;
			MaxHitChainForRanged = 2;
			HitCountData = new(100);
			HitCountArrayEnd = 100;
		}
	}
}
