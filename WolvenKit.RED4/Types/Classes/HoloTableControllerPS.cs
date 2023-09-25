
namespace WolvenKit.RED4.Types
{
	public partial class HoloTableControllerPS : MediaDeviceControllerPS
	{
		public HoloTableControllerPS()
		{
			DeviceName = "LocKey#17851";
			TweakDBRecord = "Devices.HoloTable";
			TweakDBDescriptionRecord = 128182655022;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
