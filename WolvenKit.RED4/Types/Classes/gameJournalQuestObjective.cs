
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestObjective : gameJournalQuestObjectiveBase
	{
		public gameJournalQuestObjective()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();
			Description = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
