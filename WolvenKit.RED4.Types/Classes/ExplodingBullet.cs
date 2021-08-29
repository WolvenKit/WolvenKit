using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExplodingBullet : BaseBullet
	{
		private CFloat _explosionTime;
		private gameEffectRef _effectReference;
		private CBool _hasExploded;
		private Vector4 _initialPosition;
		private CBool _trailStarted;
		private CWeakHandle<gameweaponObject> _weapon;
		private CHandle<gamedataAttack_Record> _attack_record;
		private TweakDBID _attackID;
		private Vector4 _colliderBox;
		private Quaternion _rotation;
		private CFloat _range;
		private CBool _explodeAfterRangeTravelled;
		private CHandle<gameIAttack> _attack;
		private CHandle<BulletCollisionEvaluator> _bulletCollisionEvaluator;

		[Ordinal(56)] 
		[RED("explosionTime")] 
		public CFloat ExplosionTime
		{
			get => GetProperty(ref _explosionTime);
			set => SetProperty(ref _explosionTime, value);
		}

		[Ordinal(57)] 
		[RED("effectReference")] 
		public gameEffectRef EffectReference
		{
			get => GetProperty(ref _effectReference);
			set => SetProperty(ref _effectReference, value);
		}

		[Ordinal(58)] 
		[RED("hasExploded")] 
		public CBool HasExploded
		{
			get => GetProperty(ref _hasExploded);
			set => SetProperty(ref _hasExploded, value);
		}

		[Ordinal(59)] 
		[RED("initialPosition")] 
		public Vector4 InitialPosition
		{
			get => GetProperty(ref _initialPosition);
			set => SetProperty(ref _initialPosition, value);
		}

		[Ordinal(60)] 
		[RED("trailStarted")] 
		public CBool TrailStarted
		{
			get => GetProperty(ref _trailStarted);
			set => SetProperty(ref _trailStarted, value);
		}

		[Ordinal(61)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(62)] 
		[RED("attack_record")] 
		public CHandle<gamedataAttack_Record> Attack_record
		{
			get => GetProperty(ref _attack_record);
			set => SetProperty(ref _attack_record, value);
		}

		[Ordinal(63)] 
		[RED("attackID")] 
		public TweakDBID AttackID
		{
			get => GetProperty(ref _attackID);
			set => SetProperty(ref _attackID, value);
		}

		[Ordinal(64)] 
		[RED("colliderBox")] 
		public Vector4 ColliderBox
		{
			get => GetProperty(ref _colliderBox);
			set => SetProperty(ref _colliderBox, value);
		}

		[Ordinal(65)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(66)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(67)] 
		[RED("explodeAfterRangeTravelled")] 
		public CBool ExplodeAfterRangeTravelled
		{
			get => GetProperty(ref _explodeAfterRangeTravelled);
			set => SetProperty(ref _explodeAfterRangeTravelled, value);
		}

		[Ordinal(68)] 
		[RED("attack")] 
		public CHandle<gameIAttack> Attack
		{
			get => GetProperty(ref _attack);
			set => SetProperty(ref _attack, value);
		}

		[Ordinal(69)] 
		[RED("BulletCollisionEvaluator")] 
		public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator
		{
			get => GetProperty(ref _bulletCollisionEvaluator);
			set => SetProperty(ref _bulletCollisionEvaluator, value);
		}
	}
}
