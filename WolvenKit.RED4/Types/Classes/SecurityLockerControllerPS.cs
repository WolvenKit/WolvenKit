using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityLockerControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("securityLockerProperties")] 
		public SecurityLockerProperties SecurityLockerProperties
		{
			get => GetPropertyValue<SecurityLockerProperties>();
			set => SetPropertyValue<SecurityLockerProperties>(value);
		}

		[Ordinal(108)] 
		[RED("isStoringPlayerEquipement")] 
		public CBool IsStoringPlayerEquipement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecurityLockerControllerPS()
		{
			DeviceName = "LocKey#122";
			SecurityLockerProperties = new SecurityLockerProperties { SecurityLevelAccessGranted = Enums.ESecurityAccessLevel.ESL_4, StoreWeaponSFX = "ui_loot_gun", PickUpWeaponSFX = "ui_loot_take_all" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
