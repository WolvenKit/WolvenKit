using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuickSlotButtonHoldEndEvent : redEvent
	{
		[Ordinal(0)]  [RED("dPadItemDirection")] public CEnum<EDPadSlot> DPadItemDirection { get; set; }
		[Ordinal(1)]  [RED("rightStickAngle")] public CFloat RightStickAngle { get; set; }
		[Ordinal(2)]  [RED("tryExecuteCommand")] public CBool TryExecuteCommand { get; set; }

		public QuickSlotButtonHoldEndEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
