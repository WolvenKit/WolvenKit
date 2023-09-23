
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDynamicSpawnSystem : gameIGameSystem
	{
		public gameIDynamicSpawnSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
