
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestPointOfInterestMapPin : gameJournalQuestMapPinBase
	{
		public gameJournalQuestPointOfInterestMapPin()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();
			EnableGPS = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
