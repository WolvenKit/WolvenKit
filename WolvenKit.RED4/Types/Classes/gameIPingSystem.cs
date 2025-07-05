
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIPingSystem : gameIReplicatedGameSystem
	{
		public gameIPingSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
