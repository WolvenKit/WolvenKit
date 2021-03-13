using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkDurationAnim : animAnimNode_SkAnim
	{
		[Ordinal(30)] [RED("Duration")] public animFloatLink Duration { get; set; }

		public animAnimNode_SkDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
