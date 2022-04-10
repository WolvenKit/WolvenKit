
namespace WolvenKit.RED4.Types
{
	public partial class DeviceSystemBase : InteractiveMasterDevice
	{
		public DeviceSystemBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
