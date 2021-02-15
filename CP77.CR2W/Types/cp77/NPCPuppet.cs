using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCPuppet : ScriptedPuppet
	{
		[Ordinal(96)] [RED("lastHitEvent")] public CHandle<gameeventsHitEvent> LastHitEvent { get; set; }
		[Ordinal(97)] [RED("totalFrameReactionDamageReceived")] public CFloat TotalFrameReactionDamageReceived { get; set; }
		[Ordinal(98)] [RED("totalFrameWoundsDamageReceived")] public CFloat TotalFrameWoundsDamageReceived { get; set; }
		[Ordinal(99)] [RED("totalFrameDismembermentDamageReceived")] public CFloat TotalFrameDismembermentDamageReceived { get; set; }
		[Ordinal(100)] [RED("hitEventLock")] public ScriptReentrantRWLock HitEventLock { get; set; }
		[Ordinal(101)] [RED("NPCManager")] public CHandle<NPCManager> NPCManager { get; set; }
		[Ordinal(102)] [RED("customDeathDirection")] public CInt32 CustomDeathDirection { get; set; }
		[Ordinal(103)] [RED("deathOverrideState")] public CBool DeathOverrideState { get; set; }
		[Ordinal(104)] [RED("agonyState")] public CBool AgonyState { get; set; }
		[Ordinal(105)] [RED("defensiveState")] public CBool DefensiveState { get; set; }
		[Ordinal(106)] [RED("lastSetupWorkspotActionEvent")] public CHandle<gameSetupWorkspotActionEvent> LastSetupWorkspotActionEvent { get; set; }
		[Ordinal(107)] [RED("wasJustKilledOrDefeated")] public CBool WasJustKilledOrDefeated { get; set; }
		[Ordinal(108)] [RED("shouldDie")] public CBool ShouldDie { get; set; }
		[Ordinal(109)] [RED("shouldBeDefeated")] public CBool ShouldBeDefeated { get; set; }
		[Ordinal(110)] [RED("sentDownedEvent")] public CBool SentDownedEvent { get; set; }
		[Ordinal(111)] [RED("isRagdolling")] public CBool IsRagdolling { get; set; }
		[Ordinal(112)] [RED("hasAnimatedRagdoll")] public CBool HasAnimatedRagdoll { get; set; }
		[Ordinal(113)] [RED("disableCollisionRequested")] public CBool DisableCollisionRequested { get; set; }
		[Ordinal(114)] [RED("ragdollInstigator")] public wCHandle<gameObject> RagdollInstigator { get; set; }
		[Ordinal(115)] [RED("ragdollSplattersSpawned")] public CInt32 RagdollSplattersSpawned { get; set; }
		[Ordinal(116)] [RED("ragdollFloorSplashSpawned")] public CBool RagdollFloorSplashSpawned { get; set; }
		[Ordinal(117)] [RED("ragdollImpactData")] public entRagdollImpactPointData RagdollImpactData { get; set; }
		[Ordinal(118)] [RED("ragdollDamageData")] public RagdollDamagePollData RagdollDamageData { get; set; }
		[Ordinal(119)] [RED("ragdollInitialPosition")] public Vector4 RagdollInitialPosition { get; set; }
		[Ordinal(120)] [RED("ragdollActivationTimestamp")] public CFloat RagdollActivationTimestamp { get; set; }
		[Ordinal(121)] [RED("ragdolledEntities")] public CArray<wCHandle<entEntity>> RagdolledEntities { get; set; }
		[Ordinal(122)] [RED("isNotVisible")] public CBool IsNotVisible { get; set; }
		[Ordinal(123)] [RED("deathListener")] public CHandle<NPCDeathListener> DeathListener { get; set; }
		[Ordinal(124)] [RED("godModeStatListener")] public CHandle<NPCGodModeListener> GodModeStatListener { get; set; }
		[Ordinal(125)] [RED("npcCollisionComponent")] public CHandle<entSimpleColliderComponent> NpcCollisionComponent { get; set; }
		[Ordinal(126)] [RED("npcRagdollComponent")] public CHandle<entIComponent> NpcRagdollComponent { get; set; }
		[Ordinal(127)] [RED("npcMountedToPlayerComponents")] public CArray<CHandle<entIComponent>> NpcMountedToPlayerComponents { get; set; }
		[Ordinal(128)] [RED("scavengeComponent")] public CHandle<ScavengeComponent> ScavengeComponent { get; set; }
		[Ordinal(129)] [RED("influenceComponent")] public CHandle<gameinfluenceComponent> InfluenceComponent { get; set; }
		[Ordinal(130)] [RED("comfortZoneComponent")] public CHandle<entIComponent> ComfortZoneComponent { get; set; }
		[Ordinal(131)] [RED("isTargetingPlayer")] public CBool IsTargetingPlayer { get; set; }
		[Ordinal(132)] [RED("playerStatsListener")] public CHandle<gameScriptStatsListener> PlayerStatsListener { get; set; }
		[Ordinal(133)] [RED("upperBodyStateCallbackID")] public CUInt32 UpperBodyStateCallbackID { get; set; }
		[Ordinal(134)] [RED("leftCyberwareStateCallbackID")] public CUInt32 LeftCyberwareStateCallbackID { get; set; }
		[Ordinal(135)] [RED("meleeStateCallbackID")] public CUInt32 MeleeStateCallbackID { get; set; }
		[Ordinal(136)] [RED("combatGadgetStateCallbackID")] public CUInt32 CombatGadgetStateCallbackID { get; set; }
		[Ordinal(137)] [RED("wasAimedAtLast")] public CBool WasAimedAtLast { get; set; }
		[Ordinal(138)] [RED("wasCWChargedAtLast")] public CBool WasCWChargedAtLast { get; set; }
		[Ordinal(139)] [RED("wasMeleeChargedAtLast")] public CBool WasMeleeChargedAtLast { get; set; }
		[Ordinal(140)] [RED("wasChargingGadgetAtLast")] public CBool WasChargingGadgetAtLast { get; set; }
		[Ordinal(141)] [RED("isLookedAt")] public CBool IsLookedAt { get; set; }
		[Ordinal(142)] [RED("cachedPlayerID")] public entEntityID CachedPlayerID { get; set; }
		[Ordinal(143)] [RED("canGoThroughDoors")] public CBool CanGoThroughDoors { get; set; }
		[Ordinal(144)] [RED("lastStatusEffectSignalSent")] public wCHandle<gamedataStatusEffect_Record> LastStatusEffectSignalSent { get; set; }
		[Ordinal(145)] [RED("cachedStatusEffectAnim")] public wCHandle<gamedataStatusEffect_Record> CachedStatusEffectAnim { get; set; }
		[Ordinal(146)] [RED("resendStatusEffectSignalDelayID")] public gameDelayID ResendStatusEffectSignalDelayID { get; set; }
		[Ordinal(147)] [RED("lastSEAppliedByPlayer")] public CHandle<gameStatusEffect> LastSEAppliedByPlayer { get; set; }
		[Ordinal(148)] [RED("pendingSEEvent")] public CHandle<gameeventsApplyStatusEffectEvent> PendingSEEvent { get; set; }
		[Ordinal(149)] [RED("bounty")] public Bounty Bounty { get; set; }
		[Ordinal(150)] [RED("cachedVFXList")] public CArray<wCHandle<gamedataStatusEffectFX_Record>> CachedVFXList { get; set; }
		[Ordinal(151)] [RED("cachedSFXList")] public CArray<wCHandle<gamedataStatusEffectFX_Record>> CachedSFXList { get; set; }
		[Ordinal(152)] [RED("isThrowingGrenadeToPlayer")] public CBool IsThrowingGrenadeToPlayer { get; set; }
		[Ordinal(153)] [RED("throwingGrenadeDelayEventID")] public gameDelayID ThrowingGrenadeDelayEventID { get; set; }
		[Ordinal(154)] [RED("myKiller")] public wCHandle<gameObject> MyKiller { get; set; }
		[Ordinal(155)] [RED("primaryThreatCalculationType")] public CEnum<EAIThreatCalculationType> PrimaryThreatCalculationType { get; set; }
		[Ordinal(156)] [RED("temporaryThreatCalculationType")] public CEnum<EAIThreatCalculationType> TemporaryThreatCalculationType { get; set; }
		[Ordinal(157)] [RED("isPlayerCompanionCached")] public CBool IsPlayerCompanionCached { get; set; }
		[Ordinal(158)] [RED("isPlayerCompanionCachedTimeStamp")] public CFloat IsPlayerCompanionCachedTimeStamp { get; set; }
		[Ordinal(159)] [RED("quickHackEffectsApplied")] public CUInt32 QuickHackEffectsApplied { get; set; }
		[Ordinal(160)] [RED("hackingResistanceMod")] public CHandle<gameConstantStatModifierData> HackingResistanceMod { get; set; }
		[Ordinal(161)] [RED("delayNonStealthQuickHackVictimEventID")] public gameDelayID DelayNonStealthQuickHackVictimEventID { get; set; }
		[Ordinal(162)] [RED("cachedIsPaperdoll")] public CInt32 CachedIsPaperdoll { get; set; }
		[Ordinal(163)] [RED("smartDespawnDelayID")] public gameDelayID SmartDespawnDelayID { get; set; }
		[Ordinal(164)] [RED("despawnTicks")] public CUInt32 DespawnTicks { get; set; }

		public NPCPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
