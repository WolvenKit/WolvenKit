using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questUseWorkspotCommandParams : questAICommandParams
	{
		[Ordinal(0)] [RED("workspotNode")] public NodeRef WorkspotNode { get; set; }
		[Ordinal(1)] [RED("moveToWorkspot")] public CBool MoveToWorkspot { get; set; }
		[Ordinal(2)] [RED("forceEntryAnimName")] public CName ForceEntryAnimName { get; set; }

		public questUseWorkspotCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
