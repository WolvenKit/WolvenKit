
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalFileGroup : gameJournalFileEntry
	{
		public gameJournalFileGroup()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
