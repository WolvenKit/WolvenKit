using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorScriptTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("script")] public CHandle<AIbehaviortaskScript> Script { get; set; }
		[Ordinal(1)]  [RED("disableLazyInitialization")] public CBool DisableLazyInitialization { get; set; }

		public AIbehaviorScriptTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
