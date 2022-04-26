
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalBriefing : gameJournalFileEntry
	{
		public gameJournalBriefing()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
