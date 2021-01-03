using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestTrackerObjectiveLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(1)]  [RED("AnimProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(2)]  [RED("IntroAnimProxy")] public CHandle<inkanimProxy> IntroAnimProxy { get; set; }
		[Ordinal(3)]  [RED("objectiveEntry")] public wCHandle<gameJournalQuestObjective> ObjectiveEntry { get; set; }
		[Ordinal(4)]  [RED("objectiveTitle")] public inkTextWidgetReference ObjectiveTitle { get; set; }
		[Ordinal(5)]  [RED("readyToRemove")] public CBool ReadyToRemove { get; set; }
		[Ordinal(6)]  [RED("trackingFrame")] public inkWidgetReference TrackingFrame { get; set; }
		[Ordinal(7)]  [RED("trackingIcon")] public inkWidgetReference TrackingIcon { get; set; }

		public QuestTrackerObjectiveLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
