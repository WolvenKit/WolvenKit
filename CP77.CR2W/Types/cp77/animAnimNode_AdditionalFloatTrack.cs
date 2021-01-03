using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AdditionalFloatTrack : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("additionalTracks")] public animAdditionalFloatTrackContainer AdditionalTracks { get; set; }
		[Ordinal(1)]  [RED("poseInputNode")] public animPoseLink PoseInputNode { get; set; }

		public animAnimNode_AdditionalFloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
