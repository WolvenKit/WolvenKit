using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSEquipArea : CVariable
	{
		[Ordinal(0)] [RED("areaType")] public CEnum<gamedataEquipmentArea> AreaType { get; set; }
		[Ordinal(1)] [RED("equipSlots")] public CArray<gameSEquipSlot> EquipSlots { get; set; }
		[Ordinal(2)] [RED("activeIndex")] public CInt32 ActiveIndex { get; set; }

		public gameSEquipArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
