using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryCyberwareItemChooser : InventoryGenericItemChooser
	{
		[Ordinal(0)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(1)]  [RED("itemDatas")] public CArray<InventoryItemData> ItemDatas { get; set; }
		[Ordinal(2)]  [RED("leftSlotsContainer")] public inkCompoundWidgetReference LeftSlotsContainer { get; set; }
		[Ordinal(3)]  [RED("rightSlotsContainer")] public inkCompoundWidgetReference RightSlotsContainer { get; set; }

		public InventoryCyberwareItemChooser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
