
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalEmailGroup : gameJournalFileEntry
	{
		public gameJournalEmailGroup()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
