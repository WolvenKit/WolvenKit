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
			get
			{
				if (_ammoCurrent == null)
				{
					_ammoCurrent = (CInt32) CR2WTypeManager.Create("Int32", "ammoCurrent", cr2w, this);
				}
				return _ammoCurrent;
			}
			set
			{
				if (_ammoCurrent == value)
				{
					return;
				}
				_ammoCurrent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ammoMagazine")] 
		public CInt32 AmmoMagazine
		{
			get
			{
				if (_ammoMagazine == null)
				{
					_ammoMagazine = (CInt32) CR2WTypeManager.Create("Int32", "ammoMagazine", cr2w, this);
				}
				return _ammoMagazine;
			}
			set
			{
				if (_ammoMagazine == value)
				{
					return;
				}
				_ammoMagazine = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ammoAvailable")] 
		public CInt32 AmmoAvailable
		{
			get
			{
				if (_ammoAvailable == null)
				{
					_ammoAvailable = (CInt32) CR2WTypeManager.Create("Int32", "ammoAvailable", cr2w, this);
				}
				return _ammoAvailable;
			}
			set
			{
				if (_ammoAvailable == value)
				{
					return;
				}
				_ammoAvailable = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fireModeCurrent")] 
		public CInt32 FireModeCurrent
		{
			get
			{
				if (_fireModeCurrent == null)
				{
					_fireModeCurrent = (CInt32) CR2WTypeManager.Create("Int32", "fireModeCurrent", cr2w, this);
				}
				return _fireModeCurrent;
			}
			set
			{
				if (_fireModeCurrent == value)
				{
					return;
				}
				_fireModeCurrent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fileModeList")] 
		public CArray<CName> FileModeList
		{
			get
			{
				if (_fileModeList == null)
				{
					_fileModeList = (CArray<CName>) CR2WTypeManager.Create("array:CName", "fileModeList", cr2w, this);
				}
				return _fileModeList;
			}
			set
			{
				if (_fileModeList == value)
				{
					return;
				}
				_fileModeList = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("damageTypeList")] 
		public CArray<CEnum<gamedataDamageType>> DamageTypeList
		{
			get
			{
				if (_damageTypeList == null)
				{
					_damageTypeList = (CArray<CEnum<gamedataDamageType>>) CR2WTypeManager.Create("array:gamedataDamageType", "damageTypeList", cr2w, this);
				}
				return _damageTypeList;
			}
			set
			{
				if (_damageTypeList == value)
				{
					return;
				}
				_damageTypeList = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("weaponId")] 
		public CInt32 WeaponId
		{
			get
			{
				if (_weaponId == null)
				{
					_weaponId = (CInt32) CR2WTypeManager.Create("Int32", "weaponId", cr2w, this);
				}
				return _weaponId;
			}
			set
			{
				if (_weaponId == value)
				{
					return;
				}
				_weaponId = value;
				PropertySet(this);
			}
		}

		public gameuiWeaponRosterInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
