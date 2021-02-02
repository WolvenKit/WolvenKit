using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkFrameAnimByTrack : animAnimNode_SkFrameAnim
	{
		[Ordinal(0)]  [RED("progressFloatTrack")] public animNamedTrackIndex ProgressFloatTrack { get; set; }
		[Ordinal(1)]  [RED("timeFloatTrack")] public animNamedTrackIndex TimeFloatTrack { get; set; }
		[Ordinal(2)]  [RED("frameFloatTrack")] public animNamedTrackIndex FrameFloatTrack { get; set; }
		[Ordinal(3)]  [RED("inputWithTracks")] public animPoseLink InputWithTracks { get; set; }

		public animAnimNode_SkFrameAnimByTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
