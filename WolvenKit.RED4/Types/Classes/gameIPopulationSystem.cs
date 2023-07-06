
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIPopulationSystem : gameIGameSystem
	{
		public gameIPopulationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
