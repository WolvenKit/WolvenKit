using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BaseGrenade : gameweaponGrenade
	{
		[Ordinal(0)]  [RED("additionalAttackOnCollision")] public CBool AdditionalAttackOnCollision { get; set; }
		[Ordinal(1)]  [RED("additionalAttackOnDetonate")] public CBool AdditionalAttackOnDetonate { get; set; }
		[Ordinal(2)]  [RED("additionalEffect")] public gameFxResource AdditionalEffect { get; set; }
		[Ordinal(3)]  [RED("attacksSpawned")] public CArray<CHandle<gameEffectInstance>> AttacksSpawned { get; set; }
		[Ordinal(4)]  [RED("canBeShot")] public CBool CanBeShot { get; set; }
		[Ordinal(5)]  [RED("collidedWithNPC")] public CBool CollidedWithNPC { get; set; }
		[Ordinal(6)]  [RED("cpoTimeBeforeRelease")] public CFloat CpoTimeBeforeRelease { get; set; }
		[Ordinal(7)]  [RED("cuttingGrenadePotentialTarget")] public CuttingGrenadePotentialTarget CuttingGrenadePotentialTarget { get; set; }
		[Ordinal(8)]  [RED("cuttingGrenadePotentialTargets")] public CArray<CuttingGrenadePotentialTarget> CuttingGrenadePotentialTargets { get; set; }
		[Ordinal(9)]  [RED("decalsStickyComponent")] public CHandle<entIComponent> DecalsStickyComponent { get; set; }
		[Ordinal(10)]  [RED("delayToDetonate")] public CFloat DelayToDetonate { get; set; }
		[Ordinal(11)]  [RED("delayingDetonation")] public CBool DelayingDetonation { get; set; }
		[Ordinal(12)]  [RED("deliveryMethod")] public CEnum<gamedataGrenadeDeliveryMethodType> DeliveryMethod { get; set; }
		[Ordinal(13)]  [RED("detonateOnImpact")] public CBool DetonateOnImpact { get; set; }
		[Ordinal(14)]  [RED("detonationTimer")] public CFloat DetonationTimer { get; set; }
		[Ordinal(15)]  [RED("detonationTimerActive")] public CBool DetonationTimerActive { get; set; }
		[Ordinal(16)]  [RED("drillTargetPosition")] public Vector4 DrillTargetPosition { get; set; }
		[Ordinal(17)]  [RED("forceExplosion")] public CBool ForceExplosion { get; set; }
		[Ordinal(18)]  [RED("hasClearedIgnoredObject")] public CBool HasClearedIgnoredObject { get; set; }
		[Ordinal(19)]  [RED("homingGrenadeTarget")] public GrenadePotentialHomingTarget HomingGrenadeTarget { get; set; }
		[Ordinal(20)]  [RED("homingMeshComponent")] public CHandle<entIComponent> HomingMeshComponent { get; set; }
		[Ordinal(21)]  [RED("isAlive")] public CBool IsAlive { get; set; }
		[Ordinal(22)]  [RED("isBroadcastingStim")] public CBool IsBroadcastingStim { get; set; }
		[Ordinal(23)]  [RED("isContinuousEffect")] public CBool IsContinuousEffect { get; set; }
		[Ordinal(24)]  [RED("isLockedOn")] public CBool IsLockedOn { get; set; }
		[Ordinal(25)]  [RED("isLockingOn")] public CBool IsLockingOn { get; set; }
		[Ordinal(26)]  [RED("isStuck")] public CBool IsStuck { get; set; }
		[Ordinal(27)]  [RED("isTracking")] public CBool IsTracking { get; set; }
		[Ordinal(28)]  [RED("landedCooldownActive")] public CBool LandedCooldownActive { get; set; }
		[Ordinal(29)]  [RED("landedCooldownTimer")] public CFloat LandedCooldownTimer { get; set; }
		[Ordinal(30)]  [RED("landedOnGround")] public CBool LandedOnGround { get; set; }
		[Ordinal(31)]  [RED("lastHitNormal")] public Vector4 LastHitNormal { get; set; }
		[Ordinal(32)]  [RED("lockOnFailed")] public CBool LockOnFailed { get; set; }
		[Ordinal(33)]  [RED("mappinID")] public gameNewMappinID MappinID { get; set; }
		[Ordinal(34)]  [RED("playingFastBeep")] public CBool PlayingFastBeep { get; set; }
		[Ordinal(35)]  [RED("potentialHomingTargets")] public CArray<GrenadePotentialHomingTarget> PotentialHomingTargets { get; set; }
		[Ordinal(36)]  [RED("projectileComponent")] public CHandle<gameprojectileComponent> ProjectileComponent { get; set; }
		[Ordinal(37)]  [RED("projectileSpawnPoint")] public Vector4 ProjectileSpawnPoint { get; set; }
		[Ordinal(38)]  [RED("readyToTrack")] public CBool ReadyToTrack { get; set; }
		[Ordinal(39)]  [RED("resourceLibraryComponent")] public CHandle<ResourceLibraryComponent> ResourceLibraryComponent { get; set; }
		[Ordinal(40)]  [RED("setStickyTracker")] public CBool SetStickyTracker { get; set; }
		[Ordinal(41)]  [RED("shootCollision")] public CHandle<entSimpleColliderComponent> ShootCollision { get; set; }
		[Ordinal(42)]  [RED("shotDownByThePlayer")] public CBool ShotDownByThePlayer { get; set; }
		[Ordinal(43)]  [RED("stickedTarget")] public wCHandle<ScriptedPuppet> StickedTarget { get; set; }
		[Ordinal(44)]  [RED("stickyMeshComponent")] public CHandle<entIComponent> StickyMeshComponent { get; set; }
		[Ordinal(45)]  [RED("stickyTrackerTimeout")] public CFloat StickyTrackerTimeout { get; set; }
		[Ordinal(46)]  [RED("targetAcquired")] public CBool TargetAcquired { get; set; }
		[Ordinal(47)]  [RED("targetTracker")] public CHandle<gameEffectInstance> TargetTracker { get; set; }
		[Ordinal(48)]  [RED("targetingComponent")] public CHandle<gameTargetingComponent> TargetingComponent { get; set; }
		[Ordinal(49)]  [RED("timeOfFreezing")] public CFloat TimeOfFreezing { get; set; }
		[Ordinal(50)]  [RED("timeSinceLaunch")] public CFloat TimeSinceLaunch { get; set; }
		[Ordinal(51)]  [RED("trackedTargets")] public CArray<wCHandle<ScriptedPuppet>> TrackedTargets { get; set; }
		[Ordinal(52)]  [RED("tweakRecord")] public CHandle<gamedataGrenade_Record> TweakRecord { get; set; }
		[Ordinal(53)]  [RED("user")] public wCHandle<gameObject> User { get; set; }
		[Ordinal(54)]  [RED("visualComponent")] public CHandle<entIComponent> VisualComponent { get; set; }

		public BaseGrenade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
