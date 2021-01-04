using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ReleaseWorkSpotTask : WorkSpotTask
	{
		[Ordinal(0)]  [RED("workspotObject")] public wCHandle<gameObject> WorkspotObject { get; set; }
		[Ordinal(1)]  [RED("workspotRef")] public NodeRef WorkspotRef { get; set; }

		public ReleaseWorkSpotTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
