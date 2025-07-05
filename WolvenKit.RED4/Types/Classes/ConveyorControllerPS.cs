
namespace WolvenKit.RED4.Types
{
	public partial class ConveyorControllerPS : ScriptableDeviceComponentPS
	{
		public ConveyorControllerPS()
		{
			DeviceState = Enums.EDeviceStatus.OFF;
			DeviceName = "LocKey#45661";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
