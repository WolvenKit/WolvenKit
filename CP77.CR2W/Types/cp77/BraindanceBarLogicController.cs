using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BraindanceBarLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("layer")] public CEnum<gameuiEBraindanceLayer> Layer { get; set; }
		[Ordinal(2)] [RED("isInLayer")] public CBool IsInLayer { get; set; }
		[Ordinal(3)] [RED("timelineActiveAnimationName")] public CName TimelineActiveAnimationName { get; set; }
		[Ordinal(4)] [RED("timelineDisabledAnimationName")] public CName TimelineDisabledAnimationName { get; set; }
		[Ordinal(5)] [RED("timelineActiveAnimation")] public CHandle<inkanimProxy> TimelineActiveAnimation { get; set; }
		[Ordinal(6)] [RED("timelineDisabledAnimation")] public CHandle<inkanimProxy> TimelineDisabledAnimation { get; set; }

		public BraindanceBarLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
