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
		private CFloat _lifetime_424;
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
			get => GetProperty(ref _countTime);
			set => SetProperty(ref _countTime, value);
		}

		[Ordinal(52)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetProperty(ref _startVelocity);
			set => SetProperty(ref _startVelocity, value);
		}

		[Ordinal(53)] 
		[RED("lifetime")] 
		public CFloat Lifetime_424
		{
			get => GetProperty(ref _lifetime_424);
			set => SetProperty(ref _lifetime_424, value);
		}

		[Ordinal(54)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(55)] 
		[RED("hitEffectName")] 
		public CName HitEffectName
		{
			get => GetProperty(ref _hitEffectName);
			set => SetProperty(ref _hitEffectName, value);
		}

		[Ordinal(56)] 
		[RED("followTarget")] 
		public CBool FollowTarget
		{
			get => GetProperty(ref _followTarget);
			set => SetProperty(ref _followTarget, value);
		}

		[Ordinal(57)] 
		[RED("bendFactor")] 
		public CFloat BendFactor
		{
			get => GetProperty(ref _bendFactor);
			set => SetProperty(ref _bendFactor, value);
		}

		[Ordinal(58)] 
		[RED("bendRatio")] 
		public CFloat BendRatio
		{
			get => GetProperty(ref _bendRatio);
			set => SetProperty(ref _bendRatio, value);
		}

		[Ordinal(59)] 
		[RED("shouldRotate")] 
		public CBool ShouldRotate
		{
			get => GetProperty(ref _shouldRotate);
			set => SetProperty(ref _shouldRotate, value);
		}

		[Ordinal(60)] 
		[RED("attackRecordID")] 
		public TweakDBID AttackRecordID
		{
			get => GetProperty(ref _attackRecordID);
			set => SetProperty(ref _attackRecordID, value);
		}

		[Ordinal(61)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(62)] 
		[RED("spawnGameEffectOnCollision")] 
		public CBool SpawnGameEffectOnCollision
		{
			get => GetProperty(ref _spawnGameEffectOnCollision);
			set => SetProperty(ref _spawnGameEffectOnCollision, value);
		}

		[Ordinal(63)] 
		[RED("collisionAttackRecord")] 
		public CHandle<gamedataAttack_Record> CollisionAttackRecord
		{
			get => GetProperty(ref _collisionAttackRecord);
			set => SetProperty(ref _collisionAttackRecord, value);
		}

		[Ordinal(64)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		[Ordinal(65)] 
		[RED("owner")] 
		public wCHandle<ScriptedPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(66)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		public minibossPlasmaProjectile(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
