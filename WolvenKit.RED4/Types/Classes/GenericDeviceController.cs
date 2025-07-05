
namespace WolvenKit.RED4.Types
{
	public partial class GenericDeviceController : ScriptableDeviceComponent
	{
		public GenericDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
