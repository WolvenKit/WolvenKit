
namespace WolvenKit.RED4.Types
{
	public partial class StaticPlatformController : ScriptableDeviceComponent
	{
		public StaticPlatformController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
