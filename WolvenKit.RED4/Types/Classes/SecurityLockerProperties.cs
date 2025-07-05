using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityLockerProperties : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("securityLevelAccessGranted")] 
		public CEnum<ESecurityAccessLevel> SecurityLevelAccessGranted
		{
			get => GetPropertyValue<CEnum<ESecurityAccessLevel>>();
			set => SetPropertyValue<CEnum<ESecurityAccessLevel>>(value);
		}

		[Ordinal(1)] 
		[RED("disableCyberware")] 
		public CBool DisableCyberware
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("storeWeaponSFX")] 
		public CName StoreWeaponSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("pickUpWeaponSFX")] 
		public CName PickUpWeaponSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SecurityLockerProperties()
		{
			SecurityLevelAccessGranted = Enums.ESecurityAccessLevel.ESL_4;
			StoreWeaponSFX = "ui_loot_gun";
			PickUpWeaponSFX = "ui_loot_take_all";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
