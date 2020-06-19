using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintNodeFloorIKQuadruped : CBehaviorConstraintNodeFloorIKBase
	{
		[RED("speedForFullyPerpendicularLegs")] 		public CFloat SpeedForFullyPerpendicularLegs { get; set;}

		[RED("upDirFromFrontAndBackLegsDiffCoef")] 		public CFloat UpDirFromFrontAndBackLegsDiffCoef { get; set;}

		[RED("upDirUseFrontAndBackLegsDiff")] 		public CFloat UpDirUseFrontAndBackLegsDiff { get; set;}

		[RED("upDirAdditionalWS")] 		public Vector UpDirAdditionalWS { get; set;}

		[RED("pelvis")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis { get; set;}

		[RED("legs")] 		public SBehaviorConstraintNodeFloorIKLegsData Legs { get; set;}

		[RED("leftBackLegIK")] 		public STwoBonesIKSolverData LeftBackLegIK { get; set;}

		[RED("rightBackLegIK")] 		public STwoBonesIKSolverData RightBackLegIK { get; set;}

		[RED("leftFrontLegIK")] 		public STwoBonesIKSolverData LeftFrontLegIK { get; set;}

		[RED("rightFrontLegIK")] 		public STwoBonesIKSolverData RightFrontLegIK { get; set;}

		[RED("leftFrontLegRotIK")] 		public SApplyRotationIKSolverData LeftFrontLegRotIK { get; set;}

		[RED("rightFrontLegRotIK")] 		public SApplyRotationIKSolverData RightFrontLegRotIK { get; set;}

		[RED("leftBackShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData LeftBackShoulder { get; set;}

		[RED("rightBackShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData RightBackShoulder { get; set;}

		[RED("leftFrontShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData LeftFrontShoulder { get; set;}

		[RED("rightFrontShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData RightFrontShoulder { get; set;}

		[RED("neck1MaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck1MaintainLook { get; set;}

		[RED("neck2MaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck2MaintainLook { get; set;}

		[RED("headMaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData HeadMaintainLook { get; set;}

		public CBehaviorConstraintNodeFloorIKQuadruped(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorConstraintNodeFloorIKQuadruped(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}