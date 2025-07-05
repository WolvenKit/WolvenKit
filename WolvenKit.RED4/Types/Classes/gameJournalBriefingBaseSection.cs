
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameJournalBriefingBaseSection : gameJournalEntry
	{
		public gameJournalBriefingBaseSection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
