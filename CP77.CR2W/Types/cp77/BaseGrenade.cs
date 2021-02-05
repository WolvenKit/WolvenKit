using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseGrenade : gameweaponGrenade
	{
		[Ordinal(0)]  [RED("e3HighlightHackStarted")] public CBool E3HighlightHackStarted { get; set; }
		[Ordinal(1)]  [RED("e3ObjectRevealed")] public CBool E3ObjectRevealed { get; set; }
		[Ordinal(2)]  [RED("cpoTimeBeforeRelease")] public CFloat CpoTimeBeforeRelease { get; set; }
		[Ordinal(3)]  [RED("forceRegisterInHudManager")] public CBool ForceRegisterInHudManager { get; set; }
		[Ordinal(4)]  [RED("prereqListeners")] public CArray<CHandle<GameObjectListener>> PrereqListeners { get; set; }
		[Ordinal(5)]  [RED("statusEffectListeners")] public CArray<CHandle<StatusEffectTriggerListener>> StatusEffectListeners { get; set; }
		[Ordinal(6)]  [RED("outlineRequestsManager")] public CHandle<OutlineRequestManager> OutlineRequestsManager { get; set; }
		[Ordinal(7)]  [RED("outlineFadeCounter")] public CInt32 OutlineFadeCounter { get; set; }
		[Ordinal(8)]  [RED("fadeOutStarted")] public CBool FadeOutStarted { get; set; }
		[Ordinal(9)]  [RED("lastEngineTime")] public CFloat LastEngineTime { get; set; }
		[Ordinal(10)]  [RED("accumulatedTimePasssed")] public CFloat AccumulatedTimePasssed { get; set; }
		[Ordinal(11)]  [RED("scanningComponent")] public CHandle<gameScanningComponent> ScanningComponent { get; set; }
		[Ordinal(12)]  [RED("visionComponent")] public CHandle<gameVisionModeComponent> VisionComponent { get; set; }
		[Ordinal(13)]  [RED("isHighlightedInFocusMode")] public CBool IsHighlightedInFocusMode { get; set; }
		[Ordinal(14)]  [RED("statusEffectComponent")] public CHandle<gameStatusEffectComponent> StatusEffectComponent { get; set; }
		[Ordinal(15)]  [RED("lastFrameGreen")] public CHandle<OutlineRequest> LastFrameGreen { get; set; }
		[Ordinal(16)]  [RED("lastFrameRed")] public CHandle<OutlineRequest> LastFrameRed { get; set; }
		[Ordinal(17)]  [RED("markAsQuest")] public CBool MarkAsQuest { get; set; }
		[Ordinal(18)]  [RED("forceHighlightSource")] public entEntityID ForceHighlightSource { get; set; }
		[Ordinal(19)]  [RED("workspotMapper")] public CHandle<WorkspotMapperComponent> WorkspotMapper { get; set; }
		[Ordinal(20)]  [RED("stimBroadcaster")] public CHandle<StimBroadcasterComponent> StimBroadcaster { get; set; }
		[Ordinal(21)]  [RED("uiSlotComponent")] public CHandle<entSlotComponent> UiSlotComponent { get; set; }
		[Ordinal(22)]  [RED("squadMemberComponent")] public CHandle<SquadMemberBaseComponent> SquadMemberComponent { get; set; }
		[Ordinal(23)]  [RED("sourceShootComponent")] public CHandle<gameSourceShootComponent> SourceShootComponent { get; set; }
		[Ordinal(24)]  [RED("targetShootComponent")] public CHandle<gameTargetShootComponent> TargetShootComponent { get; set; }
		[Ordinal(25)]  [RED("receivedDamageHistory")] public CArray<DamageHistoryEntry> ReceivedDamageHistory { get; set; }
		[Ordinal(26)]  [RED("forceDefeatReward")] public CBool ForceDefeatReward { get; set; }
		[Ordinal(27)]  [RED("killRewardDisabled")] public CBool KillRewardDisabled { get; set; }
		[Ordinal(28)]  [RED("willDieSoon")] public CBool WillDieSoon { get; set; }
		[Ordinal(29)]  [RED("isScannerDataDirty")] public CBool IsScannerDataDirty { get; set; }
		[Ordinal(30)]  [RED("hasVisibilityForcedInAnimSystem")] public CBool HasVisibilityForcedInAnimSystem { get; set; }
		[Ordinal(31)]  [RED("isDead")] public CBool IsDead { get; set; }
		[Ordinal(32)]  [RED("lootQuality")] public CEnum<gamedataQuality> LootQuality { get; set; }
		[Ordinal(33)]  [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(34)]  [RED("projectileComponent")] public CHandle<gameprojectileComponent> ProjectileComponent { get; set; }
		[Ordinal(35)]  [RED("user")] public wCHandle<gameObject> User { get; set; }
		[Ordinal(36)]  [RED("projectileSpawnPoint")] public Vector4 ProjectileSpawnPoint { get; set; }
		[Ordinal(37)]  [RED("shootCollision")] public CHandle<entSimpleColliderComponent> ShootCollision { get; set; }
		[Ordinal(38)]  [RED("visualComponent")] public CHandle<entIComponent> VisualComponent { get; set; }
		[Ordinal(39)]  [RED("stickyMeshComponent")] public CHandle<entIComponent> StickyMeshComponent { get; set; }
		[Ordinal(40)]  [RED("decalsStickyComponent")] public CHandle<entIComponent> DecalsStickyComponent { get; set; }
		[Ordinal(41)]  [RED("homingMeshComponent")] public CHandle<entIComponent> HomingMeshComponent { get; set; }
		[Ordinal(42)]  [RED("targetingComponent")] public CHandle<gameTargetingComponent> TargetingComponent { get; set; }
		[Ordinal(43)]  [RED("resourceLibraryComponent")] public CHandle<ResourceLibraryComponent> ResourceLibraryComponent { get; set; }
		[Ordinal(44)]  [RED("mappinID")] public gameNewMappinID MappinID { get; set; }
		[Ordinal(45)]  [RED("timeSinceLaunch")] public CFloat TimeSinceLaunch { get; set; }
		[Ordinal(46)]  [RED("detonationTimer")] public CFloat DetonationTimer { get; set; }
		[Ordinal(47)]  [RED("stickyTrackerTimeout")] public CFloat StickyTrackerTimeout { get; set; }
		[Ordinal(48)]  [RED("timeOfFreezing")] public CFloat TimeOfFreezing { get; set; }
		[Ordinal(49)]  [RED("delayToDetonate")] public CFloat DelayToDetonate { get; set; }
		[Ordinal(50)]  [RED("detonationTimerActive")] public CBool DetonationTimerActive { get; set; }
		[Ordinal(51)]  [RED("lastHitNormal")] public Vector4 LastHitNormal { get; set; }
		[Ordinal(52)]  [RED("isAlive")] public CBool IsAlive { get; set; }
		[Ordinal(53)]  [RED("delayingDetonation")] public CBool DelayingDetonation { get; set; }
		[Ordinal(54)]  [RED("landedOnGround")] public CBool LandedOnGround { get; set; }
		[Ordinal(55)]  [RED("isStuck")] public CBool IsStuck { get; set; }
		[Ordinal(56)]  [RED("isTracking")] public CBool IsTracking { get; set; }
		[Ordinal(57)]  [RED("isLockingOn")] public CBool IsLockingOn { get; set; }
		[Ordinal(58)]  [RED("isLockedOn")] public CBool IsLockedOn { get; set; }
		[Ordinal(59)]  [RED("readyToTrack")] public CBool ReadyToTrack { get; set; }
		[Ordinal(60)]  [RED("lockOnFailed")] public CBool LockOnFailed { get; set; }
		[Ordinal(61)]  [RED("canBeShot")] public CBool CanBeShot { get; set; }
		[Ordinal(62)]  [RED("shotDownByThePlayer")] public CBool ShotDownByThePlayer { get; set; }
		[Ordinal(63)]  [RED("forceExplosion")] public CBool ForceExplosion { get; set; }
		[Ordinal(64)]  [RED("hasClearedIgnoredObject")] public CBool HasClearedIgnoredObject { get; set; }
		[Ordinal(65)]  [RED("detonateOnImpact")] public CBool DetonateOnImpact { get; set; }
		[Ordinal(66)]  [RED("setStickyTracker")] public CBool SetStickyTracker { get; set; }
		[Ordinal(67)]  [RED("isContinuousEffect")] public CBool IsContinuousEffect { get; set; }
		[Ordinal(68)]  [RED("additionalAttackOnDetonate")] public CBool AdditionalAttackOnDetonate { get; set; }
		[Ordinal(69)]  [RED("additionalAttackOnCollision")] public CBool AdditionalAttackOnCollision { get; set; }
		[Ordinal(70)]  [RED("targetAcquired")] public CBool TargetAcquired { get; set; }
		[Ordinal(71)]  [RED("collidedWithNPC")] public CBool CollidedWithNPC { get; set; }
		[Ordinal(72)]  [RED("isBroadcastingStim")] public CBool IsBroadcastingStim { get; set; }
		[Ordinal(73)]  [RED("playingFastBeep")] public CBool PlayingFastBeep { get; set; }
		[Ordinal(74)]  [RED("targetTracker")] public CHandle<gameEffectInstance> TargetTracker { get; set; }
		[Ordinal(75)]  [RED("trackedTargets")] public CArray<wCHandle<ScriptedPuppet>> TrackedTargets { get; set; }
		[Ordinal(76)]  [RED("potentialHomingTargets")] public CArray<GrenadePotentialHomingTarget> PotentialHomingTargets { get; set; }
		[Ordinal(77)]  [RED("homingGrenadeTarget")] public GrenadePotentialHomingTarget HomingGrenadeTarget { get; set; }
		[Ordinal(78)]  [RED("cuttingGrenadePotentialTargets")] public CArray<CuttingGrenadePotentialTarget> CuttingGrenadePotentialTargets { get; set; }
		[Ordinal(79)]  [RED("cuttingGrenadePotentialTarget")] public CuttingGrenadePotentialTarget CuttingGrenadePotentialTarget { get; set; }
		[Ordinal(80)]  [RED("stickedTarget")] public wCHandle<ScriptedPuppet> StickedTarget { get; set; }
		[Ordinal(81)]  [RED("drillTargetPosition")] public Vector4 DrillTargetPosition { get; set; }
		[Ordinal(82)]  [RED("attacksSpawned")] public CArray<CHandle<gameEffectInstance>> AttacksSpawned { get; set; }
		[Ordinal(83)]  [RED("tweakRecord")] public CHandle<gamedataGrenade_Record> TweakRecord { get; set; }
		[Ordinal(84)]  [RED("deliveryMethod")] public CEnum<gamedataGrenadeDeliveryMethodType> DeliveryMethod { get; set; }
		[Ordinal(85)]  [RED("additionalEffect")] public gameFxResource AdditionalEffect { get; set; }
		[Ordinal(86)]  [RED("landedCooldownActive")] public CBool LandedCooldownActive { get; set; }
		[Ordinal(87)]  [RED("landedCooldownTimer")] public CFloat LandedCooldownTimer { get; set; }

		public BaseGrenade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
