using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterEquippedWeapon_ConditionType : questICharacterConditionType
	{
		private CBool _anyWeaponEquipped;
		private CString _weaponID;
		private CName _weaponTag;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("anyWeaponEquipped")] 
		public CBool AnyWeaponEquipped
		{
			get
			{
				if (_anyWeaponEquipped == null)
				{
					_anyWeaponEquipped = (CBool) CR2WTypeManager.Create("Bool", "anyWeaponEquipped", cr2w, this);
				}
				return _anyWeaponEquipped;
			}
			set
			{
				if (_anyWeaponEquipped == value)
				{
					return;
				}
				_anyWeaponEquipped = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weaponID")] 
		public CString WeaponID
		{
			get
			{
				if (_weaponID == null)
				{
					_weaponID = (CString) CR2WTypeManager.Create("String", "weaponID", cr2w, this);
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

		[Ordinal(2)] 
		[RED("weaponTag")] 
		public CName WeaponTag
		{
			get
			{
				if (_weaponTag == null)
				{
					_weaponTag = (CName) CR2WTypeManager.Create("CName", "weaponTag", cr2w, this);
				}
				return _weaponTag;
			}
			set
			{
				if (_weaponTag == value)
				{
					return;
				}
				_weaponTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		public questCharacterEquippedWeapon_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
