
namespace WolvenKit.RED4.Types
{
	public partial class gameObjectDeathListener : gameIStatPoolsListener
	{
		public gameObjectDeathListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
