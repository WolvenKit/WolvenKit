
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIEffectSpawnerSaveSystem : gameIGameSystem
	{
		public gameIEffectSpawnerSaveSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
