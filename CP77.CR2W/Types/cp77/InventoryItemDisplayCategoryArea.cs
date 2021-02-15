using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryItemDisplayCategoryArea : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("areasToHide")] public CArray<inkWidgetReference> AreasToHide { get; set; }
		[Ordinal(2)] [RED("equipmentAreas")] public CArray<inkCompoundWidgetReference> EquipmentAreas { get; set; }
		[Ordinal(3)] [RED("newItemsWrapper")] public inkWidgetReference NewItemsWrapper { get; set; }
		[Ordinal(4)] [RED("newItemsCounter")] public inkTextWidgetReference NewItemsCounter { get; set; }
		[Ordinal(5)] [RED("categoryAreas")] public CArray<CHandle<InventoryItemDisplayEquipmentArea>> CategoryAreas { get; set; }

		public InventoryItemDisplayCategoryArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
