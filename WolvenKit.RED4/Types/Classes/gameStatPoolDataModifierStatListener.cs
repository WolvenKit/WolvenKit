
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameStatPoolDataModifierStatListener : gameIStatsListener
	{
		public gameStatPoolDataModifierStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
