using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSlotWeaponData : CVariable
	{
		private gameItemID _weaponID;
		private CInt32 _ammoCurrent;
		private CInt32 _magazineCap;
		private gameItemID _ammoId;
		private CEnum<gamedataTriggerMode> _triggerModeCurrent;
		private CArray<CEnum<gamedataTriggerMode>> _triggerModeList;
		private CEnum<gamedataWeaponEvolution> _evolution;
		private CBool _isActive;
		private CBool _isFirstEquip;

		[Ordinal(0)] 
		[RED("weaponID")] 
		public gameItemID WeaponID
		{
			get
			{
				if (_weaponID == null)
				{
					_weaponID = (gameItemID) CR2WTypeManager.Create("gameItemID", "weaponID", cr2w, this);
				}
				return _weaponID;
			}
			set
			{
				if (_weaponID == value)
				{
					return;
				}
				_weaponID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("magazineCap")] 
		public CInt32 MagazineCap
		{
			get
			{
				if (_magazineCap == null)
				{
					_magazineCap = (CInt32) CR2WTypeManager.Create("Int32", "magazineCap", cr2w, this);
				}
				return _magazineCap;
			}
			set
			{
				if (_magazineCap == value)
				{
					return;
				}
				_magazineCap = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ammoId")] 
		public gameItemID AmmoId
		{
			get
			{
				if (_ammoId == null)
				{
					_ammoId = (gameItemID) CR2WTypeManager.Create("gameItemID", "ammoId", cr2w, this);
				}
				return _ammoId;
			}
			set
			{
				if (_ammoId == value)
				{
					return;
				}
				_ammoId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("triggerModeCurrent")] 
		public CEnum<gamedataTriggerMode> TriggerModeCurrent
		{
			get
			{
				if (_triggerModeCurrent == null)
				{
					_triggerModeCurrent = (CEnum<gamedataTriggerMode>) CR2WTypeManager.Create("gamedataTriggerMode", "triggerModeCurrent", cr2w, this);
				}
				return _triggerModeCurrent;
			}
			set
			{
				if (_triggerModeCurrent == value)
				{
					return;
				}
				_triggerModeCurrent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("triggerModeList")] 
		public CArray<CEnum<gamedataTriggerMode>> TriggerModeList
		{
			get
			{
				if (_triggerModeList == null)
				{
					_triggerModeList = (CArray<CEnum<gamedataTriggerMode>>) CR2WTypeManager.Create("array:gamedataTriggerMode", "triggerModeList", cr2w, this);
				}
				return _triggerModeList;
			}
			set
			{
				if (_triggerModeList == value)
				{
					return;
				}
				_triggerModeList = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("evolution")] 
		public CEnum<gamedataWeaponEvolution> Evolution
		{
			get
			{
				if (_evolution == null)
				{
					_evolution = (CEnum<gamedataWeaponEvolution>) CR2WTypeManager.Create("gamedataWeaponEvolution", "evolution", cr2w, this);
				}
				return _evolution;
			}
			set
			{
				if (_evolution == value)
				{
					return;
				}
				_evolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isFirstEquip")] 
		public CBool IsFirstEquip
		{
			get
			{
				if (_isFirstEquip == null)
				{
					_isFirstEquip = (CBool) CR2WTypeManager.Create("Bool", "isFirstEquip", cr2w, this);
				}
				return _isFirstEquip;
			}
			set
			{
				if (_isFirstEquip == value)
				{
					return;
				}
				_isFirstEquip = value;
				PropertySet(this);
			}
		}

		public gameSlotWeaponData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
