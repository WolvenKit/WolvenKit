using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workWorkspotResource : animAnimGraph
	{
		[Ordinal(16)] [RED("workspotTree")] public CHandle<workWorkspotTree> WorkspotTree { get; set; }

		public workWorkspotResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
