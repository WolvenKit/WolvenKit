using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OnWorkspotAvailabilityEvent : redEvent
	{
		[Ordinal(0)] [RED("workspotRef")] public NodeRef WorkspotRef { get; set; }

		public OnWorkspotAvailabilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
