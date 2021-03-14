using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateTrackedObjectiveEvent : redEvent
	{
		private wCHandle<gameJournalQuestObjective> _trackedObjective;
		private wCHandle<gameJournalQuest> _trackedQuest;

		[Ordinal(0)] 
		[RED("trackedObjective")] 
		public wCHandle<gameJournalQuestObjective> TrackedObjective
		{
			get
			{
				if (_trackedObjective == null)
				{
					_trackedObjective = (wCHandle<gameJournalQuestObjective>) CR2WTypeManager.Create("whandle:gameJournalQuestObjective", "trackedObjective", cr2w, this);
				}
				return _trackedObjective;
			}
			set
			{
				if (_trackedObjective == value)
				{
					return;
				}
				_trackedObjective = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("trackedQuest")] 
		public wCHandle<gameJournalQuest> TrackedQuest
		{
			get
			{
				if (_trackedQuest == null)
				{
					_trackedQuest = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "trackedQuest", cr2w, this);
				}
				return _trackedQuest;
			}
			set
			{
				if (_trackedQuest == value)
				{
					return;
				}
				_trackedQuest = value;
				PropertySet(this);
			}
		}

		public UpdateTrackedObjectiveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
