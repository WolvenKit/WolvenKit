
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalBriefing : gameJournalFileEntry
	{
		public gameJournalBriefing()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
