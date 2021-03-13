using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnCheckDistractedReturnCondition : scnIReturnCondition
	{
		[Ordinal(0)] [RED("params")] public scnCheckDistractedReturnConditionParams Params { get; set; }

		public scnCheckDistractedReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
