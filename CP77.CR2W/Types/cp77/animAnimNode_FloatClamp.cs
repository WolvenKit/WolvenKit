using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatClamp : animAnimNode_FloatValue
	{
		[Ordinal(1)] [RED("min")] public CFloat Min { get; set; }
		[Ordinal(2)] [RED("max")] public CFloat Max { get; set; }
		[Ordinal(3)] [RED("inputNode")] public animFloatLink InputNode { get; set; }

		public animAnimNode_FloatClamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
