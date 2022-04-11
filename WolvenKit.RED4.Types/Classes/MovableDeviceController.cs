
namespace WolvenKit.RED4.Types
{
	public partial class MovableDeviceController : ScriptableDeviceComponent
	{
		public MovableDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
