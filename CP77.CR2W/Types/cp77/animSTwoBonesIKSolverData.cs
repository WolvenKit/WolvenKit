using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSTwoBonesIKSolverData : CVariable
	{
		[Ordinal(0)]  [RED("Joint_to_next_dir_in_upper_s_BS")] public Vector4 Joint_to_next_dir_in_upper_s_BS { get; set; }
		[Ordinal(1)]  [RED("Joint_to_next_dir_in_joint_s_BS")] public Vector4 Joint_to_next_dir_in_joint_s_BS { get; set; }
		[Ordinal(2)]  [RED("Joint_to_next_dir_in_lower_s_BS")] public Vector4 Joint_to_next_dir_in_lower_s_BS { get; set; }
		[Ordinal(3)]  [RED("Joint_side_dir_in_upper_s_BS")] public Vector4 Joint_side_dir_in_upper_s_BS { get; set; }
		[Ordinal(4)]  [RED("Joint_side_dir_in_joint_s_BS")] public Vector4 Joint_side_dir_in_joint_s_BS { get; set; }
		[Ordinal(5)]  [RED("Joint_side_dir_in_lower_s_BS")] public Vector4 Joint_side_dir_in_lower_s_BS { get; set; }
		[Ordinal(6)]  [RED("Joint_bend_dir_in_upper_s_BS")] public Vector4 Joint_bend_dir_in_upper_s_BS { get; set; }
		[Ordinal(7)]  [RED("Joint_bend_dir_in_joint_s_BS")] public Vector4 Joint_bend_dir_in_joint_s_BS { get; set; }
		[Ordinal(8)]  [RED("Joint_bend_dir_in_lower_s_BS")] public Vector4 Joint_bend_dir_in_lower_s_BS { get; set; }
		[Ordinal(9)]  [RED("upperBone")] public animTransformIndex UpperBone { get; set; }
		[Ordinal(10)]  [RED("jointBone")] public animTransformIndex JointBone { get; set; }
		[Ordinal(11)]  [RED("subLowerBone")] public animTransformIndex SubLowerBone { get; set; }
		[Ordinal(12)]  [RED("lowerBone")] public animTransformIndex LowerBone { get; set; }
		[Ordinal(13)]  [RED("ikBone")] public animTransformIndex IkBone { get; set; }
		[Ordinal(14)]  [RED("limitToLengthPercentage")] public CFloat LimitToLengthPercentage { get; set; }
		[Ordinal(15)]  [RED("reverseBend")] public CBool ReverseBend { get; set; }
		[Ordinal(16)]  [RED("allowToLock")] public CBool AllowToLock { get; set; }
		[Ordinal(17)]  [RED("autoSetupDirs")] public CBool AutoSetupDirs { get; set; }
		[Ordinal(18)]  [RED("jointSideWeightUpper")] public CFloat JointSideWeightUpper { get; set; }
		[Ordinal(19)]  [RED("jointSideWeightJoint")] public CFloat JointSideWeightJoint { get; set; }
		[Ordinal(20)]  [RED("jointSideWeightLower")] public CFloat JointSideWeightLower { get; set; }

		public animSTwoBonesIKSolverData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
