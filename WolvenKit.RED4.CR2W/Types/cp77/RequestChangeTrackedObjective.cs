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
			get => GetProperty(ref _objective);
			set => SetProperty(ref _objective, value);
		}

		[Ordinal(1)] 
		[RED("quest")] 
		public wCHandle<gameJournalQuest> Quest
		{
			get => GetProperty(ref _quest);
			set => SetProperty(ref _quest, value);
		}

		public RequestChangeTrackedObjective(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
