using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCombatModeTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("mode")] public CEnum<AIbehaviorCombatModes> Mode { get; set; }
		[Ordinal(2)] [RED("priority")] public CInt32 Priority { get; set; }
		[Ordinal(3)] [RED("timeToLive")] public CFloat TimeToLive { get; set; }

		public AIbehaviorCombatModeTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
