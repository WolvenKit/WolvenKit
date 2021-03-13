using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentAreaCategory : IScriptable
	{
		[Ordinal(0)] [RED("parentCategory")] public CHandle<InventoryItemDisplayCategoryArea> ParentCategory { get; set; }
		[Ordinal(1)] [RED("areaDisplays")] public CArray<CHandle<EquipmentAreaDisplays>> AreaDisplays { get; set; }

		public EquipmentAreaCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
