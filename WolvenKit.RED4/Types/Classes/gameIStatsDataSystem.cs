
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIStatsDataSystem : gameIGameSystem
	{
		public gameIStatsDataSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
