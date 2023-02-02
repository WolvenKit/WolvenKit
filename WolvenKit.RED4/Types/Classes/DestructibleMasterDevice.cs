
namespace WolvenKit.RED4.Types
{
	public partial class DestructibleMasterDevice : InteractiveMasterDevice
	{
		public DestructibleMasterDevice()
		{
			ControllerTypeName = "DestructibleMasterDeviceController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
