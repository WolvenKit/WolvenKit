using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TooltipCycleDotController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("slotBackground")] public inkWidgetReference SlotBackground { get; set; }
		[Ordinal(1)]  [RED("slotBorder")] public inkWidgetReference SlotBorder { get; set; }

		public TooltipCycleDotController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
