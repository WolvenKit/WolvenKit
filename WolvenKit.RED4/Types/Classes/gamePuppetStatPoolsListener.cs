
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamePuppetStatPoolsListener : gameIStatPoolsListener
	{
		public gamePuppetStatPoolsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
