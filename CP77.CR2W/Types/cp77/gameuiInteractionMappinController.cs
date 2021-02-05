using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiInteractionMappinController : gameuiMappinBaseController
	{
		[Ordinal(0)]  [RED("animPlayerTrackedWidget")] public inkWidgetReference AnimPlayerTrackedWidget { get; set; }
		[Ordinal(1)]  [RED("animPlayerAboveBelowWidget")] public inkWidgetReference AnimPlayerAboveBelowWidget { get; set; }
		[Ordinal(2)]  [RED("taggedWidgets")] public CArray<inkWidgetReference> TaggedWidgets { get; set; }
		[Ordinal(3)]  [RED("isCurrentlyClamped")] public CBool IsCurrentlyClamped { get; set; }
		[Ordinal(4)]  [RED("isUnderCrosshair")] public CBool IsUnderCrosshair { get; set; }
		[Ordinal(5)]  [RED("canvasWidgetName")] public CName CanvasWidgetName { get; set; }
		[Ordinal(6)]  [RED("arrowWidgetName")] public CName ArrowWidgetName { get; set; }

		public gameuiInteractionMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
