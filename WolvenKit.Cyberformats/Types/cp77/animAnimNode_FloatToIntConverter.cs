using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatToIntConverter : animAnimNode_IntValue
	{
		[Ordinal(11)] [RED("inputNode")] public animFloatLink InputNode { get; set; }

		public animAnimNode_FloatToIntConverter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
