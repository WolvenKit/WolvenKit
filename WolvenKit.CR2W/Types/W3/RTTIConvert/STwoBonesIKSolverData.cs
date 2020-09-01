using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STwoBonesIKSolverData : CVariable
	{
		[Ordinal(0)] [RED("("upperBone")] 		public STwoBonesIKSolverBoneData UpperBone { get; set;}

		[Ordinal(0)] [RED("("jointBone")] 		public STwoBonesIKSolverBoneData JointBone { get; set;}

		[Ordinal(0)] [RED("("subLowerBone")] 		public STwoBonesIKSolverBoneData SubLowerBone { get; set;}

		[Ordinal(0)] [RED("("lowerBone")] 		public STwoBonesIKSolverBoneData LowerBone { get; set;}

		[Ordinal(0)] [RED("("ikBone")] 		public STwoBonesIKSolverBoneData IkBone { get; set;}

		[Ordinal(0)] [RED("("limitToLengthPercentage")] 		public CFloat LimitToLengthPercentage { get; set;}

		[Ordinal(0)] [RED("("reverseBend")] 		public CBool ReverseBend { get; set;}

		[Ordinal(0)] [RED("("allowToLock")] 		public CBool AllowToLock { get; set;}

		[Ordinal(0)] [RED("("autoSetupDirs")] 		public CBool AutoSetupDirs { get; set;}

		[Ordinal(0)] [RED("("jointSideWeightUpper")] 		public CFloat JointSideWeightUpper { get; set;}

		[Ordinal(0)] [RED("("jointSideWeightJoint")] 		public CFloat JointSideWeightJoint { get; set;}

		[Ordinal(0)] [RED("("jointSideWeightLower")] 		public CFloat JointSideWeightLower { get; set;}

		[Ordinal(0)] [RED("("Joint to-next dir in upper's BS")] 		public Vector Joint_to_next_dir_in_upper_s_BS { get; set;}

		[Ordinal(0)] [RED("("Joint to-next dir in joint's BS")] 		public Vector Joint_to_next_dir_in_joint_s_BS { get; set;}

		[Ordinal(0)] [RED("("Joint to-next dir in lower's BS")] 		public Vector Joint_to_next_dir_in_lower_s_BS { get; set;}

		[Ordinal(0)] [RED("("Joint side dir in upper's BS")] 		public Vector Joint_side_dir_in_upper_s_BS { get; set;}

		[Ordinal(0)] [RED("("Joint side dir in joint's BS")] 		public Vector Joint_side_dir_in_joint_s_BS { get; set;}

		[Ordinal(0)] [RED("("Joint side dir in lower's BS")] 		public Vector Joint_side_dir_in_lower_s_BS { get; set;}

		[Ordinal(0)] [RED("("Joint bend dir in upper's BS")] 		public Vector Joint_bend_dir_in_upper_s_BS { get; set;}

		[Ordinal(0)] [RED("("Joint bend dir in joint's BS")] 		public Vector Joint_bend_dir_in_joint_s_BS { get; set;}

		[Ordinal(0)] [RED("("Joint bend dir in lower's BS")] 		public Vector Joint_bend_dir_in_lower_s_BS { get; set;}

		public STwoBonesIKSolverData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STwoBonesIKSolverData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}