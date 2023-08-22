
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamePuppetStatsListener : gameIStatsListener
	{
		public gamePuppetStatsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
