
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIReplicatedGameSystem : gameIGameSystem
	{
		public gameIReplicatedGameSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
