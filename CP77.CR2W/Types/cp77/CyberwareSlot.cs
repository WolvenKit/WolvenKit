using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberwareSlot : BaseButtonView
	{
		[Ordinal(2)] [RED("IconImageRef")] public inkImageWidgetReference IconImageRef { get; set; }
		[Ordinal(3)] [RED("SlotEquipArea")] public CEnum<gamedataEquipmentArea> SlotEquipArea { get; set; }
		[Ordinal(4)] [RED("NumSlots")] public CInt32 NumSlots { get; set; }

		public CyberwareSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
