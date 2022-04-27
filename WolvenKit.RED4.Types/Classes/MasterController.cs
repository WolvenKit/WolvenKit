
namespace WolvenKit.RED4.Types
{
	public partial class MasterController : ScriptableDeviceComponent
	{
		public MasterController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
