
namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceController : ScriptableDeviceComponent
	{
		public ActivatedDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
