using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFSMEventTransitionsListDefinition : CVariable
	{
		[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(1)] [RED("transitions")] public AIFSMTransitionListDefinition Transitions { get; set; }

		public AIFSMEventTransitionsListDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
