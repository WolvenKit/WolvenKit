using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleWheelEvents : QuickSlotsHoldEvents
	{
		[Ordinal(0)]  [RED("holdDirection")] public CEnum<EDPadSlot> HoldDirection { get; set; }

		public VehicleWheelEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
