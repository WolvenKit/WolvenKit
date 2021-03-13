using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTrackModifier : animAnimNode_Base
	{
		[Ordinal(11)] [RED("floatTrack")] public animNamedTrackIndex FloatTrack { get; set; }
		[Ordinal(12)] [RED("operationType")] public CEnum<animFloatTrackOperationType> OperationType { get; set; }
		[Ordinal(13)] [RED("inputFloatTrack")] public animNamedTrackIndex InputFloatTrack { get; set; }
		[Ordinal(14)] [RED("poseInputNode")] public animPoseLink PoseInputNode { get; set; }
		[Ordinal(15)] [RED("floatInputNode")] public animFloatLink FloatInputNode { get; set; }

		public animAnimNode_FloatTrackModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
