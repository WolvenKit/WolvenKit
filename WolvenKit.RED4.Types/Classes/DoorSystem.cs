
namespace WolvenKit.RED4.Types
{
	public partial class DoorSystem : DeviceSystemBase
	{
		public DoorSystem()
		{
			ControllerTypeName = "DoorSystemController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
