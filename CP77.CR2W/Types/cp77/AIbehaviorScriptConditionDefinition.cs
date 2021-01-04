using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorScriptConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("disableLazyInitialization")] public CBool DisableLazyInitialization { get; set; }
		[Ordinal(1)]  [RED("script")] public CHandle<AIbehaviorconditionScript> Script { get; set; }

		public AIbehaviorScriptConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
