using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryItemModSlotDisplay : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("slotBorder")] public inkWidgetReference SlotBorder { get; set; }
		[Ordinal(2)] [RED("slotBackground")] public inkWidgetReference SlotBackground { get; set; }

		public InventoryItemModSlotDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
