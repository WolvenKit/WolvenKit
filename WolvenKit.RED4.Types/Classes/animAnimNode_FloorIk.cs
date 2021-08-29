using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FloorIk : animAnimNode_FloorIkBase
	{
		private animSBehaviorConstraintNodeFloorIKVerticalBoneData _pelvis;
		private animSBehaviorConstraintNodeFloorIKLegsData _legs;
		private animSTwoBonesIKSolverData _leftLegIK;
		private animSTwoBonesIKSolverData _rightLegIK;

		[Ordinal(18)] 
		[RED("pelvis")] 
		public animSBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis
		{
			get => GetProperty(ref _pelvis);
			set => SetProperty(ref _pelvis, value);
		}

		[Ordinal(19)] 
		[RED("legs")] 
		public animSBehaviorConstraintNodeFloorIKLegsData Legs
		{
			get => GetProperty(ref _legs);
			set => SetProperty(ref _legs, value);
		}

		[Ordinal(20)] 
		[RED("leftLegIK")] 
		public animSTwoBonesIKSolverData LeftLegIK
		{
			get => GetProperty(ref _leftLegIK);
			set => SetProperty(ref _leftLegIK, value);
		}

		[Ordinal(21)] 
		[RED("rightLegIK")] 
		public animSTwoBonesIKSolverData RightLegIK
		{
			get => GetProperty(ref _rightLegIK);
			set => SetProperty(ref _rightLegIK, value);
		}
	}
}
