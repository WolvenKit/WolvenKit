
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDeviceSystem : gameIGameSystem
	{
		public gameIDeviceSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
