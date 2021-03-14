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
			get
			{
				if (_journalEntry == null)
				{
					_journalEntry = (wCHandle<gameJournalQuestObjectiveBase>) CR2WTypeManager.Create("whandle:gameJournalQuestObjectiveBase", "journalEntry", cr2w, this);
				}
				return _journalEntry;
			}
			set
			{
				if (_journalEntry == value)
				{
					return;
				}
				_journalEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("objective")] 
		public wCHandle<QuestItemController> Objective
		{
			get
			{
				if (_objective == null)
				{
					_objective = (wCHandle<QuestItemController>) CR2WTypeManager.Create("whandle:QuestItemController", "objective", cr2w, this);
				}
				return _objective;
			}
			set
			{
				if (_objective == value)
				{
					return;
				}
				_objective = value;
				PropertySet(this);
			}
		}

		public QuestTrackingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
