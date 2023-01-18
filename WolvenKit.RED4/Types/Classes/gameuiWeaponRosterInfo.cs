using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiWeaponRosterInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ammoCurrent")] 
		public CInt32 AmmoCurrent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("ammoMagazine")] 
		public CInt32 AmmoMagazine
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("ammoAvailable")] 
		public CInt32 AmmoAvailable
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("fireModeCurrent")] 
		public CInt32 FireModeCurrent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("fileModeList")] 
		public CArray<CName> FileModeList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("damageTypeList")] 
		public CArray<CEnum<gamedataDamageType>> DamageTypeList
		{
			get => GetPropertyValue<CArray<CEnum<gamedataDamageType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataDamageType>>>(value);
		}

		[Ordinal(6)] 
		[RED("weaponId")] 
		public CInt32 WeaponId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiWeaponRosterInfo()
		{
			FileModeList = new();
			DamageTypeList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
