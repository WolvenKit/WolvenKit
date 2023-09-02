
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameITimeSystem : gameIReplicatedGameSystem
	{
		public gameITimeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
