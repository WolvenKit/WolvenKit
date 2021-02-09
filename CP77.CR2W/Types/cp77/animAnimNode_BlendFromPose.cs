using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendFromPose : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(1)]  [RED("blendType")] public CEnum<animEBlendTypeLBC> BlendType { get; set; }
		[Ordinal(2)]  [RED("customBlendCurve")] public curveData<CFloat> CustomBlendCurve { get; set; }
		[Ordinal(3)]  [RED("mode")] public CEnum<animEBlendFromPoseMode> Mode { get; set; }
		[Ordinal(4)]  [RED("requestedByTag")] public CName RequestedByTag { get; set; }

        [Ordinal(998)] [RED("debug")] public CBool debug { get; set; }

		public animAnimNode_BlendFromPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
