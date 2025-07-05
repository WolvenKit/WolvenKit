
namespace WolvenKit.RED4.Types
{
	public partial class LaserDetectorControllerPS : ScriptableDeviceComponentPS
	{
		public LaserDetectorControllerPS()
		{
			DeviceName = "Gameplay-Devices-DisplayNames-LaserDetector";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
