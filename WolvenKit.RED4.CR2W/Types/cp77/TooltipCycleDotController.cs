using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipCycleDotController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("slotBorder")] public inkWidgetReference SlotBorder { get; set; }
		[Ordinal(2)] [RED("slotBackground")] public inkWidgetReference SlotBackground { get; set; }

		public TooltipCycleDotController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
