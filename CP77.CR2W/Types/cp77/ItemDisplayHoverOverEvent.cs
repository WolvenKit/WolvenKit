using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayHoverOverEvent : redEvent
	{
		[Ordinal(0)]  [RED("display")] public wCHandle<InventoryItemDisplayController> Display { get; set; }
		[Ordinal(1)]  [RED("isBuybackStack")] public CBool IsBuybackStack { get; set; }
		[Ordinal(2)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(3)]  [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }

		public ItemDisplayHoverOverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
