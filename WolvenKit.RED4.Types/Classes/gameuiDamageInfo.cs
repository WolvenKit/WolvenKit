using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiDamageInfo : RedBaseClass
	{
		private Vector4 _hitPosition;
		private CFloat _damageValue;
		private CEnum<gamedataDamageType> _damageType;
		private CEnum<gameuiHitType> _hitType;
		private CWeakHandle<gameObject> _entityHit;
		private CWeakHandle<gameObject> _instigator;
		private CHandle<gameuiDamageInfoUserData> _userData;

		[Ordinal(0)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetProperty(ref _hitPosition);
			set => SetProperty(ref _hitPosition, value);
		}

		[Ordinal(1)] 
		[RED("damageValue")] 
		public CFloat DamageValue
		{
			get => GetProperty(ref _damageValue);
			set => SetProperty(ref _damageValue, value);
		}

		[Ordinal(2)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get => GetProperty(ref _damageType);
			set => SetProperty(ref _damageType, value);
		}

		[Ordinal(3)] 
		[RED("hitType")] 
		public CEnum<gameuiHitType> HitType
		{
			get => GetProperty(ref _hitType);
			set => SetProperty(ref _hitType, value);
		}

		[Ordinal(4)] 
		[RED("entityHit")] 
		public CWeakHandle<gameObject> EntityHit
		{
			get => GetProperty(ref _entityHit);
			set => SetProperty(ref _entityHit, value);
		}

		[Ordinal(5)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(6)] 
		[RED("userData")] 
		public CHandle<gameuiDamageInfoUserData> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		public gameuiDamageInfo()
		{
			_damageType = new() { Value = Enums.gamedataDamageType.Invalid };
		}
	}
}
