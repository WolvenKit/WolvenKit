using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConvertCommandToDynamicWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
		[Ordinal(2)] [RED("outWorkspotData")] public CHandle<AIArgumentMapping> OutWorkspotData { get; set; }

		public AIbehaviorConvertCommandToDynamicWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
