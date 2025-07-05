
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIRealTimeEventSystem : gameIGameSystem
	{
		public gameIRealTimeEventSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
