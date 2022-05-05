
namespace WolvenKit.RED4.Types
{
	public partial class HoloDeviceController : ScriptableDeviceComponent
	{
		public HoloDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
