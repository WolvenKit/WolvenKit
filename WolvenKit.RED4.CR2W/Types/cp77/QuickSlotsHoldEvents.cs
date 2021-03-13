using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsHoldEvents : QuickSlotsEvents
	{
		[Ordinal(0)] [RED("holdDirection")] public CEnum<EDPadSlot> HoldDirection { get; set; }

		public QuickSlotsHoldEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
