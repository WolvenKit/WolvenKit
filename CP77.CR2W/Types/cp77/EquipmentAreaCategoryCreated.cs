using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EquipmentAreaCategoryCreated : redEvent
	{
		[Ordinal(0)] [RED("categoryController")] public CHandle<InventoryItemDisplayCategoryArea> CategoryController { get; set; }
		[Ordinal(1)] [RED("equipmentAreasControllers")] public CArray<CHandle<InventoryItemDisplayEquipmentArea>> EquipmentAreasControllers { get; set; }

		public EquipmentAreaCategoryCreated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
