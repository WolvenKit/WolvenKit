using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplodingBullet : BaseBullet
	{
		private CFloat _explosionTime;
		private gameEffectRef _effectReference;
		private CBool _hasExploded;
		private Vector4 _initialPosition;
		private CBool _trailStarted;
		private wCHandle<gameweaponObject> _weapon;
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
			get
			{
				if (_explosionTime == null)
				{
					_explosionTime = (CFloat) CR2WTypeManager.Create("Float", "explosionTime", cr2w, this);
				}
				return _explosionTime;
			}
			set
			{
				if (_explosionTime == value)
				{
					return;
				}
				_explosionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("effectReference")] 
		public gameEffectRef EffectReference
		{
			get
			{
				if (_effectReference == null)
				{
					_effectReference = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "effectReference", cr2w, this);
				}
				return _effectReference;
			}
			set
			{
				if (_effectReference == value)
				{
					return;
				}
				_effectReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
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

		[Ordinal(59)] 
		[RED("initialPosition")] 
		public Vector4 InitialPosition
		{
			get
			{
				if (_initialPosition == null)
				{
					_initialPosition = (Vector4) CR2WTypeManager.Create("Vector4", "initialPosition", cr2w, this);
				}
				return _initialPosition;
			}
			set
			{
				if (_initialPosition == value)
				{
					return;
				}
				_initialPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
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

		[Ordinal(61)] 
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

		[Ordinal(62)] 
		[RED("attack_record")] 
		public CHandle<gamedataAttack_Record> Attack_record
		{
			get
			{
				if (_attack_record == null)
				{
					_attack_record = (CHandle<gamedataAttack_Record>) CR2WTypeManager.Create("handle:gamedataAttack_Record", "attack_record", cr2w, this);
				}
				return _attack_record;
			}
			set
			{
				if (_attack_record == value)
				{
					return;
				}
				_attack_record = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("attackID")] 
		public TweakDBID AttackID
		{
			get
			{
				if (_attackID == null)
				{
					_attackID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attackID", cr2w, this);
				}
				return _attackID;
			}
			set
			{
				if (_attackID == value)
				{
					return;
				}
				_attackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("colliderBox")] 
		public Vector4 ColliderBox
		{
			get
			{
				if (_colliderBox == null)
				{
					_colliderBox = (Vector4) CR2WTypeManager.Create("Vector4", "colliderBox", cr2w, this);
				}
				return _colliderBox;
			}
			set
			{
				if (_colliderBox == value)
				{
					return;
				}
				_colliderBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("explodeAfterRangeTravelled")] 
		public CBool ExplodeAfterRangeTravelled
		{
			get
			{
				if (_explodeAfterRangeTravelled == null)
				{
					_explodeAfterRangeTravelled = (CBool) CR2WTypeManager.Create("Bool", "explodeAfterRangeTravelled", cr2w, this);
				}
				return _explodeAfterRangeTravelled;
			}
			set
			{
				if (_explodeAfterRangeTravelled == value)
				{
					return;
				}
				_explodeAfterRangeTravelled = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
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

		[Ordinal(69)] 
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

		public ExplodingBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
