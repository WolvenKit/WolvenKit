using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCommandConditionExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)]  [RED("commandName")] public CName CommandName { get; set; }
		[Ordinal(1)]  [RED("isEnqueued")] public CBool IsEnqueued { get; set; }
		[Ordinal(2)]  [RED("isExecuting")] public CBool IsExecuting { get; set; }
		[Ordinal(3)]  [RED("useInheritance")] public CBool UseInheritance { get; set; }

		public AIbehaviorCommandConditionExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
