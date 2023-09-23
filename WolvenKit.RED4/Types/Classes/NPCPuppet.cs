using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCPuppet : ScriptedPuppet
	{
		[Ordinal(101)] 
		[RED("lastHitEvent")] 
		public CHandle<gameeventsHitEvent> LastHitEvent
		{
			get => GetPropertyValue<CHandle<gameeventsHitEvent>>();
			set => SetPropertyValue<CHandle<gameeventsHitEvent>>(value);
		}

		[Ordinal(102)] 
		[RED("totalFrameReactionDamageReceived")] 
		public CFloat TotalFrameReactionDamageReceived
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(103)] 
		[RED("totalFrameWoundsDamageReceived")] 
		public CFloat TotalFrameWoundsDamageReceived
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(104)] 
		[RED("totalFrameDismembermentDamageReceived")] 
		public CFloat TotalFrameDismembermentDamageReceived
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(105)] 
		[RED("hitEventLock")] 
		public ScriptReentrantRWLock HitEventLock
		{
			get => GetPropertyValue<ScriptReentrantRWLock>();
			set => SetPropertyValue<ScriptReentrantRWLock>(value);
		}

		[Ordinal(106)] 
		[RED("NPCManager")] 
		public CHandle<NPCManager> NPCManager
		{
			get => GetPropertyValue<CHandle<NPCManager>>();
			set => SetPropertyValue<CHandle<NPCManager>>(value);
		}

		[Ordinal(107)] 
		[RED("customDeathDirection")] 
		public CInt32 CustomDeathDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(108)] 
		[RED("deathOverrideState")] 
		public CBool DeathOverrideState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("agonyState")] 
		public CBool AgonyState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("defensiveState")] 
		public CBool DefensiveState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("lastSetupWorkspotActionEvent")] 
		public CHandle<gameSetupWorkspotActionEvent> LastSetupWorkspotActionEvent
		{
			get => GetPropertyValue<CHandle<gameSetupWorkspotActionEvent>>();
			set => SetPropertyValue<CHandle<gameSetupWorkspotActionEvent>>(value);
		}

		[Ordinal(112)] 
		[RED("wasJustKilledOrDefeated")] 
		public CBool WasJustKilledOrDefeated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(113)] 
		[RED("shouldDie")] 
		public CBool ShouldDie
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(114)] 
		[RED("shouldBeDefeated")] 
		public CBool ShouldBeDefeated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(115)] 
		[RED("sentDownedEvent")] 
		public CBool SentDownedEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(116)] 
		[RED("isRagdolling")] 
		public CBool IsRagdolling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("hasAnimatedRagdoll")] 
		public CBool HasAnimatedRagdoll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(118)] 
		[RED("disableCollisionRequested")] 
		public CBool DisableCollisionRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(119)] 
		[RED("ragdollInstigator")] 
		public CWeakHandle<gameObject> RagdollInstigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(120)] 
		[RED("ragdollSplattersSpawned")] 
		public CInt32 RagdollSplattersSpawned
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(121)] 
		[RED("ragdollFloorSplashSpawned")] 
		public CBool RagdollFloorSplashSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(122)] 
		[RED("ragdollDamageData")] 
		public RagdollDamagePollData RagdollDamageData
		{
			get => GetPropertyValue<RagdollDamagePollData>();
			set => SetPropertyValue<RagdollDamagePollData>(value);
		}

		[Ordinal(123)] 
		[RED("ragdollInitialPosition")] 
		public Vector4 RagdollInitialPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(124)] 
		[RED("ragdollActivationTimestamp")] 
		public CFloat RagdollActivationTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(125)] 
		[RED("ragdollImpactedNPCs")] 
		public CArray<CWeakHandle<NPCPuppet>> RagdollImpactedNPCs
		{
			get => GetPropertyValue<CArray<CWeakHandle<NPCPuppet>>>();
			set => SetPropertyValue<CArray<CWeakHandle<NPCPuppet>>>(value);
		}

		[Ordinal(126)] 
		[RED("disableRagdollAfterRecovery")] 
		public CBool DisableRagdollAfterRecovery
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(127)] 
		[RED("thrownNPCNearbyCrowdNPCs")] 
		public CArray<CWeakHandle<entEntity>> ThrownNPCNearbyCrowdNPCs
		{
			get => GetPropertyValue<CArray<CWeakHandle<entEntity>>>();
			set => SetPropertyValue<CArray<CWeakHandle<entEntity>>>(value);
		}

		[Ordinal(128)] 
		[RED("isNotVisible")] 
		public CBool IsNotVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(129)] 
		[RED("deathListener")] 
		public CHandle<NPCDeathListener> DeathListener
		{
			get => GetPropertyValue<CHandle<NPCDeathListener>>();
			set => SetPropertyValue<CHandle<NPCDeathListener>>(value);
		}

		[Ordinal(130)] 
		[RED("poiseListener")] 
		public CHandle<NPCPoiseListener> PoiseListener
		{
			get => GetPropertyValue<CHandle<NPCPoiseListener>>();
			set => SetPropertyValue<CHandle<NPCPoiseListener>>(value);
		}

		[Ordinal(131)] 
		[RED("godModeStatListener")] 
		public CHandle<NPCGodModeListener> GodModeStatListener
		{
			get => GetPropertyValue<CHandle<NPCGodModeListener>>();
			set => SetPropertyValue<CHandle<NPCGodModeListener>>(value);
		}

		[Ordinal(132)] 
		[RED("VehicleHitImmunityCallbackID")] 
		public CUInt32 VehicleHitImmunityCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(133)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(134)] 
		[RED("npcRagdollComponent")] 
		public CHandle<entIComponent> NpcRagdollComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(135)] 
		[RED("npcTraceObstacleComponent")] 
		public CHandle<entSimpleColliderComponent> NpcTraceObstacleComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(136)] 
		[RED("npcMountedToPlayerComponents")] 
		public CArray<CHandle<entIComponent>> NpcMountedToPlayerComponents
		{
			get => GetPropertyValue<CArray<CHandle<entIComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIComponent>>>(value);
		}

		[Ordinal(137)] 
		[RED("scavengeComponent")] 
		public CHandle<ScavengeComponent> ScavengeComponent
		{
			get => GetPropertyValue<CHandle<ScavengeComponent>>();
			set => SetPropertyValue<CHandle<ScavengeComponent>>(value);
		}

		[Ordinal(138)] 
		[RED("influenceComponent")] 
		public CHandle<gameinfluenceComponent> InfluenceComponent
		{
			get => GetPropertyValue<CHandle<gameinfluenceComponent>>();
			set => SetPropertyValue<CHandle<gameinfluenceComponent>>(value);
		}

		[Ordinal(139)] 
		[RED("comfortZoneComponent")] 
		public CHandle<entIComponent> ComfortZoneComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(140)] 
		[RED("isTargetingPlayer")] 
		public CBool IsTargetingPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(141)] 
		[RED("shouldBeImmuneToVehicleHit")] 
		public CBool ShouldBeImmuneToVehicleHit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(142)] 
		[RED("playerStatsListener")] 
		public CHandle<gameScriptStatsListener> PlayerStatsListener
		{
			get => GetPropertyValue<CHandle<gameScriptStatsListener>>();
			set => SetPropertyValue<CHandle<gameScriptStatsListener>>(value);
		}

		[Ordinal(143)] 
		[RED("upperBodyStateCallbackID")] 
		public CHandle<redCallbackObject> UpperBodyStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(144)] 
		[RED("leftCyberwareStateCallbackID")] 
		public CHandle<redCallbackObject> LeftCyberwareStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(145)] 
		[RED("meleeStateCallbackID")] 
		public CHandle<redCallbackObject> MeleeStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(146)] 
		[RED("combatGadgetStateCallbackID")] 
		public CHandle<redCallbackObject> CombatGadgetStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(147)] 
		[RED("wasAimedAtLast")] 
		public CBool WasAimedAtLast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(148)] 
		[RED("wasCWChargedAtLast")] 
		public CBool WasCWChargedAtLast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(149)] 
		[RED("wasMeleeChargedAtLast")] 
		public CBool WasMeleeChargedAtLast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(150)] 
		[RED("wasChargingGadgetAtLast")] 
		public CBool WasChargingGadgetAtLast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(151)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(152)] 
		[RED("cachedPlayerID")] 
		public entEntityID CachedPlayerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(153)] 
		[RED("wasAggressiveCrowd")] 
		public CBool WasAggressiveCrowd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(154)] 
		[RED("canGoThroughDoors")] 
		public CBool CanGoThroughDoors
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(155)] 
		[RED("lastStatusEffectSignalSent")] 
		public CWeakHandle<gamedataStatusEffect_Record> LastStatusEffectSignalSent
		{
			get => GetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>(value);
		}

		[Ordinal(156)] 
		[RED("cachedStatusEffectAnim")] 
		public CWeakHandle<gamedataStatusEffect_Record> CachedStatusEffectAnim
		{
			get => GetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>(value);
		}

		[Ordinal(157)] 
		[RED("resendStatusEffectSignalDelayID")] 
		public gameDelayID ResendStatusEffectSignalDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(158)] 
		[RED("lastSEAppliedByPlayer")] 
		public CHandle<gameStatusEffect> LastSEAppliedByPlayer
		{
			get => GetPropertyValue<CHandle<gameStatusEffect>>();
			set => SetPropertyValue<CHandle<gameStatusEffect>>(value);
		}

		[Ordinal(159)] 
		[RED("pendingSEEvent")] 
		public CHandle<gameeventsApplyStatusEffectEvent> PendingSEEvent
		{
			get => GetPropertyValue<CHandle<gameeventsApplyStatusEffectEvent>>();
			set => SetPropertyValue<CHandle<gameeventsApplyStatusEffectEvent>>(value);
		}

		[Ordinal(160)] 
		[RED("pendingDueToCachedSEAnim")] 
		public CBool PendingDueToCachedSEAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(161)] 
		[RED("bounty")] 
		public Bounty Bounty
		{
			get => GetPropertyValue<Bounty>();
			set => SetPropertyValue<Bounty>(value);
		}

		[Ordinal(162)] 
		[RED("cachedVFXList")] 
		public CArray<CWeakHandle<gamedataStatusEffectFX_Record>> CachedVFXList
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>(value);
		}

		[Ordinal(163)] 
		[RED("cachedSFXList")] 
		public CArray<CWeakHandle<gamedataStatusEffectFX_Record>> CachedSFXList
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>(value);
		}

		[Ordinal(164)] 
		[RED("isThrowingGrenadeToPlayer")] 
		public CBool IsThrowingGrenadeToPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(165)] 
		[RED("throwingGrenadeDelayEventID")] 
		public gameDelayID ThrowingGrenadeDelayEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(166)] 
		[RED("myKiller")] 
		public CWeakHandle<gameObject> MyKiller
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(167)] 
		[RED("primaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> PrimaryThreatCalculationType
		{
			get => GetPropertyValue<CEnum<EAIThreatCalculationType>>();
			set => SetPropertyValue<CEnum<EAIThreatCalculationType>>(value);
		}

		[Ordinal(168)] 
		[RED("temporaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> TemporaryThreatCalculationType
		{
			get => GetPropertyValue<CEnum<EAIThreatCalculationType>>();
			set => SetPropertyValue<CEnum<EAIThreatCalculationType>>(value);
		}

		[Ordinal(169)] 
		[RED("isPlayerCompanionCached")] 
		public CBool IsPlayerCompanionCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(170)] 
		[RED("isPlayerCompanionCachedTimeStamp")] 
		public CFloat IsPlayerCompanionCachedTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(171)] 
		[RED("quickHackEffectsApplied")] 
		public CUInt32 QuickHackEffectsApplied
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(172)] 
		[RED("hackingResistanceMod")] 
		public CHandle<gameConstantStatModifierData_Deprecated> HackingResistanceMod
		{
			get => GetPropertyValue<CHandle<gameConstantStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameConstantStatModifierData_Deprecated>>(value);
		}

		[Ordinal(173)] 
		[RED("delayNonStealthQuickHackVictimEventID")] 
		public gameDelayID DelayNonStealthQuickHackVictimEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(174)] 
		[RED("cachedIsPaperdoll")] 
		public CInt32 CachedIsPaperdoll
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(175)] 
		[RED("smartDespawnDelayID")] 
		public gameDelayID SmartDespawnDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(176)] 
		[RED("despawnTicks")] 
		public CUInt32 DespawnTicks
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public NPCPuppet()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
