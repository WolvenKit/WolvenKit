using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintNodeFloorIKBipedLong : CBehaviorConstraintNodeFloorIKBase
	{
		[Ordinal(1)] [RED("speedForFullyPerpendicularLegs")] 		public CFloat SpeedForFullyPerpendicularLegs { get; set;}

		[Ordinal(2)] [RED("upDirAdditionalWS")] 		public Vector UpDirAdditionalWS { get; set;}

		[Ordinal(3)] [RED("pelvis")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis { get; set;}

		[Ordinal(4)] [RED("legs")] 		public SBehaviorConstraintNodeFloorIKLegsData Legs { get; set;}

		[Ordinal(5)] [RED("leftLegIK")] 		public STwoBonesIKSolverData LeftLegIK { get; set;}

		[Ordinal(6)] [RED("rightLegIK")] 		public STwoBonesIKSolverData RightLegIK { get; set;}

		[Ordinal(7)] [RED("leftShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData LeftShoulder { get; set;}

		[Ordinal(8)] [RED("rightShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData RightShoulder { get; set;}

		[Ordinal(9)] [RED("neck1MaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck1MaintainLook { get; set;}

		[Ordinal(10)] [RED("neck2MaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck2MaintainLook { get; set;}

		[Ordinal(11)] [RED("headMaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData HeadMaintainLook { get; set;}

		public CBehaviorConstraintNodeFloorIKBipedLong(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorConstraintNodeFloorIKBipedLong(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}