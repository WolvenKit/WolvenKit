using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrackQuestNotificationAction : GenericNotificationBaseAction
	{
		[Ordinal(0)] [RED("questEntry")] public wCHandle<gameJournalQuest> QuestEntry { get; set; }
		[Ordinal(1)] [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }

		public TrackQuestNotificationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
