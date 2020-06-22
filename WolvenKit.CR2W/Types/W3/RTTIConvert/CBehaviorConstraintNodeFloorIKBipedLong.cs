using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintNodeFloorIKBipedLong : CBehaviorConstraintNodeFloorIKBase
	{
		[RED("speedForFullyPerpendicularLegs")] 		public CFloat SpeedForFullyPerpendicularLegs { get; set;}

		[RED("upDirAdditionalWS")] 		public Vector UpDirAdditionalWS { get; set;}

		[RED("pelvis")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis { get; set;}

		[RED("legs")] 		public SBehaviorConstraintNodeFloorIKLegsData Legs { get; set;}

		[RED("leftLegIK")] 		public STwoBonesIKSolverData LeftLegIK { get; set;}

		[RED("rightLegIK")] 		public STwoBonesIKSolverData RightLegIK { get; set;}

		[RED("leftShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData LeftShoulder { get; set;}

		[RED("rightShoulder")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData RightShoulder { get; set;}

		[RED("neck1MaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck1MaintainLook { get; set;}

		[RED("neck2MaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck2MaintainLook { get; set;}

		[RED("headMaintainLook")] 		public SBehaviorConstraintNodeFloorIKMaintainLookBoneData HeadMaintainLook { get; set;}

		public CBehaviorConstraintNodeFloorIKBipedLong(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorConstraintNodeFloorIKBipedLong(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}