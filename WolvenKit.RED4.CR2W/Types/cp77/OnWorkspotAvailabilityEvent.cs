using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnWorkspotAvailabilityEvent : redEvent
	{
		[Ordinal(0)] [RED("workspotRef")] public NodeRef WorkspotRef { get; set; }

		public OnWorkspotAvailabilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
