
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIClientEntitySpawnSystem : gameIGameSystem
	{
		public gameIClientEntitySpawnSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
