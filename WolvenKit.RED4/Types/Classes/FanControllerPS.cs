using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FanControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(113)] 
		[RED("fanSetup")] 
		public FanSetup FanSetup
		{
			get => GetPropertyValue<FanSetup>();
			set => SetPropertyValue<FanSetup>(value);
		}

		public FanControllerPS()
		{
			DeviceName = "LocKey#94";
			TweakDBRecord = "Devices.Fan";
			TweakDBDescriptionRecord = "device_descriptions.Fan";
			FanSetup = new FanSetup();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
