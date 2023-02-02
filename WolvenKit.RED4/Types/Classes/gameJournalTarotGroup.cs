
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalTarotGroup : gameJournalFileEntry
	{
		public gameJournalTarotGroup()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
