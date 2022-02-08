
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestPointOfInterestMapPin : gameJournalQuestMapPinBase
	{

		public gameJournalQuestPointOfInterestMapPin()
		{
			Entries = new();
			EnableGPS = true;
		}
	}
}
