using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleStartedUnmountingEvent : redEvent
	{
		[Ordinal(0)]  [RED("character")] public wCHandle<gameObject> Character { get; set; }
		[Ordinal(1)]  [RED("isMounting")] public CBool IsMounting { get; set; }
		[Ordinal(2)]  [RED("slotID")] public CName SlotID { get; set; }

		public VehicleStartedUnmountingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
