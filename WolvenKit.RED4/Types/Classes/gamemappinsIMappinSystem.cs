
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamemappinsIMappinSystem : gameIReplicatedGameSystem
	{
		public gamemappinsIMappinSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
