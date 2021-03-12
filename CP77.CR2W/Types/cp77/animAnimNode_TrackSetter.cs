using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TrackSetter : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("track")] public animNamedTrackIndex Track { get; set; }
		[Ordinal(13)] [RED("value")] public animFloatLink Value { get; set; }

		public animAnimNode_TrackSetter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
