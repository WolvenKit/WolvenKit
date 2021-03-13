using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DelayedTimetableEvent : redEvent
	{
		[Ordinal(0)] [RED("eventToForward")] public CHandle<DeviceTimetableEvent> EventToForward { get; set; }
		[Ordinal(1)] [RED("targetPS")] public wCHandle<ScriptableDeviceComponentPS> TargetPS { get; set; }

		public DelayedTimetableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
