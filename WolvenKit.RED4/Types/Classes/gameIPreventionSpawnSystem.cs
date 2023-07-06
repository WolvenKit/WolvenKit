
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIPreventionSpawnSystem : gameIGameSystem
	{
		public gameIPreventionSpawnSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
