using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EquipmentAreaCategory : IScriptable
	{
		[Ordinal(0)]  [RED("areaDisplays")] public CArray<CHandle<EquipmentAreaDisplays>> AreaDisplays { get; set; }
		[Ordinal(1)]  [RED("parentCategory")] public CHandle<InventoryItemDisplayCategoryArea> ParentCategory { get; set; }

		public EquipmentAreaCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
