
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDebugDrawHistorySystem : gameIGameSystem
	{
		public gameIDebugDrawHistorySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
