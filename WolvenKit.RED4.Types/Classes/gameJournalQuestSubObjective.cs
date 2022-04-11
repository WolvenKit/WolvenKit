
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestSubObjective : gameJournalQuestObjectiveBase
	{

		public gameJournalQuestSubObjective()
		{
			Entries = new();
			Description = new() { Unk1 = 0, Value = "" };
		}
	}
}
