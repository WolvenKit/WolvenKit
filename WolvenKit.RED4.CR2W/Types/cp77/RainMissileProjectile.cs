using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RainMissileProjectile : BaseProjectile
	{
		private CHandle<entIComponent> _meshComponent;
		private gameEffectRef _effect;
		private CHandle<gameEffectInstance> _damage;
		private wCHandle<gameObject> _owner;
		private wCHandle<gameweaponObject> _weapon;
		private CFloat _countTime;
		private CFloat _startVelocity;
		private CFloat _lifetime;
		private CBool _alive;
		private CBool _hit;
		private CBool _arrived;
		private Vector4 _spawnPosition;
		private CFloat _phase1Duration;
		private gameFxResource _landIndicatorFX;
		private CHandle<gameFxInstance> _fxInstance;
		private CBool _hasExploded;
		private TweakDBID _missileDBID;
		private CFloat _timeToDestory;
		private Vector4 _initialTargetPosition;
		private Vector4 _initialTargetOffset;
		private Vector4 _finalTargetPosition;
		private Vector4 _finalTargetOffset;
		private CFloat _finalTargetPositionCalculationDelay;
		private wCHandle<entIPlacedComponent> _targetComponent;
		private CBool _followTargetInPhase2;
		private CFloat _puppetBroadphaseHitRadiusSquared;
		private CEnum<EMissileRainPhase> _phase;
		private CHandle<gameprojectileSpiralParams> _spiralParams;
		private CBool _useSpiralParams;
		private CFloat _randStartVelocity;

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
		[RED("damage")] 
		public CHandle<gameEffectInstance> Damage
		{
			get
			{
				if (_damage == null)
				{
					_damage = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "damage", cr2w, this);
				}
				return _damage;
			}
			set
			{
				if (_damage == value)
				{
					return;
				}
				_damage = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
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

		[Ordinal(55)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (wCHandle<gameweaponObject>) CR2WTypeManager.Create("whandle:gameweaponObject", "weapon", cr2w, this);
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

		[Ordinal(56)] 
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

		[Ordinal(57)] 
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

		[Ordinal(58)] 
		[RED("lifetime")] 
		public CFloat Lifetime_544
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

		[Ordinal(59)] 
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

		[Ordinal(60)] 
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

		[Ordinal(61)] 
		[RED("arrived")] 
		public CBool Arrived
		{
			get
			{
				if (_arrived == null)
				{
					_arrived = (CBool) CR2WTypeManager.Create("Bool", "arrived", cr2w, this);
				}
				return _arrived;
			}
			set
			{
				if (_arrived == value)
				{
					return;
				}
				_arrived = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("spawnPosition")] 
		public Vector4 SpawnPosition
		{
			get
			{
				if (_spawnPosition == null)
				{
					_spawnPosition = (Vector4) CR2WTypeManager.Create("Vector4", "spawnPosition", cr2w, this);
				}
				return _spawnPosition;
			}
			set
			{
				if (_spawnPosition == value)
				{
					return;
				}
				_spawnPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("phase1Duration")] 
		public CFloat Phase1Duration
		{
			get
			{
				if (_phase1Duration == null)
				{
					_phase1Duration = (CFloat) CR2WTypeManager.Create("Float", "phase1Duration", cr2w, this);
				}
				return _phase1Duration;
			}
			set
			{
				if (_phase1Duration == value)
				{
					return;
				}
				_phase1Duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("landIndicatorFX")] 
		public gameFxResource LandIndicatorFX
		{
			get
			{
				if (_landIndicatorFX == null)
				{
					_landIndicatorFX = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "landIndicatorFX", cr2w, this);
				}
				return _landIndicatorFX;
			}
			set
			{
				if (_landIndicatorFX == value)
				{
					return;
				}
				_landIndicatorFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("fxInstance")] 
		public CHandle<gameFxInstance> FxInstance
		{
			get
			{
				if (_fxInstance == null)
				{
					_fxInstance = (CHandle<gameFxInstance>) CR2WTypeManager.Create("handle:gameFxInstance", "fxInstance", cr2w, this);
				}
				return _fxInstance;
			}
			set
			{
				if (_fxInstance == value)
				{
					return;
				}
				_fxInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
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

		[Ordinal(67)] 
		[RED("missileDBID")] 
		public TweakDBID MissileDBID
		{
			get
			{
				if (_missileDBID == null)
				{
					_missileDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "missileDBID", cr2w, this);
				}
				return _missileDBID;
			}
			set
			{
				if (_missileDBID == value)
				{
					return;
				}
				_missileDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("timeToDestory")] 
		public CFloat TimeToDestory
		{
			get
			{
				if (_timeToDestory == null)
				{
					_timeToDestory = (CFloat) CR2WTypeManager.Create("Float", "timeToDestory", cr2w, this);
				}
				return _timeToDestory;
			}
			set
			{
				if (_timeToDestory == value)
				{
					return;
				}
				_timeToDestory = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("initialTargetPosition")] 
		public Vector4 InitialTargetPosition
		{
			get
			{
				if (_initialTargetPosition == null)
				{
					_initialTargetPosition = (Vector4) CR2WTypeManager.Create("Vector4", "initialTargetPosition", cr2w, this);
				}
				return _initialTargetPosition;
			}
			set
			{
				if (_initialTargetPosition == value)
				{
					return;
				}
				_initialTargetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("initialTargetOffset")] 
		public Vector4 InitialTargetOffset
		{
			get
			{
				if (_initialTargetOffset == null)
				{
					_initialTargetOffset = (Vector4) CR2WTypeManager.Create("Vector4", "initialTargetOffset", cr2w, this);
				}
				return _initialTargetOffset;
			}
			set
			{
				if (_initialTargetOffset == value)
				{
					return;
				}
				_initialTargetOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("finalTargetPosition")] 
		public Vector4 FinalTargetPosition
		{
			get
			{
				if (_finalTargetPosition == null)
				{
					_finalTargetPosition = (Vector4) CR2WTypeManager.Create("Vector4", "finalTargetPosition", cr2w, this);
				}
				return _finalTargetPosition;
			}
			set
			{
				if (_finalTargetPosition == value)
				{
					return;
				}
				_finalTargetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("finalTargetOffset")] 
		public Vector4 FinalTargetOffset
		{
			get
			{
				if (_finalTargetOffset == null)
				{
					_finalTargetOffset = (Vector4) CR2WTypeManager.Create("Vector4", "finalTargetOffset", cr2w, this);
				}
				return _finalTargetOffset;
			}
			set
			{
				if (_finalTargetOffset == value)
				{
					return;
				}
				_finalTargetOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("finalTargetPositionCalculationDelay")] 
		public CFloat FinalTargetPositionCalculationDelay
		{
			get
			{
				if (_finalTargetPositionCalculationDelay == null)
				{
					_finalTargetPositionCalculationDelay = (CFloat) CR2WTypeManager.Create("Float", "finalTargetPositionCalculationDelay", cr2w, this);
				}
				return _finalTargetPositionCalculationDelay;
			}
			set
			{
				if (_finalTargetPositionCalculationDelay == value)
				{
					return;
				}
				_finalTargetPositionCalculationDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("targetComponent")] 
		public wCHandle<entIPlacedComponent> TargetComponent
		{
			get
			{
				if (_targetComponent == null)
				{
					_targetComponent = (wCHandle<entIPlacedComponent>) CR2WTypeManager.Create("whandle:entIPlacedComponent", "targetComponent", cr2w, this);
				}
				return _targetComponent;
			}
			set
			{
				if (_targetComponent == value)
				{
					return;
				}
				_targetComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("followTargetInPhase2")] 
		public CBool FollowTargetInPhase2
		{
			get
			{
				if (_followTargetInPhase2 == null)
				{
					_followTargetInPhase2 = (CBool) CR2WTypeManager.Create("Bool", "followTargetInPhase2", cr2w, this);
				}
				return _followTargetInPhase2;
			}
			set
			{
				if (_followTargetInPhase2 == value)
				{
					return;
				}
				_followTargetInPhase2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("puppetBroadphaseHitRadiusSquared")] 
		public CFloat PuppetBroadphaseHitRadiusSquared
		{
			get
			{
				if (_puppetBroadphaseHitRadiusSquared == null)
				{
					_puppetBroadphaseHitRadiusSquared = (CFloat) CR2WTypeManager.Create("Float", "puppetBroadphaseHitRadiusSquared", cr2w, this);
				}
				return _puppetBroadphaseHitRadiusSquared;
			}
			set
			{
				if (_puppetBroadphaseHitRadiusSquared == value)
				{
					return;
				}
				_puppetBroadphaseHitRadiusSquared = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("phase")] 
		public CEnum<EMissileRainPhase> Phase
		{
			get
			{
				if (_phase == null)
				{
					_phase = (CEnum<EMissileRainPhase>) CR2WTypeManager.Create("EMissileRainPhase", "phase", cr2w, this);
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

		[Ordinal(78)] 
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

		[Ordinal(79)] 
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

		[Ordinal(80)] 
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

		public RainMissileProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
