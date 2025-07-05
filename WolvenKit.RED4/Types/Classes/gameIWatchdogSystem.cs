
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIWatchdogSystem : gameIGameSystem
	{
		public gameIWatchdogSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
