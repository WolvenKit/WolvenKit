
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIStatsSystem : gameIGameSystem
	{
		public gameIStatsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
