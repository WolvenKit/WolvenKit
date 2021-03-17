using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageInfo : CVariable
	{
		private Vector4 _hitPosition;
		private CFloat _damageValue;
		private CEnum<gamedataDamageType> _damageType;
		private CEnum<gameuiHitType> _hitType;
		private wCHandle<gameObject> _entityHit;
		private wCHandle<gameObject> _instigator;
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
		public wCHandle<gameObject> EntityHit
		{
			get => GetProperty(ref _entityHit);
			set => SetProperty(ref _entityHit, value);
		}

		[Ordinal(5)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
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

		public gameuiDamageInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
