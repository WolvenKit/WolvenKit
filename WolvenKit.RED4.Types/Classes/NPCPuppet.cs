using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCPuppet : ScriptedPuppet
	{
		[Ordinal(96)] 
		[RED("lastHitEvent")] 
		public CHandle<gameeventsHitEvent> LastHitEvent
		{
			get => GetPropertyValue<CHandle<gameeventsHitEvent>>();
			set => SetPropertyValue<CHandle<gameeventsHitEvent>>(value);
		}

		[Ordinal(97)] 
		[RED("totalFrameReactionDamageReceived")] 
		public CFloat TotalFrameReactionDamageReceived
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(98)] 
		[RED("totalFrameWoundsDamageReceived")] 
		public CFloat TotalFrameWoundsDamageReceived
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(99)] 
		[RED("totalFrameDismembermentDamageReceived")] 
		public CFloat TotalFrameDismembermentDamageReceived
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(100)] 
		[RED("hitEventLock")] 
		public ScriptReentrantRWLock HitEventLock
		{
			get => GetPropertyValue<ScriptReentrantRWLock>();
			set => SetPropertyValue<ScriptReentrantRWLock>(value);
		}

		[Ordinal(101)] 
		[RED("NPCManager")] 
		public CHandle<NPCManager> NPCManager
		{
			get => GetPropertyValue<CHandle<NPCManager>>();
			set => SetPropertyValue<CHandle<NPCManager>>(value);
		}

		[Ordinal(102)] 
		[RED("customDeathDirection")] 
		public CInt32 CustomDeathDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(103)] 
		[RED("deathOverrideState")] 
		public CBool DeathOverrideState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(104)] 
		[RED("agonyState")] 
		public CBool AgonyState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("defensiveState")] 
		public CBool DefensiveState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(106)] 
		[RED("lastSetupWorkspotActionEvent")] 
		public CHandle<gameSetupWorkspotActionEvent> LastSetupWorkspotActionEvent
		{
			get => GetPropertyValue<CHandle<gameSetupWorkspotActionEvent>>();
			set => SetPropertyValue<CHandle<gameSetupWorkspotActionEvent>>(value);
		}

		[Ordinal(107)] 
		[RED("wasJustKilledOrDefeated")] 
		public CBool WasJustKilledOrDefeated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("shouldDie")] 
		public CBool ShouldDie
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("shouldBeDefeated")] 
		public CBool ShouldBeDefeated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("sentDownedEvent")] 
		public CBool SentDownedEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("isRagdolling")] 
		public CBool IsRagdolling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("hasAnimatedRagdoll")] 
		public CBool HasAnimatedRagdoll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(113)] 
		[RED("disableCollisionRequested")] 
		public CBool DisableCollisionRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(114)] 
		[RED("ragdollInstigator")] 
		public CWeakHandle<gameObject> RagdollInstigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(115)] 
		[RED("ragdollSplattersSpawned")] 
		public CInt32 RagdollSplattersSpawned
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(116)] 
		[RED("ragdollFloorSplashSpawned")] 
		public CBool RagdollFloorSplashSpawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("ragdollImpactData")] 
		public entRagdollImpactPointData RagdollImpactData
		{
			get => GetPropertyValue<entRagdollImpactPointData>();
			set => SetPropertyValue<entRagdollImpactPointData>(value);
		}

		[Ordinal(118)] 
		[RED("ragdollDamageData")] 
		public RagdollDamagePollData RagdollDamageData
		{
			get => GetPropertyValue<RagdollDamagePollData>();
			set => SetPropertyValue<RagdollDamagePollData>(value);
		}

		[Ordinal(119)] 
		[RED("ragdollInitialPosition")] 
		public Vector4 RagdollInitialPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(120)] 
		[RED("ragdollActivationTimestamp")] 
		public CFloat RagdollActivationTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(121)] 
		[RED("ragdolledEntities")] 
		public CArray<CWeakHandle<entEntity>> RagdolledEntities
		{
			get => GetPropertyValue<CArray<CWeakHandle<entEntity>>>();
			set => SetPropertyValue<CArray<CWeakHandle<entEntity>>>(value);
		}

		[Ordinal(122)] 
		[RED("disableRagdollAfterRecovery")] 
		public CBool DisableRagdollAfterRecovery
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(123)] 
		[RED("isNotVisible")] 
		public CBool IsNotVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(124)] 
		[RED("deathListener")] 
		public CHandle<NPCDeathListener> DeathListener
		{
			get => GetPropertyValue<CHandle<NPCDeathListener>>();
			set => SetPropertyValue<CHandle<NPCDeathListener>>(value);
		}

		[Ordinal(125)] 
		[RED("godModeStatListener")] 
		public CHandle<NPCGodModeListener> GodModeStatListener
		{
			get => GetPropertyValue<CHandle<NPCGodModeListener>>();
			set => SetPropertyValue<CHandle<NPCGodModeListener>>(value);
		}

		[Ordinal(126)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(127)] 
		[RED("npcRagdollComponent")] 
		public CHandle<entIComponent> NpcRagdollComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(128)] 
		[RED("npcTraceObstacleComponent")] 
		public CHandle<entSimpleColliderComponent> NpcTraceObstacleComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(129)] 
		[RED("npcMountedToPlayerComponents")] 
		public CArray<CHandle<entIComponent>> NpcMountedToPlayerComponents
		{
			get => GetPropertyValue<CArray<CHandle<entIComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIComponent>>>(value);
		}

		[Ordinal(130)] 
		[RED("scavengeComponent")] 
		public CHandle<ScavengeComponent> ScavengeComponent
		{
			get => GetPropertyValue<CHandle<ScavengeComponent>>();
			set => SetPropertyValue<CHandle<ScavengeComponent>>(value);
		}

		[Ordinal(131)] 
		[RED("influenceComponent")] 
		public CHandle<gameinfluenceComponent> InfluenceComponent
		{
			get => GetPropertyValue<CHandle<gameinfluenceComponent>>();
			set => SetPropertyValue<CHandle<gameinfluenceComponent>>(value);
		}

		[Ordinal(132)] 
		[RED("comfortZoneComponent")] 
		public CHandle<entIComponent> ComfortZoneComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(133)] 
		[RED("isTargetingPlayer")] 
		public CBool IsTargetingPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(134)] 
		[RED("playerStatsListener")] 
		public CHandle<gameScriptStatsListener> PlayerStatsListener
		{
			get => GetPropertyValue<CHandle<gameScriptStatsListener>>();
			set => SetPropertyValue<CHandle<gameScriptStatsListener>>(value);
		}

		[Ordinal(135)] 
		[RED("upperBodyStateCallbackID")] 
		public CHandle<redCallbackObject> UpperBodyStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(136)] 
		[RED("leftCyberwareStateCallbackID")] 
		public CHandle<redCallbackObject> LeftCyberwareStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(137)] 
		[RED("meleeStateCallbackID")] 
		public CHandle<redCallbackObject> MeleeStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(138)] 
		[RED("combatGadgetStateCallbackID")] 
		public CHandle<redCallbackObject> CombatGadgetStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(139)] 
		[RED("wasAimedAtLast")] 
		public CBool WasAimedAtLast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(140)] 
		[RED("wasCWChargedAtLast")] 
		public CBool WasCWChargedAtLast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(141)] 
		[RED("wasMeleeChargedAtLast")] 
		public CBool WasMeleeChargedAtLast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(142)] 
		[RED("wasChargingGadgetAtLast")] 
		public CBool WasChargingGadgetAtLast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(143)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(144)] 
		[RED("cachedPlayerID")] 
		public entEntityID CachedPlayerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(145)] 
		[RED("canGoThroughDoors")] 
		public CBool CanGoThroughDoors
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(146)] 
		[RED("lastStatusEffectSignalSent")] 
		public CWeakHandle<gamedataStatusEffect_Record> LastStatusEffectSignalSent
		{
			get => GetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>(value);
		}

		[Ordinal(147)] 
		[RED("cachedStatusEffectAnim")] 
		public CWeakHandle<gamedataStatusEffect_Record> CachedStatusEffectAnim
		{
			get => GetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>(value);
		}

		[Ordinal(148)] 
		[RED("resendStatusEffectSignalDelayID")] 
		public gameDelayID ResendStatusEffectSignalDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(149)] 
		[RED("lastSEAppliedByPlayer")] 
		public CHandle<gameStatusEffect> LastSEAppliedByPlayer
		{
			get => GetPropertyValue<CHandle<gameStatusEffect>>();
			set => SetPropertyValue<CHandle<gameStatusEffect>>(value);
		}

		[Ordinal(150)] 
		[RED("pendingSEEvent")] 
		public CHandle<gameeventsApplyStatusEffectEvent> PendingSEEvent
		{
			get => GetPropertyValue<CHandle<gameeventsApplyStatusEffectEvent>>();
			set => SetPropertyValue<CHandle<gameeventsApplyStatusEffectEvent>>(value);
		}

		[Ordinal(151)] 
		[RED("bounty")] 
		public Bounty Bounty
		{
			get => GetPropertyValue<Bounty>();
			set => SetPropertyValue<Bounty>(value);
		}

		[Ordinal(152)] 
		[RED("cachedVFXList")] 
		public CArray<CWeakHandle<gamedataStatusEffectFX_Record>> CachedVFXList
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>(value);
		}

		[Ordinal(153)] 
		[RED("cachedSFXList")] 
		public CArray<CWeakHandle<gamedataStatusEffectFX_Record>> CachedSFXList
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataStatusEffectFX_Record>>>(value);
		}

		[Ordinal(154)] 
		[RED("isThrowingGrenadeToPlayer")] 
		public CBool IsThrowingGrenadeToPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(155)] 
		[RED("throwingGrenadeDelayEventID")] 
		public gameDelayID ThrowingGrenadeDelayEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(156)] 
		[RED("myKiller")] 
		public CWeakHandle<gameObject> MyKiller
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(157)] 
		[RED("primaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> PrimaryThreatCalculationType
		{
			get => GetPropertyValue<CEnum<EAIThreatCalculationType>>();
			set => SetPropertyValue<CEnum<EAIThreatCalculationType>>(value);
		}

		[Ordinal(158)] 
		[RED("temporaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> TemporaryThreatCalculationType
		{
			get => GetPropertyValue<CEnum<EAIThreatCalculationType>>();
			set => SetPropertyValue<CEnum<EAIThreatCalculationType>>(value);
		}

		[Ordinal(159)] 
		[RED("isPlayerCompanionCached")] 
		public CBool IsPlayerCompanionCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(160)] 
		[RED("isPlayerCompanionCachedTimeStamp")] 
		public CFloat IsPlayerCompanionCachedTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(161)] 
		[RED("quickHackEffectsApplied")] 
		public CUInt32 QuickHackEffectsApplied
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(162)] 
		[RED("hackingResistanceMod")] 
		public CHandle<gameConstantStatModifierData_Deprecated> HackingResistanceMod
		{
			get => GetPropertyValue<CHandle<gameConstantStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameConstantStatModifierData_Deprecated>>(value);
		}

		[Ordinal(163)] 
		[RED("delayNonStealthQuickHackVictimEventID")] 
		public gameDelayID DelayNonStealthQuickHackVictimEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(164)] 
		[RED("cachedIsPaperdoll")] 
		public CInt32 CachedIsPaperdoll
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(165)] 
		[RED("smartDespawnDelayID")] 
		public gameDelayID SmartDespawnDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(166)] 
		[RED("despawnTicks")] 
		public CUInt32 DespawnTicks
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public NPCPuppet()
		{
			HitEventLock = new();
			RagdollImpactData = new() { WorldPosition = new() { X = new(), Y = new(), Z = new() }, WorldNormal = new() { W = 1.000000F }, OtherProxyActorIndex = 1 };
			RagdollDamageData = new() { WorldPosition = new() { X = new(), Y = new(), Z = new() }, WorldNormal = new() };
			RagdollInitialPosition = new();
			RagdolledEntities = new();
			NpcMountedToPlayerComponents = new();
			CachedPlayerID = new();
			ResendStatusEffectSignalDelayID = new();
			Bounty = new() { Transgressions = new() };
			CachedVFXList = new();
			CachedSFXList = new();
			ThrowingGrenadeDelayEventID = new();
			DelayNonStealthQuickHackVictimEventID = new();
			SmartDespawnDelayID = new();
		}
	}
}
