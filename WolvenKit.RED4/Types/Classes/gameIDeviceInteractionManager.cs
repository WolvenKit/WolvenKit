
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDeviceInteractionManager : gameIGameSystem
	{
		public gameIDeviceInteractionManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
