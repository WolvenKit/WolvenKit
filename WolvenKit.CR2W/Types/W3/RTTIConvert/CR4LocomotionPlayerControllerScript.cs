using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4LocomotionPlayerControllerScript : CR4LocomotionDirectControllerScript
	{
		[RED("player")] 		public CHandle<CR4Player> Player { get; set;}

		[RED("angularInputSpeed")] 		public CFloat AngularInputSpeed { get; set;}

		[RED("worldMoveDirection")] 		public CFloat WorldMoveDirection { get; set;}

		[RED("localMoveDirection")] 		public CFloat LocalMoveDirection { get; set;}

		[RED("previousInputVector")] 		public Vector PreviousInputVector { get; set;}

		[RED("timerValue")] 		public CFloat TimerValue { get; set;}

		[RED("angularSpeed")] 		public CFloat AngularSpeed { get; set;}

		[RED("_inputLocoEnabled")] 		public CBool _inputLocoEnabled { get; set;}

		[RED("_inputVecCurr")] 		public Vector _inputVecCurr { get; set;}

		[RED("_inputVecPrev")] 		public Vector _inputVecPrev { get; set;}

		[RED("_inputHeading180Curr")] 		public CFloat _inputHeading180Curr { get; set;}

		[RED("_inputHeading180Prev")] 		public CFloat _inputHeading180Prev { get; set;}

		[RED("_inputHeading180LastCached")] 		public CFloat _inputHeading180LastCached { get; set;}

		[RED("_inputMagCurr")] 		public CFloat _inputMagCurr { get; set;}

		[RED("_inputMagPrev")] 		public CFloat _inputMagPrev { get; set;}

		[RED("_inputMagDiffCurr")] 		public CFloat _inputMagDiffCurr { get; set;}

		[RED("_inputMagDiffPrev")] 		public CFloat _inputMagDiffPrev { get; set;}

		[RED("_inputMagLastCached")] 		public CFloat _inputMagLastCached { get; set;}

		[RED("speedSlowWalkingMax")] 		public CFloat SpeedSlowWalkingMax { get; set;}

		[RED("speedWalkingMax")] 		public CFloat SpeedWalkingMax { get; set;}

		[RED("speedRunning")] 		public CFloat SpeedRunning { get; set;}

		[RED("speedSprinting")] 		public CFloat SpeedSprinting { get; set;}

		[RED("speedSprintingWithPerk")] 		public CFloat SpeedSprintingWithPerk { get; set;}

		[RED("maxTerrainPitchToWalkUp")] 		public CFloat MaxTerrainPitchToWalkUp { get; set;}

		[RED("prevPosition")] 		public Vector PrevPosition { get; set;}

		[RED("prevRotation")] 		public EulerAngles PrevRotation { get; set;}

		[RED("cachedMoveSpeed")] 		public CFloat CachedMoveSpeed { get; set;}

		[RED("stoppedTimeStamp")] 		public CFloat StoppedTimeStamp { get; set;}

		[RED("stopCheckEnabled")] 		public CBool StopCheckEnabled { get; set;}

		[RED("stoppedTimeStampDelta")] 		public CFloat StoppedTimeStampDelta { get; set;}

		[RED("doubleTapEnabled")] 		public CBool DoubleTapEnabled { get; set;}

		[RED("localMoveDirectionPrevFrame")] 		public CFloat LocalMoveDirectionPrevFrame { get; set;}

		[RED("directionSwitchTimeStamp")] 		public CFloat DirectionSwitchTimeStamp { get; set;}

		[RED("directionCenteredTimeStamp")] 		public CFloat DirectionCenteredTimeStamp { get; set;}

		[RED("isCheckingCentered")] 		public CBool IsCheckingCentered { get; set;}

		[RED("isCheckingCommitToRightTurn")] 		public CBool IsCheckingCommitToRightTurn { get; set;}

		[RED("isCheckingCommitToLeftTurn")] 		public CBool IsCheckingCommitToLeftTurn { get; set;}

		[RED("isTurningRight")] 		public CBool IsTurningRight { get; set;}

		[RED("isTurningLeft")] 		public CBool IsTurningLeft { get; set;}

		[RED("commitToRightTurnTimeStamp")] 		public CFloat CommitToRightTurnTimeStamp { get; set;}

		[RED("commitToLeftTurnTimeStamp")] 		public CFloat CommitToLeftTurnTimeStamp { get; set;}

		[RED("directionSwitchTimeStampDelta")] 		public CFloat DirectionSwitchTimeStampDelta { get; set;}

		[RED("startRightTurnTimeStamp")] 		public CFloat StartRightTurnTimeStamp { get; set;}

		[RED("startLeftTurnTimeStamp")] 		public CFloat StartLeftTurnTimeStamp { get; set;}

		[RED("useRightTurnTimeStamp")] 		public CBool UseRightTurnTimeStamp { get; set;}

		[RED("useLeftTurnTimeStamp")] 		public CBool UseLeftTurnTimeStamp { get; set;}

		[RED("fastTurnEnabled")] 		public CBool FastTurnEnabled { get; set;}

		public CR4LocomotionPlayerControllerScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4LocomotionPlayerControllerScript(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}