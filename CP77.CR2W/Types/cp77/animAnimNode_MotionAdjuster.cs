using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MotionAdjuster : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("inputNode")] public animPoseLink InputNode { get; set; }
		[Ordinal(1)]  [RED("targetPosition")] public animVectorLink TargetPosition { get; set; }
		[Ordinal(2)]  [RED("targetDirection")] public animVectorLink TargetDirection { get; set; }
		[Ordinal(3)]  [RED("totalTimeToAdjust")] public animFloatLink TotalTimeToAdjust { get; set; }
		[Ordinal(4)]  [RED("forwardVector")] public Vector4 ForwardVector { get; set; }

		public animAnimNode_MotionAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
