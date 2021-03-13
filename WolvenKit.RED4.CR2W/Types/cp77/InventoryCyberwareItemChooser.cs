using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryCyberwareItemChooser : InventoryGenericItemChooser
	{
		[Ordinal(13)] [RED("leftSlotsContainer")] public inkCompoundWidgetReference LeftSlotsContainer { get; set; }
		[Ordinal(14)] [RED("rightSlotsContainer")] public inkCompoundWidgetReference RightSlotsContainer { get; set; }
		[Ordinal(15)] [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(16)] [RED("itemDatas")] public CArray<InventoryItemData> ItemDatas { get; set; }

		public InventoryCyberwareItemChooser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
