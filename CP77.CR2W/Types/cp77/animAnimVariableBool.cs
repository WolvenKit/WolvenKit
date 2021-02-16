using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableBool : animAnimVariable
	{
		[Ordinal(1)] [RED("value")] public CBool Value { get; set; }
		[Ordinal(2)] [RED("default")] public CBool Default { get; set; }

		public animAnimVariableBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
