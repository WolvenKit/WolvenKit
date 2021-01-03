using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleSeatReservationEvent : redEvent
	{
		[Ordinal(0)]  [RED("reserve")] public CBool Reserve { get; set; }
		[Ordinal(1)]  [RED("slotID")] public CName SlotID { get; set; }

		public VehicleSeatReservationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
