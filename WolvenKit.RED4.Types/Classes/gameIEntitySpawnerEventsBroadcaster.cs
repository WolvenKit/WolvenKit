
namespace WolvenKit.RED4.Types
{
	public partial class gameIEntitySpawnerEventsBroadcaster : gameIGameSystem
	{
		public gameIEntitySpawnerEventsBroadcaster()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
