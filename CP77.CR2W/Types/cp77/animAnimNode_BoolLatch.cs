using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BoolLatch : animAnimNode_BoolValue
	{
		[Ordinal(1)] [RED("input")] public animBoolLink Input { get; set; }

		public animAnimNode_BoolLatch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
