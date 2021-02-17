using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConvertToDynamicWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
		[Ordinal(2)] [RED("spotInstance")] public CHandle<AIArgumentMapping> SpotInstance { get; set; }
		[Ordinal(3)] [RED("jumpToEntry")] public CHandle<AIArgumentMapping> JumpToEntry { get; set; }
		[Ordinal(4)] [RED("entryId")] public CHandle<AIArgumentMapping> EntryId { get; set; }

		public AIbehaviorConvertToDynamicWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
