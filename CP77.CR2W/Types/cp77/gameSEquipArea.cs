using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSEquipArea : CVariable
	{
		[Ordinal(0)]  [RED("activeIndex")] public CInt32 ActiveIndex { get; set; }
		[Ordinal(1)]  [RED("areaType")] public CEnum<gamedataEquipmentArea> AreaType { get; set; }
		[Ordinal(2)]  [RED("equipSlots")] public CArray<gameSEquipSlot> EquipSlots { get; set; }

		public gameSEquipArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
