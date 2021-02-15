using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animPoseInfoLoggerEntry_FloatTrack : animPoseInfoLoggerEntry
	{
		[Ordinal(0)] [RED("floatTrack")] public animNamedTrackIndex FloatTrack { get; set; }
		[Ordinal(1)] [RED("showOnlyWhenPositive")] public CBool ShowOnlyWhenPositive { get; set; }

		public animPoseInfoLoggerEntry_FloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
