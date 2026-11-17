using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloorIk : animAnimNode_FloorIkBase
	{
		[Ordinal(8)] 
		[RED("pelvis")] 
		public animSBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis
		{
			get => GetPropertyValue<animSBehaviorConstraintNodeFloorIKVerticalBoneData>();
			set => SetPropertyValue<animSBehaviorConstraintNodeFloorIKVerticalBoneData>(value);
		}

		[Ordinal(9)] 
		[RED("legs")] 
		public animSBehaviorConstraintNodeFloorIKLegsData Legs
		{
			get => GetPropertyValue<animSBehaviorConstraintNodeFloorIKLegsData>();
			set => SetPropertyValue<animSBehaviorConstraintNodeFloorIKLegsData>(value);
		}

		[Ordinal(10)] 
		[RED("leftLegIK")] 
		public animSTwoBonesIKSolverData LeftLegIK
		{
			get => GetPropertyValue<animSTwoBonesIKSolverData>();
			set => SetPropertyValue<animSTwoBonesIKSolverData>(value);
		}

		[Ordinal(11)] 
		[RED("rightLegIK")] 
		public animSTwoBonesIKSolverData RightLegIK
		{
			get => GetPropertyValue<animSTwoBonesIKSolverData>();
			set => SetPropertyValue<animSTwoBonesIKSolverData>(value);
		}

		public animAnimNode_FloorIk()
		{
			CanBeDisabledDueToFrameRate = true;
			Common = new animSBehaviorConstraintNodeFloorIKCommonData { GravityCentreBone = new animTransformIndex { Name = "Hips" }, VerticalVelocityOffsetUpBlendTime = 0.100000F, VerticalVelocityOffsetDownBlendTime = 0.080000F };
			Pelvis = new animSBehaviorConstraintNodeFloorIKVerticalBoneData { Bone = new animTransformIndex { Name = "Hips" }, VerticalOffsetBlendTime = 0.050000F };
			Legs = new animSBehaviorConstraintNodeFloorIKLegsData { Min_trace_offset = -1.500000F, Max_trace_offset = 1.500000F, VerticalOffsetBlendUpTime = 0.080000F, Max_angle_from_upright_normal_to_side = 15.000000F };
			LeftLegIK = new animSTwoBonesIKSolverData { UpperBone = new animTransformIndex { Name = "LeftUpLeg" }, JointBone = new animTransformIndex { Name = "LeftLeg" }, LowerBone = new animTransformIndex { Name = "LeftFoot" } };
			RightLegIK = new animSTwoBonesIKSolverData { UpperBone = new animTransformIndex { Name = "RightUpLeg" }, JointBone = new animTransformIndex { Name = "RightLeg" }, LowerBone = new animTransformIndex { Name = "RightFoot" } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
