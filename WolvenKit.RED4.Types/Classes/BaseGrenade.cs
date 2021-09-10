using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseGrenade : gameweaponGrenade
	{
		[Ordinal(45)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetPropertyValue<CHandle<gameprojectileComponent>>();
			set => SetPropertyValue<CHandle<gameprojectileComponent>>(value);
		}

		[Ordinal(46)] 
		[RED("user")] 
		public CWeakHandle<gameObject> User
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(47)] 
		[RED("projectileSpawnPoint")] 
		public Vector4 ProjectileSpawnPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(48)] 
		[RED("shootCollision")] 
		public CHandle<entSimpleColliderComponent> ShootCollision
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(49)] 
		[RED("visualComponent")] 
		public CHandle<entIComponent> VisualComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(50)] 
		[RED("stickyMeshComponent")] 
		public CHandle<entIComponent> StickyMeshComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(51)] 
		[RED("decalsStickyComponent")] 
		public CHandle<entIComponent> DecalsStickyComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(52)] 
		[RED("homingMeshComponent")] 
		public CHandle<entIComponent> HomingMeshComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(53)] 
		[RED("targetingComponent")] 
		public CHandle<gameTargetingComponent> TargetingComponent
		{
			get => GetPropertyValue<CHandle<gameTargetingComponent>>();
			set => SetPropertyValue<CHandle<gameTargetingComponent>>(value);
		}

		[Ordinal(54)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetPropertyValue<CHandle<ResourceLibraryComponent>>();
			set => SetPropertyValue<CHandle<ResourceLibraryComponent>>(value);
		}

		[Ordinal(55)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(56)] 
		[RED("timeSinceLaunch")] 
		public CFloat TimeSinceLaunch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("detonationTimer")] 
		public CFloat DetonationTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("stickyTrackerTimeout")] 
		public CFloat StickyTrackerTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("timeOfFreezing")] 
		public CFloat TimeOfFreezing
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(60)] 
		[RED("queueFailDetonationDelayID")] 
		public gameDelayID QueueFailDetonationDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(61)] 
		[RED("delayToDetonate")] 
		public CFloat DelayToDetonate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(62)] 
		[RED("detonationTimerActive")] 
		public CBool DetonationTimerActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("delayingDetonation")] 
		public CBool DelayingDetonation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("landedOnGround")] 
		public CBool LandedOnGround
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(66)] 
		[RED("isStuck")] 
		public CBool IsStuck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("isTracking")] 
		public CBool IsTracking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("isLockingOn")] 
		public CBool IsLockingOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(69)] 
		[RED("isLockedOn")] 
		public CBool IsLockedOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("readyToTrack")] 
		public CBool ReadyToTrack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("lockOnFailed")] 
		public CBool LockOnFailed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("canBeShot")] 
		public CBool CanBeShot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("shotDownByThePlayer")] 
		public CBool ShotDownByThePlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(74)] 
		[RED("forceExplosion")] 
		public CBool ForceExplosion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(75)] 
		[RED("hasClearedIgnoredObject")] 
		public CBool HasClearedIgnoredObject
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(76)] 
		[RED("detonateOnImpact")] 
		public CBool DetonateOnImpact
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(77)] 
		[RED("setStickyTracker")] 
		public CBool SetStickyTracker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(78)] 
		[RED("isContinuousEffect")] 
		public CBool IsContinuousEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(79)] 
		[RED("additionalAttackOnDetonate")] 
		public CBool AdditionalAttackOnDetonate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(80)] 
		[RED("additionalAttackOnCollision")] 
		public CBool AdditionalAttackOnCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(81)] 
		[RED("targetAcquired")] 
		public CBool TargetAcquired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(82)] 
		[RED("collidedWithNPC")] 
		public CBool CollidedWithNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(83)] 
		[RED("isBroadcastingStim")] 
		public CBool IsBroadcastingStim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(84)] 
		[RED("playingFastBeep")] 
		public CBool PlayingFastBeep
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(85)] 
		[RED("targetTracker")] 
		public CHandle<gameEffectInstance> TargetTracker
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(86)] 
		[RED("trackedTargets")] 
		public CArray<CWeakHandle<ScriptedPuppet>> TrackedTargets
		{
			get => GetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>(value);
		}

		[Ordinal(87)] 
		[RED("potentialHomingTargets")] 
		public CArray<GrenadePotentialHomingTarget> PotentialHomingTargets
		{
			get => GetPropertyValue<CArray<GrenadePotentialHomingTarget>>();
			set => SetPropertyValue<CArray<GrenadePotentialHomingTarget>>(value);
		}

		[Ordinal(88)] 
		[RED("homingGrenadeTarget")] 
		public GrenadePotentialHomingTarget HomingGrenadeTarget
		{
			get => GetPropertyValue<GrenadePotentialHomingTarget>();
			set => SetPropertyValue<GrenadePotentialHomingTarget>(value);
		}

		[Ordinal(89)] 
		[RED("cuttingGrenadePotentialTargets")] 
		public CArray<CuttingGrenadePotentialTarget> CuttingGrenadePotentialTargets
		{
			get => GetPropertyValue<CArray<CuttingGrenadePotentialTarget>>();
			set => SetPropertyValue<CArray<CuttingGrenadePotentialTarget>>(value);
		}

		[Ordinal(90)] 
		[RED("cuttingGrenadePotentialTarget")] 
		public CuttingGrenadePotentialTarget CuttingGrenadePotentialTarget
		{
			get => GetPropertyValue<CuttingGrenadePotentialTarget>();
			set => SetPropertyValue<CuttingGrenadePotentialTarget>(value);
		}

		[Ordinal(91)] 
		[RED("stickedTarget")] 
		public CWeakHandle<ScriptedPuppet> StickedTarget
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(92)] 
		[RED("drillTargetPosition")] 
		public Vector4 DrillTargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(93)] 
		[RED("attacksSpawned")] 
		public CArray<CHandle<gameEffectInstance>> AttacksSpawned
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectInstance>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectInstance>>>(value);
		}

		[Ordinal(94)] 
		[RED("tweakRecord")] 
		public CHandle<gamedataGrenade_Record> TweakRecord
		{
			get => GetPropertyValue<CHandle<gamedataGrenade_Record>>();
			set => SetPropertyValue<CHandle<gamedataGrenade_Record>>(value);
		}

		[Ordinal(95)] 
		[RED("additionalEffect")] 
		public gameFxResource AdditionalEffect
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(96)] 
		[RED("landedCooldownActive")] 
		public CBool LandedCooldownActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(97)] 
		[RED("landedCooldownTimer")] 
		public CFloat LandedCooldownTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(98)] 
		[RED("cpoTimeBeforeRelease")] 
		public CFloat CpoTimeBeforeRelease
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public BaseGrenade()
		{
			ProjectileSpawnPoint = new();
			MappinID = new();
			QueueFailDetonationDelayID = new();
			IsAlive = true;
			TrackedTargets = new();
			PotentialHomingTargets = new();
			HomingGrenadeTarget = new();
			CuttingGrenadePotentialTargets = new();
			CuttingGrenadePotentialTarget = new();
			DrillTargetPosition = new();
			AttacksSpawned = new();
			AdditionalEffect = new();
			CpoTimeBeforeRelease = 3.000000F;
		}
	}
}
