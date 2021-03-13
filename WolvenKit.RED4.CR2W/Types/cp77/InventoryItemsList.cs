using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemsList : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("InventoryItemName")] public CName InventoryItemName { get; set; }
		[Ordinal(2)] [RED("ItemsLayoutRef")] public inkCompoundWidgetReference ItemsLayoutRef { get; set; }
		[Ordinal(3)] [RED("TooltipsData")] public CArray<CHandle<ATooltipData>> TooltipsData { get; set; }
		[Ordinal(4)] [RED("ItemsOwner")] public wCHandle<gameObject> ItemsOwner { get; set; }
		[Ordinal(5)] [RED("ItemsLayout")] public wCHandle<inkCompoundWidget> ItemsLayout { get; set; }
		[Ordinal(6)] [RED("InventoryItems")] public CArray<wCHandle<inkWidget>> InventoryItems { get; set; }
		[Ordinal(7)] [RED("IsDevice")] public CBool IsDevice { get; set; }
		[Ordinal(8)] [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }

		public InventoryItemsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
