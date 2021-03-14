using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleSmartBullet : BaseProjectile
	{
		private CHandle<entIComponent> _meshComponent;
		private gameEffectRef _effect;
		private CFloat _countTime;
		private CFloat _startVelocity;
		private CFloat _lifetime;
		private CFloat _bendTimeRatio;
		private CFloat _bendFactor;
		private CBool _useParabolicPhase;
		private CFloat _parabolicVelocityMin;
		private CFloat _parabolicVelocityMax;
		private CFloat _parabolicDuration;
		private Vector4 _parabolicGravity;
		private CHandle<gameprojectileSpiralParams> _spiralParams;
		private CBool _useSpiralParams;
		private CBool _alive;
		private CBool _hit;
		private CName _trailName;
		private CHandle<gameStatsSystem> _statsSystem;
		private entEntityID _weaponID;
		private CHandle<gameprojectileParabolicTrajectoryParams> _parabolicPhaseParams;
		private CHandle<gameprojectileFollowCurveTrajectoryParams> _followPhaseParams;
		private CHandle<gameprojectileLinearTrajectoryParams> _linearPhaseParams;
		private CBool _targeted;
		private CBool _trailStarted;
		private CEnum<ESmartBulletPhase> _phase;
		private CFloat _timeInPhase;
		private CFloat _randStartVelocity;
		private CFloat _smartGunMissDelay;
		private CFloat _smartGunHitProbability;
		private CFloat _smartGunMissRadius;
		private CFloat _randomWeaponMissChance;
		private CFloat _randomTargetMissChance;
		private CBool _readyToMiss;
		private CBool _stopAndDropOnTargetingDisruption;
		private CBool _shouldStopAndDrop;
		private entEntityID _targetID;
		private entEntityID _ignoredTargetID;
		private wCHandle<gameObject> _owner;
		private wCHandle<gameObject> _weapon;
		private Vector4 _startPosition;
		private CBool _hasExploded;
		private CHandle<gameIAttack> _attack;
		private CHandle<BulletCollisionEvaluator> _bulletCollisionEvaluator;

		[Ordinal(51)] 
		[RED("meshComponent")] 
		public CHandle<entIComponent> MeshComponent
		{
			get
			{
				if (_meshComponent == null)
				{
					_meshComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "meshComponent", cr2w, this);
				}
				return _meshComponent;
			}
			set
			{
				if (_meshComponent == value)
				{
					return;
				}
				_meshComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("effect")] 
		public gameEffectRef Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get
			{
				if (_countTime == null)
				{
					_countTime = (CFloat) CR2WTypeManager.Create("Float", "countTime", cr2w, this);
				}
				return _countTime;
			}
			set
			{
				if (_countTime == value)
				{
					return;
				}
				_countTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get
			{
				if (_startVelocity == null)
				{
					_startVelocity = (CFloat) CR2WTypeManager.Create("Float", "startVelocity", cr2w, this);
				}
				return _startVelocity;
			}
			set
			{
				if (_startVelocity == value)
				{
					return;
				}
				_startVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("lifetime")] 
		public CFloat Lifetime_496
		{
			get
			{
				if (_lifetime == null)
				{
					_lifetime = (CFloat) CR2WTypeManager.Create("Float", "lifetime", cr2w, this);
				}
				return _lifetime;
			}
			set
			{
				if (_lifetime == value)
				{
					return;
				}
				_lifetime = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("bendTimeRatio")] 
		public CFloat BendTimeRatio
		{
			get
			{
				if (_bendTimeRatio == null)
				{
					_bendTimeRatio = (CFloat) CR2WTypeManager.Create("Float", "bendTimeRatio", cr2w, this);
				}
				return _bendTimeRatio;
			}
			set
			{
				if (_bendTimeRatio == value)
				{
					return;
				}
				_bendTimeRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("bendFactor")] 
		public CFloat BendFactor
		{
			get
			{
				if (_bendFactor == null)
				{
					_bendFactor = (CFloat) CR2WTypeManager.Create("Float", "bendFactor", cr2w, this);
				}
				return _bendFactor;
			}
			set
			{
				if (_bendFactor == value)
				{
					return;
				}
				_bendFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("useParabolicPhase")] 
		public CBool UseParabolicPhase
		{
			get
			{
				if (_useParabolicPhase == null)
				{
					_useParabolicPhase = (CBool) CR2WTypeManager.Create("Bool", "useParabolicPhase", cr2w, this);
				}
				return _useParabolicPhase;
			}
			set
			{
				if (_useParabolicPhase == value)
				{
					return;
				}
				_useParabolicPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("parabolicVelocityMin")] 
		public CFloat ParabolicVelocityMin
		{
			get
			{
				if (_parabolicVelocityMin == null)
				{
					_parabolicVelocityMin = (CFloat) CR2WTypeManager.Create("Float", "parabolicVelocityMin", cr2w, this);
				}
				return _parabolicVelocityMin;
			}
			set
			{
				if (_parabolicVelocityMin == value)
				{
					return;
				}
				_parabolicVelocityMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("parabolicVelocityMax")] 
		public CFloat ParabolicVelocityMax
		{
			get
			{
				if (_parabolicVelocityMax == null)
				{
					_parabolicVelocityMax = (CFloat) CR2WTypeManager.Create("Float", "parabolicVelocityMax", cr2w, this);
				}
				return _parabolicVelocityMax;
			}
			set
			{
				if (_parabolicVelocityMax == value)
				{
					return;
				}
				_parabolicVelocityMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("parabolicDuration")] 
		public CFloat ParabolicDuration
		{
			get
			{
				if (_parabolicDuration == null)
				{
					_parabolicDuration = (CFloat) CR2WTypeManager.Create("Float", "parabolicDuration", cr2w, this);
				}
				return _parabolicDuration;
			}
			set
			{
				if (_parabolicDuration == value)
				{
					return;
				}
				_parabolicDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("parabolicGravity")] 
		public Vector4 ParabolicGravity
		{
			get
			{
				if (_parabolicGravity == null)
				{
					_parabolicGravity = (Vector4) CR2WTypeManager.Create("Vector4", "parabolicGravity", cr2w, this);
				}
				return _parabolicGravity;
			}
			set
			{
				if (_parabolicGravity == value)
				{
					return;
				}
				_parabolicGravity = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("spiralParams")] 
		public CHandle<gameprojectileSpiralParams> SpiralParams
		{
			get
			{
				if (_spiralParams == null)
				{
					_spiralParams = (CHandle<gameprojectileSpiralParams>) CR2WTypeManager.Create("handle:gameprojectileSpiralParams", "spiralParams", cr2w, this);
				}
				return _spiralParams;
			}
			set
			{
				if (_spiralParams == value)
				{
					return;
				}
				_spiralParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("useSpiralParams")] 
		public CBool UseSpiralParams
		{
			get
			{
				if (_useSpiralParams == null)
				{
					_useSpiralParams = (CBool) CR2WTypeManager.Create("Bool", "useSpiralParams", cr2w, this);
				}
				return _useSpiralParams;
			}
			set
			{
				if (_useSpiralParams == value)
				{
					return;
				}
				_useSpiralParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("alive")] 
		public CBool Alive
		{
			get
			{
				if (_alive == null)
				{
					_alive = (CBool) CR2WTypeManager.Create("Bool", "alive", cr2w, this);
				}
				return _alive;
			}
			set
			{
				if (_alive == value)
				{
					return;
				}
				_alive = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("hit")] 
		public CBool Hit
		{
			get
			{
				if (_hit == null)
				{
					_hit = (CBool) CR2WTypeManager.Create("Bool", "hit", cr2w, this);
				}
				return _hit;
			}
			set
			{
				if (_hit == value)
				{
					return;
				}
				_hit = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("trailName")] 
		public CName TrailName
		{
			get
			{
				if (_trailName == null)
				{
					_trailName = (CName) CR2WTypeManager.Create("CName", "trailName", cr2w, this);
				}
				return _trailName;
			}
			set
			{
				if (_trailName == value)
				{
					return;
				}
				_trailName = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get
			{
				if (_statsSystem == null)
				{
					_statsSystem = (CHandle<gameStatsSystem>) CR2WTypeManager.Create("handle:gameStatsSystem", "statsSystem", cr2w, this);
				}
				return _statsSystem;
			}
			set
			{
				if (_statsSystem == value)
				{
					return;
				}
				_statsSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get
			{
				if (_weaponID == null)
				{
					_weaponID = (entEntityID) CR2WTypeManager.Create("entEntityID", "weaponID", cr2w, this);
				}
				return _weaponID;
			}
			set
			{
				if (_weaponID == value)
				{
					return;
				}
				_weaponID = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("parabolicPhaseParams")] 
		public CHandle<gameprojectileParabolicTrajectoryParams> ParabolicPhaseParams
		{
			get
			{
				if (_parabolicPhaseParams == null)
				{
					_parabolicPhaseParams = (CHandle<gameprojectileParabolicTrajectoryParams>) CR2WTypeManager.Create("handle:gameprojectileParabolicTrajectoryParams", "parabolicPhaseParams", cr2w, this);
				}
				return _parabolicPhaseParams;
			}
			set
			{
				if (_parabolicPhaseParams == value)
				{
					return;
				}
				_parabolicPhaseParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("followPhaseParams")] 
		public CHandle<gameprojectileFollowCurveTrajectoryParams> FollowPhaseParams
		{
			get
			{
				if (_followPhaseParams == null)
				{
					_followPhaseParams = (CHandle<gameprojectileFollowCurveTrajectoryParams>) CR2WTypeManager.Create("handle:gameprojectileFollowCurveTrajectoryParams", "followPhaseParams", cr2w, this);
				}
				return _followPhaseParams;
			}
			set
			{
				if (_followPhaseParams == value)
				{
					return;
				}
				_followPhaseParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("linearPhaseParams")] 
		public CHandle<gameprojectileLinearTrajectoryParams> LinearPhaseParams
		{
			get
			{
				if (_linearPhaseParams == null)
				{
					_linearPhaseParams = (CHandle<gameprojectileLinearTrajectoryParams>) CR2WTypeManager.Create("handle:gameprojectileLinearTrajectoryParams", "linearPhaseParams", cr2w, this);
				}
				return _linearPhaseParams;
			}
			set
			{
				if (_linearPhaseParams == value)
				{
					return;
				}
				_linearPhaseParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("targeted")] 
		public CBool Targeted
		{
			get
			{
				if (_targeted == null)
				{
					_targeted = (CBool) CR2WTypeManager.Create("Bool", "targeted", cr2w, this);
				}
				return _targeted;
			}
			set
			{
				if (_targeted == value)
				{
					return;
				}
				_targeted = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("trailStarted")] 
		public CBool TrailStarted
		{
			get
			{
				if (_trailStarted == null)
				{
					_trailStarted = (CBool) CR2WTypeManager.Create("Bool", "trailStarted", cr2w, this);
				}
				return _trailStarted;
			}
			set
			{
				if (_trailStarted == value)
				{
					return;
				}
				_trailStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("phase")] 
		public CEnum<ESmartBulletPhase> Phase
		{
			get
			{
				if (_phase == null)
				{
					_phase = (CEnum<ESmartBulletPhase>) CR2WTypeManager.Create("ESmartBulletPhase", "phase", cr2w, this);
				}
				return _phase;
			}
			set
			{
				if (_phase == value)
				{
					return;
				}
				_phase = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("timeInPhase")] 
		public CFloat TimeInPhase
		{
			get
			{
				if (_timeInPhase == null)
				{
					_timeInPhase = (CFloat) CR2WTypeManager.Create("Float", "timeInPhase", cr2w, this);
				}
				return _timeInPhase;
			}
			set
			{
				if (_timeInPhase == value)
				{
					return;
				}
				_timeInPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("randStartVelocity")] 
		public CFloat RandStartVelocity
		{
			get
			{
				if (_randStartVelocity == null)
				{
					_randStartVelocity = (CFloat) CR2WTypeManager.Create("Float", "randStartVelocity", cr2w, this);
				}
				return _randStartVelocity;
			}
			set
			{
				if (_randStartVelocity == value)
				{
					return;
				}
				_randStartVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("smartGunMissDelay")] 
		public CFloat SmartGunMissDelay
		{
			get
			{
				if (_smartGunMissDelay == null)
				{
					_smartGunMissDelay = (CFloat) CR2WTypeManager.Create("Float", "smartGunMissDelay", cr2w, this);
				}
				return _smartGunMissDelay;
			}
			set
			{
				if (_smartGunMissDelay == value)
				{
					return;
				}
				_smartGunMissDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("smartGunHitProbability")] 
		public CFloat SmartGunHitProbability
		{
			get
			{
				if (_smartGunHitProbability == null)
				{
					_smartGunHitProbability = (CFloat) CR2WTypeManager.Create("Float", "smartGunHitProbability", cr2w, this);
				}
				return _smartGunHitProbability;
			}
			set
			{
				if (_smartGunHitProbability == value)
				{
					return;
				}
				_smartGunHitProbability = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("smartGunMissRadius")] 
		public CFloat SmartGunMissRadius
		{
			get
			{
				if (_smartGunMissRadius == null)
				{
					_smartGunMissRadius = (CFloat) CR2WTypeManager.Create("Float", "smartGunMissRadius", cr2w, this);
				}
				return _smartGunMissRadius;
			}
			set
			{
				if (_smartGunMissRadius == value)
				{
					return;
				}
				_smartGunMissRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("randomWeaponMissChance")] 
		public CFloat RandomWeaponMissChance
		{
			get
			{
				if (_randomWeaponMissChance == null)
				{
					_randomWeaponMissChance = (CFloat) CR2WTypeManager.Create("Float", "randomWeaponMissChance", cr2w, this);
				}
				return _randomWeaponMissChance;
			}
			set
			{
				if (_randomWeaponMissChance == value)
				{
					return;
				}
				_randomWeaponMissChance = value;
				PropertySet(this);
			}
		}

		[Ordinal(82)] 
		[RED("randomTargetMissChance")] 
		public CFloat RandomTargetMissChance
		{
			get
			{
				if (_randomTargetMissChance == null)
				{
					_randomTargetMissChance = (CFloat) CR2WTypeManager.Create("Float", "randomTargetMissChance", cr2w, this);
				}
				return _randomTargetMissChance;
			}
			set
			{
				if (_randomTargetMissChance == value)
				{
					return;
				}
				_randomTargetMissChance = value;
				PropertySet(this);
			}
		}

		[Ordinal(83)] 
		[RED("readyToMiss")] 
		public CBool ReadyToMiss
		{
			get
			{
				if (_readyToMiss == null)
				{
					_readyToMiss = (CBool) CR2WTypeManager.Create("Bool", "readyToMiss", cr2w, this);
				}
				return _readyToMiss;
			}
			set
			{
				if (_readyToMiss == value)
				{
					return;
				}
				_readyToMiss = value;
				PropertySet(this);
			}
		}

		[Ordinal(84)] 
		[RED("stopAndDropOnTargetingDisruption")] 
		public CBool StopAndDropOnTargetingDisruption
		{
			get
			{
				if (_stopAndDropOnTargetingDisruption == null)
				{
					_stopAndDropOnTargetingDisruption = (CBool) CR2WTypeManager.Create("Bool", "stopAndDropOnTargetingDisruption", cr2w, this);
				}
				return _stopAndDropOnTargetingDisruption;
			}
			set
			{
				if (_stopAndDropOnTargetingDisruption == value)
				{
					return;
				}
				_stopAndDropOnTargetingDisruption = value;
				PropertySet(this);
			}
		}

		[Ordinal(85)] 
		[RED("shouldStopAndDrop")] 
		public CBool ShouldStopAndDrop
		{
			get
			{
				if (_shouldStopAndDrop == null)
				{
					_shouldStopAndDrop = (CBool) CR2WTypeManager.Create("Bool", "shouldStopAndDrop", cr2w, this);
				}
				return _shouldStopAndDrop;
			}
			set
			{
				if (_shouldStopAndDrop == value)
				{
					return;
				}
				_shouldStopAndDrop = value;
				PropertySet(this);
			}
		}

		[Ordinal(86)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get
			{
				if (_targetID == null)
				{
					_targetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetID", cr2w, this);
				}
				return _targetID;
			}
			set
			{
				if (_targetID == value)
				{
					return;
				}
				_targetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("ignoredTargetID")] 
		public entEntityID IgnoredTargetID
		{
			get
			{
				if (_ignoredTargetID == null)
				{
					_ignoredTargetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ignoredTargetID", cr2w, this);
				}
				return _ignoredTargetID;
			}
			set
			{
				if (_ignoredTargetID == value)
				{
					return;
				}
				_ignoredTargetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(88)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(89)] 
		[RED("weapon")] 
		public wCHandle<gameObject> Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "weapon", cr2w, this);
				}
				return _weapon;
			}
			set
			{
				if (_weapon == value)
				{
					return;
				}
				_weapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(90)] 
		[RED("startPosition")] 
		public Vector4 StartPosition
		{
			get
			{
				if (_startPosition == null)
				{
					_startPosition = (Vector4) CR2WTypeManager.Create("Vector4", "startPosition", cr2w, this);
				}
				return _startPosition;
			}
			set
			{
				if (_startPosition == value)
				{
					return;
				}
				_startPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(91)] 
		[RED("hasExploded")] 
		public CBool HasExploded
		{
			get
			{
				if (_hasExploded == null)
				{
					_hasExploded = (CBool) CR2WTypeManager.Create("Bool", "hasExploded", cr2w, this);
				}
				return _hasExploded;
			}
			set
			{
				if (_hasExploded == value)
				{
					return;
				}
				_hasExploded = value;
				PropertySet(this);
			}
		}

		[Ordinal(92)] 
		[RED("attack")] 
		public CHandle<gameIAttack> Attack
		{
			get
			{
				if (_attack == null)
				{
					_attack = (CHandle<gameIAttack>) CR2WTypeManager.Create("handle:gameIAttack", "attack", cr2w, this);
				}
				return _attack;
			}
			set
			{
				if (_attack == value)
				{
					return;
				}
				_attack = value;
				PropertySet(this);
			}
		}

		[Ordinal(93)] 
		[RED("BulletCollisionEvaluator")] 
		public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator
		{
			get
			{
				if (_bulletCollisionEvaluator == null)
				{
					_bulletCollisionEvaluator = (CHandle<BulletCollisionEvaluator>) CR2WTypeManager.Create("handle:BulletCollisionEvaluator", "BulletCollisionEvaluator", cr2w, this);
				}
				return _bulletCollisionEvaluator;
			}
			set
			{
				if (_bulletCollisionEvaluator == value)
				{
					return;
				}
				_bulletCollisionEvaluator = value;
				PropertySet(this);
			}
		}

		public sampleSmartBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
