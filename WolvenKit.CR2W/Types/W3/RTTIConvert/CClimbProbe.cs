using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CClimbProbe : CObject
	{
		[RED("distForwardToCheckClose")] 		public CFloat DistForwardToCheckClose { get; set;}

		[RED("distForwardToCheckMedium")] 		public CFloat DistForwardToCheckMedium { get; set;}

		[RED("maxAttempts")] 		public CInt32 MaxAttempts { get; set;}

		[RED("distForwardToCheckLong")] 		public CFloat DistForwardToCheckLong { get; set;}

		[RED("characterRadius")] 		public CFloat CharacterRadius { get; set;}

		[RED("ceilingDoubleCheck")] 		public CBool CeilingDoubleCheck { get; set;}

		[RED("ceilingCheckingClose")] 		public CBool CeilingCheckingClose { get; set;}

		[RED("ceilingBackOffsetClose")] 		public CFloat CeilingBackOffsetClose { get; set;}

		[RED("ceilingBackOffsetFar")] 		public CFloat CeilingBackOffsetFar { get; set;}

		[RED("ceilingHeightNeeded")] 		public CFloat CeilingHeightNeeded { get; set;}

		[RED("ceilingRadius")] 		public CFloat CeilingRadius { get; set;}

		[RED("groundRadiusToCheck")] 		public CFloat GroundRadiusToCheck { get; set;}

		[RED("groundNormalMinZ")] 		public CFloat GroundNormalMinZ { get; set;}

		[RED("groundRefineEnabled")] 		public CBool GroundRefineEnabled { get; set;}

		[RED("groundRefineDistCheck")] 		public CFloat GroundRefineDistCheck { get; set;}

		[RED("groundRefineHeightCheck")] 		public CFloat GroundRefineHeightCheck { get; set;}

		[RED("groundRefineRadius")] 		public CFloat GroundRefineRadius { get; set;}

		[RED("climbableRadius")] 		public CFloat ClimbableRadius { get; set;}

		[RED("climbableLockTag")] 		public CName ClimbableLockTag { get; set;}

		[RED("climbableUnLockTag")] 		public CName ClimbableUnLockTag { get; set;}

		[RED("holeForwardNeeded")] 		public CFloat HoleForwardNeeded { get; set;}

		[RED("wallRadiusToCheck")] 		public CFloat WallRadiusToCheck { get; set;}

		[RED("wallNormalCheckBackExtra")] 		public CFloat WallNormalCheckBackExtra { get; set;}

		[RED("wallSideSeparation")] 		public CFloat WallSideSeparation { get; set;}

		[RED("slopeAngleMax")] 		public CFloat SlopeAngleMax { get; set;}

		[RED("slopeForwardDistance")] 		public CFloat SlopeForwardDistance { get; set;}

		[RED("slopeLeftDistance")] 		public CFloat SlopeLeftDistance { get; set;}

		[RED("horizHeightRdius")] 		public CFloat HorizHeightRdius { get; set;}

		[RED("horizHeightSeparation")] 		public CFloat HorizHeightSeparation { get; set;}

		[RED("horizHeightAngleMin")] 		public CFloat HorizHeightAngleMin { get; set;}

		[RED("horizHeightAngleMax")] 		public CFloat HorizHeightAngleMax { get; set;}

		[RED("vertSlopeAngleOffset")] 		public CFloat VertSlopeAngleOffset { get; set;}

		[RED("vertSlopeAngleMax")] 		public CFloat VertSlopeAngleMax { get; set;}

		[RED("vertSlopeAngleLowOffset")] 		public CFloat VertSlopeAngleLowOffset { get; set;}

		[RED("vertSlopeLowAngleMax")] 		public CFloat VertSlopeLowAngleMax { get; set;}

		[RED("vertFreeHeightEnable")] 		public CBool VertFreeHeightEnable { get; set;}

		[RED("vertFreeHorOffset")] 		public CFloat VertFreeHorOffset { get; set;}

		[RED("vertFreeHorMin")] 		public CFloat VertFreeHorMin { get; set;}

		[RED("vertFreeHeightMin")] 		public CFloat VertFreeHeightMin { get; set;}

		[RED("vertFreeHeightGrndMax")] 		public CFloat VertFreeHeightGrndMax { get; set;}

		[RED("vertFreeHeightCur")] 		public CFloat VertFreeHeightCur { get; set;}

		[RED("vaultHeight")] 		public CFloat VaultHeight { get; set;}

		[RED("vaultHeightOffset")] 		public CFloat VaultHeightOffset { get; set;}

		[RED("vaultDistance")] 		public CFloat VaultDistance { get; set;}

		[RED("vaultRadius")] 		public CFloat VaultRadius { get; set;}

		[RED("heightOffsetToEndFall")] 		public CFloat HeightOffsetToEndFall { get; set;}

		[RED("heighAbsToEndFall")] 		public CFloat HeighAbsToEndFall { get; set;}

		[RED("platformHeightDown")] 		public CFloat PlatformHeightDown { get; set;}

		[RED("platformRadius")] 		public CFloat PlatformRadius { get; set;}

		[RED("platformDeep")] 		public CFloat PlatformDeep { get; set;}

		public CClimbProbe(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CClimbProbe(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}