using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SniperNestControllerPS : SensorDeviceControllerPS
	{
		[Ordinal(150)] 
		[RED("vfxNameOnShoot")] 
		public CName VfxNameOnShoot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(151)] 
		[RED("isRippedOff")] 
		public CBool IsRippedOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SniperNestControllerPS()
		{
			DeviceName = "LocKey#91723";
			TweakDBRecord = "Devices.SniperNest";
			TweakDBDescriptionRecord = "device_descriptions.SecurityTurret";
			CanBeInDeviceChain = true;
			DisableQuickHacks = true;
			LookAtPresetVert = "LookatPreset.TurretVertical";
			LookAtPresetHor = "LookatPreset.TurretHorizontal";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
