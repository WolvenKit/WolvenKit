
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestSubObjective : gameJournalQuestObjectiveBase
	{
		public gameJournalQuestSubObjective()
		{
			Entries = new();
			Description = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
