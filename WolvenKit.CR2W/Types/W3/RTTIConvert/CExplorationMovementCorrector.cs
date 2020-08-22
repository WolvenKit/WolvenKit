using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationMovementCorrector : CObject
	{
		[RED("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[RED("correctionNone")] 		public CHandle<NavigationCorrection> CorrectionNone { get; set;}

		[RED("correctionOnCollision")] 		public CHandle<NavigationCorrection> CorrectionOnCollision { get; set;}

		[RED("correctionOnPhysics")] 		public CHandle<NavigationCorrection> CorrectionOnPhysics { get; set;}

		[RED("correctionOnPush")] 		public CHandle<NavigationCorrection> CorrectionOnPush { get; set;}

		[RED("correctionOnNavMesh")] 		public CHandle<NavigationCorrection> CorrectionOnNavMesh { get; set;}

		[RED("correctionOnExploration")] 		public CHandle<NavigationCorrection> CorrectionOnExploration { get; set;}

		[RED("correctionOnDoors")] 		public CHandle<NavigationCorrection> CorrectionOnDoors { get; set;}

		[RED("correctionOnFalling")] 		public CHandle<NavigationCorrection> CorrectionOnFalling { get; set;}

		[RED("correctionAccepted")] 		public CHandle<NavigationCorrection> CorrectionAccepted { get; set;}

		[RED("validExploration")] 		public SExplorationQueryToken ValidExploration { get; set;}

		[RED("checkingForRun")] 		public CBool CheckingForRun { get; set;}

		[RED("checkingForCombat")] 		public CBool CheckingForCombat { get; set;}

		[RED("inputDiference")] 		public CFloat InputDiference { get; set;}

		[RED("pushSlowingTimeCooldown")] 		public CFloat PushSlowingTimeCooldown { get; set;}

		[RED("pushSlowingTimeCur")] 		public CFloat PushSlowingTimeCur { get; set;}

		[RED("maxPushAngleSlow")] 		public CFloat MaxPushAngleSlow { get; set;}

		[RED("maxPushAngleTurn")] 		public CFloat MaxPushAngleTurn { get; set;}

		[RED("pushCooldownTotal")] 		public CFloat PushCooldownTotal { get; set;}

		[RED("pushCooldownCur")] 		public CFloat PushCooldownCur { get; set;}

		[RED("pushDirection")] 		public Vector PushDirection { get; set;}

		[RED("collisionStopped")] 		public CBool CollisionStopped { get; set;}

		[RED("enableCollisionWalking")] 		public CBool EnableCollisionWalking { get; set;}

		[RED("enableCollisionRunning")] 		public CBool EnableCollisionRunning { get; set;}

		[RED("enablePushCombat")] 		public CBool EnablePushCombat { get; set;}

		[RED("enablePushWhileMoving")] 		public CBool EnablePushWhileMoving { get; set;}

		[RED("enablePhysicsWalking")] 		public CBool EnablePhysicsWalking { get; set;}

		[RED("enablePhysicsRunning")] 		public CBool EnablePhysicsRunning { get; set;}

		[RED("enableNavMeshWalking")] 		public CBool EnableNavMeshWalking { get; set;}

		[RED("enableNavMeshRunning")] 		public CBool EnableNavMeshRunning { get; set;}

		[RED("enableExplorationWalking")] 		public CBool EnableExplorationWalking { get; set;}

		[RED("enableExplorationRunning")] 		public CBool EnableExplorationRunning { get; set;}

		[RED("enableDoorsWalking")] 		public CBool EnableDoorsWalking { get; set;}

		[RED("enableDoorsRunning")] 		public CBool EnableDoorsRunning { get; set;}

		[RED("limitCorrectionTurningSide")] 		public CBool LimitCorrectionTurningSide { get; set;}

		[RED("inputDifToSide")] 		public CFloat InputDifToSide { get; set;}

		[RED("maxPhysicSideDistance")] 		public CFloat MaxPhysicSideDistance { get; set;}

		[RED("maxPhysicPortalDistance")] 		public CFloat MaxPhysicPortalDistance { get; set;}

		[RED("maxPhysicDistanceWalk")] 		public CFloat MaxPhysicDistanceWalk { get; set;}

		[RED("maxPhysicDistanceRun")] 		public CFloat MaxPhysicDistanceRun { get; set;}

		[RED("maxPhysicAngleWalk")] 		public CFloat MaxPhysicAngleWalk { get; set;}

		[RED("maxPhysicAngleRun")] 		public CFloat MaxPhysicAngleRun { get; set;}

		[RED("maxNavmeshDistanceWalk")] 		public CFloat MaxNavmeshDistanceWalk { get; set;}

		[RED("maxNavmeshDistanceRun")] 		public CFloat MaxNavmeshDistanceRun { get; set;}

		[RED("maxNavmeshAngleWalk")] 		public CFloat MaxNavmeshAngleWalk { get; set;}

		[RED("maxNavmeshAngleRun")] 		public CFloat MaxNavmeshAngleRun { get; set;}

		[RED("maxExplorationDistanceWalk")] 		public CFloat MaxExplorationDistanceWalk { get; set;}

		[RED("maxExplorationDistanceRun")] 		public CFloat MaxExplorationDistanceRun { get; set;}

		[RED("maxExplorationAngleWalk")] 		public CFloat MaxExplorationAngleWalk { get; set;}

		[RED("maxExplorationAngleRun")] 		public CFloat MaxExplorationAngleRun { get; set;}

		[RED("maxDoorDistanceWalk")] 		public CFloat MaxDoorDistanceWalk { get; set;}

		[RED("maxDoorDistanceRun")] 		public CFloat MaxDoorDistanceRun { get; set;}

		[RED("maxDoorAngleWalk")] 		public CFloat MaxDoorAngleWalk { get; set;}

		[RED("maxDoorAngleRun")] 		public CFloat MaxDoorAngleRun { get; set;}

		[RED("maxDoorAngleGather")] 		public CFloat MaxDoorAngleGather { get; set;}

		[RED("maxDoorBack")] 		public CFloat MaxDoorBack { get; set;}

		[RED("maxDoorHeight")] 		public CFloat MaxDoorHeight { get; set;}

		[RED("turnAdjustBlocked")] 		public CBool TurnAdjustBlocked { get; set;}

		[RED("animEventBlockTurnAdjust")] 		public CName AnimEventBlockTurnAdjust { get; set;}

		[RED("turnAdjustmentEnabled")] 		public CBool TurnAdjustmentEnabled { get; set;}

		[RED("turnAdjustmentTimeCur")] 		public CFloat TurnAdjustmentTimeCur { get; set;}

		[RED("turnAdjustmentTimeMax")] 		public CFloat TurnAdjustmentTimeMax { get; set;}

		[RED("inputLastModule")] 		public CFloat InputLastModule { get; set;}

		[RED("inputSpeedLast")] 		public CFloat InputSpeedLast { get; set;}

		[RED("inputSpeedToStartRun")] 		public CFloat InputSpeedToStartRun { get; set;}

		[RED("inputSpeedToStartRunHiFPS")] 		public CFloat InputSpeedToStartRunHiFPS { get; set;}

		[RED("cameraRequestByDoor")] 		public CBool CameraRequestByDoor { get; set;}

		[RED("doorPoint")] 		public Vector DoorPoint { get; set;}

		[RED("auxDiff")] 		public CFloat AuxDiff { get; set;}

		[RED("debugPush")] 		public CBool DebugPush { get; set;}

		[RED("debugingSpeed")] 		public CBool DebugingSpeed { get; set;}

		[RED("disallowRotWhenGoingToSleep")] 		public CBool DisallowRotWhenGoingToSleep { get; set;}

		public CExplorationMovementCorrector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationMovementCorrector(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}