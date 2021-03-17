using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrackQuestNotificationAction : GenericNotificationBaseAction
	{
		private wCHandle<gameJournalQuest> _questEntry;
		private wCHandle<gameJournalManager> _journalMgr;

		[Ordinal(0)] 
		[RED("questEntry")] 
		public wCHandle<gameJournalQuest> QuestEntry
		{
			get => GetProperty(ref _questEntry);
			set => SetProperty(ref _questEntry, value);
		}

		[Ordinal(1)] 
		[RED("journalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		public TrackQuestNotificationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
