using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCPuppet : ScriptedPuppet
	{
		[Ordinal(0)]  [RED("NPCManager")] public CHandle<NPCManager> NPCManager { get; set; }
		[Ordinal(1)]  [RED("agonyState")] public CBool AgonyState { get; set; }
		[Ordinal(2)]  [RED("bounty")] public Bounty Bounty { get; set; }
		[Ordinal(3)]  [RED("cachedIsPaperdoll")] public CInt32 CachedIsPaperdoll { get; set; }
		[Ordinal(4)]  [RED("cachedPlayerID")] public entEntityID CachedPlayerID { get; set; }
		[Ordinal(5)]  [RED("cachedSFXList")] public CArray<wCHandle<gamedataStatusEffectFX_Record>> CachedSFXList { get; set; }
		[Ordinal(6)]  [RED("cachedStatusEffectAnim")] public wCHandle<gamedataStatusEffect_Record> CachedStatusEffectAnim { get; set; }
		[Ordinal(7)]  [RED("cachedVFXList")] public CArray<wCHandle<gamedataStatusEffectFX_Record>> CachedVFXList { get; set; }
		[Ordinal(8)]  [RED("canGoThroughDoors")] public CBool CanGoThroughDoors { get; set; }
		[Ordinal(9)]  [RED("combatGadgetStateCallbackID")] public CUInt32 CombatGadgetStateCallbackID { get; set; }
		[Ordinal(10)]  [RED("comfortZoneComponent")] public CHandle<entIComponent> ComfortZoneComponent { get; set; }
		[Ordinal(11)]  [RED("customDeathDirection")] public CInt32 CustomDeathDirection { get; set; }
		[Ordinal(12)]  [RED("deathListener")] public CHandle<NPCDeathListener> DeathListener { get; set; }
		[Ordinal(13)]  [RED("deathOverrideState")] public CBool DeathOverrideState { get; set; }
		[Ordinal(14)]  [RED("defensiveState")] public CBool DefensiveState { get; set; }
		[Ordinal(15)]  [RED("delayNonStealthQuickHackVictimEventID")] public gameDelayID DelayNonStealthQuickHackVictimEventID { get; set; }
		[Ordinal(16)]  [RED("despawnTicks")] public CUInt32 DespawnTicks { get; set; }
		[Ordinal(17)]  [RED("disableCollisionRequested")] public CBool DisableCollisionRequested { get; set; }
		[Ordinal(18)]  [RED("godModeStatListener")] public CHandle<NPCGodModeListener> GodModeStatListener { get; set; }
		[Ordinal(19)]  [RED("hackingResistanceMod")] public CHandle<gameConstantStatModifierData> HackingResistanceMod { get; set; }
		[Ordinal(20)]  [RED("hasAnimatedRagdoll")] public CBool HasAnimatedRagdoll { get; set; }
		[Ordinal(21)]  [RED("hitEventLock")] public ScriptReentrantRWLock HitEventLock { get; set; }
		[Ordinal(22)]  [RED("influenceComponent")] public CHandle<gameinfluenceComponent> InfluenceComponent { get; set; }
		[Ordinal(23)]  [RED("isLookedAt")] public CBool IsLookedAt { get; set; }
		[Ordinal(24)]  [RED("isNotVisible")] public CBool IsNotVisible { get; set; }
		[Ordinal(25)]  [RED("isPlayerCompanionCached")] public CBool IsPlayerCompanionCached { get; set; }
		[Ordinal(26)]  [RED("isPlayerCompanionCachedTimeStamp")] public CFloat IsPlayerCompanionCachedTimeStamp { get; set; }
		[Ordinal(27)]  [RED("isRagdolling")] public CBool IsRagdolling { get; set; }
		[Ordinal(28)]  [RED("isTargetingPlayer")] public CBool IsTargetingPlayer { get; set; }
		[Ordinal(29)]  [RED("isThrowingGrenadeToPlayer")] public CBool IsThrowingGrenadeToPlayer { get; set; }
		[Ordinal(30)]  [RED("lastHitEvent")] public CHandle<gameeventsHitEvent> LastHitEvent { get; set; }
		[Ordinal(31)]  [RED("lastSEAppliedByPlayer")] public CHandle<gameStatusEffect> LastSEAppliedByPlayer { get; set; }
		[Ordinal(32)]  [RED("lastSetupWorkspotActionEvent")] public CHandle<gameSetupWorkspotActionEvent> LastSetupWorkspotActionEvent { get; set; }
		[Ordinal(33)]  [RED("lastStatusEffectSignalSent")] public wCHandle<gamedataStatusEffect_Record> LastStatusEffectSignalSent { get; set; }
		[Ordinal(34)]  [RED("leftCyberwareStateCallbackID")] public CUInt32 LeftCyberwareStateCallbackID { get; set; }
		[Ordinal(35)]  [RED("meleeStateCallbackID")] public CUInt32 MeleeStateCallbackID { get; set; }
		[Ordinal(36)]  [RED("myKiller")] public wCHandle<gameObject> MyKiller { get; set; }
		[Ordinal(37)]  [RED("npcCollisionComponent")] public CHandle<entSimpleColliderComponent> NpcCollisionComponent { get; set; }
		[Ordinal(38)]  [RED("npcMountedToPlayerComponents")] public CArray<CHandle<entIComponent>> NpcMountedToPlayerComponents { get; set; }
		[Ordinal(39)]  [RED("npcRagdollComponent")] public CHandle<entIComponent> NpcRagdollComponent { get; set; }
		[Ordinal(40)]  [RED("pendingSEEvent")] public CHandle<gameeventsApplyStatusEffectEvent> PendingSEEvent { get; set; }
		[Ordinal(41)]  [RED("playerStatsListener")] public CHandle<gameScriptStatsListener> PlayerStatsListener { get; set; }
		[Ordinal(42)]  [RED("primaryThreatCalculationType")] public CEnum<EAIThreatCalculationType> PrimaryThreatCalculationType { get; set; }
		[Ordinal(43)]  [RED("quickHackEffectsApplied")] public CUInt32 QuickHackEffectsApplied { get; set; }
		[Ordinal(44)]  [RED("ragdollActivationTimestamp")] public CFloat RagdollActivationTimestamp { get; set; }
		[Ordinal(45)]  [RED("ragdollDamageData")] public RagdollDamagePollData RagdollDamageData { get; set; }
		[Ordinal(46)]  [RED("ragdollFloorSplashSpawned")] public CBool RagdollFloorSplashSpawned { get; set; }
		[Ordinal(47)]  [RED("ragdollImpactData")] public entRagdollImpactPointData RagdollImpactData { get; set; }
		[Ordinal(48)]  [RED("ragdollInitialPosition")] public Vector4 RagdollInitialPosition { get; set; }
		[Ordinal(49)]  [RED("ragdollInstigator")] public wCHandle<gameObject> RagdollInstigator { get; set; }
		[Ordinal(50)]  [RED("ragdollSplattersSpawned")] public CInt32 RagdollSplattersSpawned { get; set; }
		[Ordinal(51)]  [RED("ragdolledEntities")] public CArray<wCHandle<entEntity>> RagdolledEntities { get; set; }
		[Ordinal(52)]  [RED("resendStatusEffectSignalDelayID")] public gameDelayID ResendStatusEffectSignalDelayID { get; set; }
		[Ordinal(53)]  [RED("scavengeComponent")] public CHandle<ScavengeComponent> ScavengeComponent { get; set; }
		[Ordinal(54)]  [RED("sentDownedEvent")] public CBool SentDownedEvent { get; set; }
		[Ordinal(55)]  [RED("shouldBeDefeated")] public CBool ShouldBeDefeated { get; set; }
		[Ordinal(56)]  [RED("shouldDie")] public CBool ShouldDie { get; set; }
		[Ordinal(57)]  [RED("smartDespawnDelayID")] public gameDelayID SmartDespawnDelayID { get; set; }
		[Ordinal(58)]  [RED("temporaryThreatCalculationType")] public CEnum<EAIThreatCalculationType> TemporaryThreatCalculationType { get; set; }
		[Ordinal(59)]  [RED("throwingGrenadeDelayEventID")] public gameDelayID ThrowingGrenadeDelayEventID { get; set; }
		[Ordinal(60)]  [RED("totalFrameDismembermentDamageReceived")] public CFloat TotalFrameDismembermentDamageReceived { get; set; }
		[Ordinal(61)]  [RED("totalFrameReactionDamageReceived")] public CFloat TotalFrameReactionDamageReceived { get; set; }
		[Ordinal(62)]  [RED("totalFrameWoundsDamageReceived")] public CFloat TotalFrameWoundsDamageReceived { get; set; }
		[Ordinal(63)]  [RED("upperBodyStateCallbackID")] public CUInt32 UpperBodyStateCallbackID { get; set; }
		[Ordinal(64)]  [RED("wasAimedAtLast")] public CBool WasAimedAtLast { get; set; }
		[Ordinal(65)]  [RED("wasCWChargedAtLast")] public CBool WasCWChargedAtLast { get; set; }
		[Ordinal(66)]  [RED("wasChargingGadgetAtLast")] public CBool WasChargingGadgetAtLast { get; set; }
		[Ordinal(67)]  [RED("wasJustKilledOrDefeated")] public CBool WasJustKilledOrDefeated { get; set; }
		[Ordinal(68)]  [RED("wasMeleeChargedAtLast")] public CBool WasMeleeChargedAtLast { get; set; }

		public NPCPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
