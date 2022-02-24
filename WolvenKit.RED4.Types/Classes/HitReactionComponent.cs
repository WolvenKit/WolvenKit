using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitReactionComponent : AIMandatoryComponents
	{
		[Ordinal(5)] 
		[RED("ownerNPC")] 
		public CWeakHandle<NPCPuppet> OwnerNPC
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(6)] 
		[RED("ownerPuppet")] 
		public CWeakHandle<ScriptedPuppet> OwnerPuppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(7)] 
		[RED("ownerWeapon")] 
		public CWeakHandle<gameweaponObject> OwnerWeapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(8)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(9)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CHandle<gameStatsSystem>>();
			set => SetPropertyValue<CHandle<gameStatsSystem>>(value);
		}

		[Ordinal(10)] 
		[RED("ownerIsMassive")] 
		public CBool OwnerIsMassive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("impactDamageDuration")] 
		public CFloat ImpactDamageDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("staggerDamageDuration")] 
		public CFloat StaggerDamageDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("impactDamageDurationMelee")] 
		public CFloat ImpactDamageDurationMelee
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("staggerDamageDurationMelee")] 
		public CFloat StaggerDamageDurationMelee
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("knockdownDamageDuration")] 
		public CFloat KnockdownDamageDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("defeatedMinDuration")] 
		public CFloat DefeatedMinDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("previousHitTime")] 
		public CFloat PreviousHitTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("reactionType")] 
		public CEnum<animHitReactionType> ReactionType
		{
			get => GetPropertyValue<CEnum<animHitReactionType>>();
			set => SetPropertyValue<CEnum<animHitReactionType>>(value);
		}

		[Ordinal(19)] 
		[RED("animHitReaction")] 
		public CHandle<animAnimFeature_HitReactionsData> AnimHitReaction
		{
			get => GetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>();
			set => SetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>(value);
		}

		[Ordinal(20)] 
		[RED("lastAnimHitReaction")] 
		public CHandle<animAnimFeature_HitReactionsData> LastAnimHitReaction
		{
			get => GetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>();
			set => SetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>(value);
		}

		[Ordinal(21)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get => GetPropertyValue<CHandle<ActionHitReactionScriptProxy>>();
			set => SetPropertyValue<CHandle<ActionHitReactionScriptProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("previousAnimHitReactionArray")] 
		public CArray<ScriptHitData> PreviousAnimHitReactionArray
		{
			get => GetPropertyValue<CArray<ScriptHitData>>();
			set => SetPropertyValue<CArray<ScriptHitData>>(value);
		}

		[Ordinal(23)] 
		[RED("lastHitReactionPlayed")] 
		public CEnum<EAILastHitReactionPlayed> LastHitReactionPlayed
		{
			get => GetPropertyValue<CEnum<EAILastHitReactionPlayed>>();
			set => SetPropertyValue<CEnum<EAILastHitReactionPlayed>>(value);
		}

		[Ordinal(24)] 
		[RED("hitShapeData")] 
		public gameShapeData HitShapeData
		{
			get => GetPropertyValue<gameShapeData>();
			set => SetPropertyValue<gameShapeData>(value);
		}

		[Ordinal(25)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(26)] 
		[RED("specificHitTimeout")] 
		public CFloat SpecificHitTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("quickMeleeCooldown")] 
		public CFloat QuickMeleeCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("dismembermentBodyPartDamageThreshold")] 
		public CArray<CFloat> DismembermentBodyPartDamageThreshold
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(29)] 
		[RED("woundedBodyPartDamageThreshold")] 
		public CArray<CFloat> WoundedBodyPartDamageThreshold
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(30)] 
		[RED("defeatedBodyPartDamageThreshold")] 
		public CArray<CFloat> DefeatedBodyPartDamageThreshold
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(31)] 
		[RED("defeatedDamageThreshold")] 
		public CFloat DefeatedDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("impactDamageThreshold")] 
		public CFloat ImpactDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("staggerDamageThreshold")] 
		public CFloat StaggerDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("knockdownDamageThreshold")] 
		public CFloat KnockdownDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("knockdownImpulseThreshold")] 
		public CFloat KnockdownImpulseThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("immuneToKnockDown")] 
		public CBool ImmuneToKnockDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("hitComboReset")] 
		public CFloat HitComboReset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("physicalImpulseReset")] 
		public CFloat PhysicalImpulseReset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("guardBreakImpulseReset")] 
		public CFloat GuardBreakImpulseReset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(40)] 
		[RED("cumulatedDamages")] 
		public CFloat CumulatedDamages
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("bodyPartWoundCumulatedDamages")] 
		public CArray<CFloat> BodyPartWoundCumulatedDamages
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(42)] 
		[RED("bodyPartDismemberCumulatedDamages")] 
		public CArray<CFloat> BodyPartDismemberCumulatedDamages
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(43)] 
		[RED("attackerWeaponKnockdownImpulse")] 
		public CFloat AttackerWeaponKnockdownImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("attackerWeaponKnockdownImpulseForEvade")] 
		public CFloat AttackerWeaponKnockdownImpulseForEvade
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("attackerWeaponKnockdownImpulseForEvadeCumulation")] 
		public CFloat AttackerWeaponKnockdownImpulseForEvadeCumulation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(46)] 
		[RED("ownerWeaponKnockdownImpulseForEvade")] 
		public CFloat OwnerWeaponKnockdownImpulseForEvade
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
		[RED("cumulatedPhysicalImpulse")] 
		public CFloat CumulatedPhysicalImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(48)] 
		[RED("cumulatedGuardBreakImpulse")] 
		public CFloat CumulatedGuardBreakImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(49)] 
		[RED("cumulatedEvadeBreakImpulse")] 
		public CFloat CumulatedEvadeBreakImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(50)] 
		[RED("ragdollImpulse")] 
		public CFloat RagdollImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(51)] 
		[RED("hitIntensity")] 
		public CEnum<EAIHitIntensity> HitIntensity
		{
			get => GetPropertyValue<CEnum<EAIHitIntensity>>();
			set => SetPropertyValue<CEnum<EAIHitIntensity>>(value);
		}

		[Ordinal(52)] 
		[RED("previousMeleeHitTimeStamp")] 
		public CFloat PreviousMeleeHitTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("previousRangedHitTimeStamp")] 
		public CFloat PreviousRangedHitTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("previousBlockTimeStamp")] 
		public CFloat PreviousBlockTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("previousParryTimeStamp")] 
		public CFloat PreviousParryTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("previousDodgeTimeStamp")] 
		public CFloat PreviousDodgeTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("previousRagdollTimeStamp")] 
		public CFloat PreviousRagdollTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("blockCount")] 
		public CInt32 BlockCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(59)] 
		[RED("parryCount")] 
		public CInt32 ParryCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(60)] 
		[RED("dodgeCount")] 
		public CInt32 DodgeCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(61)] 
		[RED("hitCount")] 
		public CUInt32 HitCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(62)] 
		[RED("defeatedHasBeenPlayed")] 
		public CBool DefeatedHasBeenPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("deathHasBeenPlayed")] 
		public CBool DeathHasBeenPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("deathRegisteredTime")] 
		public CFloat DeathRegisteredTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(65)] 
		[RED("extendedDeathRegisteredTime")] 
		public CFloat ExtendedDeathRegisteredTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(66)] 
		[RED("extendedDeathDelayRegisteredTime")] 
		public CFloat ExtendedDeathDelayRegisteredTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(67)] 
		[RED("disableDismembermentAfterDeathDelay")] 
		public CFloat DisableDismembermentAfterDeathDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(68)] 
		[RED("extendedHitReactionRegisteredTime")] 
		public CFloat ExtendedHitReactionRegisteredTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(69)] 
		[RED("extendedHitReactionDelayRegisteredTime")] 
		public CFloat ExtendedHitReactionDelayRegisteredTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(70)] 
		[RED("scatteredGuts")] 
		public CBool ScatteredGuts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("cumulativeDamageUpdateInterval")] 
		public CFloat CumulativeDamageUpdateInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(72)] 
		[RED("cumulativeDamageUpdateRequested")] 
		public CBool CumulativeDamageUpdateRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("currentStimId")] 
		public CUInt32 CurrentStimId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(74)] 
		[RED("attackData")] 
		public CHandle<gamedamageAttackData> AttackData
		{
			get => GetPropertyValue<CHandle<gamedamageAttackData>>();
			set => SetPropertyValue<CHandle<gamedamageAttackData>>(value);
		}

		[Ordinal(75)] 
		[RED("attackDirectionToInt")] 
		public CInt32 AttackDirectionToInt
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(76)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(77)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(78)] 
		[RED("hitDirectionToInt")] 
		public CInt32 HitDirectionToInt
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(79)] 
		[RED("overridenHitDirection")] 
		public CBool OverridenHitDirection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(80)] 
		[RED("lastHitReactionBehaviorData")] 
		public CHandle<HitReactionBehaviorData> LastHitReactionBehaviorData
		{
			get => GetPropertyValue<CHandle<HitReactionBehaviorData>>();
			set => SetPropertyValue<CHandle<HitReactionBehaviorData>>(value);
		}

		[Ordinal(81)] 
		[RED("lastStimName")] 
		public CName LastStimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(82)] 
		[RED("deathStimName")] 
		public CName DeathStimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(83)] 
		[RED("meleeHitCount")] 
		public CInt32 MeleeHitCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(84)] 
		[RED("strongMeleeHitCount")] 
		public CInt32 StrongMeleeHitCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(85)] 
		[RED("meleeBaseMaxHitChain")] 
		public CInt32 MeleeBaseMaxHitChain
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(86)] 
		[RED("rangedBaseMaxHitChain")] 
		public CInt32 RangedBaseMaxHitChain
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(87)] 
		[RED("maxHitChainForMelee")] 
		public CInt32 MaxHitChainForMelee
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(88)] 
		[RED("maxHitChainForRanged")] 
		public CInt32 MaxHitChainForRanged
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(89)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(90)] 
		[RED("frameDamageHealthFactor")] 
		public CFloat FrameDamageHealthFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(91)] 
		[RED("hitCountData", 100)] 
		public CArrayFixedSize<CFloat> HitCountData
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(92)] 
		[RED("hitCountArrayEnd")] 
		public CInt32 HitCountArrayEnd
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(93)] 
		[RED("hitCountArrayCurrent")] 
		public CInt32 HitCountArrayCurrent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(94)] 
		[RED("allowDefeatedOnCompanion")] 
		public CBool AllowDefeatedOnCompanion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(95)] 
		[RED("baseCumulativeDamagesDecreaser")] 
		public CFloat BaseCumulativeDamagesDecreaser
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(96)] 
		[RED("blockCountInterval")] 
		public CFloat BlockCountInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(97)] 
		[RED("dodgeCountInterval")] 
		public CFloat DodgeCountInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(98)] 
		[RED("globalHitTimer")] 
		public CFloat GlobalHitTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(99)] 
		[RED("hasMantisBladesinRecord")] 
		public CBool HasMantisBladesinRecord
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(100)] 
		[RED("indicatorEnabledBlackboardId")] 
		public CHandle<redCallbackObject> IndicatorEnabledBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(101)] 
		[RED("hitIndicatorEnabled")] 
		public CBool HitIndicatorEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(102)] 
		[RED("hasBeenWounded")] 
		public CBool HasBeenWounded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(103)] 
		[RED("inWorkspot")] 
		public CBool InWorkspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(104)] 
		[RED("inCover")] 
		public CBool InCover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("healthListener")] 
		public CHandle<NPCHealthListener> HealthListener
		{
			get => GetPropertyValue<CHandle<NPCHealthListener>>();
			set => SetPropertyValue<CHandle<NPCHealthListener>>(value);
		}

		[Ordinal(106)] 
		[RED("hitReactionComponentStatsListener")] 
		public CHandle<NPCHitReactionComponentStatsListener> HitReactionComponentStatsListener
		{
			get => GetPropertyValue<CHandle<NPCHitReactionComponentStatsListener>>();
			set => SetPropertyValue<CHandle<NPCHitReactionComponentStatsListener>>(value);
		}

		[Ordinal(107)] 
		[RED("currentHealth")] 
		public CFloat CurrentHealth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(108)] 
		[RED("totalHealth")] 
		public CFloat TotalHealth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(109)] 
		[RED("totalStamina")] 
		public CFloat TotalStamina
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(110)] 
		[RED("currentCanDropWeapon")] 
		public CFloat CurrentCanDropWeapon
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(111)] 
		[RED("currentExtendedHitReactionImmunity")] 
		public CFloat CurrentExtendedHitReactionImmunity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(112)] 
		[RED("currentIsInvulnerable")] 
		public CFloat CurrentIsInvulnerable
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(113)] 
		[RED("currentDefeatedDamageThreshold")] 
		public CFloat CurrentDefeatedDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(114)] 
		[RED("currentImpactDamageThreshold")] 
		public CFloat CurrentImpactDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(115)] 
		[RED("currentImpactDamageThresholdInCover")] 
		public CFloat CurrentImpactDamageThresholdInCover
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(116)] 
		[RED("currentKnockdownDamageThreshold")] 
		public CFloat CurrentKnockdownDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(117)] 
		[RED("currentKnockdownDamageThresholdImpulse")] 
		public CFloat CurrentKnockdownDamageThresholdImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(118)] 
		[RED("currentKnockdownDamageThresholdInCover")] 
		public CFloat CurrentKnockdownDamageThresholdInCover
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(119)] 
		[RED("currentKnockdownImmunity")] 
		public CFloat CurrentKnockdownImmunity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(120)] 
		[RED("currentMeleeImmunity")] 
		public CFloat CurrentMeleeImmunity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(121)] 
		[RED("currentStaggerDamageThreshold")] 
		public CFloat CurrentStaggerDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(122)] 
		[RED("currentStaggerDamageThresholdInCover")] 
		public CFloat CurrentStaggerDamageThresholdInCover
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(123)] 
		[RED("currentCanBlock")] 
		public CFloat CurrentCanBlock
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(124)] 
		[RED("currentHasKerenzikov")] 
		public CFloat CurrentHasKerenzikov
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(125)] 
		[RED("hitReactionData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitReactionData
		{
			get => GetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>();
			set => SetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>(value);
		}

		public HitReactionComponent()
		{
			OwnerID = new();
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
			PhysicalImpulseReset = 0.500000F;
			GuardBreakImpulseReset = 5.000000F;
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
