using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceTimetableEvent : redEvent
	{
		[Ordinal(0)]  [RED("requesterID")] public entEntityID RequesterID { get; set; }
		[Ordinal(1)]  [RED("restorePower")] public CBool RestorePower { get; set; }
		[Ordinal(2)]  [RED("state")] public CEnum<EDeviceStatus> State { get; set; }

		public DeviceTimetableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
