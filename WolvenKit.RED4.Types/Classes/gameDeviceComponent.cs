
namespace WolvenKit.RED4.Types
{
	public partial class gameDeviceComponent : gameComponent
	{
		public gameDeviceComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
