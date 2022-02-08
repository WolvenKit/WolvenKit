
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestObjective : gameJournalQuestObjectiveBase
	{

		public gameJournalQuestObjective()
		{
			Entries = new();
			Description = new() { Unk1 = 0, Value = "" };
		}
	}
}
