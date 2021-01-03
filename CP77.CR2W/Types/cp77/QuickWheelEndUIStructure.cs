using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuickWheelEndUIStructure : CVariable
	{
		[Ordinal(0)]  [RED("ChosenItem")] public QuickSlotCommand ChosenItem { get; set; }
		[Ordinal(1)]  [RED("WasAssignedToSlot")] public CBool WasAssignedToSlot { get; set; }
		[Ordinal(2)]  [RED("WasUsed")] public CBool WasUsed { get; set; }
		[Ordinal(3)]  [RED("WheelDirection")] public CEnum<EDPadSlot> WheelDirection { get; set; }

		public QuickWheelEndUIStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
