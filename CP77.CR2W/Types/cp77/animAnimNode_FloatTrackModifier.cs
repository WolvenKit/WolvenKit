using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTrackModifier : animAnimNode_Base
	{
		[Ordinal(1)] [RED("floatTrack")] public animNamedTrackIndex FloatTrack { get; set; }
		[Ordinal(2)] [RED("operationType")] public CEnum<animFloatTrackOperationType> OperationType { get; set; }
		[Ordinal(3)] [RED("inputFloatTrack")] public animNamedTrackIndex InputFloatTrack { get; set; }
		[Ordinal(4)] [RED("poseInputNode")] public animPoseLink PoseInputNode { get; set; }
		[Ordinal(5)] [RED("floatInputNode")] public animFloatLink FloatInputNode { get; set; }

		public animAnimNode_FloatTrackModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
