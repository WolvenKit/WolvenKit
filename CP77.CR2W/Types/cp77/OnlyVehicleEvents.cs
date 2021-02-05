using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OnlyVehicleEvents : QuickSlotsReadyEvents
	{
		[Ordinal(0)]  [RED("shouldSendEvent")] public CBool ShouldSendEvent { get; set; }
		[Ordinal(1)]  [RED("timePressed")] public CFloat TimePressed { get; set; }

		public OnlyVehicleEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
