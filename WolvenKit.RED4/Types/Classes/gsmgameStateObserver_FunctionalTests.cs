
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class gsmgameStateObserver_FunctionalTests : gsmIStateObserver
	{
		public gsmgameStateObserver_FunctionalTests()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
