using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseGrenade : gameweaponGrenade
	{
		[Ordinal(40)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetPropertyValue<CHandle<gameprojectileComponent>>();
			set => SetPropertyValue<CHandle<gameprojectileComponent>>(value);
		}

		[Ordinal(41)] 
		[RED("user")] 
		public CWeakHandle<gameObject> User
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(42)] 
		[RED("projectileSpawnPoint")] 
		public Vector4 ProjectileSpawnPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(43)] 
		[RED("shootCollision")] 
		public CHandle<entSimpleColliderComponent> ShootCollision
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(44)] 
		[RED("visualComponent")] 
		public CHandle<entIComponent> VisualComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(45)] 
		[RED("stickyMeshComponent")] 
		public CHandle<entIComponent> StickyMeshComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(46)] 
		[RED("decalsStickyComponent")] 
		public CHandle<entIComponent> DecalsStickyComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(47)] 
		[RED("homingMeshComponent")] 
		public CHandle<entIComponent> HomingMeshComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(48)] 
		[RED("targetingComponent")] 
		public CHandle<gameTargetingComponent> TargetingComponent
		{
			get => GetPropertyValue<CHandle<gameTargetingComponent>>();
			set => SetPropertyValue<CHandle<gameTargetingComponent>>(value);
		}

		[Ordinal(49)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetPropertyValue<CHandle<ResourceLibraryComponent>>();
			set => SetPropertyValue<CHandle<ResourceLibraryComponent>>(value);
		}

		[Ordinal(50)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(51)] 
		[RED("timeSinceLaunch")] 
		public CFloat TimeSinceLaunch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("detonationTimer")] 
		public CFloat DetonationTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("stickyTrackerTimeout")] 
		public CFloat StickyTrackerTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("timeOfFreezing")] 
		public CFloat TimeOfFreezing
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("spawnBlinkEffectDelayID")] 
		public gameDelayID SpawnBlinkEffectDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(56)] 
		[RED("detonateRequestDelayID")] 
		public gameDelayID DetonateRequestDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(57)] 
		[RED("releaseRequestDelayID")] 
		public gameDelayID ReleaseRequestDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(58)] 
		[RED("delayToDetonate")] 
		public CFloat DelayToDetonate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("detonationTimerActive")] 
		public CBool DetonationTimerActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("isSinking")] 
		public CBool IsSinking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("landedOnGround")] 
		public CBool LandedOnGround
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("isStuck")] 
		public CBool IsStuck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("isTracking")] 
		public CBool IsTracking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("isLockingOn")] 
		public CBool IsLockingOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(66)] 
		[RED("isLockedOn")] 
		public CBool IsLockedOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("readyToTrack")] 
		public CBool ReadyToTrack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("lockOnFailed")] 
		public CBool LockOnFailed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(69)] 
		[RED("canBeShot")] 
		public CBool CanBeShot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("shotDownByThePlayer")] 
		public CBool ShotDownByThePlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("forceExplosion")] 
		public CBool ForceExplosion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("hasClearedIgnoredObject")] 
		public CBool HasClearedIgnoredObject
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("detonateOnImpact")] 
		public CBool DetonateOnImpact
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(74)] 
		[RED("setStickyTracker")] 
		public CBool SetStickyTracker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(75)] 
		[RED("isContinuousEffect")] 
		public CBool IsContinuousEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(76)] 
		[RED("additionalAttackOnDetonate")] 
		public CBool AdditionalAttackOnDetonate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(77)] 
		[RED("additionalAttackOnCollision")] 
		public CBool AdditionalAttackOnCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(78)] 
		[RED("targetAcquired")] 
		public CBool TargetAcquired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(79)] 
		[RED("collidedWithNPC")] 
		public CBool CollidedWithNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(80)] 
		[RED("isBroadcastingStim")] 
		public CBool IsBroadcastingStim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(81)] 
		[RED("playingFastBeep")] 
		public CBool PlayingFastBeep
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(82)] 
		[RED("targetTracker")] 
		public CHandle<gameEffectInstance> TargetTracker
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(83)] 
		[RED("potentialHomingTargets")] 
		public CArray<GrenadePotentialHomingTarget> PotentialHomingTargets
		{
			get => GetPropertyValue<CArray<GrenadePotentialHomingTarget>>();
			set => SetPropertyValue<CArray<GrenadePotentialHomingTarget>>(value);
		}

		[Ordinal(84)] 
		[RED("homingGrenadeTarget")] 
		public GrenadePotentialHomingTarget HomingGrenadeTarget
		{
			get => GetPropertyValue<GrenadePotentialHomingTarget>();
			set => SetPropertyValue<GrenadePotentialHomingTarget>(value);
		}

		[Ordinal(85)] 
		[RED("cuttingGrenadePotentialTargets")] 
		public CArray<CuttingGrenadePotentialTarget> CuttingGrenadePotentialTargets
		{
			get => GetPropertyValue<CArray<CuttingGrenadePotentialTarget>>();
			set => SetPropertyValue<CArray<CuttingGrenadePotentialTarget>>(value);
		}

		[Ordinal(86)] 
		[RED("drillTargetPosition")] 
		public Vector4 DrillTargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(87)] 
		[RED("attacksSpawned")] 
		public CArray<CHandle<gameEffectInstance>> AttacksSpawned
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectInstance>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectInstance>>>(value);
		}

		[Ordinal(88)] 
		[RED("tweakRecord")] 
		public CHandle<gamedataGrenade_Record> TweakRecord
		{
			get => GetPropertyValue<CHandle<gamedataGrenade_Record>>();
			set => SetPropertyValue<CHandle<gamedataGrenade_Record>>(value);
		}

		[Ordinal(89)] 
		[RED("additionalEffect")] 
		public gameFxResource AdditionalEffect
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(90)] 
		[RED("landedCooldownActive")] 
		public CBool LandedCooldownActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(91)] 
		[RED("landedCooldownTimer")] 
		public CFloat LandedCooldownTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(92)] 
		[RED("hasHitWater")] 
		public CBool HasHitWater
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(93)] 
		[RED("waterHeight")] 
		public CFloat WaterHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(94)] 
		[RED("cpoTimeBeforeRelease")] 
		public CFloat CpoTimeBeforeRelease
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public BaseGrenade()
		{
			ProjectileSpawnPoint = new Vector4();
			MappinID = new gameNewMappinID();
			SpawnBlinkEffectDelayID = new gameDelayID();
			DetonateRequestDelayID = new gameDelayID();
			ReleaseRequestDelayID = new gameDelayID();
			IsAlive = true;
			PotentialHomingTargets = new();
			HomingGrenadeTarget = new GrenadePotentialHomingTarget();
			CuttingGrenadePotentialTargets = new();
			DrillTargetPosition = new Vector4();
			AttacksSpawned = new();
			AdditionalEffect = new gameFxResource();
			CpoTimeBeforeRelease = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
