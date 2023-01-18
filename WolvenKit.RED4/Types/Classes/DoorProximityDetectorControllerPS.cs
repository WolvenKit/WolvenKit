
namespace WolvenKit.RED4.Types
{
	public partial class DoorProximityDetectorControllerPS : ScriptableDeviceComponentPS
	{
		public DoorProximityDetectorControllerPS()
		{
			DeviceName = "Gameplay-Devices-DisplayNames-LaserDetector";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
