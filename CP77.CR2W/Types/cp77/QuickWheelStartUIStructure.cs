using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuickWheelStartUIStructure : CVariable
	{
		[Ordinal(0)]  [RED("WheelItems")] public CArray<QuickSlotCommand> WheelItems { get; set; }
		[Ordinal(1)]  [RED("dpadSlot")] public CEnum<EDPadSlot> DpadSlot { get; set; }

		public QuickWheelStartUIStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
