using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiDamageInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("damageValue")] 
		public CFloat DamageValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get => GetPropertyValue<CEnum<gamedataDamageType>>();
			set => SetPropertyValue<CEnum<gamedataDamageType>>(value);
		}

		[Ordinal(3)] 
		[RED("hitType")] 
		public CEnum<gameuiHitType> HitType
		{
			get => GetPropertyValue<CEnum<gameuiHitType>>();
			set => SetPropertyValue<CEnum<gameuiHitType>>(value);
		}

		[Ordinal(4)] 
		[RED("entityHit")] 
		public CWeakHandle<gameObject> EntityHit
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(6)] 
		[RED("userData")] 
		public CHandle<gameuiDamageInfoUserData> UserData
		{
			get => GetPropertyValue<CHandle<gameuiDamageInfoUserData>>();
			set => SetPropertyValue<CHandle<gameuiDamageInfoUserData>>(value);
		}

		public gameuiDamageInfo()
		{
			HitPosition = new();
			DamageType = Enums.gamedataDamageType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
