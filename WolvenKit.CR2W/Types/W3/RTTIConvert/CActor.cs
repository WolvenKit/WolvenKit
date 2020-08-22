using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CActor : CGameplayEntity
	{
		[RED("actorGroups")] 		public CEnum<EPathEngineAgentType> ActorGroups { get; set;}

		[RED("aimOffset")] 		public CFloat AimOffset { get; set;}

		[RED("barOffset")] 		public CFloat BarOffset { get; set;}

		[RED("isAttackableByPlayer")] 		public CBool IsAttackableByPlayer { get; set;}

		[RED("losTestBoneIndex")] 		public CInt32 LosTestBoneIndex { get; set;}

		[RED("attackTarget")] 		public CHandle<CActor> AttackTarget { get; set;}

		[RED("attackTargetSetTime")] 		public EngineTime AttackTargetSetTime { get; set;}

		[RED("frontPushAnim")] 		public CName FrontPushAnim { get; set;}

		[RED("backPushAnim")] 		public CName BackPushAnim { get; set;}

		[RED("isCollidable")] 		public CBool IsCollidable { get; set;}

		[RED("isVisibileFromFar")] 		public CBool IsVisibileFromFar { get; set;}

		[RED("voiceTag")] 		public CName VoiceTag { get; set;}

		[RED("voiceToRandomize", 2,0)] 		public CArray<StringAnsi> VoiceToRandomize { get; set;}

		[RED("behTreeMachine")] 		public CPtr<CBehTreeMachine> BehTreeMachine { get; set;}

		[RED("useHiResShadows")] 		public CBool UseHiResShadows { get; set;}

		[RED("isInFFMiniGame")] 		public CBool IsInFFMiniGame { get; set;}

		[RED("pelvisBoneName")] 		public CName PelvisBoneName { get; set;}

		[RED("torsoBoneName")] 		public CName TorsoBoneName { get; set;}

		[RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[RED("useAnimationEventFilter")] 		public CBool UseAnimationEventFilter { get; set;}

		[RED("soundListenerOverride")] 		public CString SoundListenerOverride { get; set;}

		[RED("encounterGroupUsedToSpawn")] 		public CInt32 EncounterGroupUsedToSpawn { get; set;}

		[RED("isTargatebleByPlayer")] 		public CBool IsTargatebleByPlayer { get; set;}

		[RED("isUsingTooltip")] 		public CBool IsUsingTooltip { get; set;}

		[RED("slideTarget")] 		public CHandle<CGameplayEntity> SlideTarget { get; set;}

		[RED("parryTypeTable", 2,0)] 		public CArray<CArray<CEnum<EParryType>>> ParryTypeTable { get; set;}

		[RED("lastAttacker")] 		public CHandle<CActor> LastAttacker { get; set;}

		[RED("counterAttackAnimTable", 2,0)] 		public CArray<CName> CounterAttackAnimTable { get; set;}

		[RED("bIsGuarded")] 		public CBool BIsGuarded { get; set;}

		[RED("bParryEnabled")] 		public CBool BParryEnabled { get; set;}

		[RED("bCanPerformCounter")] 		public CBool BCanPerformCounter { get; set;}

		[RED("lastParryType")] 		public CEnum<EParryType> LastParryType { get; set;}

		[RED("useAdditiveHits")] 		public CBool UseAdditiveHits { get; set;}

		[RED("oneTimeAdditiveHit")] 		public CBool OneTimeAdditiveHit { get; set;}

		[RED("useAdditiveCriticalStateAnim")] 		public CBool UseAdditiveCriticalStateAnim { get; set;}

		[RED("criticalCancelAdditiveHit")] 		public CBool CriticalCancelAdditiveHit { get; set;}

		[RED("lastAttackRangeName")] 		public CName LastAttackRangeName { get; set;}

		[RED("attackActionName")] 		public CName AttackActionName { get; set;}

		[RED("hitTargets", 2,0)] 		public CArray<CHandle<CGameplayEntity>> HitTargets { get; set;}

		[RED("droppedItems", 2,0)] 		public CArray<SDroppedItem> DroppedItems { get; set;}

		[RED("wasDefeatedFromFistFight")] 		public CBool WasDefeatedFromFistFight { get; set;}

		[RED("isCurrentlyDodging")] 		public CBool IsCurrentlyDodging { get; set;}

		[RED("combatStartTime")] 		public CFloat CombatStartTime { get; set;}

		[RED("combatPartStartTime")] 		public CFloat CombatPartStartTime { get; set;}

		[RED("collisionDamageTimestamp")] 		public CFloat CollisionDamageTimestamp { get; set;}

		[RED("lastWasAttackedTime")] 		public CFloat LastWasAttackedTime { get; set;}

		[RED("lastWasHitTime")] 		public CFloat LastWasHitTime { get; set;}

		[RED("lowerGuardTime")] 		public CFloat LowerGuardTime { get; set;}

		[RED("knockedUncounscious")] 		public CBool KnockedUncounscious { get; set;}

		[RED("isGameplayVisible")] 		public CBool IsGameplayVisible { get; set;}

		[RED("lastBreathTime")] 		public CFloat LastBreathTime { get; set;}

		[RED("isRecoveringFromKnockdown")] 		public CBool IsRecoveringFromKnockdown { get; set;}

		[RED("hitCounter")] 		public CInt32 HitCounter { get; set;}

		[RED("totalHitCounter")] 		public CInt32 TotalHitCounter { get; set;}

		[RED("customHits")] 		public CBool CustomHits { get; set;}

		[RED("defendCounter")] 		public CInt32 DefendCounter { get; set;}

		[RED("totalDefendCounter")] 		public CInt32 TotalDefendCounter { get; set;}

		[RED("bIsPlayerCurrentTarget")] 		public CBool BIsPlayerCurrentTarget { get; set;}

		[RED("buffImmunities", 2,0)] 		public CArray<SBuffImmunity> BuffImmunities { get; set;}

		[RED("buffRemovedImmunities", 2,0)] 		public CArray<SBuffImmunity> BuffRemovedImmunities { get; set;}

		[RED("newRequestedCS")] 		public CHandle<CBaseGameplayEffect> NewRequestedCS { get; set;}

		[RED("criticalStateCounter")] 		public CInt32 CriticalStateCounter { get; set;}

		[RED("totalCriticalStateCounter")] 		public CInt32 TotalCriticalStateCounter { get; set;}

		[RED("isDead")] 		public CBool IsDead { get; set;}

		[RED("canPlayHitAnim")] 		public CBool CanPlayHitAnim { get; set;}

		[RED("damageDistanceNotReducing")] 		public CFloat DamageDistanceNotReducing { get; set;}

		[RED("deathDistNotReducing")] 		public CFloat DeathDistNotReducing { get; set;}

		[RED("damageDistanceReducing")] 		public CFloat DamageDistanceReducing { get; set;}

		[RED("deathDistanceReducing")] 		public CFloat DeathDistanceReducing { get; set;}

		[RED("fallDamageMinHealthPerc")] 		public CFloat FallDamageMinHealthPerc { get; set;}

		[RED("isPlayerFollower")] 		public CBool IsPlayerFollower { get; set;}

		[RED("MAC")] 		public CHandle<CMovingPhysicalAgentComponent> MAC { get; set;}

		[RED("immortalityFlags")] 		public CInt32 ImmortalityFlags { get; set;}

		[RED("abilityManager")] 		public CHandle<W3AbilityManager> AbilityManager { get; set;}

		[RED("effectsUpdateTicking")] 		public CBool EffectsUpdateTicking { get; set;}

		[RED("immortalityFlagsCopy")] 		public CInt32 ImmortalityFlagsCopy { get; set;}

		[RED("isSwimming")] 		public CBool IsSwimming { get; set;}

		[RED("usedVehicleHandle")] 		public EntityHandle UsedVehicleHandle { get; set;}

		[RED("usedVehicle")] 		public CHandle<CGameplayEntity> UsedVehicle { get; set;}

		[RED("effectManager")] 		public CHandle<W3EffectManager> EffectManager { get; set;}

		[RED("traverser")] 		public CHandle<CScriptedExplorationTraverser> Traverser { get; set;}

		[RED("nextFreeAnimMultCauserId")] 		public CInt32 NextFreeAnimMultCauserId { get; set;}

		[RED("animationMultiplierCausers", 2,0)] 		public CArray<SAnimMultiplyCauser> AnimationMultiplierCausers { get; set;}

		[RED("isInAir")] 		public CBool IsInAir { get; set;}

		[RED("ragdollPullingStartPosition")] 		public Vector RagdollPullingStartPosition { get; set;}

		[RED("cachedIsHuman")] 		public CInt32 CachedIsHuman { get; set;}

		[RED("cachedIsWoman")] 		public CInt32 CachedIsWoman { get; set;}

		[RED("cachedIsMan")] 		public CInt32 CachedIsMan { get; set;}

		[RED("cachedIsMonster")] 		public CInt32 CachedIsMonster { get; set;}

		[RED("cachedIsAnimal")] 		public CInt32 CachedIsAnimal { get; set;}

		[RED("cachedIsVampire")] 		public CInt32 CachedIsVampire { get; set;}

		[RED("isImmuneToNegativeBuffs")] 		public CBool IsImmuneToNegativeBuffs { get; set;}

		[RED("woundToDismember")] 		public CName WoundToDismember { get; set;}

		[RED("forwardVector")] 		public Vector ForwardVector { get; set;}

		[RED("dismemberForceRagdoll")] 		public CBool DismemberForceRagdoll { get; set;}

		[RED("dismemberEffectsMask")] 		public CInt32 DismemberEffectsMask { get; set;}

		[RED("attackEventInProgress")] 		public CBool AttackEventInProgress { get; set;}

		[RED("ignoreAttack")] 		public CBool IgnoreAttack { get; set;}

		[RED("currentAttackData")] 		public CPreAttackEventData CurrentAttackData { get; set;}

		[RED("currentAttackAnimInfo")] 		public SAnimationEventAnimInfo CurrentAttackAnimInfo { get; set;}

		[RED("ignoreTargetsForCurrentAttack", 2,0)] 		public CArray<CHandle<CGameplayEntity>> IgnoreTargetsForCurrentAttack { get; set;}

		[RED("phantomWeaponAnimData")] 		public CPreAttackEventData PhantomWeaponAnimData { get; set;}

		[RED("phantomWeaponWeaponId")] 		public SItemUniqueId PhantomWeaponWeaponId { get; set;}

		[RED("phantomWeaponParried")] 		public CBool PhantomWeaponParried { get; set;}

		[RED("phantomWeaponCountered")] 		public CBool PhantomWeaponCountered { get; set;}

		[RED("phantomWeaponParriedBy", 2,0)] 		public CArray<CHandle<CActor>> PhantomWeaponParriedBy { get; set;}

		[RED("phantomWeaponAttackAnimationName")] 		public CName PhantomWeaponAttackAnimationName { get; set;}

		[RED("phantomWeaponHitTime")] 		public CFloat PhantomWeaponHitTime { get; set;}

		[RED("phantomWeaponHitTargets", 2,0)] 		public CArray<CHandle<CGameplayEntity>> PhantomWeaponHitTargets { get; set;}

		[RED("phantomStrike")] 		public CBool PhantomStrike { get; set;}

		[RED("customCameraStackIndex")] 		public CInt32 CustomCameraStackIndex { get; set;}

		[RED("cachedHeal")] 		public CFloat CachedHeal { get; set;}

		[RED("hudModuleHealScheduledUpdate")] 		public CBool HudModuleHealScheduledUpdate { get; set;}

		[RED("cachedDoTDamage")] 		public CFloat CachedDoTDamage { get; set;}

		[RED("hudModuleDoTScheduledUpdate")] 		public CBool HudModuleDoTScheduledUpdate { get; set;}

		public CActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CActor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}