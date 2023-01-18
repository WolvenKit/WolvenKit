
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalPhoneChoiceGroup : gameJournalContainerEntry
	{
		public gameJournalPhoneChoiceGroup()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
