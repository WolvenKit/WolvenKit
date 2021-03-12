using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatConstant : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("value")] public CFloat Value { get; set; }

		public animAnimNode_FloatConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
