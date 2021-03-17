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
			get => GetProperty(ref _securityLevelAccessGranted);
			set => SetProperty(ref _securityLevelAccessGranted, value);
		}

		[Ordinal(1)] 
		[RED("disableCyberware")] 
		public CBool DisableCyberware
		{
			get => GetProperty(ref _disableCyberware);
			set => SetProperty(ref _disableCyberware, value);
		}

		[Ordinal(2)] 
		[RED("storeWeaponSFX")] 
		public CName StoreWeaponSFX
		{
			get => GetProperty(ref _storeWeaponSFX);
			set => SetProperty(ref _storeWeaponSFX, value);
		}

		[Ordinal(3)] 
		[RED("pickUpWeaponSFX")] 
		public CName PickUpWeaponSFX
		{
			get => GetProperty(ref _pickUpWeaponSFX);
			set => SetProperty(ref _pickUpWeaponSFX, value);
		}

		public SecurityLockerProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
