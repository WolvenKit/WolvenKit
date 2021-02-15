using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkScrollController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("ScrollArea")] public inkScrollAreaWidgetReference ScrollArea { get; set; }
		[Ordinal(2)] [RED("VerticalScrollBarRef")] public inkWidgetReference VerticalScrollBarRef { get; set; }
		[Ordinal(3)] [RED("navigableCompoundWidget")] public inkWidgetReference NavigableCompoundWidget { get; set; }
		[Ordinal(4)] [RED("CompoundWidgetRef")] public inkCompoundWidgetReference CompoundWidgetRef { get; set; }
		[Ordinal(5)] [RED("autoHideVertical")] public CBool AutoHideVertical { get; set; }
		[Ordinal(6)] [RED("scrollSpeedGamepad")] public CFloat ScrollSpeedGamepad { get; set; }
		[Ordinal(7)] [RED("scrollSpeedMouse")] public CFloat ScrollSpeedMouse { get; set; }
		[Ordinal(8)] [RED("direction")] public CEnum<inkEScrollDirection> Direction { get; set; }
		[Ordinal(9)] [RED("useGlobalInput")] public CBool UseGlobalInput { get; set; }
		[Ordinal(10)] [RED("position")] public CFloat Position { get; set; }
		[Ordinal(11)] [RED("scrollDelta")] public CFloat ScrollDelta { get; set; }
		[Ordinal(12)] [RED("viewportSize")] public Vector2 ViewportSize { get; set; }
		[Ordinal(13)] [RED("contentSize")] public Vector2 ContentSize { get; set; }

		public inkScrollController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
