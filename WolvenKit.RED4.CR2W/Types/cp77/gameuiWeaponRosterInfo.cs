using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWeaponRosterInfo : CVariable
	{
		private CInt32 _ammoCurrent;
		private CInt32 _ammoMagazine;
		private CInt32 _ammoAvailable;
		private CInt32 _fireModeCurrent;
		private CArray<CName> _fileModeList;
		private CArray<CEnum<gamedataDamageType>> _damageTypeList;
		private CInt32 _weaponId;

		[Ordinal(0)] 
		[RED("ammoCurrent")] 
		public CInt32 AmmoCurrent
		{
			get => GetProperty(ref _ammoCurrent);
			set => SetProperty(ref _ammoCurrent, value);
		}

		[Ordinal(1)] 
		[RED("ammoMagazine")] 
		public CInt32 AmmoMagazine
		{
			get => GetProperty(ref _ammoMagazine);
			set => SetProperty(ref _ammoMagazine, value);
		}

		[Ordinal(2)] 
		[RED("ammoAvailable")] 
		public CInt32 AmmoAvailable
		{
			get => GetProperty(ref _ammoAvailable);
			set => SetProperty(ref _ammoAvailable, value);
		}

		[Ordinal(3)] 
		[RED("fireModeCurrent")] 
		public CInt32 FireModeCurrent
		{
			get => GetProperty(ref _fireModeCurrent);
			set => SetProperty(ref _fireModeCurrent, value);
		}

		[Ordinal(4)] 
		[RED("fileModeList")] 
		public CArray<CName> FileModeList
		{
			get => GetProperty(ref _fileModeList);
			set => SetProperty(ref _fileModeList, value);
		}

		[Ordinal(5)] 
		[RED("damageTypeList")] 
		public CArray<CEnum<gamedataDamageType>> DamageTypeList
		{
			get => GetProperty(ref _damageTypeList);
			set => SetProperty(ref _damageTypeList, value);
		}

		[Ordinal(6)] 
		[RED("weaponId")] 
		public CInt32 WeaponId
		{
			get => GetProperty(ref _weaponId);
			set => SetProperty(ref _weaponId, value);
		}

		public gameuiWeaponRosterInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
