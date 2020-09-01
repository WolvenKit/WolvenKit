using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STwoBonesIKSolverData : CVariable
	{
		[Ordinal(1)] [RED("upperBone")] 		public STwoBonesIKSolverBoneData UpperBone { get; set;}

		[Ordinal(2)] [RED("jointBone")] 		public STwoBonesIKSolverBoneData JointBone { get; set;}

		[Ordinal(3)] [RED("subLowerBone")] 		public STwoBonesIKSolverBoneData SubLowerBone { get; set;}

		[Ordinal(4)] [RED("lowerBone")] 		public STwoBonesIKSolverBoneData LowerBone { get; set;}

		[Ordinal(5)] [RED("ikBone")] 		public STwoBonesIKSolverBoneData IkBone { get; set;}

		[Ordinal(6)] [RED("limitToLengthPercentage")] 		public CFloat LimitToLengthPercentage { get; set;}

		[Ordinal(7)] [RED("reverseBend")] 		public CBool ReverseBend { get; set;}

		[Ordinal(8)] [RED("allowToLock")] 		public CBool AllowToLock { get; set;}

		[Ordinal(9)] [RED("autoSetupDirs")] 		public CBool AutoSetupDirs { get; set;}

		[Ordinal(10)] [RED("jointSideWeightUpper")] 		public CFloat JointSideWeightUpper { get; set;}

		[Ordinal(11)] [RED("jointSideWeightJoint")] 		public CFloat JointSideWeightJoint { get; set;}

		[Ordinal(12)] [RED("jointSideWeightLower")] 		public CFloat JointSideWeightLower { get; set;}

		[Ordinal(13)] [RED("Joint to-next dir in upper's BS")] 		public Vector Joint_to_next_dir_in_upper_s_BS { get; set;}

		[Ordinal(14)] [RED("Joint to-next dir in joint's BS")] 		public Vector Joint_to_next_dir_in_joint_s_BS { get; set;}

		[Ordinal(15)] [RED("Joint to-next dir in lower's BS")] 		public Vector Joint_to_next_dir_in_lower_s_BS { get; set;}

		[Ordinal(16)] [RED("Joint side dir in upper's BS")] 		public Vector Joint_side_dir_in_upper_s_BS { get; set;}

		[Ordinal(17)] [RED("Joint side dir in joint's BS")] 		public Vector Joint_side_dir_in_joint_s_BS { get; set;}

		[Ordinal(18)] [RED("Joint side dir in lower's BS")] 		public Vector Joint_side_dir_in_lower_s_BS { get; set;}

		[Ordinal(19)] [RED("Joint bend dir in upper's BS")] 		public Vector Joint_bend_dir_in_upper_s_BS { get; set;}

		[Ordinal(20)] [RED("Joint bend dir in joint's BS")] 		public Vector Joint_bend_dir_in_joint_s_BS { get; set;}

		[Ordinal(21)] [RED("Joint bend dir in lower's BS")] 		public Vector Joint_bend_dir_in_lower_s_BS { get; set;}

		public STwoBonesIKSolverData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STwoBonesIKSolverData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}