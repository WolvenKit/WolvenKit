using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HoloFeederControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("turnOnSFX")] 
		public CName TurnOnSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(108)] 
		[RED("turnOffSFX")] 
		public CName TurnOffSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public HoloFeederControllerPS()
		{
			DeviceName = "LocKey#95";
			TweakDBRecord = "Devices.HoloFeeder";
			TweakDBDescriptionRecord = "device_descriptions.HoloFeeder";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
