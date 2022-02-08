using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class minibossPlasmaProjectile : BaseProjectile
	{
		[Ordinal(51)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("lifetime")] 
		public CFloat Lifetime_424
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(55)] 
		[RED("hitEffectName")] 
		public CName HitEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(56)] 
		[RED("followTarget")] 
		public CBool FollowTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("bendFactor")] 
		public CFloat BendFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("bendRatio")] 
		public CFloat BendRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("shouldRotate")] 
		public CBool ShouldRotate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("attackRecordID")] 
		public TweakDBID AttackRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(61)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(62)] 
		[RED("spawnGameEffectOnCollision")] 
		public CBool SpawnGameEffectOnCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("collisionAttackRecord")] 
		public CHandle<gamedataAttack_Record> CollisionAttackRecord
		{
			get => GetPropertyValue<CHandle<gamedataAttack_Record>>();
			set => SetPropertyValue<CHandle<gamedataAttack_Record>>(value);
		}

		[Ordinal(64)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("owner")] 
		public CWeakHandle<ScriptedPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(66)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public minibossPlasmaProjectile()
		{
			Alive = true;
		}
	}
}
