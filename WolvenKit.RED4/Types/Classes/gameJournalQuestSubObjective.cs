
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestSubObjective : gameJournalQuestObjectiveBase
	{
		public gameJournalQuestSubObjective()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();
			Description = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
