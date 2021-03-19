using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCPuppet : ScriptedPuppet
	{
		private CHandle<gameeventsHitEvent> _lastHitEvent;
		private CFloat _totalFrameReactionDamageReceived;
		private CFloat _totalFrameWoundsDamageReceived;
		private CFloat _totalFrameDismembermentDamageReceived;
		private ScriptReentrantRWLock _hitEventLock;
		private CHandle<NPCManager> _nPCManager;
		private CInt32 _customDeathDirection;
		private CBool _deathOverrideState;
		private CBool _agonyState;
		private CBool _defensiveState;
		private CHandle<gameSetupWorkspotActionEvent> _lastSetupWorkspotActionEvent;
		private CBool _wasJustKilledOrDefeated;
		private CBool _shouldDie;
		private CBool _shouldBeDefeated;
		private CBool _sentDownedEvent;
		private CBool _isRagdolling;
		private CBool _hasAnimatedRagdoll;
		private CBool _disableCollisionRequested;
		private wCHandle<gameObject> _ragdollInstigator;
		private CInt32 _ragdollSplattersSpawned;
		private CBool _ragdollFloorSplashSpawned;
		private entRagdollImpactPointData _ragdollImpactData;
		private RagdollDamagePollData _ragdollDamageData;
		private Vector4 _ragdollInitialPosition;
		private CFloat _ragdollActivationTimestamp;
		private CArray<wCHandle<entEntity>> _ragdolledEntities;
		private CBool _isNotVisible;
		private CHandle<NPCDeathListener> _deathListener;
		private CHandle<NPCGodModeListener> _godModeStatListener;
		private CHandle<entSimpleColliderComponent> _npcCollisionComponent;
		private CHandle<entIComponent> _npcRagdollComponent;
		private CArray<CHandle<entIComponent>> _npcMountedToPlayerComponents;
		private CHandle<ScavengeComponent> _scavengeComponent;
		private CHandle<gameinfluenceComponent> _influenceComponent;
		private CHandle<entIComponent> _comfortZoneComponent;
		private CBool _isTargetingPlayer;
		private CHandle<gameScriptStatsListener> _playerStatsListener;
		private CUInt32 _upperBodyStateCallbackID;
		private CUInt32 _leftCyberwareStateCallbackID;
		private CUInt32 _meleeStateCallbackID;
		private CUInt32 _combatGadgetStateCallbackID;
		private CBool _wasAimedAtLast;
		private CBool _wasCWChargedAtLast;
		private CBool _wasMeleeChargedAtLast;
		private CBool _wasChargingGadgetAtLast;
		private CBool _isLookedAt;
		private entEntityID _cachedPlayerID;
		private CBool _canGoThroughDoors;
		private wCHandle<gamedataStatusEffect_Record> _lastStatusEffectSignalSent;
		private wCHandle<gamedataStatusEffect_Record> _cachedStatusEffectAnim;
		private gameDelayID _resendStatusEffectSignalDelayID;
		private CHandle<gameStatusEffect> _lastSEAppliedByPlayer;
		private CHandle<gameeventsApplyStatusEffectEvent> _pendingSEEvent;
		private Bounty _bounty;
		private CArray<wCHandle<gamedataStatusEffectFX_Record>> _cachedVFXList;
		private CArray<wCHandle<gamedataStatusEffectFX_Record>> _cachedSFXList;
		private CBool _isThrowingGrenadeToPlayer;
		private gameDelayID _throwingGrenadeDelayEventID;
		private wCHandle<gameObject> _myKiller;
		private CEnum<EAIThreatCalculationType> _primaryThreatCalculationType;
		private CEnum<EAIThreatCalculationType> _temporaryThreatCalculationType;
		private CBool _isPlayerCompanionCached;
		private CFloat _isPlayerCompanionCachedTimeStamp;
		private CUInt32 _quickHackEffectsApplied;
		private CHandle<gameConstantStatModifierData> _hackingResistanceMod;
		private gameDelayID _delayNonStealthQuickHackVictimEventID;
		private CInt32 _cachedIsPaperdoll;
		private gameDelayID _smartDespawnDelayID;
		private CUInt32 _despawnTicks;

		[Ordinal(96)] 
		[RED("lastHitEvent")] 
		public CHandle<gameeventsHitEvent> LastHitEvent
		{
			get => GetProperty(ref _lastHitEvent);
			set => SetProperty(ref _lastHitEvent, value);
		}

		[Ordinal(97)] 
		[RED("totalFrameReactionDamageReceived")] 
		public CFloat TotalFrameReactionDamageReceived
		{
			get => GetProperty(ref _totalFrameReactionDamageReceived);
			set => SetProperty(ref _totalFrameReactionDamageReceived, value);
		}

		[Ordinal(98)] 
		[RED("totalFrameWoundsDamageReceived")] 
		public CFloat TotalFrameWoundsDamageReceived
		{
			get => GetProperty(ref _totalFrameWoundsDamageReceived);
			set => SetProperty(ref _totalFrameWoundsDamageReceived, value);
		}

		[Ordinal(99)] 
		[RED("totalFrameDismembermentDamageReceived")] 
		public CFloat TotalFrameDismembermentDamageReceived
		{
			get => GetProperty(ref _totalFrameDismembermentDamageReceived);
			set => SetProperty(ref _totalFrameDismembermentDamageReceived, value);
		}

		[Ordinal(100)] 
		[RED("hitEventLock")] 
		public ScriptReentrantRWLock HitEventLock
		{
			get => GetProperty(ref _hitEventLock);
			set => SetProperty(ref _hitEventLock, value);
		}

		[Ordinal(101)] 
		[RED("NPCManager")] 
		public CHandle<NPCManager> NPCManager
		{
			get => GetProperty(ref _nPCManager);
			set => SetProperty(ref _nPCManager, value);
		}

		[Ordinal(102)] 
		[RED("customDeathDirection")] 
		public CInt32 CustomDeathDirection
		{
			get => GetProperty(ref _customDeathDirection);
			set => SetProperty(ref _customDeathDirection, value);
		}

		[Ordinal(103)] 
		[RED("deathOverrideState")] 
		public CBool DeathOverrideState
		{
			get => GetProperty(ref _deathOverrideState);
			set => SetProperty(ref _deathOverrideState, value);
		}

		[Ordinal(104)] 
		[RED("agonyState")] 
		public CBool AgonyState
		{
			get => GetProperty(ref _agonyState);
			set => SetProperty(ref _agonyState, value);
		}

		[Ordinal(105)] 
		[RED("defensiveState")] 
		public CBool DefensiveState
		{
			get => GetProperty(ref _defensiveState);
			set => SetProperty(ref _defensiveState, value);
		}

		[Ordinal(106)] 
		[RED("lastSetupWorkspotActionEvent")] 
		public CHandle<gameSetupWorkspotActionEvent> LastSetupWorkspotActionEvent
		{
			get => GetProperty(ref _lastSetupWorkspotActionEvent);
			set => SetProperty(ref _lastSetupWorkspotActionEvent, value);
		}

		[Ordinal(107)] 
		[RED("wasJustKilledOrDefeated")] 
		public CBool WasJustKilledOrDefeated
		{
			get => GetProperty(ref _wasJustKilledOrDefeated);
			set => SetProperty(ref _wasJustKilledOrDefeated, value);
		}

		[Ordinal(108)] 
		[RED("shouldDie")] 
		public CBool ShouldDie
		{
			get => GetProperty(ref _shouldDie);
			set => SetProperty(ref _shouldDie, value);
		}

		[Ordinal(109)] 
		[RED("shouldBeDefeated")] 
		public CBool ShouldBeDefeated
		{
			get => GetProperty(ref _shouldBeDefeated);
			set => SetProperty(ref _shouldBeDefeated, value);
		}

		[Ordinal(110)] 
		[RED("sentDownedEvent")] 
		public CBool SentDownedEvent
		{
			get => GetProperty(ref _sentDownedEvent);
			set => SetProperty(ref _sentDownedEvent, value);
		}

		[Ordinal(111)] 
		[RED("isRagdolling")] 
		public CBool IsRagdolling
		{
			get => GetProperty(ref _isRagdolling);
			set => SetProperty(ref _isRagdolling, value);
		}

		[Ordinal(112)] 
		[RED("hasAnimatedRagdoll")] 
		public CBool HasAnimatedRagdoll
		{
			get => GetProperty(ref _hasAnimatedRagdoll);
			set => SetProperty(ref _hasAnimatedRagdoll, value);
		}

		[Ordinal(113)] 
		[RED("disableCollisionRequested")] 
		public CBool DisableCollisionRequested
		{
			get => GetProperty(ref _disableCollisionRequested);
			set => SetProperty(ref _disableCollisionRequested, value);
		}

		[Ordinal(114)] 
		[RED("ragdollInstigator")] 
		public wCHandle<gameObject> RagdollInstigator
		{
			get => GetProperty(ref _ragdollInstigator);
			set => SetProperty(ref _ragdollInstigator, value);
		}

		[Ordinal(115)] 
		[RED("ragdollSplattersSpawned")] 
		public CInt32 RagdollSplattersSpawned
		{
			get => GetProperty(ref _ragdollSplattersSpawned);
			set => SetProperty(ref _ragdollSplattersSpawned, value);
		}

		[Ordinal(116)] 
		[RED("ragdollFloorSplashSpawned")] 
		public CBool RagdollFloorSplashSpawned
		{
			get => GetProperty(ref _ragdollFloorSplashSpawned);
			set => SetProperty(ref _ragdollFloorSplashSpawned, value);
		}

		[Ordinal(117)] 
		[RED("ragdollImpactData")] 
		public entRagdollImpactPointData RagdollImpactData
		{
			get => GetProperty(ref _ragdollImpactData);
			set => SetProperty(ref _ragdollImpactData, value);
		}

		[Ordinal(118)] 
		[RED("ragdollDamageData")] 
		public RagdollDamagePollData RagdollDamageData
		{
			get => GetProperty(ref _ragdollDamageData);
			set => SetProperty(ref _ragdollDamageData, value);
		}

		[Ordinal(119)] 
		[RED("ragdollInitialPosition")] 
		public Vector4 RagdollInitialPosition
		{
			get => GetProperty(ref _ragdollInitialPosition);
			set => SetProperty(ref _ragdollInitialPosition, value);
		}

		[Ordinal(120)] 
		[RED("ragdollActivationTimestamp")] 
		public CFloat RagdollActivationTimestamp
		{
			get => GetProperty(ref _ragdollActivationTimestamp);
			set => SetProperty(ref _ragdollActivationTimestamp, value);
		}

		[Ordinal(121)] 
		[RED("ragdolledEntities")] 
		public CArray<wCHandle<entEntity>> RagdolledEntities
		{
			get => GetProperty(ref _ragdolledEntities);
			set => SetProperty(ref _ragdolledEntities, value);
		}

		[Ordinal(122)] 
		[RED("isNotVisible")] 
		public CBool IsNotVisible
		{
			get => GetProperty(ref _isNotVisible);
			set => SetProperty(ref _isNotVisible, value);
		}

		[Ordinal(123)] 
		[RED("deathListener")] 
		public CHandle<NPCDeathListener> DeathListener
		{
			get => GetProperty(ref _deathListener);
			set => SetProperty(ref _deathListener, value);
		}

		[Ordinal(124)] 
		[RED("godModeStatListener")] 
		public CHandle<NPCGodModeListener> GodModeStatListener
		{
			get => GetProperty(ref _godModeStatListener);
			set => SetProperty(ref _godModeStatListener, value);
		}

		[Ordinal(125)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get => GetProperty(ref _npcCollisionComponent);
			set => SetProperty(ref _npcCollisionComponent, value);
		}

		[Ordinal(126)] 
		[RED("npcRagdollComponent")] 
		public CHandle<entIComponent> NpcRagdollComponent
		{
			get => GetProperty(ref _npcRagdollComponent);
			set => SetProperty(ref _npcRagdollComponent, value);
		}

		[Ordinal(127)] 
		[RED("npcMountedToPlayerComponents")] 
		public CArray<CHandle<entIComponent>> NpcMountedToPlayerComponents
		{
			get => GetProperty(ref _npcMountedToPlayerComponents);
			set => SetProperty(ref _npcMountedToPlayerComponents, value);
		}

		[Ordinal(128)] 
		[RED("scavengeComponent")] 
		public CHandle<ScavengeComponent> ScavengeComponent
		{
			get => GetProperty(ref _scavengeComponent);
			set => SetProperty(ref _scavengeComponent, value);
		}

		[Ordinal(129)] 
		[RED("influenceComponent")] 
		public CHandle<gameinfluenceComponent> InfluenceComponent
		{
			get => GetProperty(ref _influenceComponent);
			set => SetProperty(ref _influenceComponent, value);
		}

		[Ordinal(130)] 
		[RED("comfortZoneComponent")] 
		public CHandle<entIComponent> ComfortZoneComponent
		{
			get => GetProperty(ref _comfortZoneComponent);
			set => SetProperty(ref _comfortZoneComponent, value);
		}

		[Ordinal(131)] 
		[RED("isTargetingPlayer")] 
		public CBool IsTargetingPlayer
		{
			get => GetProperty(ref _isTargetingPlayer);
			set => SetProperty(ref _isTargetingPlayer, value);
		}

		[Ordinal(132)] 
		[RED("playerStatsListener")] 
		public CHandle<gameScriptStatsListener> PlayerStatsListener
		{
			get => GetProperty(ref _playerStatsListener);
			set => SetProperty(ref _playerStatsListener, value);
		}

		[Ordinal(133)] 
		[RED("upperBodyStateCallbackID")] 
		public CUInt32 UpperBodyStateCallbackID
		{
			get => GetProperty(ref _upperBodyStateCallbackID);
			set => SetProperty(ref _upperBodyStateCallbackID, value);
		}

		[Ordinal(134)] 
		[RED("leftCyberwareStateCallbackID")] 
		public CUInt32 LeftCyberwareStateCallbackID
		{
			get => GetProperty(ref _leftCyberwareStateCallbackID);
			set => SetProperty(ref _leftCyberwareStateCallbackID, value);
		}

		[Ordinal(135)] 
		[RED("meleeStateCallbackID")] 
		public CUInt32 MeleeStateCallbackID
		{
			get => GetProperty(ref _meleeStateCallbackID);
			set => SetProperty(ref _meleeStateCallbackID, value);
		}

		[Ordinal(136)] 
		[RED("combatGadgetStateCallbackID")] 
		public CUInt32 CombatGadgetStateCallbackID
		{
			get => GetProperty(ref _combatGadgetStateCallbackID);
			set => SetProperty(ref _combatGadgetStateCallbackID, value);
		}

		[Ordinal(137)] 
		[RED("wasAimedAtLast")] 
		public CBool WasAimedAtLast
		{
			get => GetProperty(ref _wasAimedAtLast);
			set => SetProperty(ref _wasAimedAtLast, value);
		}

		[Ordinal(138)] 
		[RED("wasCWChargedAtLast")] 
		public CBool WasCWChargedAtLast
		{
			get => GetProperty(ref _wasCWChargedAtLast);
			set => SetProperty(ref _wasCWChargedAtLast, value);
		}

		[Ordinal(139)] 
		[RED("wasMeleeChargedAtLast")] 
		public CBool WasMeleeChargedAtLast
		{
			get => GetProperty(ref _wasMeleeChargedAtLast);
			set => SetProperty(ref _wasMeleeChargedAtLast, value);
		}

		[Ordinal(140)] 
		[RED("wasChargingGadgetAtLast")] 
		public CBool WasChargingGadgetAtLast
		{
			get => GetProperty(ref _wasChargingGadgetAtLast);
			set => SetProperty(ref _wasChargingGadgetAtLast, value);
		}

		[Ordinal(141)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get => GetProperty(ref _isLookedAt);
			set => SetProperty(ref _isLookedAt, value);
		}

		[Ordinal(142)] 
		[RED("cachedPlayerID")] 
		public entEntityID CachedPlayerID
		{
			get => GetProperty(ref _cachedPlayerID);
			set => SetProperty(ref _cachedPlayerID, value);
		}

		[Ordinal(143)] 
		[RED("canGoThroughDoors")] 
		public CBool CanGoThroughDoors
		{
			get => GetProperty(ref _canGoThroughDoors);
			set => SetProperty(ref _canGoThroughDoors, value);
		}

		[Ordinal(144)] 
		[RED("lastStatusEffectSignalSent")] 
		public wCHandle<gamedataStatusEffect_Record> LastStatusEffectSignalSent
		{
			get => GetProperty(ref _lastStatusEffectSignalSent);
			set => SetProperty(ref _lastStatusEffectSignalSent, value);
		}

		[Ordinal(145)] 
		[RED("cachedStatusEffectAnim")] 
		public wCHandle<gamedataStatusEffect_Record> CachedStatusEffectAnim
		{
			get => GetProperty(ref _cachedStatusEffectAnim);
			set => SetProperty(ref _cachedStatusEffectAnim, value);
		}

		[Ordinal(146)] 
		[RED("resendStatusEffectSignalDelayID")] 
		public gameDelayID ResendStatusEffectSignalDelayID
		{
			get => GetProperty(ref _resendStatusEffectSignalDelayID);
			set => SetProperty(ref _resendStatusEffectSignalDelayID, value);
		}

		[Ordinal(147)] 
		[RED("lastSEAppliedByPlayer")] 
		public CHandle<gameStatusEffect> LastSEAppliedByPlayer
		{
			get => GetProperty(ref _lastSEAppliedByPlayer);
			set => SetProperty(ref _lastSEAppliedByPlayer, value);
		}

		[Ordinal(148)] 
		[RED("pendingSEEvent")] 
		public CHandle<gameeventsApplyStatusEffectEvent> PendingSEEvent
		{
			get => GetProperty(ref _pendingSEEvent);
			set => SetProperty(ref _pendingSEEvent, value);
		}

		[Ordinal(149)] 
		[RED("bounty")] 
		public Bounty Bounty
		{
			get => GetProperty(ref _bounty);
			set => SetProperty(ref _bounty, value);
		}

		[Ordinal(150)] 
		[RED("cachedVFXList")] 
		public CArray<wCHandle<gamedataStatusEffectFX_Record>> CachedVFXList
		{
			get => GetProperty(ref _cachedVFXList);
			set => SetProperty(ref _cachedVFXList, value);
		}

		[Ordinal(151)] 
		[RED("cachedSFXList")] 
		public CArray<wCHandle<gamedataStatusEffectFX_Record>> CachedSFXList
		{
			get => GetProperty(ref _cachedSFXList);
			set => SetProperty(ref _cachedSFXList, value);
		}

		[Ordinal(152)] 
		[RED("isThrowingGrenadeToPlayer")] 
		public CBool IsThrowingGrenadeToPlayer
		{
			get => GetProperty(ref _isThrowingGrenadeToPlayer);
			set => SetProperty(ref _isThrowingGrenadeToPlayer, value);
		}

		[Ordinal(153)] 
		[RED("throwingGrenadeDelayEventID")] 
		public gameDelayID ThrowingGrenadeDelayEventID
		{
			get => GetProperty(ref _throwingGrenadeDelayEventID);
			set => SetProperty(ref _throwingGrenadeDelayEventID, value);
		}

		[Ordinal(154)] 
		[RED("myKiller")] 
		public wCHandle<gameObject> MyKiller
		{
			get => GetProperty(ref _myKiller);
			set => SetProperty(ref _myKiller, value);
		}

		[Ordinal(155)] 
		[RED("primaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> PrimaryThreatCalculationType
		{
			get => GetProperty(ref _primaryThreatCalculationType);
			set => SetProperty(ref _primaryThreatCalculationType, value);
		}

		[Ordinal(156)] 
		[RED("temporaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> TemporaryThreatCalculationType
		{
			get => GetProperty(ref _temporaryThreatCalculationType);
			set => SetProperty(ref _temporaryThreatCalculationType, value);
		}

		[Ordinal(157)] 
		[RED("isPlayerCompanionCached")] 
		public CBool IsPlayerCompanionCached
		{
			get => GetProperty(ref _isPlayerCompanionCached);
			set => SetProperty(ref _isPlayerCompanionCached, value);
		}

		[Ordinal(158)] 
		[RED("isPlayerCompanionCachedTimeStamp")] 
		public CFloat IsPlayerCompanionCachedTimeStamp
		{
			get => GetProperty(ref _isPlayerCompanionCachedTimeStamp);
			set => SetProperty(ref _isPlayerCompanionCachedTimeStamp, value);
		}

		[Ordinal(159)] 
		[RED("quickHackEffectsApplied")] 
		public CUInt32 QuickHackEffectsApplied
		{
			get => GetProperty(ref _quickHackEffectsApplied);
			set => SetProperty(ref _quickHackEffectsApplied, value);
		}

		[Ordinal(160)] 
		[RED("hackingResistanceMod")] 
		public CHandle<gameConstantStatModifierData> HackingResistanceMod
		{
			get => GetProperty(ref _hackingResistanceMod);
			set => SetProperty(ref _hackingResistanceMod, value);
		}

		[Ordinal(161)] 
		[RED("delayNonStealthQuickHackVictimEventID")] 
		public gameDelayID DelayNonStealthQuickHackVictimEventID
		{
			get => GetProperty(ref _delayNonStealthQuickHackVictimEventID);
			set => SetProperty(ref _delayNonStealthQuickHackVictimEventID, value);
		}

		[Ordinal(162)] 
		[RED("cachedIsPaperdoll")] 
		public CInt32 CachedIsPaperdoll
		{
			get => GetProperty(ref _cachedIsPaperdoll);
			set => SetProperty(ref _cachedIsPaperdoll, value);
		}

		[Ordinal(163)] 
		[RED("smartDespawnDelayID")] 
		public gameDelayID SmartDespawnDelayID
		{
			get => GetProperty(ref _smartDespawnDelayID);
			set => SetProperty(ref _smartDespawnDelayID, value);
		}

		[Ordinal(164)] 
		[RED("despawnTicks")] 
		public CUInt32 DespawnTicks
		{
			get => GetProperty(ref _despawnTicks);
			set => SetProperty(ref _despawnTicks, value);
		}

		public NPCPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
