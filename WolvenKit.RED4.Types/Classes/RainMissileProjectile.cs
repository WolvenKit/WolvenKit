using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RainMissileProjectile : BaseProjectile
	{
		private CHandle<entIComponent> _meshComponent;
		private gameEffectRef _effect;
		private CHandle<gameEffectInstance> _damage;
		private CWeakHandle<gameObject> _owner;
		private CWeakHandle<gameweaponObject> _weapon;
		private CFloat _countTime;
		private CFloat _startVelocity;
		private CFloat _lifetime_528;
		private CBool _alive;
		private CBool _hit;
		private CBool _arrived;
		private Vector4 _spawnPosition;
		private CFloat _phase1Duration;
		private gameFxResource _landIndicatorFX;
		private CHandle<gameFxInstance> _fxInstance;
		private CBool _hasExploded;
		private TweakDBID _missileDBID;
		private CWeakHandle<gamedataAttack_Record> _missileAttackRecord;
		private CFloat _timeToDestory;
		private Vector4 _initialTargetPosition;
		private Vector4 _initialTargetOffset;
		private Vector4 _finalTargetPosition;
		private Vector4 _finalTargetOffset;
		private CFloat _finalTargetPositionCalculationDelay;
		private CWeakHandle<entIPlacedComponent> _targetComponent;
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
			get => GetProperty(ref _meshComponent);
			set => SetProperty(ref _meshComponent, value);
		}

		[Ordinal(52)] 
		[RED("effect")] 
		public gameEffectRef Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(53)] 
		[RED("damage")] 
		public CHandle<gameEffectInstance> Damage
		{
			get => GetProperty(ref _damage);
			set => SetProperty(ref _damage, value);
		}

		[Ordinal(54)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(55)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(56)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetProperty(ref _countTime);
			set => SetProperty(ref _countTime, value);
		}

		[Ordinal(57)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetProperty(ref _startVelocity);
			set => SetProperty(ref _startVelocity, value);
		}

		[Ordinal(58)] 
		[RED("lifetime")] 
		public CFloat Lifetime_528
		{
			get => GetProperty(ref _lifetime_528);
			set => SetProperty(ref _lifetime_528, value);
		}

		[Ordinal(59)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		[Ordinal(60)] 
		[RED("hit")] 
		public CBool Hit
		{
			get => GetProperty(ref _hit);
			set => SetProperty(ref _hit, value);
		}

		[Ordinal(61)] 
		[RED("arrived")] 
		public CBool Arrived
		{
			get => GetProperty(ref _arrived);
			set => SetProperty(ref _arrived, value);
		}

		[Ordinal(62)] 
		[RED("spawnPosition")] 
		public Vector4 SpawnPosition
		{
			get => GetProperty(ref _spawnPosition);
			set => SetProperty(ref _spawnPosition, value);
		}

		[Ordinal(63)] 
		[RED("phase1Duration")] 
		public CFloat Phase1Duration
		{
			get => GetProperty(ref _phase1Duration);
			set => SetProperty(ref _phase1Duration, value);
		}

		[Ordinal(64)] 
		[RED("landIndicatorFX")] 
		public gameFxResource LandIndicatorFX
		{
			get => GetProperty(ref _landIndicatorFX);
			set => SetProperty(ref _landIndicatorFX, value);
		}

		[Ordinal(65)] 
		[RED("fxInstance")] 
		public CHandle<gameFxInstance> FxInstance
		{
			get => GetProperty(ref _fxInstance);
			set => SetProperty(ref _fxInstance, value);
		}

		[Ordinal(66)] 
		[RED("hasExploded")] 
		public CBool HasExploded
		{
			get => GetProperty(ref _hasExploded);
			set => SetProperty(ref _hasExploded, value);
		}

		[Ordinal(67)] 
		[RED("missileDBID")] 
		public TweakDBID MissileDBID
		{
			get => GetProperty(ref _missileDBID);
			set => SetProperty(ref _missileDBID, value);
		}

		[Ordinal(68)] 
		[RED("missileAttackRecord")] 
		public CWeakHandle<gamedataAttack_Record> MissileAttackRecord
		{
			get => GetProperty(ref _missileAttackRecord);
			set => SetProperty(ref _missileAttackRecord, value);
		}

		[Ordinal(69)] 
		[RED("timeToDestory")] 
		public CFloat TimeToDestory
		{
			get => GetProperty(ref _timeToDestory);
			set => SetProperty(ref _timeToDestory, value);
		}

		[Ordinal(70)] 
		[RED("initialTargetPosition")] 
		public Vector4 InitialTargetPosition
		{
			get => GetProperty(ref _initialTargetPosition);
			set => SetProperty(ref _initialTargetPosition, value);
		}

		[Ordinal(71)] 
		[RED("initialTargetOffset")] 
		public Vector4 InitialTargetOffset
		{
			get => GetProperty(ref _initialTargetOffset);
			set => SetProperty(ref _initialTargetOffset, value);
		}

		[Ordinal(72)] 
		[RED("finalTargetPosition")] 
		public Vector4 FinalTargetPosition
		{
			get => GetProperty(ref _finalTargetPosition);
			set => SetProperty(ref _finalTargetPosition, value);
		}

		[Ordinal(73)] 
		[RED("finalTargetOffset")] 
		public Vector4 FinalTargetOffset
		{
			get => GetProperty(ref _finalTargetOffset);
			set => SetProperty(ref _finalTargetOffset, value);
		}

		[Ordinal(74)] 
		[RED("finalTargetPositionCalculationDelay")] 
		public CFloat FinalTargetPositionCalculationDelay
		{
			get => GetProperty(ref _finalTargetPositionCalculationDelay);
			set => SetProperty(ref _finalTargetPositionCalculationDelay, value);
		}

		[Ordinal(75)] 
		[RED("targetComponent")] 
		public CWeakHandle<entIPlacedComponent> TargetComponent
		{
			get => GetProperty(ref _targetComponent);
			set => SetProperty(ref _targetComponent, value);
		}

		[Ordinal(76)] 
		[RED("followTargetInPhase2")] 
		public CBool FollowTargetInPhase2
		{
			get => GetProperty(ref _followTargetInPhase2);
			set => SetProperty(ref _followTargetInPhase2, value);
		}

		[Ordinal(77)] 
		[RED("puppetBroadphaseHitRadiusSquared")] 
		public CFloat PuppetBroadphaseHitRadiusSquared
		{
			get => GetProperty(ref _puppetBroadphaseHitRadiusSquared);
			set => SetProperty(ref _puppetBroadphaseHitRadiusSquared, value);
		}

		[Ordinal(78)] 
		[RED("phase")] 
		public CEnum<EMissileRainPhase> Phase
		{
			get => GetProperty(ref _phase);
			set => SetProperty(ref _phase, value);
		}

		[Ordinal(79)] 
		[RED("spiralParams")] 
		public CHandle<gameprojectileSpiralParams> SpiralParams
		{
			get => GetProperty(ref _spiralParams);
			set => SetProperty(ref _spiralParams, value);
		}

		[Ordinal(80)] 
		[RED("useSpiralParams")] 
		public CBool UseSpiralParams
		{
			get => GetProperty(ref _useSpiralParams);
			set => SetProperty(ref _useSpiralParams, value);
		}

		[Ordinal(81)] 
		[RED("randStartVelocity")] 
		public CFloat RandStartVelocity
		{
			get => GetProperty(ref _randStartVelocity);
			set => SetProperty(ref _randStartVelocity, value);
		}
	}
}
