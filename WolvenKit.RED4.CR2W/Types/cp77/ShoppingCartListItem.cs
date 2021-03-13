using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShoppingCartListItem : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(2)] [RED("quantity")] public inkTextWidgetReference Quantity { get; set; }
		[Ordinal(3)] [RED("value")] public inkTextWidgetReference Value { get; set; }
		[Ordinal(4)] [RED("removeBtn")] public inkWidgetReference RemoveBtn { get; set; }
		[Ordinal(5)] [RED("data")] public InventoryItemData Data { get; set; }

		public ShoppingCartListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
