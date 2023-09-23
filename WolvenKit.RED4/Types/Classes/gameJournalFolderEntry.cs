
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalFolderEntry : gameJournalContainerEntry
	{
		public gameJournalFolderEntry()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
