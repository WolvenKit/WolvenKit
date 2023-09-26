
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalPointOfInterestGroup : gameJournalFileEntry
	{
		public gameJournalPointOfInterestGroup()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
