
namespace WolvenKit.RED4.Types
{
	public partial class DoorProximityDetectorControllerPS : ProximityDetectorControllerPS
	{
		public DoorProximityDetectorControllerPS()
		{
			DeviceName = "Gameplay-Devices-DisplayNames-DoorDetector";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
