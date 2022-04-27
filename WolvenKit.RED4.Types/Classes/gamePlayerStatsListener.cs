
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class gamePlayerStatsListener : gamePuppetStatsListener
	{
		public gamePlayerStatsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
