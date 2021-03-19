using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestTrackingEvent : redEvent
	{
		private wCHandle<gameJournalQuestObjectiveBase> _journalEntry;
		private wCHandle<QuestItemController> _objective;

		[Ordinal(0)] 
		[RED("journalEntry")] 
		public wCHandle<gameJournalQuestObjectiveBase> JournalEntry
		{
			get => GetProperty(ref _journalEntry);
			set => SetProperty(ref _journalEntry, value);
		}

		[Ordinal(1)] 
		[RED("objective")] 
		public wCHandle<QuestItemController> Objective
		{
			get => GetProperty(ref _objective);
			set => SetProperty(ref _objective, value);
		}

		public QuestTrackingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
