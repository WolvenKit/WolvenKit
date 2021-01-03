using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryItemModSlotDisplay : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("slotBackground")] public inkWidgetReference SlotBackground { get; set; }
		[Ordinal(1)]  [RED("slotBorder")] public inkWidgetReference SlotBorder { get; set; }

		public InventoryItemModSlotDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
