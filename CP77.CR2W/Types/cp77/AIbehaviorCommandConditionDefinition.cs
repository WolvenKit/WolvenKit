using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCommandConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("commandName")] public CHandle<AIArgumentMapping> CommandName { get; set; }
		[Ordinal(1)]  [RED("commandOut")] public CHandle<AIArgumentMapping> CommandOut { get; set; }
		[Ordinal(2)]  [RED("isExecuting")] public CBool IsExecuting { get; set; }
		[Ordinal(3)]  [RED("isWaiting")] public CBool IsWaiting { get; set; }
		[Ordinal(4)]  [RED("useInheritance")] public CBool UseInheritance { get; set; }

		public AIbehaviorCommandConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
