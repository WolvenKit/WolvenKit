using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EquipmentAreaDisplays : IScriptable
	{
		[Ordinal(0)]  [RED("displayControllers")] public CArray<CHandle<InventoryItemDisplayController>> DisplayControllers { get; set; }
		[Ordinal(1)]  [RED("displaysRoot")] public wCHandle<inkWidget> DisplaysRoot { get; set; }
		[Ordinal(2)]  [RED("equipmentAreas")] public CArray<CEnum<gamedataEquipmentArea>> EquipmentAreas { get; set; }

		public EquipmentAreaDisplays(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
