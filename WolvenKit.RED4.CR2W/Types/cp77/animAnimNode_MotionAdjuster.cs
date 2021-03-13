using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MotionAdjuster : animAnimNode_Base
	{
		[Ordinal(11)] [RED("inputNode")] public animPoseLink InputNode { get; set; }
		[Ordinal(12)] [RED("targetPosition")] public animVectorLink TargetPosition { get; set; }
		[Ordinal(13)] [RED("targetDirection")] public animVectorLink TargetDirection { get; set; }
		[Ordinal(14)] [RED("totalTimeToAdjust")] public animFloatLink TotalTimeToAdjust { get; set; }
		[Ordinal(15)] [RED("forwardVector")] public Vector4 ForwardVector { get; set; }

		public animAnimNode_MotionAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
