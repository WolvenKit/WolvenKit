
namespace WolvenKit.RED4.Types
{
	public partial class BaseAnimatedDeviceController : ScriptableDeviceComponent
	{
		public BaseAnimatedDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
