using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseGrenade : gameweaponGrenade
	{
		private CHandle<gameprojectileComponent> _projectileComponent;
		private wCHandle<gameObject> _user;
		private Vector4 _projectileSpawnPoint;
		private CHandle<entSimpleColliderComponent> _shootCollision;
		private CHandle<entIComponent> _visualComponent;
		private CHandle<entIComponent> _stickyMeshComponent;
		private CHandle<entIComponent> _decalsStickyComponent;
		private CHandle<entIComponent> _homingMeshComponent;
		private CHandle<gameTargetingComponent> _targetingComponent;
		private CHandle<ResourceLibraryComponent> _resourceLibraryComponent;
		private gameNewMappinID _mappinID;
		private CFloat _timeSinceLaunch;
		private CFloat _detonationTimer;
		private CFloat _stickyTrackerTimeout;
		private CFloat _timeOfFreezing;
		private CFloat _delayToDetonate;
		private CBool _detonationTimerActive;
		private Vector4 _lastHitNormal;
		private CBool _isAlive;
		private CBool _delayingDetonation;
		private CBool _landedOnGround;
		private CBool _isStuck;
		private CBool _isTracking;
		private CBool _isLockingOn;
		private CBool _isLockedOn;
		private CBool _readyToTrack;
		private CBool _lockOnFailed;
		private CBool _canBeShot;
		private CBool _shotDownByThePlayer;
		private CBool _forceExplosion;
		private CBool _hasClearedIgnoredObject;
		private CBool _detonateOnImpact;
		private CBool _setStickyTracker;
		private CBool _isContinuousEffect;
		private CBool _additionalAttackOnDetonate;
		private CBool _additionalAttackOnCollision;
		private CBool _targetAcquired;
		private CBool _collidedWithNPC;
		private CBool _isBroadcastingStim;
		private CBool _playingFastBeep;
		private CHandle<gameEffectInstance> _targetTracker;
		private CArray<wCHandle<ScriptedPuppet>> _trackedTargets;
		private CArray<GrenadePotentialHomingTarget> _potentialHomingTargets;
		private GrenadePotentialHomingTarget _homingGrenadeTarget;
		private CArray<CuttingGrenadePotentialTarget> _cuttingGrenadePotentialTargets;
		private CuttingGrenadePotentialTarget _cuttingGrenadePotentialTarget;
		private wCHandle<ScriptedPuppet> _stickedTarget;
		private Vector4 _drillTargetPosition;
		private CArray<CHandle<gameEffectInstance>> _attacksSpawned;
		private CHandle<gamedataGrenade_Record> _tweakRecord;
		private CEnum<gamedataGrenadeDeliveryMethodType> _deliveryMethod;
		private gameFxResource _additionalEffect;
		private CBool _landedCooldownActive;
		private CFloat _landedCooldownTimer;
		private CFloat _cpoTimeBeforeRelease;

		[Ordinal(43)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get
			{
				if (_projectileComponent == null)
				{
					_projectileComponent = (CHandle<gameprojectileComponent>) CR2WTypeManager.Create("handle:gameprojectileComponent", "projectileComponent", cr2w, this);
				}
				return _projectileComponent;
			}
			set
			{
				if (_projectileComponent == value)
				{
					return;
				}
				_projectileComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("user")] 
		public wCHandle<gameObject> User
		{
			get
			{
				if (_user == null)
				{
					_user = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "user", cr2w, this);
				}
				return _user;
			}
			set
			{
				if (_user == value)
				{
					return;
				}
				_user = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("projectileSpawnPoint")] 
		public Vector4 ProjectileSpawnPoint
		{
			get
			{
				if (_projectileSpawnPoint == null)
				{
					_projectileSpawnPoint = (Vector4) CR2WTypeManager.Create("Vector4", "projectileSpawnPoint", cr2w, this);
				}
				return _projectileSpawnPoint;
			}
			set
			{
				if (_projectileSpawnPoint == value)
				{
					return;
				}
				_projectileSpawnPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("shootCollision")] 
		public CHandle<entSimpleColliderComponent> ShootCollision
		{
			get
			{
				if (_shootCollision == null)
				{
					_shootCollision = (CHandle<entSimpleColliderComponent>) CR2WTypeManager.Create("handle:entSimpleColliderComponent", "shootCollision", cr2w, this);
				}
				return _shootCollision;
			}
			set
			{
				if (_shootCollision == value)
				{
					return;
				}
				_shootCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("visualComponent")] 
		public CHandle<entIComponent> VisualComponent
		{
			get
			{
				if (_visualComponent == null)
				{
					_visualComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "visualComponent", cr2w, this);
				}
				return _visualComponent;
			}
			set
			{
				if (_visualComponent == value)
				{
					return;
				}
				_visualComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("stickyMeshComponent")] 
		public CHandle<entIComponent> StickyMeshComponent
		{
			get
			{
				if (_stickyMeshComponent == null)
				{
					_stickyMeshComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "stickyMeshComponent", cr2w, this);
				}
				return _stickyMeshComponent;
			}
			set
			{
				if (_stickyMeshComponent == value)
				{
					return;
				}
				_stickyMeshComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("decalsStickyComponent")] 
		public CHandle<entIComponent> DecalsStickyComponent
		{
			get
			{
				if (_decalsStickyComponent == null)
				{
					_decalsStickyComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "decalsStickyComponent", cr2w, this);
				}
				return _decalsStickyComponent;
			}
			set
			{
				if (_decalsStickyComponent == value)
				{
					return;
				}
				_decalsStickyComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("homingMeshComponent")] 
		public CHandle<entIComponent> HomingMeshComponent
		{
			get
			{
				if (_homingMeshComponent == null)
				{
					_homingMeshComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "homingMeshComponent", cr2w, this);
				}
				return _homingMeshComponent;
			}
			set
			{
				if (_homingMeshComponent == value)
				{
					return;
				}
				_homingMeshComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("targetingComponent")] 
		public CHandle<gameTargetingComponent> TargetingComponent
		{
			get
			{
				if (_targetingComponent == null)
				{
					_targetingComponent = (CHandle<gameTargetingComponent>) CR2WTypeManager.Create("handle:gameTargetingComponent", "targetingComponent", cr2w, this);
				}
				return _targetingComponent;
			}
			set
			{
				if (_targetingComponent == value)
				{
					return;
				}
				_targetingComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get
			{
				if (_resourceLibraryComponent == null)
				{
					_resourceLibraryComponent = (CHandle<ResourceLibraryComponent>) CR2WTypeManager.Create("handle:ResourceLibraryComponent", "resourceLibraryComponent", cr2w, this);
				}
				return _resourceLibraryComponent;
			}
			set
			{
				if (_resourceLibraryComponent == value)
				{
					return;
				}
				_resourceLibraryComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get
			{
				if (_mappinID == null)
				{
					_mappinID = (gameNewMappinID) CR2WTypeManager.Create("gameNewMappinID", "mappinID", cr2w, this);
				}
				return _mappinID;
			}
			set
			{
				if (_mappinID == value)
				{
					return;
				}
				_mappinID = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("timeSinceLaunch")] 
		public CFloat TimeSinceLaunch
		{
			get
			{
				if (_timeSinceLaunch == null)
				{
					_timeSinceLaunch = (CFloat) CR2WTypeManager.Create("Float", "timeSinceLaunch", cr2w, this);
				}
				return _timeSinceLaunch;
			}
			set
			{
				if (_timeSinceLaunch == value)
				{
					return;
				}
				_timeSinceLaunch = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("detonationTimer")] 
		public CFloat DetonationTimer
		{
			get
			{
				if (_detonationTimer == null)
				{
					_detonationTimer = (CFloat) CR2WTypeManager.Create("Float", "detonationTimer", cr2w, this);
				}
				return _detonationTimer;
			}
			set
			{
				if (_detonationTimer == value)
				{
					return;
				}
				_detonationTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("stickyTrackerTimeout")] 
		public CFloat StickyTrackerTimeout
		{
			get
			{
				if (_stickyTrackerTimeout == null)
				{
					_stickyTrackerTimeout = (CFloat) CR2WTypeManager.Create("Float", "stickyTrackerTimeout", cr2w, this);
				}
				return _stickyTrackerTimeout;
			}
			set
			{
				if (_stickyTrackerTimeout == value)
				{
					return;
				}
				_stickyTrackerTimeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("timeOfFreezing")] 
		public CFloat TimeOfFreezing
		{
			get
			{
				if (_timeOfFreezing == null)
				{
					_timeOfFreezing = (CFloat) CR2WTypeManager.Create("Float", "timeOfFreezing", cr2w, this);
				}
				return _timeOfFreezing;
			}
			set
			{
				if (_timeOfFreezing == value)
				{
					return;
				}
				_timeOfFreezing = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("delayToDetonate")] 
		public CFloat DelayToDetonate
		{
			get
			{
				if (_delayToDetonate == null)
				{
					_delayToDetonate = (CFloat) CR2WTypeManager.Create("Float", "delayToDetonate", cr2w, this);
				}
				return _delayToDetonate;
			}
			set
			{
				if (_delayToDetonate == value)
				{
					return;
				}
				_delayToDetonate = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("detonationTimerActive")] 
		public CBool DetonationTimerActive
		{
			get
			{
				if (_detonationTimerActive == null)
				{
					_detonationTimerActive = (CBool) CR2WTypeManager.Create("Bool", "detonationTimerActive", cr2w, this);
				}
				return _detonationTimerActive;
			}
			set
			{
				if (_detonationTimerActive == value)
				{
					return;
				}
				_detonationTimerActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("lastHitNormal")] 
		public Vector4 LastHitNormal
		{
			get
			{
				if (_lastHitNormal == null)
				{
					_lastHitNormal = (Vector4) CR2WTypeManager.Create("Vector4", "lastHitNormal", cr2w, this);
				}
				return _lastHitNormal;
			}
			set
			{
				if (_lastHitNormal == value)
				{
					return;
				}
				_lastHitNormal = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get
			{
				if (_isAlive == null)
				{
					_isAlive = (CBool) CR2WTypeManager.Create("Bool", "isAlive", cr2w, this);
				}
				return _isAlive;
			}
			set
			{
				if (_isAlive == value)
				{
					return;
				}
				_isAlive = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("delayingDetonation")] 
		public CBool DelayingDetonation
		{
			get
			{
				if (_delayingDetonation == null)
				{
					_delayingDetonation = (CBool) CR2WTypeManager.Create("Bool", "delayingDetonation", cr2w, this);
				}
				return _delayingDetonation;
			}
			set
			{
				if (_delayingDetonation == value)
				{
					return;
				}
				_delayingDetonation = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("landedOnGround")] 
		public CBool LandedOnGround
		{
			get
			{
				if (_landedOnGround == null)
				{
					_landedOnGround = (CBool) CR2WTypeManager.Create("Bool", "landedOnGround", cr2w, this);
				}
				return _landedOnGround;
			}
			set
			{
				if (_landedOnGround == value)
				{
					return;
				}
				_landedOnGround = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("isStuck")] 
		public CBool IsStuck
		{
			get
			{
				if (_isStuck == null)
				{
					_isStuck = (CBool) CR2WTypeManager.Create("Bool", "isStuck", cr2w, this);
				}
				return _isStuck;
			}
			set
			{
				if (_isStuck == value)
				{
					return;
				}
				_isStuck = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("isTracking")] 
		public CBool IsTracking
		{
			get
			{
				if (_isTracking == null)
				{
					_isTracking = (CBool) CR2WTypeManager.Create("Bool", "isTracking", cr2w, this);
				}
				return _isTracking;
			}
			set
			{
				if (_isTracking == value)
				{
					return;
				}
				_isTracking = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("isLockingOn")] 
		public CBool IsLockingOn
		{
			get
			{
				if (_isLockingOn == null)
				{
					_isLockingOn = (CBool) CR2WTypeManager.Create("Bool", "isLockingOn", cr2w, this);
				}
				return _isLockingOn;
			}
			set
			{
				if (_isLockingOn == value)
				{
					return;
				}
				_isLockingOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("isLockedOn")] 
		public CBool IsLockedOn
		{
			get
			{
				if (_isLockedOn == null)
				{
					_isLockedOn = (CBool) CR2WTypeManager.Create("Bool", "isLockedOn", cr2w, this);
				}
				return _isLockedOn;
			}
			set
			{
				if (_isLockedOn == value)
				{
					return;
				}
				_isLockedOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("readyToTrack")] 
		public CBool ReadyToTrack
		{
			get
			{
				if (_readyToTrack == null)
				{
					_readyToTrack = (CBool) CR2WTypeManager.Create("Bool", "readyToTrack", cr2w, this);
				}
				return _readyToTrack;
			}
			set
			{
				if (_readyToTrack == value)
				{
					return;
				}
				_readyToTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("lockOnFailed")] 
		public CBool LockOnFailed
		{
			get
			{
				if (_lockOnFailed == null)
				{
					_lockOnFailed = (CBool) CR2WTypeManager.Create("Bool", "lockOnFailed", cr2w, this);
				}
				return _lockOnFailed;
			}
			set
			{
				if (_lockOnFailed == value)
				{
					return;
				}
				_lockOnFailed = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("canBeShot")] 
		public CBool CanBeShot
		{
			get
			{
				if (_canBeShot == null)
				{
					_canBeShot = (CBool) CR2WTypeManager.Create("Bool", "canBeShot", cr2w, this);
				}
				return _canBeShot;
			}
			set
			{
				if (_canBeShot == value)
				{
					return;
				}
				_canBeShot = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("shotDownByThePlayer")] 
		public CBool ShotDownByThePlayer
		{
			get
			{
				if (_shotDownByThePlayer == null)
				{
					_shotDownByThePlayer = (CBool) CR2WTypeManager.Create("Bool", "shotDownByThePlayer", cr2w, this);
				}
				return _shotDownByThePlayer;
			}
			set
			{
				if (_shotDownByThePlayer == value)
				{
					return;
				}
				_shotDownByThePlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("forceExplosion")] 
		public CBool ForceExplosion
		{
			get
			{
				if (_forceExplosion == null)
				{
					_forceExplosion = (CBool) CR2WTypeManager.Create("Bool", "forceExplosion", cr2w, this);
				}
				return _forceExplosion;
			}
			set
			{
				if (_forceExplosion == value)
				{
					return;
				}
				_forceExplosion = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("hasClearedIgnoredObject")] 
		public CBool HasClearedIgnoredObject
		{
			get
			{
				if (_hasClearedIgnoredObject == null)
				{
					_hasClearedIgnoredObject = (CBool) CR2WTypeManager.Create("Bool", "hasClearedIgnoredObject", cr2w, this);
				}
				return _hasClearedIgnoredObject;
			}
			set
			{
				if (_hasClearedIgnoredObject == value)
				{
					return;
				}
				_hasClearedIgnoredObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("detonateOnImpact")] 
		public CBool DetonateOnImpact
		{
			get
			{
				if (_detonateOnImpact == null)
				{
					_detonateOnImpact = (CBool) CR2WTypeManager.Create("Bool", "detonateOnImpact", cr2w, this);
				}
				return _detonateOnImpact;
			}
			set
			{
				if (_detonateOnImpact == value)
				{
					return;
				}
				_detonateOnImpact = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("setStickyTracker")] 
		public CBool SetStickyTracker
		{
			get
			{
				if (_setStickyTracker == null)
				{
					_setStickyTracker = (CBool) CR2WTypeManager.Create("Bool", "setStickyTracker", cr2w, this);
				}
				return _setStickyTracker;
			}
			set
			{
				if (_setStickyTracker == value)
				{
					return;
				}
				_setStickyTracker = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("isContinuousEffect")] 
		public CBool IsContinuousEffect
		{
			get
			{
				if (_isContinuousEffect == null)
				{
					_isContinuousEffect = (CBool) CR2WTypeManager.Create("Bool", "isContinuousEffect", cr2w, this);
				}
				return _isContinuousEffect;
			}
			set
			{
				if (_isContinuousEffect == value)
				{
					return;
				}
				_isContinuousEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("additionalAttackOnDetonate")] 
		public CBool AdditionalAttackOnDetonate
		{
			get
			{
				if (_additionalAttackOnDetonate == null)
				{
					_additionalAttackOnDetonate = (CBool) CR2WTypeManager.Create("Bool", "additionalAttackOnDetonate", cr2w, this);
				}
				return _additionalAttackOnDetonate;
			}
			set
			{
				if (_additionalAttackOnDetonate == value)
				{
					return;
				}
				_additionalAttackOnDetonate = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("additionalAttackOnCollision")] 
		public CBool AdditionalAttackOnCollision
		{
			get
			{
				if (_additionalAttackOnCollision == null)
				{
					_additionalAttackOnCollision = (CBool) CR2WTypeManager.Create("Bool", "additionalAttackOnCollision", cr2w, this);
				}
				return _additionalAttackOnCollision;
			}
			set
			{
				if (_additionalAttackOnCollision == value)
				{
					return;
				}
				_additionalAttackOnCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("targetAcquired")] 
		public CBool TargetAcquired
		{
			get
			{
				if (_targetAcquired == null)
				{
					_targetAcquired = (CBool) CR2WTypeManager.Create("Bool", "targetAcquired", cr2w, this);
				}
				return _targetAcquired;
			}
			set
			{
				if (_targetAcquired == value)
				{
					return;
				}
				_targetAcquired = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("collidedWithNPC")] 
		public CBool CollidedWithNPC
		{
			get
			{
				if (_collidedWithNPC == null)
				{
					_collidedWithNPC = (CBool) CR2WTypeManager.Create("Bool", "collidedWithNPC", cr2w, this);
				}
				return _collidedWithNPC;
			}
			set
			{
				if (_collidedWithNPC == value)
				{
					return;
				}
				_collidedWithNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("isBroadcastingStim")] 
		public CBool IsBroadcastingStim
		{
			get
			{
				if (_isBroadcastingStim == null)
				{
					_isBroadcastingStim = (CBool) CR2WTypeManager.Create("Bool", "isBroadcastingStim", cr2w, this);
				}
				return _isBroadcastingStim;
			}
			set
			{
				if (_isBroadcastingStim == value)
				{
					return;
				}
				_isBroadcastingStim = value;
				PropertySet(this);
			}
		}

		[Ordinal(82)] 
		[RED("playingFastBeep")] 
		public CBool PlayingFastBeep
		{
			get
			{
				if (_playingFastBeep == null)
				{
					_playingFastBeep = (CBool) CR2WTypeManager.Create("Bool", "playingFastBeep", cr2w, this);
				}
				return _playingFastBeep;
			}
			set
			{
				if (_playingFastBeep == value)
				{
					return;
				}
				_playingFastBeep = value;
				PropertySet(this);
			}
		}

		[Ordinal(83)] 
		[RED("targetTracker")] 
		public CHandle<gameEffectInstance> TargetTracker
		{
			get
			{
				if (_targetTracker == null)
				{
					_targetTracker = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "targetTracker", cr2w, this);
				}
				return _targetTracker;
			}
			set
			{
				if (_targetTracker == value)
				{
					return;
				}
				_targetTracker = value;
				PropertySet(this);
			}
		}

		[Ordinal(84)] 
		[RED("trackedTargets")] 
		public CArray<wCHandle<ScriptedPuppet>> TrackedTargets
		{
			get
			{
				if (_trackedTargets == null)
				{
					_trackedTargets = (CArray<wCHandle<ScriptedPuppet>>) CR2WTypeManager.Create("array:whandle:ScriptedPuppet", "trackedTargets", cr2w, this);
				}
				return _trackedTargets;
			}
			set
			{
				if (_trackedTargets == value)
				{
					return;
				}
				_trackedTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(85)] 
		[RED("potentialHomingTargets")] 
		public CArray<GrenadePotentialHomingTarget> PotentialHomingTargets
		{
			get
			{
				if (_potentialHomingTargets == null)
				{
					_potentialHomingTargets = (CArray<GrenadePotentialHomingTarget>) CR2WTypeManager.Create("array:GrenadePotentialHomingTarget", "potentialHomingTargets", cr2w, this);
				}
				return _potentialHomingTargets;
			}
			set
			{
				if (_potentialHomingTargets == value)
				{
					return;
				}
				_potentialHomingTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(86)] 
		[RED("homingGrenadeTarget")] 
		public GrenadePotentialHomingTarget HomingGrenadeTarget
		{
			get
			{
				if (_homingGrenadeTarget == null)
				{
					_homingGrenadeTarget = (GrenadePotentialHomingTarget) CR2WTypeManager.Create("GrenadePotentialHomingTarget", "homingGrenadeTarget", cr2w, this);
				}
				return _homingGrenadeTarget;
			}
			set
			{
				if (_homingGrenadeTarget == value)
				{
					return;
				}
				_homingGrenadeTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("cuttingGrenadePotentialTargets")] 
		public CArray<CuttingGrenadePotentialTarget> CuttingGrenadePotentialTargets
		{
			get
			{
				if (_cuttingGrenadePotentialTargets == null)
				{
					_cuttingGrenadePotentialTargets = (CArray<CuttingGrenadePotentialTarget>) CR2WTypeManager.Create("array:CuttingGrenadePotentialTarget", "cuttingGrenadePotentialTargets", cr2w, this);
				}
				return _cuttingGrenadePotentialTargets;
			}
			set
			{
				if (_cuttingGrenadePotentialTargets == value)
				{
					return;
				}
				_cuttingGrenadePotentialTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(88)] 
		[RED("cuttingGrenadePotentialTarget")] 
		public CuttingGrenadePotentialTarget CuttingGrenadePotentialTarget
		{
			get
			{
				if (_cuttingGrenadePotentialTarget == null)
				{
					_cuttingGrenadePotentialTarget = (CuttingGrenadePotentialTarget) CR2WTypeManager.Create("CuttingGrenadePotentialTarget", "cuttingGrenadePotentialTarget", cr2w, this);
				}
				return _cuttingGrenadePotentialTarget;
			}
			set
			{
				if (_cuttingGrenadePotentialTarget == value)
				{
					return;
				}
				_cuttingGrenadePotentialTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(89)] 
		[RED("stickedTarget")] 
		public wCHandle<ScriptedPuppet> StickedTarget
		{
			get
			{
				if (_stickedTarget == null)
				{
					_stickedTarget = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "stickedTarget", cr2w, this);
				}
				return _stickedTarget;
			}
			set
			{
				if (_stickedTarget == value)
				{
					return;
				}
				_stickedTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(90)] 
		[RED("drillTargetPosition")] 
		public Vector4 DrillTargetPosition
		{
			get
			{
				if (_drillTargetPosition == null)
				{
					_drillTargetPosition = (Vector4) CR2WTypeManager.Create("Vector4", "drillTargetPosition", cr2w, this);
				}
				return _drillTargetPosition;
			}
			set
			{
				if (_drillTargetPosition == value)
				{
					return;
				}
				_drillTargetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(91)] 
		[RED("attacksSpawned")] 
		public CArray<CHandle<gameEffectInstance>> AttacksSpawned
		{
			get
			{
				if (_attacksSpawned == null)
				{
					_attacksSpawned = (CArray<CHandle<gameEffectInstance>>) CR2WTypeManager.Create("array:handle:gameEffectInstance", "attacksSpawned", cr2w, this);
				}
				return _attacksSpawned;
			}
			set
			{
				if (_attacksSpawned == value)
				{
					return;
				}
				_attacksSpawned = value;
				PropertySet(this);
			}
		}

		[Ordinal(92)] 
		[RED("tweakRecord")] 
		public CHandle<gamedataGrenade_Record> TweakRecord
		{
			get
			{
				if (_tweakRecord == null)
				{
					_tweakRecord = (CHandle<gamedataGrenade_Record>) CR2WTypeManager.Create("handle:gamedataGrenade_Record", "tweakRecord", cr2w, this);
				}
				return _tweakRecord;
			}
			set
			{
				if (_tweakRecord == value)
				{
					return;
				}
				_tweakRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(93)] 
		[RED("deliveryMethod")] 
		public CEnum<gamedataGrenadeDeliveryMethodType> DeliveryMethod
		{
			get
			{
				if (_deliveryMethod == null)
				{
					_deliveryMethod = (CEnum<gamedataGrenadeDeliveryMethodType>) CR2WTypeManager.Create("gamedataGrenadeDeliveryMethodType", "deliveryMethod", cr2w, this);
				}
				return _deliveryMethod;
			}
			set
			{
				if (_deliveryMethod == value)
				{
					return;
				}
				_deliveryMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("additionalEffect")] 
		public gameFxResource AdditionalEffect
		{
			get
			{
				if (_additionalEffect == null)
				{
					_additionalEffect = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "additionalEffect", cr2w, this);
				}
				return _additionalEffect;
			}
			set
			{
				if (_additionalEffect == value)
				{
					return;
				}
				_additionalEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("landedCooldownActive")] 
		public CBool LandedCooldownActive
		{
			get
			{
				if (_landedCooldownActive == null)
				{
					_landedCooldownActive = (CBool) CR2WTypeManager.Create("Bool", "landedCooldownActive", cr2w, this);
				}
				return _landedCooldownActive;
			}
			set
			{
				if (_landedCooldownActive == value)
				{
					return;
				}
				_landedCooldownActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("landedCooldownTimer")] 
		public CFloat LandedCooldownTimer
		{
			get
			{
				if (_landedCooldownTimer == null)
				{
					_landedCooldownTimer = (CFloat) CR2WTypeManager.Create("Float", "landedCooldownTimer", cr2w, this);
				}
				return _landedCooldownTimer;
			}
			set
			{
				if (_landedCooldownTimer == value)
				{
					return;
				}
				_landedCooldownTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("cpoTimeBeforeRelease")] 
		public CFloat CpoTimeBeforeRelease
		{
			get
			{
				if (_cpoTimeBeforeRelease == null)
				{
					_cpoTimeBeforeRelease = (CFloat) CR2WTypeManager.Create("Float", "cpoTimeBeforeRelease", cr2w, this);
				}
				return _cpoTimeBeforeRelease;
			}
			set
			{
				if (_cpoTimeBeforeRelease == value)
				{
					return;
				}
				_cpoTimeBeforeRelease = value;
				PropertySet(this);
			}
		}

		public BaseGrenade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
