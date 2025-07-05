
namespace WolvenKit.RED4.Types
{
	public abstract partial class DeviceSystemBaseController : MasterController
	{
		public DeviceSystemBaseController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
