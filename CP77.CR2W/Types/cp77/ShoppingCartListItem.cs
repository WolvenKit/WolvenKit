using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ShoppingCartListItem : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("data")] public InventoryItemData Data { get; set; }
		[Ordinal(1)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(2)]  [RED("quantity")] public inkTextWidgetReference Quantity { get; set; }
		[Ordinal(3)]  [RED("removeBtn")] public inkWidgetReference RemoveBtn { get; set; }
		[Ordinal(4)]  [RED("value")] public inkTextWidgetReference Value { get; set; }

		public ShoppingCartListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
