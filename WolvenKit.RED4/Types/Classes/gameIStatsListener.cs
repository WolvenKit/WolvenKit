
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIStatsListener : IScriptable
	{
		public gameIStatsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
