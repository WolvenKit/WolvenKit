using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_FloatTrack : animIAnimNodeSourceChannel_Float
	{
		[Ordinal(0)] [RED("floatTrack")] public animNamedTrackIndex FloatTrack { get; set; }
		[Ordinal(1)] [RED("useComplementValue")] public CBool UseComplementValue { get; set; }

		public animAnimNodeSourceChannel_FloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
