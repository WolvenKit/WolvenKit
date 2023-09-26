
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalContactModifierEntry : gameJournalEntry
	{
		public gameJournalContactModifierEntry()
		{
			JournalEntryOverrideDataList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
