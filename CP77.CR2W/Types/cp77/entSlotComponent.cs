using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entSlotComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("slots")] public CArray<entSlot> Slots { get; set; }
		[Ordinal(6)] [RED("fallbackSlots")] public CArray<entFallbackSlot> FallbackSlots { get; set; }

		public entSlotComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
