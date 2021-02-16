using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerTargetEntityDistanceInterruptCondition : scnIInterruptCondition
	{
		[Ordinal(0)] [RED("params")] public scnCheckPlayerTargetEntityDistanceInterruptConditionParams Params { get; set; }

		public scnCheckPlayerTargetEntityDistanceInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
