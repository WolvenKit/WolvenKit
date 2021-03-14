using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestChangeTrackedObjective : redEvent
	{
		private wCHandle<gameJournalQuestObjective> _objective;
		private wCHandle<gameJournalQuest> _quest;

		[Ordinal(0)] 
		[RED("objective")] 
		public wCHandle<gameJournalQuestObjective> Objective
		{
			get
			{
				if (_objective == null)
				{
					_objective = (wCHandle<gameJournalQuestObjective>) CR2WTypeManager.Create("whandle:gameJournalQuestObjective", "objective", cr2w, this);
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

		[Ordinal(1)] 
		[RED("quest")] 
		public wCHandle<gameJournalQuest> Quest
		{
			get
			{
				if (_quest == null)
				{
					_quest = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "quest", cr2w, this);
				}
				return _quest;
			}
			set
			{
				if (_quest == value)
				{
					return;
				}
				_quest = value;
				PropertySet(this);
			}
		}

		public RequestChangeTrackedObjective(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
