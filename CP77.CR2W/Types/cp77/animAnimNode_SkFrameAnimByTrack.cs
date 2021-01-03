using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkFrameAnimByTrack : animAnimNode_SkFrameAnim
	{
		[Ordinal(0)]  [RED("frameFloatTrack")] public animNamedTrackIndex FrameFloatTrack { get; set; }
		[Ordinal(1)]  [RED("inputWithTracks")] public animPoseLink InputWithTracks { get; set; }
		[Ordinal(2)]  [RED("progressFloatTrack")] public animNamedTrackIndex ProgressFloatTrack { get; set; }
		[Ordinal(3)]  [RED("timeFloatTrack")] public animNamedTrackIndex TimeFloatTrack { get; set; }

		public animAnimNode_SkFrameAnimByTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
