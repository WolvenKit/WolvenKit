using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestTrackerObjectiveLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("objectiveTitle")] public inkTextWidgetReference ObjectiveTitle { get; set; }
		[Ordinal(2)] [RED("trackingIcon")] public inkWidgetReference TrackingIcon { get; set; }
		[Ordinal(3)] [RED("trackingFrame")] public inkWidgetReference TrackingFrame { get; set; }
		[Ordinal(4)] [RED("objectiveEntry")] public wCHandle<gameJournalQuestObjective> ObjectiveEntry { get; set; }
		[Ordinal(5)] [RED("AnimProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(6)] [RED("IntroAnimProxy")] public CHandle<inkanimProxy> IntroAnimProxy { get; set; }
		[Ordinal(7)] [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(8)] [RED("readyToRemove")] public CBool ReadyToRemove { get; set; }

		public QuestTrackerObjectiveLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
