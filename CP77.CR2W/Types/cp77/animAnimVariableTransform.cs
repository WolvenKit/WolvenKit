using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableTransform : animAnimVariable
	{
		[Ordinal(2)] [RED("value")] public QsTransform Value { get; set; }
		[Ordinal(3)] [RED("default")] public QsTransform Default { get; set; }

		public animAnimVariableTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
