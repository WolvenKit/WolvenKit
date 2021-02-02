using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetTrackRange : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("minLink")] public animFloatLink MinLink { get; set; }
		[Ordinal(1)]  [RED("maxLink")] public animFloatLink MaxLink { get; set; }
		[Ordinal(2)]  [RED("oldMinLink")] public animFloatLink OldMinLink { get; set; }
		[Ordinal(3)]  [RED("oldMaxLink")] public animFloatLink OldMaxLink { get; set; }
		[Ordinal(4)]  [RED("min")] public CFloat Min { get; set; }
		[Ordinal(5)]  [RED("max")] public CFloat Max { get; set; }
		[Ordinal(6)]  [RED("oldMin")] public CFloat OldMin { get; set; }
		[Ordinal(7)]  [RED("oldMax")] public CFloat OldMax { get; set; }
		[Ordinal(8)]  [RED("track")] public animNamedTrackIndex Track { get; set; }
		[Ordinal(9)]  [RED("debug")] public CBool Debug { get; set; }

		public animAnimNode_SetTrackRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
