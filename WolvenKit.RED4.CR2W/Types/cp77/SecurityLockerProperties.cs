using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityLockerProperties : CVariable
	{
		private CEnum<ESecurityAccessLevel> _securityLevelAccessGranted;
		private CBool _disableCyberware;
		private CName _storeWeaponSFX;
		private CName _pickUpWeaponSFX;

		[Ordinal(0)] 
		[RED("securityLevelAccessGranted")] 
		public CEnum<ESecurityAccessLevel> SecurityLevelAccessGranted
		{
			get
			{
				if (_securityLevelAccessGranted == null)
				{
					_securityLevelAccessGranted = (CEnum<ESecurityAccessLevel>) CR2WTypeManager.Create("ESecurityAccessLevel", "securityLevelAccessGranted", cr2w, this);
				}
				return _securityLevelAccessGranted;
			}
			set
			{
				if (_securityLevelAccessGranted == value)
				{
					return;
				}
				_securityLevelAccessGranted = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("disableCyberware")] 
		public CBool DisableCyberware
		{
			get
			{
				if (_disableCyberware == null)
				{
					_disableCyberware = (CBool) CR2WTypeManager.Create("Bool", "disableCyberware", cr2w, this);
				}
				return _disableCyberware;
			}
			set
			{
				if (_disableCyberware == value)
				{
					return;
				}
				_disableCyberware = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("storeWeaponSFX")] 
		public CName StoreWeaponSFX
		{
			get
			{
				if (_storeWeaponSFX == null)
				{
					_storeWeaponSFX = (CName) CR2WTypeManager.Create("CName", "storeWeaponSFX", cr2w, this);
				}
				return _storeWeaponSFX;
			}
			set
			{
				if (_storeWeaponSFX == value)
				{
					return;
				}
				_storeWeaponSFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pickUpWeaponSFX")] 
		public CName PickUpWeaponSFX
		{
			get
			{
				if (_pickUpWeaponSFX == null)
				{
					_pickUpWeaponSFX = (CName) CR2WTypeManager.Create("CName", "pickUpWeaponSFX", cr2w, this);
				}
				return _pickUpWeaponSFX;
			}
			set
			{
				if (_pickUpWeaponSFX == value)
				{
					return;
				}
				_pickUpWeaponSFX = value;
				PropertySet(this);
			}
		}

		public SecurityLockerProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
