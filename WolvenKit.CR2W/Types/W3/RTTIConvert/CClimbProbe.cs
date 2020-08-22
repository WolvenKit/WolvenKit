using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CClimbProbe : CObject
	{
		[RED("valid")] 		public CBool Valid { get; set;}

		[RED("setupReady")] 		public CBool SetupReady { get; set;}

		[RED("exploratorPosition")] 		public Vector ExploratorPosition { get; set;}

		[RED("directionChecking")] 		public Vector DirectionChecking { get; set;}

		[RED("directionRequiresInput")] 		public CBool DirectionRequiresInput { get; set;}

		[RED("distForwardToCheck")] 		public CFloat DistForwardToCheck { get; set;}

		[RED("distanceCheckType")] 		public CEnum<EClimbDistanceType> DistanceCheckType { get; set;}

		[RED("distForwardToCheckClose")] 		public CFloat DistForwardToCheckClose { get; set;}

		[RED("distForwardToCheckMedium")] 		public CFloat DistForwardToCheckMedium { get; set;}

		[RED("maxAttempts")] 		public CInt32 MaxAttempts { get; set;}

		[RED("distForwardToCheckLong")] 		public CFloat DistForwardToCheckLong { get; set;}

		[RED("characterRadius")] 		public CFloat CharacterRadius { get; set;}

		[RED("heightTotalMin")] 		public CFloat HeightTotalMin { get; set;}

		[RED("heightTotalMax")] 		public CFloat HeightTotalMax { get; set;}

		[RED("ceilingDoubleCheck")] 		public CBool CeilingDoubleCheck { get; set;}

		[RED("ceilingCheckingClose")] 		public CBool CeilingCheckingClose { get; set;}

		[RED("ceilingBackOffsetClose")] 		public CFloat CeilingBackOffsetClose { get; set;}

		[RED("ceilingBackOffsetFar")] 		public CFloat CeilingBackOffsetFar { get; set;}

		[RED("ceilingHeightNeeded")] 		public CFloat CeilingHeightNeeded { get; set;}

		[RED("ceilingRadius")] 		public CFloat CeilingRadius { get; set;}

		[RED("ceilingFound")] 		public CBool CeilingFound { get; set;}

		[RED("ceilingPoint")] 		public Vector CeilingPoint { get; set;}

		[RED("ceilingHeightFree")] 		public CFloat CeilingHeightFree { get; set;}

		[RED("ceilingCheckFrom")] 		public Vector CeilingCheckFrom { get; set;}

		[RED("ceilingCheckTo")] 		public Vector CeilingCheckTo { get; set;}

		[RED("groundRadiusToCheck")] 		public CFloat GroundRadiusToCheck { get; set;}

		[RED("groundNormalMinZ")] 		public CFloat GroundNormalMinZ { get; set;}

		[RED("groundFound")] 		public CBool GroundFound { get; set;}

		[RED("groundEndPoint")] 		public Vector GroundEndPoint { get; set;}

		[RED("groundEndNormal")] 		public Vector GroundEndNormal { get; set;}

		[RED("heightTarget")] 		public CFloat HeightTarget { get; set;}

		[RED("heightAdded")] 		public CFloat HeightAdded { get; set;}

		[RED("groundCheckFrom")] 		public Vector GroundCheckFrom { get; set;}

		[RED("groundCheckTo")] 		public Vector GroundCheckTo { get; set;}

		[RED("groundRefineEnabled")] 		public CBool GroundRefineEnabled { get; set;}

		[RED("groundRefineDistCheck")] 		public CFloat GroundRefineDistCheck { get; set;}

		[RED("groundRefineHeightCheck")] 		public CFloat GroundRefineHeightCheck { get; set;}

		[RED("groundRefineRadius")] 		public CFloat GroundRefineRadius { get; set;}

		[RED("groundRefined")] 		public CBool GroundRefined { get; set;}

		[RED("climbableFound")] 		public CBool ClimbableFound { get; set;}

		[RED("climbableObjName")] 		public CString ClimbableObjName { get; set;}

		[RED("climbableObjTagOnLayer")] 		public CBool ClimbableObjTagOnLayer { get; set;}

		[RED("climbableObjForceAllow")] 		public CBool ClimbableObjForceAllow { get; set;}

		[RED("climbablePoint")] 		public Vector ClimbablePoint { get; set;}

		[RED("climbableRadius")] 		public CFloat ClimbableRadius { get; set;}

		[RED("climbableLockTag")] 		public CName ClimbableLockTag { get; set;}

		[RED("climbableUnLockTag")] 		public CName ClimbableUnLockTag { get; set;}

		[RED("holeForwardNeeded")] 		public CFloat HoleForwardNeeded { get; set;}

		[RED("holeIsBlocked")] 		public CBool HoleIsBlocked { get; set;}

		[RED("holeCollision")] 		public Vector HoleCollision { get; set;}

		[RED("holeCheckFrom")] 		public Vector HoleCheckFrom { get; set;}

		[RED("holeCheckTo")] 		public Vector HoleCheckTo { get; set;}

		[RED("wallRadiusToCheck")] 		public CFloat WallRadiusToCheck { get; set;}

		[RED("wallNormalCheckBackExtra")] 		public CFloat WallNormalCheckBackExtra { get; set;}

		[RED("wallSideSeparation")] 		public CFloat WallSideSeparation { get; set;}

		[RED("wallFound")] 		public CBool WallFound { get; set;}

		[RED("wallNormalOrigin")] 		public Vector WallNormalOrigin { get; set;}

		[RED("wallNormalDirection")] 		public Vector WallNormalDirection { get; set;}

		[RED("wallCheckFromL")] 		public Vector WallCheckFromL { get; set;}

		[RED("wallCheckToL")] 		public Vector WallCheckToL { get; set;}

		[RED("wallCheckFromR")] 		public Vector WallCheckFromR { get; set;}

		[RED("wallCheckToR")] 		public Vector WallCheckToR { get; set;}

		[RED("wallCollL")] 		public Vector WallCollL { get; set;}

		[RED("wallCollR")] 		public Vector WallCollR { get; set;}

		[RED("slopeAngleMax")] 		public CFloat SlopeAngleMax { get; set;}

		[RED("slopeNormalZMax")] 		public CFloat SlopeNormalZMax { get; set;}

		[RED("slopeForwardDistance")] 		public CFloat SlopeForwardDistance { get; set;}

		[RED("slopeLeftDistance")] 		public CFloat SlopeLeftDistance { get; set;}

		[RED("horizHeightRdius")] 		public CFloat HorizHeightRdius { get; set;}

		[RED("horizHeightSeparation")] 		public CFloat HorizHeightSeparation { get; set;}

		[RED("horizHeightAngleMin")] 		public CFloat HorizHeightAngleMin { get; set;}

		[RED("horizHeightAngleMax")] 		public CFloat HorizHeightAngleMax { get; set;}

		[RED("horizFoundLeft")] 		public CBool HorizFoundLeft { get; set;}

		[RED("horizFoundRight")] 		public CBool HorizFoundRight { get; set;}

		[RED("horizHeightAngleCur")] 		public CFloat HorizHeightAngleCur { get; set;}

		[RED("horizPointLeft")] 		public Vector HorizPointLeft { get; set;}

		[RED("horizPointRight")] 		public Vector HorizPointRight { get; set;}

		[RED("horizCorrectSideCoef")] 		public CFloat HorizCorrectSideCoef { get; set;}

		[RED("vertSlopeAngleOffset")] 		public CFloat VertSlopeAngleOffset { get; set;}

		[RED("vertSlopeAngleMax")] 		public CFloat VertSlopeAngleMax { get; set;}

		[RED("vertSlopeAngleCur")] 		public CFloat VertSlopeAngleCur { get; set;}

		[RED("vertSlopeAngleFrom")] 		public Vector VertSlopeAngleFrom { get; set;}

		[RED("vertSlopeAngleTo")] 		public Vector VertSlopeAngleTo { get; set;}

		[RED("vertSlopeAnglePoint")] 		public Vector VertSlopeAnglePoint { get; set;}

		[RED("vertSlopeAngleLowOffset")] 		public CFloat VertSlopeAngleLowOffset { get; set;}

		[RED("vertSlopeLowAngleMax")] 		public CFloat VertSlopeLowAngleMax { get; set;}

		[RED("vertSlopeLowAngleCur")] 		public CFloat VertSlopeLowAngleCur { get; set;}

		[RED("vertSlopeLowAngleFrom")] 		public Vector VertSlopeLowAngleFrom { get; set;}

		[RED("vertSlopeLowAngleTo")] 		public Vector VertSlopeLowAngleTo { get; set;}

		[RED("vertSlopeLowAnglePoint")] 		public Vector VertSlopeLowAnglePoint { get; set;}

		[RED("vertFreeHeightEnable")] 		public CBool VertFreeHeightEnable { get; set;}

		[RED("vertFreeHorOffset")] 		public CFloat VertFreeHorOffset { get; set;}

		[RED("vertFreeHorMin")] 		public CFloat VertFreeHorMin { get; set;}

		[RED("vertFreeHeightMin")] 		public CFloat VertFreeHeightMin { get; set;}

		[RED("vertFreeHeightGrndMax")] 		public CFloat VertFreeHeightGrndMax { get; set;}

		[RED("vertFreeHeightCur")] 		public CFloat VertFreeHeightCur { get; set;}

		[RED("vertFreeFrom")] 		public Vector VertFreeFrom { get; set;}

		[RED("vertFreeTo")] 		public Vector VertFreeTo { get; set;}

		[RED("vertFreeCollPoint")] 		public Vector VertFreeCollPoint { get; set;}

		[RED("vaultHeight")] 		public CFloat VaultHeight { get; set;}

		[RED("vaultHeightOffset")] 		public CFloat VaultHeightOffset { get; set;}

		[RED("vaultDistance")] 		public CFloat VaultDistance { get; set;}

		[RED("vaultRadius")] 		public CFloat VaultRadius { get; set;}

		[RED("heightOffsetToEndFall")] 		public CFloat HeightOffsetToEndFall { get; set;}

		[RED("heighAbsToEndFall")] 		public CFloat HeighAbsToEndFall { get; set;}

		[RED("vaultingFound")] 		public CEnum<EClimbRequirementVault> VaultingFound { get; set;}

		[RED("vaultCollision")] 		public Vector VaultCollision { get; set;}

		[RED("vaultEndsFalling")] 		public CBool VaultEndsFalling { get; set;}

		[RED("vaultCheckFrom")] 		public Vector VaultCheckFrom { get; set;}

		[RED("vaultCheckTo")] 		public Vector VaultCheckTo { get; set;}

		[RED("platformFound")] 		public CEnum<EClimbRequirementPlatform> PlatformFound { get; set;}

		[RED("platformFrom")] 		public Vector PlatformFrom { get; set;}

		[RED("platformTo")] 		public Vector PlatformTo { get; set;}

		[RED("platformCollision")] 		public Vector PlatformCollision { get; set;}

		[RED("platformHeightDown")] 		public CFloat PlatformHeightDown { get; set;}

		[RED("platformRadius")] 		public CFloat PlatformRadius { get; set;}

		[RED("platformDeep")] 		public CFloat PlatformDeep { get; set;}

		[RED("platformMinToCheck")] 		public CFloat PlatformMinToCheck { get; set;}

		[RED("collisionClimbableNames", 2,0)] 		public CArray<CName> CollisionClimbableNames { get; set;}

		[RED("collisionObstaclesNames", 2,0)] 		public CArray<CName> CollisionObstaclesNames { get; set;}

		[RED("collisionForceAllowNames", 2,0)] 		public CArray<CName> CollisionForceAllowNames { get; set;}

		[RED("collisionLockNames", 2,0)] 		public CArray<CName> CollisionLockNames { get; set;}

		[RED("debugPrefix")] 		public CString DebugPrefix { get; set;}

		[RED("debugIsTop")] 		public CString DebugIsTop { get; set;}

		[RED("debugColorDiv")] 		public CInt32 DebugColorDiv { get; set;}

		[RED("debugLogFails")] 		public CBool DebugLogFails { get; set;}

		[RED("onlyDebugPoint")] 		public Vector OnlyDebugPoint { get; set;}

		[RED("debugLastErrorMessage")] 		public CString DebugLastErrorMessage { get; set;}

		[RED("debugLastErrorPosition")] 		public Vector DebugLastErrorPosition { get; set;}

		[RED("debugDrawGraphics")] 		public CBool DebugDrawGraphics { get; set;}

		[RED("debugCeiling")] 		public CBool DebugCeiling { get; set;}

		[RED("debugGround")] 		public CBool DebugGround { get; set;}

		[RED("debugWall")] 		public CBool DebugWall { get; set;}

		[RED("debugHole")] 		public CBool DebugHole { get; set;}

		[RED("debugVault")] 		public CBool DebugVault { get; set;}

		[RED("debugVertSlope")] 		public CBool DebugVertSlope { get; set;}

		[RED("debugVertFree")] 		public CBool DebugVertFree { get; set;}

		[RED("debugHorSlope")] 		public CBool DebugHorSlope { get; set;}

		[RED("debugPlatform")] 		public CBool DebugPlatform { get; set;}

		[RED("vectorUp")] 		public Vector VectorUp { get; set;}

		[RED("vectorZero")] 		public Vector VectorZero { get; set;}

		public CClimbProbe(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CClimbProbe(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}