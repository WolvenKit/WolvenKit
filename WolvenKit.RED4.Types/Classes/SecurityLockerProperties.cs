using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityLockerProperties : RedBaseClass
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

		public SecurityLockerProperties()
		{
			_securityLevelAccessGranted = new() { Value = Enums.ESecurityAccessLevel.ESL_4 };
			_storeWeaponSFX = "ui_loot_gun";
			_pickUpWeaponSFX = "ui_loot_take_all";
		}
	}
}
