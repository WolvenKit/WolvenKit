
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameICollisionQueriesSystem : gameIGameSystem
	{
		public gameICollisionQueriesSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
