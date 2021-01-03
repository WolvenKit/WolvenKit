using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKCommonData : CVariable
	{
		[Ordinal(0)]  [RED("gravityCentreBone")] public animTransformIndex GravityCentreBone { get; set; }
		[Ordinal(1)]  [RED("rootRotationBlendTime")] public CFloat RootRotationBlendTime { get; set; }
		[Ordinal(2)]  [RED("slidingOnSlopeBlendTime")] public CFloat SlidingOnSlopeBlendTime { get; set; }
		[Ordinal(3)]  [RED("verticalVelocityOffsetDownBlendTime")] public CFloat VerticalVelocityOffsetDownBlendTime { get; set; }
		[Ordinal(4)]  [RED("verticalVelocityOffsetUpBlendTime")] public CFloat VerticalVelocityOffsetUpBlendTime { get; set; }

		public animSBehaviorConstraintNodeFloorIKCommonData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
