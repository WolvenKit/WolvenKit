
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIEntitySpawnerEventsBroadcaster : gameIGameSystem
	{
		public gameIEntitySpawnerEventsBroadcaster()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
