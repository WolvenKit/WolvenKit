
namespace WolvenKit.RED4.Types
{
	public partial class gameStatsComponent : gameComponent
	{
		public gameStatsComponent()
		{
			Name = "StatsComponent";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
