using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKCommonData : CVariable
	{
		[Ordinal(0)] [RED("gravityCentreBone")] public animTransformIndex GravityCentreBone { get; set; }
		[Ordinal(1)] [RED("rootRotationBlendTime")] public CFloat RootRotationBlendTime { get; set; }
		[Ordinal(2)] [RED("verticalVelocityOffsetUpBlendTime")] public CFloat VerticalVelocityOffsetUpBlendTime { get; set; }
		[Ordinal(3)] [RED("verticalVelocityOffsetDownBlendTime")] public CFloat VerticalVelocityOffsetDownBlendTime { get; set; }
		[Ordinal(4)] [RED("slidingOnSlopeBlendTime")] public CFloat SlidingOnSlopeBlendTime { get; set; }

		public animSBehaviorConstraintNodeFloorIKCommonData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
