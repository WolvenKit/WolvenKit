
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIJournalManager : gameIReplicatedGameSystem
	{
		public gameIJournalManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
