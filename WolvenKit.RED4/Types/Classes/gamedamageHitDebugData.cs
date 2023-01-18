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
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("instigatorName")] 
		public CName InstigatorName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("targetName")] 
		public CName TargetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("sourceAttackDebugData")] 
		public gameAttackDebugData SourceAttackDebugData
		{
			get => GetPropertyValue<gameAttackDebugData>();
			set => SetPropertyValue<gameAttackDebugData>(value);
		}

		[Ordinal(9)] 
		[RED("sourceWeaponName")] 
		public CName SourceWeaponName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("sourceAttackName")] 
		public CName SourceAttackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("calculatedDamages")] 
		public CArray<CHandle<gamedamageDamageDebugData>> CalculatedDamages
		{
			get => GetPropertyValue<CArray<CHandle<gamedamageDamageDebugData>>>();
			set => SetPropertyValue<CArray<CHandle<gamedamageDamageDebugData>>>(value);
		}

		[Ordinal(12)] 
		[RED("appliedDamages")] 
		public CArray<CHandle<gamedamageDamageDebugData>> AppliedDamages
		{
			get => GetPropertyValue<CArray<CHandle<gamedamageDamageDebugData>>>();
			set => SetPropertyValue<CArray<CHandle<gamedamageDamageDebugData>>>(value);
		}

		[Ordinal(13)] 
		[RED("hitType")] 
		public CName HitType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("hitFlags")] 
		public CName HitFlags
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gamedamageHitDebugData()
		{
			SourceHitPosition = new();
			TargetHitPosition = new();
			SourceAttackDebugData = new() { PointOfViewTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } }, ProjectileHitplaneSpread = new(), BulletStartPosition = new() };
			CalculatedDamages = new();
			AppliedDamages = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
