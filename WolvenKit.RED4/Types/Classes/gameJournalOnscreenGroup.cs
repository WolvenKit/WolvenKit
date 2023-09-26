
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalOnscreenGroup : gameJournalFileEntry
	{
		public gameJournalOnscreenGroup()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
