
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalBriefingPaperDollSection : gameJournalBriefingBaseSection
	{
		public gameJournalBriefingPaperDollSection()
		{
			JournalEntryOverrideDataList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
