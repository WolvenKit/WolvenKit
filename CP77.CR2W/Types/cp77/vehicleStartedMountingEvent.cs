using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleStartedMountingEvent : redEvent
	{
		[Ordinal(0)]  [RED("character")] public wCHandle<gameObject> Character { get; set; }
		[Ordinal(1)]  [RED("instant")] public CBool Instant { get; set; }
		[Ordinal(2)]  [RED("isMounting")] public CBool IsMounting { get; set; }
		[Ordinal(3)]  [RED("silent")] public CBool Silent { get; set; }
		[Ordinal(4)]  [RED("slotID")] public CName SlotID { get; set; }

		public vehicleStartedMountingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
