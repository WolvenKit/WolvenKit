using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleStartedMountingEvent : redEvent
	{
		[Ordinal(0)]  [RED("slotID")] public CName SlotID { get; set; }
		[Ordinal(1)]  [RED("isMounting")] public CBool IsMounting { get; set; }
		[Ordinal(2)]  [RED("character")] public wCHandle<gameObject> Character { get; set; }
		[Ordinal(3)]  [RED("instant")] public CBool Instant { get; set; }
		[Ordinal(4)]  [RED("silent")] public CBool Silent { get; set; }

		public vehicleStartedMountingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
