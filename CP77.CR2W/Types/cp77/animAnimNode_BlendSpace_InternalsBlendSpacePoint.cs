using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendSpace_InternalsBlendSpacePoint : CVariable
	{
		[Ordinal(0)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)]  [RED("fixedCoordinates")] public CArray<CFloat> FixedCoordinates { get; set; }
		[Ordinal(2)]  [RED("staticPoseProgress")] public CFloat StaticPoseProgress { get; set; }
		[Ordinal(3)]  [RED("staticPoseTime")] public CFloat StaticPoseTime { get; set; }
		[Ordinal(4)]  [RED("useFixedCoordinates")] public CBool UseFixedCoordinates { get; set; }
		[Ordinal(5)]  [RED("useStaticPose")] public CBool UseStaticPose { get; set; }

		public animAnimNode_BlendSpace_InternalsBlendSpacePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
