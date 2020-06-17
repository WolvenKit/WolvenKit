using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STwoBonesIKSolverData : CVariable
	{
		[RED("upperBone")] 		public STwoBonesIKSolverBoneData UpperBone { get; set;}

		[RED("jointBone")] 		public STwoBonesIKSolverBoneData JointBone { get; set;}

		[RED("subLowerBone")] 		public STwoBonesIKSolverBoneData SubLowerBone { get; set;}

		[RED("lowerBone")] 		public STwoBonesIKSolverBoneData LowerBone { get; set;}

		[RED("ikBone")] 		public STwoBonesIKSolverBoneData IkBone { get; set;}

		[RED("limitToLengthPercentage")] 		public CFloat LimitToLengthPercentage { get; set;}

		[RED("reverseBend")] 		public CBool ReverseBend { get; set;}

		[RED("allowToLock")] 		public CBool AllowToLock { get; set;}

		[RED("autoSetupDirs")] 		public CBool AutoSetupDirs { get; set;}

		[RED("jointSideWeightUpper")] 		public CFloat JointSideWeightUpper { get; set;}

		[RED("jointSideWeightJoint")] 		public CFloat JointSideWeightJoint { get; set;}

		[RED("jointSideWeightLower")] 		public CFloat JointSideWeightLower { get; set;}

		[RED("Joint to-next dir in upper's BS")] 		public Vector Joint_to_next_dir_in_upper_s_BS { get; set;}

		[RED("Joint to-next dir in joint's BS")] 		public Vector Joint_to_next_dir_in_joint_s_BS { get; set;}

		[RED("Joint to-next dir in lower's BS")] 		public Vector Joint_to_next_dir_in_lower_s_BS { get; set;}

		[RED("Joint side dir in upper's BS")] 		public Vector Joint_side_dir_in_upper_s_BS { get; set;}

		[RED("Joint side dir in joint's BS")] 		public Vector Joint_side_dir_in_joint_s_BS { get; set;}

		[RED("Joint side dir in lower's BS")] 		public Vector Joint_side_dir_in_lower_s_BS { get; set;}

		[RED("Joint bend dir in upper's BS")] 		public Vector Joint_bend_dir_in_upper_s_BS { get; set;}

		[RED("Joint bend dir in joint's BS")] 		public Vector Joint_bend_dir_in_joint_s_BS { get; set;}

		[RED("Joint bend dir in lower's BS")] 		public Vector Joint_bend_dir_in_lower_s_BS { get; set;}

		public STwoBonesIKSolverData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new STwoBonesIKSolverData(cr2w);

	}
}