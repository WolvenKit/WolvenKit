
namespace WolvenKit.RED4.Types
{
	public partial class ScriptableDeviceComponent : gameDeviceComponent
	{
		public ScriptableDeviceComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
