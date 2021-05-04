using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateOpenedQuestEvent : redEvent
	{
		private wCHandle<gameJournalQuest> _openedQuest;

		[Ordinal(0)] 
		[RED("openedQuest")] 
		public wCHandle<gameJournalQuest> OpenedQuest
		{
			get => GetProperty(ref _openedQuest);
			set => SetProperty(ref _openedQuest, value);
		}

		public UpdateOpenedQuestEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
