using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CyberwareSlot : BaseButtonView
	{
		[Ordinal(0)]  [RED("IconImageRef")] public inkImageWidgetReference IconImageRef { get; set; }
		[Ordinal(1)]  [RED("NumSlots")] public CInt32 NumSlots { get; set; }
		[Ordinal(2)]  [RED("SlotEquipArea")] public CEnum<gamedataEquipmentArea> SlotEquipArea { get; set; }

		public CyberwareSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
