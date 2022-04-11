
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalOnscreenGroup : gameJournalFileEntry
	{
		public gameJournalOnscreenGroup()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
