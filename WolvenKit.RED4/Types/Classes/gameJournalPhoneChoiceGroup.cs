
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalPhoneChoiceGroup : gameJournalContainerEntry
	{
		public gameJournalPhoneChoiceGroup()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
