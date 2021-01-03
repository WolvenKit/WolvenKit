using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTrackModifier : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("floatInputNode")] public animFloatLink FloatInputNode { get; set; }
		[Ordinal(1)]  [RED("floatTrack")] public animNamedTrackIndex FloatTrack { get; set; }
		[Ordinal(2)]  [RED("inputFloatTrack")] public animNamedTrackIndex InputFloatTrack { get; set; }
		[Ordinal(3)]  [RED("operationType")] public CEnum<animFloatTrackOperationType> OperationType { get; set; }
		[Ordinal(4)]  [RED("poseInputNode")] public animPoseLink PoseInputNode { get; set; }

		public animAnimNode_FloatTrackModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
