using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendFromPose_ : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(13)] [RED("blendType")] public CEnum<animEBlendTypeLBC> BlendType { get; set; }
		[Ordinal(14)] [RED("customBlendCurve")] public curveData<CFloat> CustomBlendCurve { get; set; }
		[Ordinal(15)] [RED("mode")] public CEnum<animEBlendFromPoseMode> Mode { get; set; }
		[Ordinal(16)] [RED("requestedByTag")] public CName RequestedByTag { get; set; }

		public animAnimNode_BlendFromPose_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
