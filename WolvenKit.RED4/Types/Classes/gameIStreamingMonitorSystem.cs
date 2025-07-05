
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIStreamingMonitorSystem : gameIGameSystem
	{
		public gameIStreamingMonitorSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
