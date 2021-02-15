using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ElevatorArrowsLogicController : DeviceInkLogicControllerBase
	{
		[Ordinal(5)] [RED("arrow1Widget")] public inkWidgetReference Arrow1Widget { get; set; }
		[Ordinal(6)] [RED("arrow2Widget")] public inkWidgetReference Arrow2Widget { get; set; }
		[Ordinal(7)] [RED("arrow3Widget")] public inkWidgetReference Arrow3Widget { get; set; }
		[Ordinal(8)] [RED("animFade1")] public CHandle<inkanimDefinition> AnimFade1 { get; set; }
		[Ordinal(9)] [RED("animFade2")] public CHandle<inkanimDefinition> AnimFade2 { get; set; }
		[Ordinal(10)] [RED("animFade3")] public CHandle<inkanimDefinition> AnimFade3 { get; set; }
		[Ordinal(11)] [RED("animSlow1")] public CHandle<inkanimDefinition> AnimSlow1 { get; set; }
		[Ordinal(12)] [RED("animSlow2")] public CHandle<inkanimDefinition> AnimSlow2 { get; set; }
		[Ordinal(13)] [RED("animOptions1")] public inkanimPlaybackOptions AnimOptions1 { get; set; }
		[Ordinal(14)] [RED("animOptions2")] public inkanimPlaybackOptions AnimOptions2 { get; set; }
		[Ordinal(15)] [RED("animOptions3")] public inkanimPlaybackOptions AnimOptions3 { get; set; }

		public ElevatorArrowsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
