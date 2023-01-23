
namespace WolvenKit.RED4.Types
{
	public partial class BaseDestructibleController : ScriptableDeviceComponent
	{
		public BaseDestructibleController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
