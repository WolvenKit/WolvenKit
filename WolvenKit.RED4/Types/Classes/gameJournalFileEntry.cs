
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameJournalFileEntry : gameJournalContainerEntry
	{
		public gameJournalFileEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
