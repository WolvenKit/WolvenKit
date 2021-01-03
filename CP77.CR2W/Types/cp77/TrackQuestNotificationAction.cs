using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TrackQuestNotificationAction : GenericNotificationBaseAction
	{
		[Ordinal(0)]  [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(1)]  [RED("questEntry")] public wCHandle<gameJournalQuest> QuestEntry { get; set; }

		public TrackQuestNotificationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
