using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CClimbProbe : CObject
	{
		[Ordinal(1)] [RED("valid")] 		public CBool Valid { get; set;}

		[Ordinal(2)] [RED("setupReady")] 		public CBool SetupReady { get; set;}

		[Ordinal(3)] [RED("exploratorPosition")] 		public Vector ExploratorPosition { get; set;}

		[Ordinal(4)] [RED("directionChecking")] 		public Vector DirectionChecking { get; set;}

		[Ordinal(5)] [RED("directionRequiresInput")] 		public CBool DirectionRequiresInput { get; set;}

		[Ordinal(6)] [RED("distForwardToCheck")] 		public CFloat DistForwardToCheck { get; set;}

		[Ordinal(7)] [RED("distanceCheckType")] 		public CEnum<EClimbDistanceType> DistanceCheckType { get; set;}

		[Ordinal(8)] [RED("distForwardToCheckClose")] 		public CFloat DistForwardToCheckClose { get; set;}

		[Ordinal(9)] [RED("distForwardToCheckMedium")] 		public CFloat DistForwardToCheckMedium { get; set;}

		[Ordinal(10)] [RED("maxAttempts")] 		public CInt32 MaxAttempts { get; set;}

		[Ordinal(11)] [RED("distForwardToCheckLong")] 		public CFloat DistForwardToCheckLong { get; set;}

		[Ordinal(12)] [RED("characterRadius")] 		public CFloat CharacterRadius { get; set;}

		[Ordinal(13)] [RED("heightTotalMin")] 		public CFloat HeightTotalMin { get; set;}

		[Ordinal(14)] [RED("heightTotalMax")] 		public CFloat HeightTotalMax { get; set;}

		[Ordinal(15)] [RED("ceilingDoubleCheck")] 		public CBool CeilingDoubleCheck { get; set;}

		[Ordinal(16)] [RED("ceilingCheckingClose")] 		public CBool CeilingCheckingClose { get; set;}

		[Ordinal(17)] [RED("ceilingBackOffsetClose")] 		public CFloat CeilingBackOffsetClose { get; set;}

		[Ordinal(18)] [RED("ceilingBackOffsetFar")] 		public CFloat CeilingBackOffsetFar { get; set;}

		[Ordinal(19)] [RED("ceilingHeightNeeded")] 		public CFloat CeilingHeightNeeded { get; set;}

		[Ordinal(20)] [RED("ceilingRadius")] 		public CFloat CeilingRadius { get; set;}

		[Ordinal(21)] [RED("ceilingFound")] 		public CBool CeilingFound { get; set;}

		[Ordinal(22)] [RED("ceilingPoint")] 		public Vector CeilingPoint { get; set;}

		[Ordinal(23)] [RED("ceilingHeightFree")] 		public CFloat CeilingHeightFree { get; set;}

		[Ordinal(24)] [RED("ceilingCheckFrom")] 		public Vector CeilingCheckFrom { get; set;}

		[Ordinal(25)] [RED("ceilingCheckTo")] 		public Vector CeilingCheckTo { get; set;}

		[Ordinal(26)] [RED("groundRadiusToCheck")] 		public CFloat GroundRadiusToCheck { get; set;}

		[Ordinal(27)] [RED("groundNormalMinZ")] 		public CFloat GroundNormalMinZ { get; set;}

		[Ordinal(28)] [RED("groundFound")] 		public CBool GroundFound { get; set;}

		[Ordinal(29)] [RED("groundEndPoint")] 		public Vector GroundEndPoint { get; set;}

		[Ordinal(30)] [RED("groundEndNormal")] 		public Vector GroundEndNormal { get; set;}

		[Ordinal(31)] [RED("heightTarget")] 		public CFloat HeightTarget { get; set;}

		[Ordinal(32)] [RED("heightAdded")] 		public CFloat HeightAdded { get; set;}

		[Ordinal(33)] [RED("groundCheckFrom")] 		public Vector GroundCheckFrom { get; set;}

		[Ordinal(34)] [RED("groundCheckTo")] 		public Vector GroundCheckTo { get; set;}

		[Ordinal(35)] [RED("groundRefineEnabled")] 		public CBool GroundRefineEnabled { get; set;}

		[Ordinal(36)] [RED("groundRefineDistCheck")] 		public CFloat GroundRefineDistCheck { get; set;}

		[Ordinal(37)] [RED("groundRefineHeightCheck")] 		public CFloat GroundRefineHeightCheck { get; set;}

		[Ordinal(38)] [RED("groundRefineRadius")] 		public CFloat GroundRefineRadius { get; set;}

		[Ordinal(39)] [RED("groundRefined")] 		public CBool GroundRefined { get; set;}

		[Ordinal(40)] [RED("climbableFound")] 		public CBool ClimbableFound { get; set;}

		[Ordinal(41)] [RED("climbableObjName")] 		public CString ClimbableObjName { get; set;}

		[Ordinal(42)] [RED("climbableObjTagOnLayer")] 		public CBool ClimbableObjTagOnLayer { get; set;}

		[Ordinal(43)] [RED("climbableObjForceAllow")] 		public CBool ClimbableObjForceAllow { get; set;}

		[Ordinal(44)] [RED("climbablePoint")] 		public Vector ClimbablePoint { get; set;}

		[Ordinal(45)] [RED("climbableRadius")] 		public CFloat ClimbableRadius { get; set;}

		[Ordinal(46)] [RED("climbableLockTag")] 		public CName ClimbableLockTag { get; set;}

		[Ordinal(47)] [RED("climbableUnLockTag")] 		public CName ClimbableUnLockTag { get; set;}

		[Ordinal(48)] [RED("holeForwardNeeded")] 		public CFloat HoleForwardNeeded { get; set;}

		[Ordinal(49)] [RED("holeIsBlocked")] 		public CBool HoleIsBlocked { get; set;}

		[Ordinal(50)] [RED("holeCollision")] 		public Vector HoleCollision { get; set;}

		[Ordinal(51)] [RED("holeCheckFrom")] 		public Vector HoleCheckFrom { get; set;}

		[Ordinal(52)] [RED("holeCheckTo")] 		public Vector HoleCheckTo { get; set;}

		[Ordinal(53)] [RED("wallRadiusToCheck")] 		public CFloat WallRadiusToCheck { get; set;}

		[Ordinal(54)] [RED("wallNormalCheckBackExtra")] 		public CFloat WallNormalCheckBackExtra { get; set;}

		[Ordinal(55)] [RED("wallSideSeparation")] 		public CFloat WallSideSeparation { get; set;}

		[Ordinal(56)] [RED("wallFound")] 		public CBool WallFound { get; set;}

		[Ordinal(57)] [RED("wallNormalOrigin")] 		public Vector WallNormalOrigin { get; set;}

		[Ordinal(58)] [RED("wallNormalDirection")] 		public Vector WallNormalDirection { get; set;}

		[Ordinal(59)] [RED("wallCheckFromL")] 		public Vector WallCheckFromL { get; set;}

		[Ordinal(60)] [RED("wallCheckToL")] 		public Vector WallCheckToL { get; set;}

		[Ordinal(61)] [RED("wallCheckFromR")] 		public Vector WallCheckFromR { get; set;}

		[Ordinal(62)] [RED("wallCheckToR")] 		public Vector WallCheckToR { get; set;}

		[Ordinal(63)] [RED("wallCollL")] 		public Vector WallCollL { get; set;}

		[Ordinal(64)] [RED("wallCollR")] 		public Vector WallCollR { get; set;}

		[Ordinal(65)] [RED("slopeAngleMax")] 		public CFloat SlopeAngleMax { get; set;}

		[Ordinal(66)] [RED("slopeNormalZMax")] 		public CFloat SlopeNormalZMax { get; set;}

		[Ordinal(67)] [RED("slopeForwardDistance")] 		public CFloat SlopeForwardDistance { get; set;}

		[Ordinal(68)] [RED("slopeLeftDistance")] 		public CFloat SlopeLeftDistance { get; set;}

		[Ordinal(69)] [RED("horizHeightRdius")] 		public CFloat HorizHeightRdius { get; set;}

		[Ordinal(70)] [RED("horizHeightSeparation")] 		public CFloat HorizHeightSeparation { get; set;}

		[Ordinal(71)] [RED("horizHeightAngleMin")] 		public CFloat HorizHeightAngleMin { get; set;}

		[Ordinal(72)] [RED("horizHeightAngleMax")] 		public CFloat HorizHeightAngleMax { get; set;}

		[Ordinal(73)] [RED("horizFoundLeft")] 		public CBool HorizFoundLeft { get; set;}

		[Ordinal(74)] [RED("horizFoundRight")] 		public CBool HorizFoundRight { get; set;}

		[Ordinal(75)] [RED("horizHeightAngleCur")] 		public CFloat HorizHeightAngleCur { get; set;}

		[Ordinal(76)] [RED("horizPointLeft")] 		public Vector HorizPointLeft { get; set;}

		[Ordinal(77)] [RED("horizPointRight")] 		public Vector HorizPointRight { get; set;}

		[Ordinal(78)] [RED("horizCorrectSideCoef")] 		public CFloat HorizCorrectSideCoef { get; set;}

		[Ordinal(79)] [RED("vertSlopeAngleOffset")] 		public CFloat VertSlopeAngleOffset { get; set;}

		[Ordinal(80)] [RED("vertSlopeAngleMax")] 		public CFloat VertSlopeAngleMax { get; set;}

		[Ordinal(81)] [RED("vertSlopeAngleCur")] 		public CFloat VertSlopeAngleCur { get; set;}

		[Ordinal(82)] [RED("vertSlopeAngleFrom")] 		public Vector VertSlopeAngleFrom { get; set;}

		[Ordinal(83)] [RED("vertSlopeAngleTo")] 		public Vector VertSlopeAngleTo { get; set;}

		[Ordinal(84)] [RED("vertSlopeAnglePoint")] 		public Vector VertSlopeAnglePoint { get; set;}

		[Ordinal(85)] [RED("vertSlopeAngleLowOffset")] 		public CFloat VertSlopeAngleLowOffset { get; set;}

		[Ordinal(86)] [RED("vertSlopeLowAngleMax")] 		public CFloat VertSlopeLowAngleMax { get; set;}

		[Ordinal(87)] [RED("vertSlopeLowAngleCur")] 		public CFloat VertSlopeLowAngleCur { get; set;}

		[Ordinal(88)] [RED("vertSlopeLowAngleFrom")] 		public Vector VertSlopeLowAngleFrom { get; set;}

		[Ordinal(89)] [RED("vertSlopeLowAngleTo")] 		public Vector VertSlopeLowAngleTo { get; set;}

		[Ordinal(90)] [RED("vertSlopeLowAnglePoint")] 		public Vector VertSlopeLowAnglePoint { get; set;}

		[Ordinal(91)] [RED("vertFreeHeightEnable")] 		public CBool VertFreeHeightEnable { get; set;}

		[Ordinal(92)] [RED("vertFreeHorOffset")] 		public CFloat VertFreeHorOffset { get; set;}

		[Ordinal(93)] [RED("vertFreeHorMin")] 		public CFloat VertFreeHorMin { get; set;}

		[Ordinal(94)] [RED("vertFreeHeightMin")] 		public CFloat VertFreeHeightMin { get; set;}

		[Ordinal(95)] [RED("vertFreeHeightGrndMax")] 		public CFloat VertFreeHeightGrndMax { get; set;}

		[Ordinal(96)] [RED("vertFreeHeightCur")] 		public CFloat VertFreeHeightCur { get; set;}

		[Ordinal(97)] [RED("vertFreeFrom")] 		public Vector VertFreeFrom { get; set;}

		[Ordinal(98)] [RED("vertFreeTo")] 		public Vector VertFreeTo { get; set;}

		[Ordinal(99)] [RED("vertFreeCollPoint")] 		public Vector VertFreeCollPoint { get; set;}

		[Ordinal(100)] [RED("vaultHeight")] 		public CFloat VaultHeight { get; set;}

		[Ordinal(101)] [RED("vaultHeightOffset")] 		public CFloat VaultHeightOffset { get; set;}

		[Ordinal(102)] [RED("vaultDistance")] 		public CFloat VaultDistance { get; set;}

		[Ordinal(103)] [RED("vaultRadius")] 		public CFloat VaultRadius { get; set;}

		[Ordinal(104)] [RED("heightOffsetToEndFall")] 		public CFloat HeightOffsetToEndFall { get; set;}

		[Ordinal(105)] [RED("heighAbsToEndFall")] 		public CFloat HeighAbsToEndFall { get; set;}

		[Ordinal(106)] [RED("vaultingFound")] 		public CEnum<EClimbRequirementVault> VaultingFound { get; set;}

		[Ordinal(107)] [RED("vaultCollision")] 		public Vector VaultCollision { get; set;}

		[Ordinal(108)] [RED("vaultEndsFalling")] 		public CBool VaultEndsFalling { get; set;}

		[Ordinal(109)] [RED("vaultCheckFrom")] 		public Vector VaultCheckFrom { get; set;}

		[Ordinal(110)] [RED("vaultCheckTo")] 		public Vector VaultCheckTo { get; set;}

		[Ordinal(111)] [RED("platformFound")] 		public CEnum<EClimbRequirementPlatform> PlatformFound { get; set;}

		[Ordinal(112)] [RED("platformFrom")] 		public Vector PlatformFrom { get; set;}

		[Ordinal(113)] [RED("platformTo")] 		public Vector PlatformTo { get; set;}

		[Ordinal(114)] [RED("platformCollision")] 		public Vector PlatformCollision { get; set;}

		[Ordinal(115)] [RED("platformHeightDown")] 		public CFloat PlatformHeightDown { get; set;}

		[Ordinal(116)] [RED("platformRadius")] 		public CFloat PlatformRadius { get; set;}

		[Ordinal(117)] [RED("platformDeep")] 		public CFloat PlatformDeep { get; set;}

		[Ordinal(118)] [RED("platformMinToCheck")] 		public CFloat PlatformMinToCheck { get; set;}

		[Ordinal(119)] [RED("collisionClimbableNames", 2,0)] 		public CArray<CName> CollisionClimbableNames { get; set;}

		[Ordinal(120)] [RED("collisionObstaclesNames", 2,0)] 		public CArray<CName> CollisionObstaclesNames { get; set;}

		[Ordinal(121)] [RED("collisionForceAllowNames", 2,0)] 		public CArray<CName> CollisionForceAllowNames { get; set;}

		[Ordinal(122)] [RED("collisionLockNames", 2,0)] 		public CArray<CName> CollisionLockNames { get; set;}

		[Ordinal(123)] [RED("debugPrefix")] 		public CString DebugPrefix { get; set;}

		[Ordinal(124)] [RED("debugIsTop")] 		public CString DebugIsTop { get; set;}

		[Ordinal(125)] [RED("debugColorDiv")] 		public CInt32 DebugColorDiv { get; set;}

		[Ordinal(126)] [RED("debugLogFails")] 		public CBool DebugLogFails { get; set;}

		[Ordinal(127)] [RED("onlyDebugPoint")] 		public Vector OnlyDebugPoint { get; set;}

		[Ordinal(128)] [RED("debugLastErrorMessage")] 		public CString DebugLastErrorMessage { get; set;}

		[Ordinal(129)] [RED("debugLastErrorPosition")] 		public Vector DebugLastErrorPosition { get; set;}

		[Ordinal(130)] [RED("debugDrawGraphics")] 		public CBool DebugDrawGraphics { get; set;}

		[Ordinal(131)] [RED("debugCeiling")] 		public CBool DebugCeiling { get; set;}

		[Ordinal(132)] [RED("debugGround")] 		public CBool DebugGround { get; set;}

		[Ordinal(133)] [RED("debugWall")] 		public CBool DebugWall { get; set;}

		[Ordinal(134)] [RED("debugHole")] 		public CBool DebugHole { get; set;}

		[Ordinal(135)] [RED("debugVault")] 		public CBool DebugVault { get; set;}

		[Ordinal(136)] [RED("debugVertSlope")] 		public CBool DebugVertSlope { get; set;}

		[Ordinal(137)] [RED("debugVertFree")] 		public CBool DebugVertFree { get; set;}

		[Ordinal(138)] [RED("debugHorSlope")] 		public CBool DebugHorSlope { get; set;}

		[Ordinal(139)] [RED("debugPlatform")] 		public CBool DebugPlatform { get; set;}

		[Ordinal(140)] [RED("vectorUp")] 		public Vector VectorUp { get; set;}

		[Ordinal(141)] [RED("vectorZero")] 		public Vector VectorZero { get; set;}

		public CClimbProbe(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}