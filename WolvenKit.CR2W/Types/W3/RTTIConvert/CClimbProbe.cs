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
		[Ordinal(0)] [RED("valid")] 		public CBool Valid { get; set;}

		[Ordinal(0)] [RED("setupReady")] 		public CBool SetupReady { get; set;}

		[Ordinal(0)] [RED("exploratorPosition")] 		public Vector ExploratorPosition { get; set;}

		[Ordinal(0)] [RED("directionChecking")] 		public Vector DirectionChecking { get; set;}

		[Ordinal(0)] [RED("directionRequiresInput")] 		public CBool DirectionRequiresInput { get; set;}

		[Ordinal(0)] [RED("distForwardToCheck")] 		public CFloat DistForwardToCheck { get; set;}

		[Ordinal(0)] [RED("distanceCheckType")] 		public CEnum<EClimbDistanceType> DistanceCheckType { get; set;}

		[Ordinal(0)] [RED("distForwardToCheckClose")] 		public CFloat DistForwardToCheckClose { get; set;}

		[Ordinal(0)] [RED("distForwardToCheckMedium")] 		public CFloat DistForwardToCheckMedium { get; set;}

		[Ordinal(0)] [RED("maxAttempts")] 		public CInt32 MaxAttempts { get; set;}

		[Ordinal(0)] [RED("distForwardToCheckLong")] 		public CFloat DistForwardToCheckLong { get; set;}

		[Ordinal(0)] [RED("characterRadius")] 		public CFloat CharacterRadius { get; set;}

		[Ordinal(0)] [RED("heightTotalMin")] 		public CFloat HeightTotalMin { get; set;}

		[Ordinal(0)] [RED("heightTotalMax")] 		public CFloat HeightTotalMax { get; set;}

		[Ordinal(0)] [RED("ceilingDoubleCheck")] 		public CBool CeilingDoubleCheck { get; set;}

		[Ordinal(0)] [RED("ceilingCheckingClose")] 		public CBool CeilingCheckingClose { get; set;}

		[Ordinal(0)] [RED("ceilingBackOffsetClose")] 		public CFloat CeilingBackOffsetClose { get; set;}

		[Ordinal(0)] [RED("ceilingBackOffsetFar")] 		public CFloat CeilingBackOffsetFar { get; set;}

		[Ordinal(0)] [RED("ceilingHeightNeeded")] 		public CFloat CeilingHeightNeeded { get; set;}

		[Ordinal(0)] [RED("ceilingRadius")] 		public CFloat CeilingRadius { get; set;}

		[Ordinal(0)] [RED("ceilingFound")] 		public CBool CeilingFound { get; set;}

		[Ordinal(0)] [RED("ceilingPoint")] 		public Vector CeilingPoint { get; set;}

		[Ordinal(0)] [RED("ceilingHeightFree")] 		public CFloat CeilingHeightFree { get; set;}

		[Ordinal(0)] [RED("ceilingCheckFrom")] 		public Vector CeilingCheckFrom { get; set;}

		[Ordinal(0)] [RED("ceilingCheckTo")] 		public Vector CeilingCheckTo { get; set;}

		[Ordinal(0)] [RED("groundRadiusToCheck")] 		public CFloat GroundRadiusToCheck { get; set;}

		[Ordinal(0)] [RED("groundNormalMinZ")] 		public CFloat GroundNormalMinZ { get; set;}

		[Ordinal(0)] [RED("groundFound")] 		public CBool GroundFound { get; set;}

		[Ordinal(0)] [RED("groundEndPoint")] 		public Vector GroundEndPoint { get; set;}

		[Ordinal(0)] [RED("groundEndNormal")] 		public Vector GroundEndNormal { get; set;}

		[Ordinal(0)] [RED("heightTarget")] 		public CFloat HeightTarget { get; set;}

		[Ordinal(0)] [RED("heightAdded")] 		public CFloat HeightAdded { get; set;}

		[Ordinal(0)] [RED("groundCheckFrom")] 		public Vector GroundCheckFrom { get; set;}

		[Ordinal(0)] [RED("groundCheckTo")] 		public Vector GroundCheckTo { get; set;}

		[Ordinal(0)] [RED("groundRefineEnabled")] 		public CBool GroundRefineEnabled { get; set;}

		[Ordinal(0)] [RED("groundRefineDistCheck")] 		public CFloat GroundRefineDistCheck { get; set;}

		[Ordinal(0)] [RED("groundRefineHeightCheck")] 		public CFloat GroundRefineHeightCheck { get; set;}

		[Ordinal(0)] [RED("groundRefineRadius")] 		public CFloat GroundRefineRadius { get; set;}

		[Ordinal(0)] [RED("groundRefined")] 		public CBool GroundRefined { get; set;}

		[Ordinal(0)] [RED("climbableFound")] 		public CBool ClimbableFound { get; set;}

		[Ordinal(0)] [RED("climbableObjName")] 		public CString ClimbableObjName { get; set;}

		[Ordinal(0)] [RED("climbableObjTagOnLayer")] 		public CBool ClimbableObjTagOnLayer { get; set;}

		[Ordinal(0)] [RED("climbableObjForceAllow")] 		public CBool ClimbableObjForceAllow { get; set;}

		[Ordinal(0)] [RED("climbablePoint")] 		public Vector ClimbablePoint { get; set;}

		[Ordinal(0)] [RED("climbableRadius")] 		public CFloat ClimbableRadius { get; set;}

		[Ordinal(0)] [RED("climbableLockTag")] 		public CName ClimbableLockTag { get; set;}

		[Ordinal(0)] [RED("climbableUnLockTag")] 		public CName ClimbableUnLockTag { get; set;}

		[Ordinal(0)] [RED("holeForwardNeeded")] 		public CFloat HoleForwardNeeded { get; set;}

		[Ordinal(0)] [RED("holeIsBlocked")] 		public CBool HoleIsBlocked { get; set;}

		[Ordinal(0)] [RED("holeCollision")] 		public Vector HoleCollision { get; set;}

		[Ordinal(0)] [RED("holeCheckFrom")] 		public Vector HoleCheckFrom { get; set;}

		[Ordinal(0)] [RED("holeCheckTo")] 		public Vector HoleCheckTo { get; set;}

		[Ordinal(0)] [RED("wallRadiusToCheck")] 		public CFloat WallRadiusToCheck { get; set;}

		[Ordinal(0)] [RED("wallNormalCheckBackExtra")] 		public CFloat WallNormalCheckBackExtra { get; set;}

		[Ordinal(0)] [RED("wallSideSeparation")] 		public CFloat WallSideSeparation { get; set;}

		[Ordinal(0)] [RED("wallFound")] 		public CBool WallFound { get; set;}

		[Ordinal(0)] [RED("wallNormalOrigin")] 		public Vector WallNormalOrigin { get; set;}

		[Ordinal(0)] [RED("wallNormalDirection")] 		public Vector WallNormalDirection { get; set;}

		[Ordinal(0)] [RED("wallCheckFromL")] 		public Vector WallCheckFromL { get; set;}

		[Ordinal(0)] [RED("wallCheckToL")] 		public Vector WallCheckToL { get; set;}

		[Ordinal(0)] [RED("wallCheckFromR")] 		public Vector WallCheckFromR { get; set;}

		[Ordinal(0)] [RED("wallCheckToR")] 		public Vector WallCheckToR { get; set;}

		[Ordinal(0)] [RED("wallCollL")] 		public Vector WallCollL { get; set;}

		[Ordinal(0)] [RED("wallCollR")] 		public Vector WallCollR { get; set;}

		[Ordinal(0)] [RED("slopeAngleMax")] 		public CFloat SlopeAngleMax { get; set;}

		[Ordinal(0)] [RED("slopeNormalZMax")] 		public CFloat SlopeNormalZMax { get; set;}

		[Ordinal(0)] [RED("slopeForwardDistance")] 		public CFloat SlopeForwardDistance { get; set;}

		[Ordinal(0)] [RED("slopeLeftDistance")] 		public CFloat SlopeLeftDistance { get; set;}

		[Ordinal(0)] [RED("horizHeightRdius")] 		public CFloat HorizHeightRdius { get; set;}

		[Ordinal(0)] [RED("horizHeightSeparation")] 		public CFloat HorizHeightSeparation { get; set;}

		[Ordinal(0)] [RED("horizHeightAngleMin")] 		public CFloat HorizHeightAngleMin { get; set;}

		[Ordinal(0)] [RED("horizHeightAngleMax")] 		public CFloat HorizHeightAngleMax { get; set;}

		[Ordinal(0)] [RED("horizFoundLeft")] 		public CBool HorizFoundLeft { get; set;}

		[Ordinal(0)] [RED("horizFoundRight")] 		public CBool HorizFoundRight { get; set;}

		[Ordinal(0)] [RED("horizHeightAngleCur")] 		public CFloat HorizHeightAngleCur { get; set;}

		[Ordinal(0)] [RED("horizPointLeft")] 		public Vector HorizPointLeft { get; set;}

		[Ordinal(0)] [RED("horizPointRight")] 		public Vector HorizPointRight { get; set;}

		[Ordinal(0)] [RED("horizCorrectSideCoef")] 		public CFloat HorizCorrectSideCoef { get; set;}

		[Ordinal(0)] [RED("vertSlopeAngleOffset")] 		public CFloat VertSlopeAngleOffset { get; set;}

		[Ordinal(0)] [RED("vertSlopeAngleMax")] 		public CFloat VertSlopeAngleMax { get; set;}

		[Ordinal(0)] [RED("vertSlopeAngleCur")] 		public CFloat VertSlopeAngleCur { get; set;}

		[Ordinal(0)] [RED("vertSlopeAngleFrom")] 		public Vector VertSlopeAngleFrom { get; set;}

		[Ordinal(0)] [RED("vertSlopeAngleTo")] 		public Vector VertSlopeAngleTo { get; set;}

		[Ordinal(0)] [RED("vertSlopeAnglePoint")] 		public Vector VertSlopeAnglePoint { get; set;}

		[Ordinal(0)] [RED("vertSlopeAngleLowOffset")] 		public CFloat VertSlopeAngleLowOffset { get; set;}

		[Ordinal(0)] [RED("vertSlopeLowAngleMax")] 		public CFloat VertSlopeLowAngleMax { get; set;}

		[Ordinal(0)] [RED("vertSlopeLowAngleCur")] 		public CFloat VertSlopeLowAngleCur { get; set;}

		[Ordinal(0)] [RED("vertSlopeLowAngleFrom")] 		public Vector VertSlopeLowAngleFrom { get; set;}

		[Ordinal(0)] [RED("vertSlopeLowAngleTo")] 		public Vector VertSlopeLowAngleTo { get; set;}

		[Ordinal(0)] [RED("vertSlopeLowAnglePoint")] 		public Vector VertSlopeLowAnglePoint { get; set;}

		[Ordinal(0)] [RED("vertFreeHeightEnable")] 		public CBool VertFreeHeightEnable { get; set;}

		[Ordinal(0)] [RED("vertFreeHorOffset")] 		public CFloat VertFreeHorOffset { get; set;}

		[Ordinal(0)] [RED("vertFreeHorMin")] 		public CFloat VertFreeHorMin { get; set;}

		[Ordinal(0)] [RED("vertFreeHeightMin")] 		public CFloat VertFreeHeightMin { get; set;}

		[Ordinal(0)] [RED("vertFreeHeightGrndMax")] 		public CFloat VertFreeHeightGrndMax { get; set;}

		[Ordinal(0)] [RED("vertFreeHeightCur")] 		public CFloat VertFreeHeightCur { get; set;}

		[Ordinal(0)] [RED("vertFreeFrom")] 		public Vector VertFreeFrom { get; set;}

		[Ordinal(0)] [RED("vertFreeTo")] 		public Vector VertFreeTo { get; set;}

		[Ordinal(0)] [RED("vertFreeCollPoint")] 		public Vector VertFreeCollPoint { get; set;}

		[Ordinal(0)] [RED("vaultHeight")] 		public CFloat VaultHeight { get; set;}

		[Ordinal(0)] [RED("vaultHeightOffset")] 		public CFloat VaultHeightOffset { get; set;}

		[Ordinal(0)] [RED("vaultDistance")] 		public CFloat VaultDistance { get; set;}

		[Ordinal(0)] [RED("vaultRadius")] 		public CFloat VaultRadius { get; set;}

		[Ordinal(0)] [RED("heightOffsetToEndFall")] 		public CFloat HeightOffsetToEndFall { get; set;}

		[Ordinal(0)] [RED("heighAbsToEndFall")] 		public CFloat HeighAbsToEndFall { get; set;}

		[Ordinal(0)] [RED("vaultingFound")] 		public CEnum<EClimbRequirementVault> VaultingFound { get; set;}

		[Ordinal(0)] [RED("vaultCollision")] 		public Vector VaultCollision { get; set;}

		[Ordinal(0)] [RED("vaultEndsFalling")] 		public CBool VaultEndsFalling { get; set;}

		[Ordinal(0)] [RED("vaultCheckFrom")] 		public Vector VaultCheckFrom { get; set;}

		[Ordinal(0)] [RED("vaultCheckTo")] 		public Vector VaultCheckTo { get; set;}

		[Ordinal(0)] [RED("platformFound")] 		public CEnum<EClimbRequirementPlatform> PlatformFound { get; set;}

		[Ordinal(0)] [RED("platformFrom")] 		public Vector PlatformFrom { get; set;}

		[Ordinal(0)] [RED("platformTo")] 		public Vector PlatformTo { get; set;}

		[Ordinal(0)] [RED("platformCollision")] 		public Vector PlatformCollision { get; set;}

		[Ordinal(0)] [RED("platformHeightDown")] 		public CFloat PlatformHeightDown { get; set;}

		[Ordinal(0)] [RED("platformRadius")] 		public CFloat PlatformRadius { get; set;}

		[Ordinal(0)] [RED("platformDeep")] 		public CFloat PlatformDeep { get; set;}

		[Ordinal(0)] [RED("platformMinToCheck")] 		public CFloat PlatformMinToCheck { get; set;}

		[Ordinal(0)] [RED("collisionClimbableNames", 2,0)] 		public CArray<CName> CollisionClimbableNames { get; set;}

		[Ordinal(0)] [RED("collisionObstaclesNames", 2,0)] 		public CArray<CName> CollisionObstaclesNames { get; set;}

		[Ordinal(0)] [RED("collisionForceAllowNames", 2,0)] 		public CArray<CName> CollisionForceAllowNames { get; set;}

		[Ordinal(0)] [RED("collisionLockNames", 2,0)] 		public CArray<CName> CollisionLockNames { get; set;}

		[Ordinal(0)] [RED("debugPrefix")] 		public CString DebugPrefix { get; set;}

		[Ordinal(0)] [RED("debugIsTop")] 		public CString DebugIsTop { get; set;}

		[Ordinal(0)] [RED("debugColorDiv")] 		public CInt32 DebugColorDiv { get; set;}

		[Ordinal(0)] [RED("debugLogFails")] 		public CBool DebugLogFails { get; set;}

		[Ordinal(0)] [RED("onlyDebugPoint")] 		public Vector OnlyDebugPoint { get; set;}

		[Ordinal(0)] [RED("debugLastErrorMessage")] 		public CString DebugLastErrorMessage { get; set;}

		[Ordinal(0)] [RED("debugLastErrorPosition")] 		public Vector DebugLastErrorPosition { get; set;}

		[Ordinal(0)] [RED("debugDrawGraphics")] 		public CBool DebugDrawGraphics { get; set;}

		[Ordinal(0)] [RED("debugCeiling")] 		public CBool DebugCeiling { get; set;}

		[Ordinal(0)] [RED("debugGround")] 		public CBool DebugGround { get; set;}

		[Ordinal(0)] [RED("debugWall")] 		public CBool DebugWall { get; set;}

		[Ordinal(0)] [RED("debugHole")] 		public CBool DebugHole { get; set;}

		[Ordinal(0)] [RED("debugVault")] 		public CBool DebugVault { get; set;}

		[Ordinal(0)] [RED("debugVertSlope")] 		public CBool DebugVertSlope { get; set;}

		[Ordinal(0)] [RED("debugVertFree")] 		public CBool DebugVertFree { get; set;}

		[Ordinal(0)] [RED("debugHorSlope")] 		public CBool DebugHorSlope { get; set;}

		[Ordinal(0)] [RED("debugPlatform")] 		public CBool DebugPlatform { get; set;}

		[Ordinal(0)] [RED("vectorUp")] 		public Vector VectorUp { get; set;}

		[Ordinal(0)] [RED("vectorZero")] 		public Vector VectorZero { get; set;}

		public CClimbProbe(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CClimbProbe(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}