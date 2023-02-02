
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestPointOfInterestMapPin : gameJournalQuestMapPinBase
	{
		public gameJournalQuestPointOfInterestMapPin()
		{
			Entries = new();
			EnableGPS = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
