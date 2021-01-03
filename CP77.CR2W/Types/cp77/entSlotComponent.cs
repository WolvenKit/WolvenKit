using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entSlotComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("fallbackSlots")] public CArray<entFallbackSlot> FallbackSlots { get; set; }
		[Ordinal(1)]  [RED("slots")] public CArray<entSlot> Slots { get; set; }

		public entSlotComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
