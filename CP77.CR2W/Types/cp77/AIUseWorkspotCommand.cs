using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIUseWorkspotCommand : AIBaseUseWorkspotCommand
	{
		[Ordinal(0)]  [RED("entryId")] public workWorkEntryId EntryId { get; set; }
		[Ordinal(1)]  [RED("entryTag")] public CName EntryTag { get; set; }
		[Ordinal(2)]  [RED("jumpToEntry")] public CBool JumpToEntry { get; set; }
		[Ordinal(3)]  [RED("workspotNode")] public NodeRef WorkspotNode { get; set; }

		public AIUseWorkspotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
