
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class gameNPCStatsListener : gamePuppetStatsListener
	{
		public gameNPCStatsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
