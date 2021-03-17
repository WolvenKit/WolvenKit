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
			get => GetProperty(ref _trackedObjective);
			set => SetProperty(ref _trackedObjective, value);
		}

		[Ordinal(1)] 
		[RED("trackedQuest")] 
		public wCHandle<gameJournalQuest> TrackedQuest
		{
			get => GetProperty(ref _trackedQuest);
			set => SetProperty(ref _trackedQuest, value);
		}

		public UpdateTrackedObjectiveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
