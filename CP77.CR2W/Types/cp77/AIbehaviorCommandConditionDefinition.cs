using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCommandConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("commandName")] public CHandle<AIArgumentMapping> CommandName { get; set; }
		[Ordinal(1)]  [RED("useInheritance")] public CBool UseInheritance { get; set; }
		[Ordinal(2)]  [RED("isWaiting")] public CBool IsWaiting { get; set; }
		[Ordinal(3)]  [RED("isExecuting")] public CBool IsExecuting { get; set; }
		[Ordinal(4)]  [RED("commandOut")] public CHandle<AIArgumentMapping> CommandOut { get; set; }

		public AIbehaviorCommandConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
