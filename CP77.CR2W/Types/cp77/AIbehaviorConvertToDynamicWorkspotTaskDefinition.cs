using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConvertToDynamicWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("entryId")] public CHandle<AIArgumentMapping> EntryId { get; set; }
		[Ordinal(1)]  [RED("jumpToEntry")] public CHandle<AIArgumentMapping> JumpToEntry { get; set; }
		[Ordinal(2)]  [RED("spotInstance")] public CHandle<AIArgumentMapping> SpotInstance { get; set; }
		[Ordinal(3)]  [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }

		public AIbehaviorConvertToDynamicWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
