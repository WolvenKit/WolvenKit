using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_EyesTracksLookAt : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("eyeTransform")] public animTransformIndex EyeTransform { get; set; }
		[Ordinal(13)] [RED("leftTrack")] public animNamedTrackIndex LeftTrack { get; set; }
		[Ordinal(14)] [RED("rightTrack")] public animNamedTrackIndex RightTrack { get; set; }
		[Ordinal(15)] [RED("upTrack")] public animNamedTrackIndex UpTrack { get; set; }
		[Ordinal(16)] [RED("downTrack")] public animNamedTrackIndex DownTrack { get; set; }
		[Ordinal(17)] [RED("debug")] public CBool Debug { get; set; }

		public animAnimNode_EyesTracksLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
