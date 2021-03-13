using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIUseWorkspotCommand : AIBaseUseWorkspotCommand
	{
		[Ordinal(11)] [RED("workspotNode")] public NodeRef WorkspotNode { get; set; }
		[Ordinal(12)] [RED("jumpToEntry")] public CBool JumpToEntry { get; set; }
		[Ordinal(13)] [RED("entryId")] public workWorkEntryId EntryId { get; set; }
		[Ordinal(14)] [RED("entryTag")] public CName EntryTag { get; set; }

		public AIUseWorkspotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
