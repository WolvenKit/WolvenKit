using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSTwoBonesIKSolverData : CVariable
	{
		[Ordinal(0)]  [RED("Joint bend dir in joint's BS")] public Vector4 Joint_bend_dir_joint { get; set; }
		[Ordinal(1)]  [RED("Joint bend dir in lower's BS")] public Vector4 Joint_bend_dir_lower { get; set; }
		[Ordinal(2)]  [RED("Joint bend dir in upper's BS")] public Vector4 Joint_bend_dir_upper { get; set; }
		[Ordinal(3)]  [RED("Joint side dir in joint's BS")] public Vector4 Joint_side_dir_joint { get; set; }
		[Ordinal(4)]  [RED("Joint side dir in lower's BS")] public Vector4 Joint_side_dir_lower { get; set; }
		[Ordinal(5)]  [RED("Joint side dir in upper's BS")] public Vector4 Joint_side_dir_upper { get; set; }
		[Ordinal(6)]  [RED("Joint to-next dir in joint's BS")] public Vector4 Joint_next_dir_joint { get; set; }
		[Ordinal(7)]  [RED("Joint to-next dir in lower's BS")] public Vector4 Joint_next_dir_lower { get; set; }
		[Ordinal(8)]  [RED("Joint to-next dir in upper's BS")] public Vector4 Joint_next_dir_upper { get; set; }
		[Ordinal(9)]  [RED("allowToLock")] public CBool AllowToLock { get; set; }
		[Ordinal(10)]  [RED("autoSetupDirs")] public CBool AutoSetupDirs { get; set; }
		[Ordinal(11)]  [RED("ikBone")] public animTransformIndex IkBone { get; set; }
		[Ordinal(12)]  [RED("jointBone")] public animTransformIndex JointBone { get; set; }
		[Ordinal(13)]  [RED("jointSideWeightJoint")] public CFloat JointSideWeightJoint { get; set; }
		[Ordinal(14)]  [RED("jointSideWeightLower")] public CFloat JointSideWeightLower { get; set; }
		[Ordinal(15)]  [RED("jointSideWeightUpper")] public CFloat JointSideWeightUpper { get; set; }
		[Ordinal(16)]  [RED("limitToLengthPercentage")] public CFloat LimitToLengthPercentage { get; set; }
		[Ordinal(17)]  [RED("lowerBone")] public animTransformIndex LowerBone { get; set; }
		[Ordinal(18)]  [RED("reverseBend")] public CBool ReverseBend { get; set; }
		[Ordinal(19)]  [RED("subLowerBone")] public animTransformIndex SubLowerBone { get; set; }
		[Ordinal(20)]  [RED("upperBone")] public animTransformIndex UpperBone { get; set; }

		public animSTwoBonesIKSolverData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
