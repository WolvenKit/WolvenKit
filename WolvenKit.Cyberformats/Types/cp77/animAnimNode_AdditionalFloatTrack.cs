using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AdditionalFloatTrack : animAnimNode_Base
	{
		[Ordinal(11)] [RED("poseInputNode")] public animPoseLink PoseInputNode { get; set; }
		[Ordinal(12)] [RED("additionalTracks")] public animAdditionalFloatTrackContainer AdditionalTracks { get; set; }

		public animAnimNode_AdditionalFloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
