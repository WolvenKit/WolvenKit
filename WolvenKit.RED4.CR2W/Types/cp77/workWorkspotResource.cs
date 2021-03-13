using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotResource : animAnimGraph
	{
		[Ordinal(16)] [RED("workspotTree")] public CHandle<workWorkspotTree> WorkspotTree { get; set; }

		public workWorkspotResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
