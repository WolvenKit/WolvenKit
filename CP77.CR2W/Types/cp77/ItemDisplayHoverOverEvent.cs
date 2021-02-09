using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayHoverOverEvent : redEvent
	{
		[Ordinal(0)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(1)]  [RED("display")] public wCHandle<InventoryItemDisplayController> Display { get; set; }
		[Ordinal(2)]  [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }
		[Ordinal(3)]  [RED("isBuybackStack")] public CBool IsBuybackStack { get; set; }

		public ItemDisplayHoverOverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
