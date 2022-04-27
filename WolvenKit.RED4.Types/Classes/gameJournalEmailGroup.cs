
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalEmailGroup : gameJournalFileEntry
	{
		public gameJournalEmailGroup()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
