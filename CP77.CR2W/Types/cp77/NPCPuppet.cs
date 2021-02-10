using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCPuppet : ScriptedPuppet
	{
		[Ordinal(2)]  [RED("godModeStatListener")] public CHandle<NPCGodModeListener> GodModeStatListener { get; set; }
		[Ordinal(88)]  [RED("lastHitEvent")] public CHandle<gameeventsHitEvent> LastHitEvent { get; set; }
		[Ordinal(89)]  [RED("totalFrameReactionDamageReceived")] public CFloat TotalFrameReactionDamageReceived { get; set; }
		[Ordinal(90)]  [RED("totalFrameWoundsDamageReceived")] public CFloat TotalFrameWoundsDamageReceived { get; set; }
		[Ordinal(91)]  [RED("totalFrameDismembermentDamageReceived")] public CFloat TotalFrameDismembermentDamageReceived { get; set; }
		[Ordinal(92)]  [RED("hitEventLock")] public ScriptReentrantRWLock HitEventLock { get; set; }
		[Ordinal(93)]  [RED("NPCManager")] public CHandle<NPCManager> NPCManager { get; set; }
		[Ordinal(94)]  [RED("customDeathDirection")] public CInt32 CustomDeathDirection { get; set; }
		[Ordinal(95)]  [RED("deathOverrideState")] public CBool DeathOverrideState { get; set; }
		[Ordinal(96)]  [RED("agonyState")] public CBool AgonyState { get; set; }
		[Ordinal(97)]  [RED("defensiveState")] public CBool DefensiveState { get; set; }
		[Ordinal(98)]  [RED("lastSetupWorkspotActionEvent")] public CHandle<gameSetupWorkspotActionEvent> LastSetupWorkspotActionEvent { get; set; }
		[Ordinal(99)]  [RED("wasJustKilledOrDefeated")] public CBool WasJustKilledOrDefeated { get; set; }
		[Ordinal(100)]  [RED("shouldDie")] public CBool ShouldDie { get; set; }
		[Ordinal(101)]  [RED("shouldBeDefeated")] public CBool ShouldBeDefeated { get; set; }
		[Ordinal(102)]  [RED("sentDownedEvent")] public CBool SentDownedEvent { get; set; }
		[Ordinal(103)]  [RED("isRagdolling")] public CBool IsRagdolling { get; set; }
		[Ordinal(104)]  [RED("hasAnimatedRagdoll")] public CBool HasAnimatedRagdoll { get; set; }
		[Ordinal(105)]  [RED("disableCollisionRequested")] public CBool DisableCollisionRequested { get; set; }
		[Ordinal(106)]  [RED("ragdollInstigator")] public wCHandle<gameObject> RagdollInstigator { get; set; }
		[Ordinal(107)]  [RED("ragdollSplattersSpawned")] public CInt32 RagdollSplattersSpawned { get; set; }
		[Ordinal(108)]  [RED("ragdollFloorSplashSpawned")] public CBool RagdollFloorSplashSpawned { get; set; }
		[Ordinal(109)]  [RED("ragdollImpactData")] public entRagdollImpactPointData RagdollImpactData { get; set; }
		[Ordinal(110)]  [RED("ragdollDamageData")] public RagdollDamagePollData RagdollDamageData { get; set; }
		[Ordinal(111)]  [RED("ragdollInitialPosition")] public Vector4 RagdollInitialPosition { get; set; }
		[Ordinal(112)]  [RED("ragdollActivationTimestamp")] public CFloat RagdollActivationTimestamp { get; set; }
		[Ordinal(113)]  [RED("ragdolledEntities")] public CArray<wCHandle<entEntity>> RagdolledEntities { get; set; }
		[Ordinal(114)]  [RED("isNotVisible")] public CBool IsNotVisible { get; set; }
		[Ordinal(115)]  [RED("deathListener")] public CHandle<NPCDeathListener> DeathListener { get; set; }
		[Ordinal(116)]  [RED("npcCollisionComponent")] public CHandle<entSimpleColliderComponent> NpcCollisionComponent { get; set; }
		[Ordinal(117)]  [RED("npcRagdollComponent")] public CHandle<entIComponent> NpcRagdollComponent { get; set; }
		[Ordinal(118)]  [RED("npcMountedToPlayerComponents")] public CArray<CHandle<entIComponent>> NpcMountedToPlayerComponents { get; set; }
		[Ordinal(119)]  [RED("scavengeComponent")] public CHandle<ScavengeComponent> ScavengeComponent { get; set; }
		[Ordinal(120)]  [RED("influenceComponent")] public CHandle<gameinfluenceComponent> InfluenceComponent { get; set; }
		[Ordinal(121)]  [RED("comfortZoneComponent")] public CHandle<entIComponent> ComfortZoneComponent { get; set; }
		[Ordinal(122)]  [RED("isTargetingPlayer")] public CBool IsTargetingPlayer { get; set; }
		[Ordinal(123)]  [RED("playerStatsListener")] public CHandle<gameScriptStatsListener> PlayerStatsListener { get; set; }
		[Ordinal(124)]  [RED("upperBodyStateCallbackID")] public CUInt32 UpperBodyStateCallbackID { get; set; }
		[Ordinal(125)]  [RED("leftCyberwareStateCallbackID")] public CUInt32 LeftCyberwareStateCallbackID { get; set; }
		[Ordinal(126)]  [RED("meleeStateCallbackID")] public CUInt32 MeleeStateCallbackID { get; set; }
		[Ordinal(127)]  [RED("combatGadgetStateCallbackID")] public CUInt32 CombatGadgetStateCallbackID { get; set; }
		[Ordinal(128)]  [RED("wasAimedAtLast")] public CBool WasAimedAtLast { get; set; }
		[Ordinal(129)]  [RED("wasCWChargedAtLast")] public CBool WasCWChargedAtLast { get; set; }
		[Ordinal(130)]  [RED("wasMeleeChargedAtLast")] public CBool WasMeleeChargedAtLast { get; set; }
		[Ordinal(131)]  [RED("wasChargingGadgetAtLast")] public CBool WasChargingGadgetAtLast { get; set; }
		[Ordinal(132)]  [RED("isLookedAt")] public CBool IsLookedAt { get; set; }
		[Ordinal(133)]  [RED("cachedPlayerID")] public entEntityID CachedPlayerID { get; set; }
		[Ordinal(134)]  [RED("canGoThroughDoors")] public CBool CanGoThroughDoors { get; set; }
		[Ordinal(135)]  [RED("lastStatusEffectSignalSent")] public wCHandle<gamedataStatusEffect_Record> LastStatusEffectSignalSent { get; set; }
		[Ordinal(136)]  [RED("cachedStatusEffectAnim")] public wCHandle<gamedataStatusEffect_Record> CachedStatusEffectAnim { get; set; }
		[Ordinal(137)]  [RED("resendStatusEffectSignalDelayID")] public gameDelayID ResendStatusEffectSignalDelayID { get; set; }
		[Ordinal(138)]  [RED("lastSEAppliedByPlayer")] public CHandle<gameStatusEffect> LastSEAppliedByPlayer { get; set; }
		[Ordinal(139)]  [RED("pendingSEEvent")] public CHandle<gameeventsApplyStatusEffectEvent> PendingSEEvent { get; set; }
		[Ordinal(140)]  [RED("bounty")] public Bounty Bounty { get; set; }
		[Ordinal(141)]  [RED("cachedVFXList")] public CArray<wCHandle<gamedataStatusEffectFX_Record>> CachedVFXList { get; set; }
		[Ordinal(142)]  [RED("cachedSFXList")] public CArray<wCHandle<gamedataStatusEffectFX_Record>> CachedSFXList { get; set; }
		[Ordinal(143)]  [RED("isThrowingGrenadeToPlayer")] public CBool IsThrowingGrenadeToPlayer { get; set; }
		[Ordinal(144)]  [RED("throwingGrenadeDelayEventID")] public gameDelayID ThrowingGrenadeDelayEventID { get; set; }
		[Ordinal(145)]  [RED("myKiller")] public wCHandle<gameObject> MyKiller { get; set; }
		[Ordinal(146)]  [RED("primaryThreatCalculationType")] public CEnum<EAIThreatCalculationType> PrimaryThreatCalculationType { get; set; }
		[Ordinal(147)]  [RED("temporaryThreatCalculationType")] public CEnum<EAIThreatCalculationType> TemporaryThreatCalculationType { get; set; }
		[Ordinal(148)]  [RED("isPlayerCompanionCached")] public CBool IsPlayerCompanionCached { get; set; }
		[Ordinal(149)]  [RED("isPlayerCompanionCachedTimeStamp")] public CFloat IsPlayerCompanionCachedTimeStamp { get; set; }
		[Ordinal(150)]  [RED("quickHackEffectsApplied")] public CUInt32 QuickHackEffectsApplied { get; set; }
		[Ordinal(151)]  [RED("hackingResistanceMod")] public CHandle<gameConstantStatModifierData> HackingResistanceMod { get; set; }
		[Ordinal(152)]  [RED("delayNonStealthQuickHackVictimEventID")] public gameDelayID DelayNonStealthQuickHackVictimEventID { get; set; }
		[Ordinal(153)]  [RED("cachedIsPaperdoll")] public CInt32 CachedIsPaperdoll { get; set; }
		[Ordinal(154)]  [RED("smartDespawnDelayID")] public gameDelayID SmartDespawnDelayID { get; set; }
		[Ordinal(155)]  [RED("despawnTicks")] public CUInt32 DespawnTicks { get; set; }

		public NPCPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
