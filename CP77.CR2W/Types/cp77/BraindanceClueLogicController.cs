using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BraindanceClueLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("bg")] public inkWidgetReference Bg { get; set; }
		[Ordinal(1)]  [RED("data")] public BraindanceClueData Data { get; set; }
		[Ordinal(2)]  [RED("isInLayer")] public CBool IsInLayer { get; set; }
		[Ordinal(3)]  [RED("isInTimeWindow")] public CBool IsInTimeWindow { get; set; }
		[Ordinal(4)]  [RED("state")] public CEnum<ClueState> State { get; set; }
		[Ordinal(5)]  [RED("timelineActiveAnimation")] public CHandle<inkanimProxy> TimelineActiveAnimation { get; set; }
		[Ordinal(6)]  [RED("timelineActiveAnimationName")] public CName TimelineActiveAnimationName { get; set; }
		[Ordinal(7)]  [RED("timelineDisabledAnimation")] public CHandle<inkanimProxy> TimelineDisabledAnimation { get; set; }
		[Ordinal(8)]  [RED("timelineDisabledAnimationName")] public CName TimelineDisabledAnimationName { get; set; }

		public BraindanceClueLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
