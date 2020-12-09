using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintNodeFloorIKSixLegs : CBehaviorConstraintNodeFloorIKBase
	{
		[Ordinal(1)] [RED("usePerpendicularUprightWS")] 		public CFloat UsePerpendicularUprightWS { get; set;}

		[Ordinal(2)] [RED("upDirAdditionalWS")] 		public Vector UpDirAdditionalWS { get; set;}

		[Ordinal(3)] [RED("upDirUseFromLegsHitLocs")] 		public CFloat UpDirUseFromLegsHitLocs { get; set;}

		[Ordinal(4)] [RED("pelvis")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis { get; set;}

		[Ordinal(5)] [RED("legs")] 		public SBehaviorConstraintNodeFloorIKLegsData Legs { get; set;}

		[Ordinal(6)] [RED("leftBackLegIK")] 		public STwoBonesIKSolverData LeftBackLegIK { get; set;}

		[Ordinal(7)] [RED("rightBackLegIK")] 		public STwoBonesIKSolverData RightBackLegIK { get; set;}

		[Ordinal(8)] [RED("leftMiddleLegIK")] 		public STwoBonesIKSolverData LeftMiddleLegIK { get; set;}

		[Ordinal(9)] [RED("rightMiddleLegIK")] 		public STwoBonesIKSolverData RightMiddleLegIK { get; set;}

		[Ordinal(10)] [RED("leftFrontLegIK")] 		public STwoBonesIKSolverData LeftFrontLegIK { get; set;}

		[Ordinal(11)] [RED("rightFrontLegIK")] 		public STwoBonesIKSolverData RightFrontLegIK { get; set;}

		public CBehaviorConstraintNodeFloorIKSixLegs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorConstraintNodeFloorIKSixLegs(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}