using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BraindanceBarLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("layer")] public CEnum<gameuiEBraindanceLayer> Layer { get; set; }
		[Ordinal(1)]  [RED("isInLayer")] public CBool IsInLayer { get; set; }
		[Ordinal(2)]  [RED("timelineActiveAnimationName")] public CName TimelineActiveAnimationName { get; set; }
		[Ordinal(3)]  [RED("timelineDisabledAnimationName")] public CName TimelineDisabledAnimationName { get; set; }
		[Ordinal(4)]  [RED("timelineActiveAnimation")] public CHandle<inkanimProxy> TimelineActiveAnimation { get; set; }
		[Ordinal(5)]  [RED("timelineDisabledAnimation")] public CHandle<inkanimProxy> TimelineDisabledAnimation { get; set; }

		public BraindanceBarLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
