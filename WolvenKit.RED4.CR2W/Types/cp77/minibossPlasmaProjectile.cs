using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class minibossPlasmaProjectile : BaseProjectile
	{
		private CFloat _countTime;
		private CFloat _startVelocity;
		private CFloat _lifetime;
		private CName _effectName;
		private CName _hitEffectName;
		private CBool _followTarget;
		private CFloat _bendFactor;
		private CFloat _bendRatio;
		private CBool _shouldRotate;
		private TweakDBID _attackRecordID;
		private wCHandle<gameObject> _instigator;
		private CBool _spawnGameEffectOnCollision;
		private CHandle<gamedataAttack_Record> _collisionAttackRecord;
		private CBool _alive;
		private wCHandle<ScriptedPuppet> _owner;
		private wCHandle<gameObject> _target;

		[Ordinal(51)] 
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

		[Ordinal(52)] 
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

		[Ordinal(53)] 
		[RED("lifetime")] 
		public CFloat Lifetime_440
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

		[Ordinal(54)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("hitEffectName")] 
		public CName HitEffectName
		{
			get
			{
				if (_hitEffectName == null)
				{
					_hitEffectName = (CName) CR2WTypeManager.Create("CName", "hitEffectName", cr2w, this);
				}
				return _hitEffectName;
			}
			set
			{
				if (_hitEffectName == value)
				{
					return;
				}
				_hitEffectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("followTarget")] 
		public CBool FollowTarget
		{
			get
			{
				if (_followTarget == null)
				{
					_followTarget = (CBool) CR2WTypeManager.Create("Bool", "followTarget", cr2w, this);
				}
				return _followTarget;
			}
			set
			{
				if (_followTarget == value)
				{
					return;
				}
				_followTarget = value;
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
		[RED("bendRatio")] 
		public CFloat BendRatio
		{
			get
			{
				if (_bendRatio == null)
				{
					_bendRatio = (CFloat) CR2WTypeManager.Create("Float", "bendRatio", cr2w, this);
				}
				return _bendRatio;
			}
			set
			{
				if (_bendRatio == value)
				{
					return;
				}
				_bendRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("shouldRotate")] 
		public CBool ShouldRotate
		{
			get
			{
				if (_shouldRotate == null)
				{
					_shouldRotate = (CBool) CR2WTypeManager.Create("Bool", "shouldRotate", cr2w, this);
				}
				return _shouldRotate;
			}
			set
			{
				if (_shouldRotate == value)
				{
					return;
				}
				_shouldRotate = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("attackRecordID")] 
		public TweakDBID AttackRecordID
		{
			get
			{
				if (_attackRecordID == null)
				{
					_attackRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attackRecordID", cr2w, this);
				}
				return _attackRecordID;
			}
			set
			{
				if (_attackRecordID == value)
				{
					return;
				}
				_attackRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("spawnGameEffectOnCollision")] 
		public CBool SpawnGameEffectOnCollision
		{
			get
			{
				if (_spawnGameEffectOnCollision == null)
				{
					_spawnGameEffectOnCollision = (CBool) CR2WTypeManager.Create("Bool", "spawnGameEffectOnCollision", cr2w, this);
				}
				return _spawnGameEffectOnCollision;
			}
			set
			{
				if (_spawnGameEffectOnCollision == value)
				{
					return;
				}
				_spawnGameEffectOnCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("collisionAttackRecord")] 
		public CHandle<gamedataAttack_Record> CollisionAttackRecord
		{
			get
			{
				if (_collisionAttackRecord == null)
				{
					_collisionAttackRecord = (CHandle<gamedataAttack_Record>) CR2WTypeManager.Create("handle:gamedataAttack_Record", "collisionAttackRecord", cr2w, this);
				}
				return _collisionAttackRecord;
			}
			set
			{
				if (_collisionAttackRecord == value)
				{
					return;
				}
				_collisionAttackRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
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

		[Ordinal(65)] 
		[RED("owner")] 
		public wCHandle<ScriptedPuppet> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "owner", cr2w, this);
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

		[Ordinal(66)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		public minibossPlasmaProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
