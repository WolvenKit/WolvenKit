using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetTrackRange : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("min")] public CFloat Min { get; set; }
		[Ordinal(13)] [RED("max")] public CFloat Max { get; set; }
		[Ordinal(14)] [RED("oldMin")] public CFloat OldMin { get; set; }
		[Ordinal(15)] [RED("oldMax")] public CFloat OldMax { get; set; }
		[Ordinal(16)] [RED("minLink")] public animFloatLink MinLink { get; set; }
		[Ordinal(17)] [RED("maxLink")] public animFloatLink MaxLink { get; set; }
		[Ordinal(18)] [RED("oldMinLink")] public animFloatLink OldMinLink { get; set; }
		[Ordinal(19)] [RED("oldMaxLink")] public animFloatLink OldMaxLink { get; set; }
		[Ordinal(20)] [RED("track")] public animNamedTrackIndex Track { get; set; }
		[Ordinal(21)] [RED("debug")] public CBool Debug { get; set; }

		public animAnimNode_SetTrackRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
