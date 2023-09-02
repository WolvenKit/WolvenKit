
namespace WolvenKit.RED4.Types
{
	public abstract partial class DeviceSystemBase : InteractiveMasterDevice
	{
		public DeviceSystemBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
