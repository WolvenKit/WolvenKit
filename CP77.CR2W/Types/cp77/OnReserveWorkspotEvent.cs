using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OnReserveWorkspotEvent : OnWorkspotAvailabilityEvent
	{
		[Ordinal(1)] [RED("action")] public CEnum<gamedataWorkspotActionType> Action { get; set; }

		public OnReserveWorkspotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
