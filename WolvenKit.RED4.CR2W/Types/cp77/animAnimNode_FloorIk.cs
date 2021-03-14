using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloorIk : animAnimNode_FloorIkBase
	{
		private animSBehaviorConstraintNodeFloorIKVerticalBoneData _pelvis;
		private animSBehaviorConstraintNodeFloorIKLegsData _legs;
		private animSTwoBonesIKSolverData _leftLegIK;
		private animSTwoBonesIKSolverData _rightLegIK;

		[Ordinal(18)] 
		[RED("pelvis")] 
		public animSBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis
		{
			get
			{
				if (_pelvis == null)
				{
					_pelvis = (animSBehaviorConstraintNodeFloorIKVerticalBoneData) CR2WTypeManager.Create("animSBehaviorConstraintNodeFloorIKVerticalBoneData", "pelvis", cr2w, this);
				}
				return _pelvis;
			}
			set
			{
				if (_pelvis == value)
				{
					return;
				}
				_pelvis = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("legs")] 
		public animSBehaviorConstraintNodeFloorIKLegsData Legs
		{
			get
			{
				if (_legs == null)
				{
					_legs = (animSBehaviorConstraintNodeFloorIKLegsData) CR2WTypeManager.Create("animSBehaviorConstraintNodeFloorIKLegsData", "legs", cr2w, this);
				}
				return _legs;
			}
			set
			{
				if (_legs == value)
				{
					return;
				}
				_legs = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("leftLegIK")] 
		public animSTwoBonesIKSolverData LeftLegIK
		{
			get
			{
				if (_leftLegIK == null)
				{
					_leftLegIK = (animSTwoBonesIKSolverData) CR2WTypeManager.Create("animSTwoBonesIKSolverData", "leftLegIK", cr2w, this);
				}
				return _leftLegIK;
			}
			set
			{
				if (_leftLegIK == value)
				{
					return;
				}
				_leftLegIK = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("rightLegIK")] 
		public animSTwoBonesIKSolverData RightLegIK
		{
			get
			{
				if (_rightLegIK == null)
				{
					_rightLegIK = (animSTwoBonesIKSolverData) CR2WTypeManager.Create("animSTwoBonesIKSolverData", "rightLegIK", cr2w, this);
				}
				return _rightLegIK;
			}
			set
			{
				if (_rightLegIK == value)
				{
					return;
				}
				_rightLegIK = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FloorIk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
