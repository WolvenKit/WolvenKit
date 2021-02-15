using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerCombatInterruptCondition : scnIInterruptCondition
	{
		[Ordinal(0)] [RED("params")] public scnCheckPlayerCombatInterruptConditionParams Params { get; set; }

		public scnCheckPlayerCombatInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
