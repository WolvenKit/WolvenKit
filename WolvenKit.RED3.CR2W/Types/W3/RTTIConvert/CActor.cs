using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CActor : CGameplayEntity
	{
		[Ordinal(1)] [RED("actorGroups")] 		public CEnum<EPathEngineAgentType> ActorGroups { get; set;}

		[Ordinal(2)] [RED("aimOffset")] 		public CFloat AimOffset { get; set;}

		[Ordinal(3)] [RED("barOffset")] 		public CFloat BarOffset { get; set;}

		[Ordinal(4)] [RED("isAttackableByPlayer")] 		public CBool IsAttackableByPlayer { get; set;}

		[Ordinal(5)] [RED("losTestBoneIndex")] 		public CInt32 LosTestBoneIndex { get; set;}

		[Ordinal(6)] [RED("attackTarget")] 		public CHandle<CActor> AttackTarget { get; set;}

		[Ordinal(7)] [RED("attackTargetSetTime")] 		public EngineTime AttackTargetSetTime { get; set;}

		[Ordinal(8)] [RED("frontPushAnim")] 		public CName FrontPushAnim { get; set;}

		[Ordinal(9)] [RED("backPushAnim")] 		public CName BackPushAnim { get; set;}

		[Ordinal(10)] [RED("isCollidable")] 		public CBool IsCollidable { get; set;}

		[Ordinal(11)] [RED("isVisibileFromFar")] 		public CBool IsVisibileFromFar { get; set;}

		[Ordinal(12)] [RED("voiceTag")] 		public CName VoiceTag { get; set;}

		[Ordinal(13)] [RED("voiceToRandomize", 2,0)] 		public CArray<StringAnsi> VoiceToRandomize { get; set;}

		[Ordinal(14)] [RED("behTreeMachine")] 		public CPtr<CBehTreeMachine> BehTreeMachine { get; set;}

		[Ordinal(15)] [RED("useHiResShadows")] 		public CBool UseHiResShadows { get; set;}

		[Ordinal(16)] [RED("isInFFMiniGame")] 		public CBool IsInFFMiniGame { get; set;}

		[Ordinal(17)] [RED("pelvisBoneName")] 		public CName PelvisBoneName { get; set;}

		[Ordinal(18)] [RED("torsoBoneName")] 		public CName TorsoBoneName { get; set;}

		[Ordinal(19)] [RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[Ordinal(20)] [RED("useAnimationEventFilter")] 		public CBool UseAnimationEventFilter { get; set;}

		[Ordinal(21)] [RED("soundListenerOverride")] 		public CString SoundListenerOverride { get; set;}

		[Ordinal(22)] [RED("encounterGroupUsedToSpawn")] 		public CInt32 EncounterGroupUsedToSpawn { get; set;}

		[Ordinal(23)] [RED("isTargatebleByPlayer")] 		public CBool IsTargatebleByPlayer { get; set;}

		[Ordinal(24)] [RED("isUsingTooltip")] 		public CBool IsUsingTooltip { get; set;}

		[Ordinal(25)] [RED("slideTarget")] 		public CHandle<CGameplayEntity> SlideTarget { get; set;}

		[Ordinal(26)] [RED("parryTypeTable", 2,0)] 		public CArray<CArray<CEnum<EParryType>>> ParryTypeTable { get; set;}

		[Ordinal(27)] [RED("lastAttacker")] 		public CHandle<CActor> LastAttacker { get; set;}

		[Ordinal(28)] [RED("counterAttackAnimTable", 2,0)] 		public CArray<CName> CounterAttackAnimTable { get; set;}

		[Ordinal(29)] [RED("bIsGuarded")] 		public CBool BIsGuarded { get; set;}

		[Ordinal(30)] [RED("bParryEnabled")] 		public CBool BParryEnabled { get; set;}

		[Ordinal(31)] [RED("bCanPerformCounter")] 		public CBool BCanPerformCounter { get; set;}

		[Ordinal(32)] [RED("lastParryType")] 		public CEnum<EParryType> LastParryType { get; set;}

		[Ordinal(33)] [RED("useAdditiveHits")] 		public CBool UseAdditiveHits { get; set;}

		[Ordinal(34)] [RED("oneTimeAdditiveHit")] 		public CBool OneTimeAdditiveHit { get; set;}

		[Ordinal(35)] [RED("useAdditiveCriticalStateAnim")] 		public CBool UseAdditiveCriticalStateAnim { get; set;}

		[Ordinal(36)] [RED("criticalCancelAdditiveHit")] 		public CBool CriticalCancelAdditiveHit { get; set;}

		[Ordinal(37)] [RED("lastAttackRangeName")] 		public CName LastAttackRangeName { get; set;}

		[Ordinal(38)] [RED("attackActionName")] 		public CName AttackActionName { get; set;}

		[Ordinal(39)] [RED("hitTargets", 2,0)] 		public CArray<CHandle<CGameplayEntity>> HitTargets { get; set;}

		[Ordinal(40)] [RED("droppedItems", 2,0)] 		public CArray<SDroppedItem> DroppedItems { get; set;}

		[Ordinal(41)] [RED("wasDefeatedFromFistFight")] 		public CBool WasDefeatedFromFistFight { get; set;}

		[Ordinal(42)] [RED("isCurrentlyDodging")] 		public CBool IsCurrentlyDodging { get; set;}

		[Ordinal(43)] [RED("combatStartTime")] 		public CFloat CombatStartTime { get; set;}

		[Ordinal(44)] [RED("combatPartStartTime")] 		public CFloat CombatPartStartTime { get; set;}

		[Ordinal(45)] [RED("collisionDamageTimestamp")] 		public CFloat CollisionDamageTimestamp { get; set;}

		[Ordinal(46)] [RED("lastWasAttackedTime")] 		public CFloat LastWasAttackedTime { get; set;}

		[Ordinal(47)] [RED("lastWasHitTime")] 		public CFloat LastWasHitTime { get; set;}

		[Ordinal(48)] [RED("lowerGuardTime")] 		public CFloat LowerGuardTime { get; set;}

		[Ordinal(49)] [RED("knockedUncounscious")] 		public CBool KnockedUncounscious { get; set;}

		[Ordinal(50)] [RED("isGameplayVisible")] 		public CBool IsGameplayVisible { get; set;}

		[Ordinal(51)] [RED("lastBreathTime")] 		public CFloat LastBreathTime { get; set;}

		[Ordinal(52)] [RED("isRecoveringFromKnockdown")] 		public CBool IsRecoveringFromKnockdown { get; set;}

		[Ordinal(53)] [RED("hitCounter")] 		public CInt32 HitCounter { get; set;}

		[Ordinal(54)] [RED("totalHitCounter")] 		public CInt32 TotalHitCounter { get; set;}

		[Ordinal(55)] [RED("customHits")] 		public CBool CustomHits { get; set;}

		[Ordinal(56)] [RED("defendCounter")] 		public CInt32 DefendCounter { get; set;}

		[Ordinal(57)] [RED("totalDefendCounter")] 		public CInt32 TotalDefendCounter { get; set;}

		[Ordinal(58)] [RED("bIsPlayerCurrentTarget")] 		public CBool BIsPlayerCurrentTarget { get; set;}

		[Ordinal(59)] [RED("buffImmunities", 2,0)] 		public CArray<SBuffImmunity> BuffImmunities { get; set;}

		[Ordinal(60)] [RED("buffRemovedImmunities", 2,0)] 		public CArray<SBuffImmunity> BuffRemovedImmunities { get; set;}

		[Ordinal(61)] [RED("newRequestedCS")] 		public CHandle<CBaseGameplayEffect> NewRequestedCS { get; set;}

		[Ordinal(62)] [RED("criticalStateCounter")] 		public CInt32 CriticalStateCounter { get; set;}

		[Ordinal(63)] [RED("totalCriticalStateCounter")] 		public CInt32 TotalCriticalStateCounter { get; set;}

		[Ordinal(64)] [RED("isDead")] 		public CBool IsDead { get; set;}

		[Ordinal(65)] [RED("canPlayHitAnim")] 		public CBool CanPlayHitAnim { get; set;}

		[Ordinal(66)] [RED("damageDistanceNotReducing")] 		public CFloat DamageDistanceNotReducing { get; set;}

		[Ordinal(67)] [RED("deathDistNotReducing")] 		public CFloat DeathDistNotReducing { get; set;}

		[Ordinal(68)] [RED("damageDistanceReducing")] 		public CFloat DamageDistanceReducing { get; set;}

		[Ordinal(69)] [RED("deathDistanceReducing")] 		public CFloat DeathDistanceReducing { get; set;}

		[Ordinal(70)] [RED("fallDamageMinHealthPerc")] 		public CFloat FallDamageMinHealthPerc { get; set;}

		[Ordinal(71)] [RED("isPlayerFollower")] 		public CBool IsPlayerFollower { get; set;}

		[Ordinal(72)] [RED("MAC")] 		public CHandle<CMovingPhysicalAgentComponent> MAC { get; set;}

		[Ordinal(73)] [RED("immortalityFlags")] 		public CInt32 ImmortalityFlags { get; set;}

		[Ordinal(74)] [RED("abilityManager")] 		public CHandle<W3AbilityManager> AbilityManager { get; set;}

		[Ordinal(75)] [RED("effectsUpdateTicking")] 		public CBool EffectsUpdateTicking { get; set;}

		[Ordinal(76)] [RED("immortalityFlagsCopy")] 		public CInt32 ImmortalityFlagsCopy { get; set;}

		[Ordinal(77)] [RED("isSwimming")] 		public CBool IsSwimming { get; set;}

		[Ordinal(78)] [RED("usedVehicleHandle")] 		public EntityHandle UsedVehicleHandle { get; set;}

		[Ordinal(79)] [RED("usedVehicle")] 		public CHandle<CGameplayEntity> UsedVehicle { get; set;}

		[Ordinal(80)] [RED("effectManager")] 		public CHandle<W3EffectManager> EffectManager { get; set;}

		[Ordinal(81)] [RED("traverser")] 		public CHandle<CScriptedExplorationTraverser> Traverser { get; set;}

		[Ordinal(82)] [RED("nextFreeAnimMultCauserId")] 		public CInt32 NextFreeAnimMultCauserId { get; set;}

		[Ordinal(83)] [RED("animationMultiplierCausers", 2,0)] 		public CArray<SAnimMultiplyCauser> AnimationMultiplierCausers { get; set;}

		[Ordinal(84)] [RED("isInAir")] 		public CBool IsInAir { get; set;}

		[Ordinal(85)] [RED("ragdollPullingStartPosition")] 		public Vector RagdollPullingStartPosition { get; set;}

		[Ordinal(86)] [RED("cachedIsHuman")] 		public CInt32 CachedIsHuman { get; set;}

		[Ordinal(87)] [RED("cachedIsWoman")] 		public CInt32 CachedIsWoman { get; set;}

		[Ordinal(88)] [RED("cachedIsMan")] 		public CInt32 CachedIsMan { get; set;}

		[Ordinal(89)] [RED("cachedIsMonster")] 		public CInt32 CachedIsMonster { get; set;}

		[Ordinal(90)] [RED("cachedIsAnimal")] 		public CInt32 CachedIsAnimal { get; set;}

		[Ordinal(91)] [RED("cachedIsVampire")] 		public CInt32 CachedIsVampire { get; set;}

		[Ordinal(92)] [RED("isImmuneToNegativeBuffs")] 		public CBool IsImmuneToNegativeBuffs { get; set;}

		[Ordinal(93)] [RED("woundToDismember")] 		public CName WoundToDismember { get; set;}

		[Ordinal(94)] [RED("forwardVector")] 		public Vector ForwardVector { get; set;}

		[Ordinal(95)] [RED("dismemberForceRagdoll")] 		public CBool DismemberForceRagdoll { get; set;}

		[Ordinal(96)] [RED("dismemberEffectsMask")] 		public CInt32 DismemberEffectsMask { get; set;}

		[Ordinal(97)] [RED("attackEventInProgress")] 		public CBool AttackEventInProgress { get; set;}

		[Ordinal(98)] [RED("ignoreAttack")] 		public CBool IgnoreAttack { get; set;}

		[Ordinal(99)] [RED("currentAttackData")] 		public CPreAttackEventData CurrentAttackData { get; set;}

		[Ordinal(100)] [RED("currentAttackAnimInfo")] 		public SAnimationEventAnimInfo CurrentAttackAnimInfo { get; set;}

		[Ordinal(101)] [RED("ignoreTargetsForCurrentAttack", 2,0)] 		public CArray<CHandle<CGameplayEntity>> IgnoreTargetsForCurrentAttack { get; set;}

		[Ordinal(102)] [RED("phantomWeaponAnimData")] 		public CPreAttackEventData PhantomWeaponAnimData { get; set;}

		[Ordinal(103)] [RED("phantomWeaponWeaponId")] 		public SItemUniqueId PhantomWeaponWeaponId { get; set;}

		[Ordinal(104)] [RED("phantomWeaponParried")] 		public CBool PhantomWeaponParried { get; set;}

		[Ordinal(105)] [RED("phantomWeaponCountered")] 		public CBool PhantomWeaponCountered { get; set;}

		[Ordinal(106)] [RED("phantomWeaponParriedBy", 2,0)] 		public CArray<CHandle<CActor>> PhantomWeaponParriedBy { get; set;}

		[Ordinal(107)] [RED("phantomWeaponAttackAnimationName")] 		public CName PhantomWeaponAttackAnimationName { get; set;}

		[Ordinal(108)] [RED("phantomWeaponHitTime")] 		public CFloat PhantomWeaponHitTime { get; set;}

		[Ordinal(109)] [RED("phantomWeaponHitTargets", 2,0)] 		public CArray<CHandle<CGameplayEntity>> PhantomWeaponHitTargets { get; set;}

		[Ordinal(110)] [RED("phantomStrike")] 		public CBool PhantomStrike { get; set;}

		[Ordinal(111)] [RED("customCameraStackIndex")] 		public CInt32 CustomCameraStackIndex { get; set;}

		[Ordinal(112)] [RED("cachedHeal")] 		public CFloat CachedHeal { get; set;}

		[Ordinal(113)] [RED("hudModuleHealScheduledUpdate")] 		public CBool HudModuleHealScheduledUpdate { get; set;}

		[Ordinal(114)] [RED("cachedDoTDamage")] 		public CFloat CachedDoTDamage { get; set;}

		[Ordinal(115)] [RED("hudModuleDoTScheduledUpdate")] 		public CBool HudModuleDoTScheduledUpdate { get; set;}

		public CActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CActor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}