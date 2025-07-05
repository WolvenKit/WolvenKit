
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDebugCheatsSystem : gameIReplicatedGameSystem
	{
		public gameIDebugCheatsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
