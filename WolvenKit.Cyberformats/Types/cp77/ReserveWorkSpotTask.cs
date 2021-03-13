using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ReserveWorkSpotTask : WorkSpotTask
	{
		[Ordinal(0)] [RED("workspotRef")] public NodeRef WorkspotRef { get; set; }
		[Ordinal(1)] [RED("workspotObject")] public wCHandle<gameObject> WorkspotObject { get; set; }

		public ReserveWorkSpotTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
