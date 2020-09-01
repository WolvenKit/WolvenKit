using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintNodeFloorIKQuadruped : CBehaviorConstraintNodeFloorIKBase
	{
		[Ordinal(0)] [RED("speedForFullyPerpendicularLegs")] 		public CFloat SpeedForFullyPerpendicularLegs { get; set;}

		[Ordinal(0)] [RED("upDirFromFrontAndBackLegsDiffCoef")] 		public CFloat UpDirFromFrontAndBackLegsDiffCoef { get; set;}

		[Ordinal(0)] [RED("upDirUseFrontAndBackLegsDiff")] 		public CFloat UpDirUseFrontAndBackLegsDiff { get; set;}

		[Ordinal(0)] [RED("upDirAdditionalWS")] 		public Vector UpDirAdditionalWS { get; set;}

		[Ordinal(0)] [RED("pelvis")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis { get; set;}

		[Ordinal(0)] [RED("legs")] 		public SBehaviorConstraintNodeFloorIKLegsData Legs { get; set;}

		[Ordinal(0)] [RED("leftBackLegIK")] 		public STwoBonesIKSolverData LeftBackLegIK { get; set;}

		[Ordinal(0)] [RED("rightBackLegIK")] 		public STwoBonesIKSolverData RightBackLegIK { get; set;}

		[Ordinal(0)] [RED("leftFrontLegIK")] 		public STwoBonesIKSolverData LeftFrontLegIK { get; set;}

		[Ordinal(0)] [RED("rightFrontLegIK")] 		public STwoBonesIKSolverData RightFrontLegIK { get; set;}

		[Ordinal(0)] [RED("leftFrontLegRotIK")] 		public SApplyRotationIKSolverData LeftFrontLegRotIK { get; set;}

		[Ordinal(0)] [RED("rightFrontLegRotIK")] 		public SApplyRotationIKSolverData RightFrontLegRotIK { get; set;}

		[Ordinal(0)] [RED("leftBackShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData LeftBackShoulder { get; set;}

		[Ordinal(0)] [RED("rightBackShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData RightBackShoulder { get; set;}

		[Ordinal(0)] [RED("leftFrontShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData LeftFrontShoulder { get; set;}

		[Ordinal(0)] [RED("rightFrontShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData RightFrontShoulder { get; set;}

		[Ordinal(0)] [RED("neck1MaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck1MaintainLook { get; set;}

		[Ordinal(0)] [RED("neck2MaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck2MaintainLook { get; set;}

		[Ordinal(0)] [RED("headMaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData HeadMaintainLook { get; set;}

		public CBehaviorConstraintNodeFloorIKQuadruped(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorConstraintNodeFloorIKQuadruped(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}