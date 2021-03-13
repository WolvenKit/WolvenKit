using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatRandom : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("rand")] public CBool Rand { get; set; }
		[Ordinal(12)] [RED("cooldown")] public CFloat Cooldown { get; set; }
		[Ordinal(13)] [RED("min")] public CFloat Min { get; set; }
		[Ordinal(14)] [RED("max")] public CFloat Max { get; set; }

		public animAnimNode_FloatRandom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
