
namespace WolvenKit.RED4.Types
{
	public partial class TrafficLightController : ScriptableDeviceComponent
	{
		public TrafficLightController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
