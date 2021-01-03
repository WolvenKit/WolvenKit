using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryItemDisplayCategoryArea : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("areasToHide")] public CArray<inkWidgetReference> AreasToHide { get; set; }
		[Ordinal(1)]  [RED("categoryAreas")] public CArray<CHandle<InventoryItemDisplayEquipmentArea>> CategoryAreas { get; set; }
		[Ordinal(2)]  [RED("equipmentAreas")] public CArray<inkCompoundWidgetReference> EquipmentAreas { get; set; }
		[Ordinal(3)]  [RED("newItemsCounter")] public inkTextWidgetReference NewItemsCounter { get; set; }
		[Ordinal(4)]  [RED("newItemsWrapper")] public inkWidgetReference NewItemsWrapper { get; set; }

		public InventoryItemDisplayCategoryArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
