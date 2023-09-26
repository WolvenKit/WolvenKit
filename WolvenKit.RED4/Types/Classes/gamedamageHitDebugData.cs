using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedamageHitDebugData : IScriptable
	{
		[Ordinal(0)] 
		[RED("sourceHitPosition")] 
		public Vector4 SourceHitPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("targetHitPosition")] 
		public Vector4 TargetHitPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("attackTime")] 
		public CFloat AttackTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(6)] 
		[RED("instigatorName")] 
		public CName InstigatorName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("targetName")] 
		public CName TargetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("sourceAttackDebugData")] 
		public gameAttackDebugData SourceAttackDebugData
		{
			get => GetPropertyValue<gameAttackDebugData>();
			set => SetPropertyValue<gameAttackDebugData>(value);
		}

		[Ordinal(10)] 
		[RED("sourceWeaponName")] 
		public CName SourceWeaponName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("sourceAttackName")] 
		public CName SourceAttackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("calculatedDamages")] 
		public CArray<CHandle<gamedamageDamageDebugData>> CalculatedDamages
		{
			get => GetPropertyValue<CArray<CHandle<gamedamageDamageDebugData>>>();
			set => SetPropertyValue<CArray<CHandle<gamedamageDamageDebugData>>>(value);
		}

		[Ordinal(13)] 
		[RED("appliedDamages")] 
		public CArray<CHandle<gamedamageDamageDebugData>> AppliedDamages
		{
			get => GetPropertyValue<CArray<CHandle<gamedamageDamageDebugData>>>();
			set => SetPropertyValue<CArray<CHandle<gamedamageDamageDebugData>>>(value);
		}

		[Ordinal(14)] 
		[RED("hitType")] 
		public CName HitType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("hitFlags")] 
		public CName HitFlags
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gamedamageHitDebugData()
		{
			SourceHitPosition = new Vector4();
			TargetHitPosition = new Vector4();
			SourceAttackDebugData = new gameAttackDebugData { PointOfViewTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } }, ProjectileHitplaneSpread = new Vector4(), BulletStartPosition = new Vector4() };
			CalculatedDamages = new();
			AppliedDamages = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
