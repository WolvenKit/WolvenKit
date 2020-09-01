using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationMovementCorrector : CObject
	{
		[Ordinal(1)] [RED("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[Ordinal(2)] [RED("correctionNone")] 		public CHandle<NavigationCorrection> CorrectionNone { get; set;}

		[Ordinal(3)] [RED("correctionOnCollision")] 		public CHandle<NavigationCorrection> CorrectionOnCollision { get; set;}

		[Ordinal(4)] [RED("correctionOnPhysics")] 		public CHandle<NavigationCorrection> CorrectionOnPhysics { get; set;}

		[Ordinal(5)] [RED("correctionOnPush")] 		public CHandle<NavigationCorrection> CorrectionOnPush { get; set;}

		[Ordinal(6)] [RED("correctionOnNavMesh")] 		public CHandle<NavigationCorrection> CorrectionOnNavMesh { get; set;}

		[Ordinal(7)] [RED("correctionOnExploration")] 		public CHandle<NavigationCorrection> CorrectionOnExploration { get; set;}

		[Ordinal(8)] [RED("correctionOnDoors")] 		public CHandle<NavigationCorrection> CorrectionOnDoors { get; set;}

		[Ordinal(9)] [RED("correctionOnFalling")] 		public CHandle<NavigationCorrection> CorrectionOnFalling { get; set;}

		[Ordinal(10)] [RED("correctionAccepted")] 		public CHandle<NavigationCorrection> CorrectionAccepted { get; set;}

		[Ordinal(11)] [RED("validExploration")] 		public SExplorationQueryToken ValidExploration { get; set;}

		[Ordinal(12)] [RED("checkingForRun")] 		public CBool CheckingForRun { get; set;}

		[Ordinal(13)] [RED("checkingForCombat")] 		public CBool CheckingForCombat { get; set;}

		[Ordinal(14)] [RED("inputDiference")] 		public CFloat InputDiference { get; set;}

		[Ordinal(15)] [RED("pushSlowingTimeCooldown")] 		public CFloat PushSlowingTimeCooldown { get; set;}

		[Ordinal(16)] [RED("pushSlowingTimeCur")] 		public CFloat PushSlowingTimeCur { get; set;}

		[Ordinal(17)] [RED("maxPushAngleSlow")] 		public CFloat MaxPushAngleSlow { get; set;}

		[Ordinal(18)] [RED("maxPushAngleTurn")] 		public CFloat MaxPushAngleTurn { get; set;}

		[Ordinal(19)] [RED("pushCooldownTotal")] 		public CFloat PushCooldownTotal { get; set;}

		[Ordinal(20)] [RED("pushCooldownCur")] 		public CFloat PushCooldownCur { get; set;}

		[Ordinal(21)] [RED("pushDirection")] 		public Vector PushDirection { get; set;}

		[Ordinal(22)] [RED("collisionStopped")] 		public CBool CollisionStopped { get; set;}

		[Ordinal(23)] [RED("enableCollisionWalking")] 		public CBool EnableCollisionWalking { get; set;}

		[Ordinal(24)] [RED("enableCollisionRunning")] 		public CBool EnableCollisionRunning { get; set;}

		[Ordinal(25)] [RED("enablePushCombat")] 		public CBool EnablePushCombat { get; set;}

		[Ordinal(26)] [RED("enablePushWhileMoving")] 		public CBool EnablePushWhileMoving { get; set;}

		[Ordinal(27)] [RED("enablePhysicsWalking")] 		public CBool EnablePhysicsWalking { get; set;}

		[Ordinal(28)] [RED("enablePhysicsRunning")] 		public CBool EnablePhysicsRunning { get; set;}

		[Ordinal(29)] [RED("enableNavMeshWalking")] 		public CBool EnableNavMeshWalking { get; set;}

		[Ordinal(30)] [RED("enableNavMeshRunning")] 		public CBool EnableNavMeshRunning { get; set;}

		[Ordinal(31)] [RED("enableExplorationWalking")] 		public CBool EnableExplorationWalking { get; set;}

		[Ordinal(32)] [RED("enableExplorationRunning")] 		public CBool EnableExplorationRunning { get; set;}

		[Ordinal(33)] [RED("enableDoorsWalking")] 		public CBool EnableDoorsWalking { get; set;}

		[Ordinal(34)] [RED("enableDoorsRunning")] 		public CBool EnableDoorsRunning { get; set;}

		[Ordinal(35)] [RED("limitCorrectionTurningSide")] 		public CBool LimitCorrectionTurningSide { get; set;}

		[Ordinal(36)] [RED("inputDifToSide")] 		public CFloat InputDifToSide { get; set;}

		[Ordinal(37)] [RED("maxPhysicSideDistance")] 		public CFloat MaxPhysicSideDistance { get; set;}

		[Ordinal(38)] [RED("maxPhysicPortalDistance")] 		public CFloat MaxPhysicPortalDistance { get; set;}

		[Ordinal(39)] [RED("maxPhysicDistanceWalk")] 		public CFloat MaxPhysicDistanceWalk { get; set;}

		[Ordinal(40)] [RED("maxPhysicDistanceRun")] 		public CFloat MaxPhysicDistanceRun { get; set;}

		[Ordinal(41)] [RED("maxPhysicAngleWalk")] 		public CFloat MaxPhysicAngleWalk { get; set;}

		[Ordinal(42)] [RED("maxPhysicAngleRun")] 		public CFloat MaxPhysicAngleRun { get; set;}

		[Ordinal(43)] [RED("maxNavmeshDistanceWalk")] 		public CFloat MaxNavmeshDistanceWalk { get; set;}

		[Ordinal(44)] [RED("maxNavmeshDistanceRun")] 		public CFloat MaxNavmeshDistanceRun { get; set;}

		[Ordinal(45)] [RED("maxNavmeshAngleWalk")] 		public CFloat MaxNavmeshAngleWalk { get; set;}

		[Ordinal(46)] [RED("maxNavmeshAngleRun")] 		public CFloat MaxNavmeshAngleRun { get; set;}

		[Ordinal(47)] [RED("maxExplorationDistanceWalk")] 		public CFloat MaxExplorationDistanceWalk { get; set;}

		[Ordinal(48)] [RED("maxExplorationDistanceRun")] 		public CFloat MaxExplorationDistanceRun { get; set;}

		[Ordinal(49)] [RED("maxExplorationAngleWalk")] 		public CFloat MaxExplorationAngleWalk { get; set;}

		[Ordinal(50)] [RED("maxExplorationAngleRun")] 		public CFloat MaxExplorationAngleRun { get; set;}

		[Ordinal(51)] [RED("maxDoorDistanceWalk")] 		public CFloat MaxDoorDistanceWalk { get; set;}

		[Ordinal(52)] [RED("maxDoorDistanceRun")] 		public CFloat MaxDoorDistanceRun { get; set;}

		[Ordinal(53)] [RED("maxDoorAngleWalk")] 		public CFloat MaxDoorAngleWalk { get; set;}

		[Ordinal(54)] [RED("maxDoorAngleRun")] 		public CFloat MaxDoorAngleRun { get; set;}

		[Ordinal(55)] [RED("maxDoorAngleGather")] 		public CFloat MaxDoorAngleGather { get; set;}

		[Ordinal(56)] [RED("maxDoorBack")] 		public CFloat MaxDoorBack { get; set;}

		[Ordinal(57)] [RED("maxDoorHeight")] 		public CFloat MaxDoorHeight { get; set;}

		[Ordinal(58)] [RED("turnAdjustBlocked")] 		public CBool TurnAdjustBlocked { get; set;}

		[Ordinal(59)] [RED("animEventBlockTurnAdjust")] 		public CName AnimEventBlockTurnAdjust { get; set;}

		[Ordinal(60)] [RED("turnAdjustmentEnabled")] 		public CBool TurnAdjustmentEnabled { get; set;}

		[Ordinal(61)] [RED("turnAdjustmentTimeCur")] 		public CFloat TurnAdjustmentTimeCur { get; set;}

		[Ordinal(62)] [RED("turnAdjustmentTimeMax")] 		public CFloat TurnAdjustmentTimeMax { get; set;}

		[Ordinal(63)] [RED("inputLastModule")] 		public CFloat InputLastModule { get; set;}

		[Ordinal(64)] [RED("inputSpeedLast")] 		public CFloat InputSpeedLast { get; set;}

		[Ordinal(65)] [RED("inputSpeedToStartRun")] 		public CFloat InputSpeedToStartRun { get; set;}

		[Ordinal(66)] [RED("inputSpeedToStartRunHiFPS")] 		public CFloat InputSpeedToStartRunHiFPS { get; set;}

		[Ordinal(67)] [RED("cameraRequestByDoor")] 		public CBool CameraRequestByDoor { get; set;}

		[Ordinal(68)] [RED("doorPoint")] 		public Vector DoorPoint { get; set;}

		[Ordinal(69)] [RED("auxDiff")] 		public CFloat AuxDiff { get; set;}

		[Ordinal(70)] [RED("debugPush")] 		public CBool DebugPush { get; set;}

		[Ordinal(71)] [RED("debugingSpeed")] 		public CBool DebugingSpeed { get; set;}

		[Ordinal(72)] [RED("disallowRotWhenGoingToSleep")] 		public CBool DisallowRotWhenGoingToSleep { get; set;}

		public CExplorationMovementCorrector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationMovementCorrector(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}