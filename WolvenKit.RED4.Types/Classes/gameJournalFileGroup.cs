
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalFileGroup : gameJournalFileEntry
	{
		public gameJournalFileGroup()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
