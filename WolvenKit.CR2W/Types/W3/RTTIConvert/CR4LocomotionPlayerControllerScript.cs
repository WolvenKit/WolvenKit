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
		[Ordinal(1)] [RED("("player")] 		public CHandle<CR4Player> Player { get; set;}

		[Ordinal(2)] [RED("("angularInputSpeed")] 		public CFloat AngularInputSpeed { get; set;}

		[Ordinal(3)] [RED("("worldMoveDirection")] 		public CFloat WorldMoveDirection { get; set;}

		[Ordinal(4)] [RED("("localMoveDirection")] 		public CFloat LocalMoveDirection { get; set;}

		[Ordinal(5)] [RED("("previousInputVector")] 		public Vector PreviousInputVector { get; set;}

		[Ordinal(6)] [RED("("timerValue")] 		public CFloat TimerValue { get; set;}

		[Ordinal(7)] [RED("("angularSpeed")] 		public CFloat AngularSpeed { get; set;}

		[Ordinal(8)] [RED("("_inputLocoEnabled")] 		public CBool _inputLocoEnabled { get; set;}

		[Ordinal(9)] [RED("("_inputVecCurr")] 		public Vector _inputVecCurr { get; set;}

		[Ordinal(10)] [RED("("_inputVecPrev")] 		public Vector _inputVecPrev { get; set;}

		[Ordinal(11)] [RED("("_inputHeading180Curr")] 		public CFloat _inputHeading180Curr { get; set;}

		[Ordinal(12)] [RED("("_inputHeading180Prev")] 		public CFloat _inputHeading180Prev { get; set;}

		[Ordinal(13)] [RED("("_inputHeading180LastCached")] 		public CFloat _inputHeading180LastCached { get; set;}

		[Ordinal(14)] [RED("("_inputMagCurr")] 		public CFloat _inputMagCurr { get; set;}

		[Ordinal(15)] [RED("("_inputMagPrev")] 		public CFloat _inputMagPrev { get; set;}

		[Ordinal(16)] [RED("("_inputMagDiffCurr")] 		public CFloat _inputMagDiffCurr { get; set;}

		[Ordinal(17)] [RED("("_inputMagDiffPrev")] 		public CFloat _inputMagDiffPrev { get; set;}

		[Ordinal(18)] [RED("("_inputMagLastCached")] 		public CFloat _inputMagLastCached { get; set;}

		[Ordinal(19)] [RED("("speedSlowWalkingMax")] 		public CFloat SpeedSlowWalkingMax { get; set;}

		[Ordinal(20)] [RED("("speedWalkingMax")] 		public CFloat SpeedWalkingMax { get; set;}

		[Ordinal(21)] [RED("("speedRunning")] 		public CFloat SpeedRunning { get; set;}

		[Ordinal(22)] [RED("("speedSprinting")] 		public CFloat SpeedSprinting { get; set;}

		[Ordinal(23)] [RED("("speedSprintingWithPerk")] 		public CFloat SpeedSprintingWithPerk { get; set;}

		[Ordinal(24)] [RED("("maxTerrainPitchToWalkUp")] 		public CFloat MaxTerrainPitchToWalkUp { get; set;}

		[Ordinal(25)] [RED("("prevPosition")] 		public Vector PrevPosition { get; set;}

		[Ordinal(26)] [RED("("prevRotation")] 		public EulerAngles PrevRotation { get; set;}

		[Ordinal(27)] [RED("("cachedMoveSpeed")] 		public CFloat CachedMoveSpeed { get; set;}

		[Ordinal(28)] [RED("("stoppedTimeStamp")] 		public CFloat StoppedTimeStamp { get; set;}

		[Ordinal(29)] [RED("("stopCheckEnabled")] 		public CBool StopCheckEnabled { get; set;}

		[Ordinal(30)] [RED("("stoppedTimeStampDelta")] 		public CFloat StoppedTimeStampDelta { get; set;}

		[Ordinal(31)] [RED("("doubleTapEnabled")] 		public CBool DoubleTapEnabled { get; set;}

		[Ordinal(32)] [RED("("localMoveDirectionPrevFrame")] 		public CFloat LocalMoveDirectionPrevFrame { get; set;}

		[Ordinal(33)] [RED("("directionSwitchTimeStamp")] 		public CFloat DirectionSwitchTimeStamp { get; set;}

		[Ordinal(34)] [RED("("directionCenteredTimeStamp")] 		public CFloat DirectionCenteredTimeStamp { get; set;}

		[Ordinal(35)] [RED("("isCheckingCentered")] 		public CBool IsCheckingCentered { get; set;}

		[Ordinal(36)] [RED("("isCheckingCommitToRightTurn")] 		public CBool IsCheckingCommitToRightTurn { get; set;}

		[Ordinal(37)] [RED("("isCheckingCommitToLeftTurn")] 		public CBool IsCheckingCommitToLeftTurn { get; set;}

		[Ordinal(38)] [RED("("isTurningRight")] 		public CBool IsTurningRight { get; set;}

		[Ordinal(39)] [RED("("isTurningLeft")] 		public CBool IsTurningLeft { get; set;}

		[Ordinal(40)] [RED("("commitToRightTurnTimeStamp")] 		public CFloat CommitToRightTurnTimeStamp { get; set;}

		[Ordinal(41)] [RED("("commitToLeftTurnTimeStamp")] 		public CFloat CommitToLeftTurnTimeStamp { get; set;}

		[Ordinal(42)] [RED("("directionSwitchTimeStampDelta")] 		public CFloat DirectionSwitchTimeStampDelta { get; set;}

		[Ordinal(43)] [RED("("startRightTurnTimeStamp")] 		public CFloat StartRightTurnTimeStamp { get; set;}

		[Ordinal(44)] [RED("("startLeftTurnTimeStamp")] 		public CFloat StartLeftTurnTimeStamp { get; set;}

		[Ordinal(45)] [RED("("useRightTurnTimeStamp")] 		public CBool UseRightTurnTimeStamp { get; set;}

		[Ordinal(46)] [RED("("useLeftTurnTimeStamp")] 		public CBool UseLeftTurnTimeStamp { get; set;}

		[Ordinal(47)] [RED("("fastTurnEnabled")] 		public CBool FastTurnEnabled { get; set;}

		public CR4LocomotionPlayerControllerScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4LocomotionPlayerControllerScript(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}