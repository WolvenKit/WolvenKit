using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloorIk : animAnimNode_FloorIkBase
	{
		[Ordinal(18)] 
		[RED("pelvis")] 
		public animSBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis
		{
			get => GetPropertyValue<animSBehaviorConstraintNodeFloorIKVerticalBoneData>();
			set => SetPropertyValue<animSBehaviorConstraintNodeFloorIKVerticalBoneData>(value);
		}

		[Ordinal(19)] 
		[RED("legs")] 
		public animSBehaviorConstraintNodeFloorIKLegsData Legs
		{
			get => GetPropertyValue<animSBehaviorConstraintNodeFloorIKLegsData>();
			set => SetPropertyValue<animSBehaviorConstraintNodeFloorIKLegsData>(value);
		}

		[Ordinal(20)] 
		[RED("leftLegIK")] 
		public animSTwoBonesIKSolverData LeftLegIK
		{
			get => GetPropertyValue<animSTwoBonesIKSolverData>();
			set => SetPropertyValue<animSTwoBonesIKSolverData>(value);
		}

		[Ordinal(21)] 
		[RED("rightLegIK")] 
		public animSTwoBonesIKSolverData RightLegIK
		{
			get => GetPropertyValue<animSTwoBonesIKSolverData>();
			set => SetPropertyValue<animSTwoBonesIKSolverData>(value);
		}

		public animAnimNode_FloorIk()
		{
			CanBeDisabledDueToFrameRate = true;
			Common = new() { GravityCentreBone = new() { Name = "Hips" }, RootRotationBlendTime = 0.200000F, VerticalVelocityOffsetUpBlendTime = 0.100000F, VerticalVelocityOffsetDownBlendTime = 0.080000F, SlidingOnSlopeBlendTime = 0.200000F };
			Pelvis = new() { Bone = new() { Name = "Hips" }, Min_offset = -0.500000F, Max_offset = 0.500000F, OffsetToDesiredBlendTime = 0.100000F, VerticalOffsetBlendTime = 0.050000F, Stiffness = 1.000000F };
			Legs = new() { Max_rel_offset = 0.500000F, Min_trace_offset = -1.500000F, Max_trace_offset = 1.500000F, VerticalOffsetBlendUpTime = 0.080000F, VerticalOffsetBlendDownTime = 0.030000F, Max_distance_for_trace_update = 0.020000F, Max_angle_from_upright_normal = 45.000000F, Max_angle_from_upright_normal_to_side = 15.000000F, Max_angle_from_upright_normal_to_revert_orientation = 70.000000F };
			LeftLegIK = new() { UpperBone = new() { Name = "LeftUpLeg" }, JointBone = new() { Name = "LeftLeg" }, SubLowerBone = new(), LowerBone = new() { Name = "LeftFoot" }, IkBone = new(), LimitToLengthPercentage = 0.990000F, AutoSetupDirs = true, JointSideWeightUpper = 0.500000F, JointSideWeightJoint = 0.300000F, JointSideWeightLower = 0.200000F, Joint_to_next_dir_in_upper_s_BS = new() { X = 1.000000F }, Joint_to_next_dir_in_joint_s_BS = new() { X = 1.000000F }, Joint_to_next_dir_in_lower_s_BS = new() { X = 1.000000F }, Joint_side_dir_in_upper_s_BS = new() { Z = 1.000000F }, Joint_side_dir_in_joint_s_BS = new() { Z = 1.000000F }, Joint_side_dir_in_lower_s_BS = new() { Z = 1.000000F }, Joint_bend_dir_in_upper_s_BS = new() { Y = 1.000000F }, Joint_bend_dir_in_joint_s_BS = new() { Y = 1.000000F }, Joint_bend_dir_in_lower_s_BS = new() { Y = 1.000000F } };
			RightLegIK = new() { UpperBone = new() { Name = "RightUpLeg" }, JointBone = new() { Name = "RightLeg" }, SubLowerBone = new(), LowerBone = new() { Name = "RightFoot" }, IkBone = new(), LimitToLengthPercentage = 0.990000F, AutoSetupDirs = true, JointSideWeightUpper = 0.500000F, JointSideWeightJoint = 0.300000F, JointSideWeightLower = 0.200000F, Joint_to_next_dir_in_upper_s_BS = new() { X = 1.000000F }, Joint_to_next_dir_in_joint_s_BS = new() { X = 1.000000F }, Joint_to_next_dir_in_lower_s_BS = new() { X = 1.000000F }, Joint_side_dir_in_upper_s_BS = new() { Z = 1.000000F }, Joint_side_dir_in_joint_s_BS = new() { Z = 1.000000F }, Joint_side_dir_in_lower_s_BS = new() { Z = 1.000000F }, Joint_bend_dir_in_upper_s_BS = new() { Y = 1.000000F }, Joint_bend_dir_in_joint_s_BS = new() { Y = 1.000000F }, Joint_bend_dir_in_lower_s_BS = new() { Y = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
