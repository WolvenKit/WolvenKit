
namespace WolvenKit.RED4.Types
{
	public partial class ProximityDetectorControllerPS : ScriptableDeviceComponentPS
	{
		public ProximityDetectorControllerPS()
		{
			DeviceName = "Gameplay-Devices-DisplayNames-LaserDetector";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
