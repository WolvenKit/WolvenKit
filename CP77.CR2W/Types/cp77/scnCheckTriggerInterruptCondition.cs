using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnCheckTriggerInterruptCondition : scnIInterruptCondition
	{
		[Ordinal(0)] [RED("params")] public scnCheckTriggerInterruptConditionParams Params { get; set; }

		public scnCheckTriggerInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
