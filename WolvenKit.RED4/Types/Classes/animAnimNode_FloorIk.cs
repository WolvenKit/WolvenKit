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
			Common = new animSBehaviorConstraintNodeFloorIKCommonData { GravityCentreBone = new animTransformIndex { Name = "Hips" }, RootRotationBlendTime = 0.200000F, VerticalVelocityOffsetUpBlendTime = 0.100000F, VerticalVelocityOffsetDownBlendTime = 0.080000F, SlidingOnSlopeBlendTime = 0.200000F };
			Pelvis = new animSBehaviorConstraintNodeFloorIKVerticalBoneData { Bone = new animTransformIndex { Name = "Hips" }, Min_offset = -0.500000F, Max_offset = 0.500000F, OffsetToDesiredBlendTime = 0.100000F, VerticalOffsetBlendTime = 0.050000F, Stiffness = 1.000000F };
			Legs = new animSBehaviorConstraintNodeFloorIKLegsData { Max_rel_offset = 0.500000F, Min_trace_offset = -1.500000F, Max_trace_offset = 1.500000F, VerticalOffsetBlendUpTime = 0.080000F, VerticalOffsetBlendDownTime = 0.030000F, Max_distance_for_trace_update = 0.020000F, Max_angle_from_upright_normal = 45.000000F, Max_angle_from_upright_normal_to_side = 15.000000F, Max_angle_from_upright_normal_to_revert_orientation = 70.000000F };
			LeftLegIK = new animSTwoBonesIKSolverData { UpperBone = new animTransformIndex { Name = "LeftUpLeg" }, JointBone = new animTransformIndex { Name = "LeftLeg" }, SubLowerBone = new animTransformIndex(), LowerBone = new animTransformIndex { Name = "LeftFoot" }, IkBone = new animTransformIndex(), LimitToLengthPercentage = 0.990000F, AutoSetupDirs = true, JointSideWeightUpper = 0.500000F, JointSideWeightJoint = 0.300000F, JointSideWeightLower = 0.200000F, Joint_to_next_dir_in_upper_s_BS = new Vector4 { X = 1.000000F }, Joint_to_next_dir_in_joint_s_BS = new Vector4 { X = 1.000000F }, Joint_to_next_dir_in_lower_s_BS = new Vector4 { X = 1.000000F }, Joint_side_dir_in_upper_s_BS = new Vector4 { Z = 1.000000F }, Joint_side_dir_in_joint_s_BS = new Vector4 { Z = 1.000000F }, Joint_side_dir_in_lower_s_BS = new Vector4 { Z = 1.000000F }, Joint_bend_dir_in_upper_s_BS = new Vector4 { Y = 1.000000F }, Joint_bend_dir_in_joint_s_BS = new Vector4 { Y = 1.000000F }, Joint_bend_dir_in_lower_s_BS = new Vector4 { Y = 1.000000F } };
			RightLegIK = new animSTwoBonesIKSolverData { UpperBone = new animTransformIndex { Name = "RightUpLeg" }, JointBone = new animTransformIndex { Name = "RightLeg" }, SubLowerBone = new animTransformIndex(), LowerBone = new animTransformIndex { Name = "RightFoot" }, IkBone = new animTransformIndex(), LimitToLengthPercentage = 0.990000F, AutoSetupDirs = true, JointSideWeightUpper = 0.500000F, JointSideWeightJoint = 0.300000F, JointSideWeightLower = 0.200000F, Joint_to_next_dir_in_upper_s_BS = new Vector4 { X = 1.000000F }, Joint_to_next_dir_in_joint_s_BS = new Vector4 { X = 1.000000F }, Joint_to_next_dir_in_lower_s_BS = new Vector4 { X = 1.000000F }, Joint_side_dir_in_upper_s_BS = new Vector4 { Z = 1.000000F }, Joint_side_dir_in_joint_s_BS = new Vector4 { Z = 1.000000F }, Joint_side_dir_in_lower_s_BS = new Vector4 { Z = 1.000000F }, Joint_bend_dir_in_upper_s_BS = new Vector4 { Y = 1.000000F }, Joint_bend_dir_in_joint_s_BS = new Vector4 { Y = 1.000000F }, Joint_bend_dir_in_lower_s_BS = new Vector4 { Y = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
