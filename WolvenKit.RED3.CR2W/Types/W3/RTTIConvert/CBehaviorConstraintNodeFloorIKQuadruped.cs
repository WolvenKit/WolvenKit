using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintNodeFloorIKQuadruped : CBehaviorConstraintNodeFloorIKBase
	{
		[Ordinal(1)] [RED("speedForFullyPerpendicularLegs")] 		public CFloat SpeedForFullyPerpendicularLegs { get; set;}

		[Ordinal(2)] [RED("upDirFromFrontAndBackLegsDiffCoef")] 		public CFloat UpDirFromFrontAndBackLegsDiffCoef { get; set;}

		[Ordinal(3)] [RED("upDirUseFrontAndBackLegsDiff")] 		public CFloat UpDirUseFrontAndBackLegsDiff { get; set;}

		[Ordinal(4)] [RED("upDirAdditionalWS")] 		public Vector UpDirAdditionalWS { get; set;}

		[Ordinal(5)] [RED("pelvis")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis { get; set;}

		[Ordinal(6)] [RED("legs")] 		public SBehaviorConstraintNodeFloorIKLegsData Legs { get; set;}

		[Ordinal(7)] [RED("leftBackLegIK")] 		public STwoBonesIKSolverData LeftBackLegIK { get; set;}

		[Ordinal(8)] [RED("rightBackLegIK")] 		public STwoBonesIKSolverData RightBackLegIK { get; set;}

		[Ordinal(9)] [RED("leftFrontLegIK")] 		public STwoBonesIKSolverData LeftFrontLegIK { get; set;}

		[Ordinal(10)] [RED("rightFrontLegIK")] 		public STwoBonesIKSolverData RightFrontLegIK { get; set;}

		[Ordinal(11)] [RED("leftFrontLegRotIK")] 		public SApplyRotationIKSolverData LeftFrontLegRotIK { get; set;}

		[Ordinal(12)] [RED("rightFrontLegRotIK")] 		public SApplyRotationIKSolverData RightFrontLegRotIK { get; set;}

		[Ordinal(13)] [RED("leftBackShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData LeftBackShoulder { get; set;}

		[Ordinal(14)] [RED("rightBackShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData RightBackShoulder { get; set;}

		[Ordinal(15)] [RED("leftFrontShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData LeftFrontShoulder { get; set;}

		[Ordinal(16)] [RED("rightFrontShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData RightFrontShoulder { get; set;}

		[Ordinal(17)] [RED("neck1MaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck1MaintainLook { get; set;}

		[Ordinal(18)] [RED("neck2MaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck2MaintainLook { get; set;}

		[Ordinal(19)] [RED("headMaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData HeadMaintainLook { get; set;}

		public CBehaviorConstraintNodeFloorIKQuadruped(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorConstraintNodeFloorIKQuadruped(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}