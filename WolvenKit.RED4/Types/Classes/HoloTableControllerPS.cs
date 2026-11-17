
namespace WolvenKit.RED4.Types
{
	public partial class HoloTableControllerPS : MediaDeviceControllerPS
	{
		public HoloTableControllerPS()
		{
			DeviceName = "LocKey#17851";
			TweakDBRecord = "Devices.HoloTable";
			TweakDBDescriptionRecord = "device_descriptions.HoloTable";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
