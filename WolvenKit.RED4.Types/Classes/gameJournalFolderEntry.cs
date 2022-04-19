
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalFolderEntry : gameJournalContainerEntry
	{
		public gameJournalFolderEntry()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
