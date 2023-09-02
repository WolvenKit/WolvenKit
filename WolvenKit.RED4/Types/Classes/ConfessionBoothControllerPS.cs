
namespace WolvenKit.RED4.Types
{
	public partial class ConfessionBoothControllerPS : BasicDistractionDeviceControllerPS
	{
		public ConfessionBoothControllerPS()
		{
			DeviceName = "LocKey#1942";
			TweakDBRecord = "Devices.ConfessionBooth";
			TweakDBDescriptionRecord = 152595250458;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
