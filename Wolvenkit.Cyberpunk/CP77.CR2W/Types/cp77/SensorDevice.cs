using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SensorDevice : ExplosiveDevice
	{
		[Ordinal(0)]  [RED("HPListenersList")] public CArray<CHandle<TargetedObjectDeathListener>> HPListenersList { get; set; }
		[Ordinal(1)]  [RED("TCExitEngineTime")] public CFloat TCExitEngineTime { get; set; }
		[Ordinal(2)]  [RED("animFeatureData")] public CHandle<AnimFeature_SensorDevice> AnimFeatureData { get; set; }
		[Ordinal(3)]  [RED("animFeatureDataName")] public CName AnimFeatureDataName { get; set; }
		[Ordinal(4)]  [RED("attitudeAgent")] public CHandle<gameAttitudeAgent> AttitudeAgent { get; set; }
		[Ordinal(5)]  [RED("cameraComponentInverted")] public CHandle<gameCameraComponent> CameraComponentInverted { get; set; }
		[Ordinal(6)]  [RED("clientForceSetAnimFeature")] public CBool ClientForceSetAnimFeature { get; set; }
		[Ordinal(7)]  [RED("currentLookAtEventHor")] public CHandle<entLookAtAddEvent> CurrentLookAtEventHor { get; set; }
		[Ordinal(8)]  [RED("currentLookAtEventVert")] public CHandle<entLookAtAddEvent> CurrentLookAtEventVert { get; set; }
		[Ordinal(9)]  [RED("currentResolveDelayEventID")] public gameDelayID CurrentResolveDelayEventID { get; set; }
		[Ordinal(10)]  [RED("currentlyFollowedTarget")] public wCHandle<gameObject> CurrentlyFollowedTarget { get; set; }
		[Ordinal(11)]  [RED("debug_SS_TargetAssessmentRequest")] public CInt32 Debug_SS_TargetAssessmentRequest { get; set; }
		[Ordinal(12)]  [RED("debug_SS_inputsSendIntresting")] public CInt32 Debug_SS_inputsSendIntresting { get; set; }
		[Ordinal(13)]  [RED("debug_SS_inputsSendLoseTarget")] public CInt32 Debug_SS_inputsSendLoseTarget { get; set; }
		[Ordinal(14)]  [RED("debug_SS_inputsSendTargetLock")] public CInt32 Debug_SS_inputsSendTargetLock { get; set; }
		[Ordinal(15)]  [RED("debug_SS_outputFormSelfRecieved")] public CInt32 Debug_SS_outputFormSelfRecieved { get; set; }
		[Ordinal(16)]  [RED("debug_SS_outputFromElseRecieved")] public CInt32 Debug_SS_outputFromElseRecieved { get; set; }
		[Ordinal(17)]  [RED("debug_SS_outputRecieved")] public CInt32 Debug_SS_outputRecieved { get; set; }
		[Ordinal(18)]  [RED("debug_SS_reevaluatesDone")] public CInt32 Debug_SS_reevaluatesDone { get; set; }
		[Ordinal(19)]  [RED("debug_SS_trespassingRecieved")] public CInt32 Debug_SS_trespassingRecieved { get; set; }
		[Ordinal(20)]  [RED("defaultSensePreset")] public TweakDBID DefaultSensePreset { get; set; }
		[Ordinal(21)]  [RED("degbu_SS_inputsSend")] public CInt32 Degbu_SS_inputsSend { get; set; }
		[Ordinal(22)]  [RED("detectionFactorMultiplier")] public CFloat DetectionFactorMultiplier { get; set; }
		[Ordinal(23)]  [RED("deviceFXRecord")] public CHandle<gamedataDeviceFX_Record> DeviceFXRecord { get; set; }
		[Ordinal(24)]  [RED("elementsToHideOnTCS")] public CArray<CName> ElementsToHideOnTCS { get; set; }
		[Ordinal(25)]  [RED("elementsToHideOnTCSRefs")] public CArray<CHandle<entIPlacedComponent>> ElementsToHideOnTCSRefs { get; set; }
		[Ordinal(26)]  [RED("engineTimeInSec")] public CFloat EngineTimeInSec { get; set; }
		[Ordinal(27)]  [RED("forwardFaceSlotComponent")] public CHandle<entSlotComponent> ForwardFaceSlotComponent { get; set; }
		[Ordinal(28)]  [RED("hack_isResolveDelayEventFilled")] public CBool Hack_isResolveDelayEventFilled { get; set; }
		[Ordinal(29)]  [RED("hack_isTargetLostBySensesDelEvtFilled")] public CBool Hack_isTargetLostBySensesDelEvtFilled { get; set; }
		[Ordinal(30)]  [RED("hack_isTargetingDelayEventFilled")] public CBool Hack_isTargetingDelayEventFilled { get; set; }
		[Ordinal(31)]  [RED("hack_wasSSOutupFromSelf")] public CBool Hack_wasSSOutupFromSelf { get; set; }
		[Ordinal(32)]  [RED("hack_wasTargetReevaluated")] public CBool Hack_wasTargetReevaluated { get; set; }
		[Ordinal(33)]  [RED("hasSupport")] public CBool HasSupport { get; set; }
		[Ordinal(34)]  [RED("idleGameEffectInstance")] public CHandle<gameEffectInstance> IdleGameEffectInstance { get; set; }
		[Ordinal(35)]  [RED("idleSound")] public CName IdleSound { get; set; }
		[Ordinal(36)]  [RED("idleSoundIsPlaying")] public CBool IdleSoundIsPlaying { get; set; }
		[Ordinal(37)]  [RED("idleSoundStop")] public CName IdleSoundStop { get; set; }
		[Ordinal(38)]  [RED("initialAttitude")] public CName InitialAttitude { get; set; }
		[Ordinal(39)]  [RED("isPLAYERSAFETargetLock")] public CBool IsPLAYERSAFETargetLock { get; set; }
		[Ordinal(40)]  [RED("lightAttitudeRefs")] public CArray<CHandle<gameLightComponent>> LightAttitudeRefs { get; set; }
		[Ordinal(41)]  [RED("lightColors")] public LedColors_SensorDevice LightColors { get; set; }
		[Ordinal(42)]  [RED("lightInfoRefs")] public CArray<CHandle<gameLightComponent>> LightInfoRefs { get; set; }
		[Ordinal(43)]  [RED("lightScanRefs")] public CArray<CHandle<gameLightComponent>> LightScanRefs { get; set; }
		[Ordinal(44)]  [RED("maxPitch")] public CFloat MaxPitch { get; set; }
		[Ordinal(45)]  [RED("maxYaw")] public CFloat MaxYaw { get; set; }
		[Ordinal(46)]  [RED("minPitch")] public CFloat MinPitch { get; set; }
		[Ordinal(47)]  [RED("minYaw")] public CFloat MinYaw { get; set; }
		[Ordinal(48)]  [RED("playIdleSoundOnIdle")] public CBool PlayIdleSoundOnIdle { get; set; }
		[Ordinal(49)]  [RED("playerControlData")] public PlayerControlDeviceData PlayerControlData { get; set; }
		[Ordinal(50)]  [RED("playerDetected")] public CBool PlayerDetected { get; set; }
		[Ordinal(51)]  [RED("previoustagKillList")] public CArray<wCHandle<gameObject>> PrevioustagKillList { get; set; }
		[Ordinal(52)]  [RED("scanFXSlotName")] public CName ScanFXSlotName { get; set; }
		[Ordinal(53)]  [RED("scanGameEffect")] public CHandle<gameEffectInstance> ScanGameEffect { get; set; }
		[Ordinal(54)]  [RED("senseComponent")] public CHandle<senseComponent> SenseComponent { get; set; }
		[Ordinal(55)]  [RED("sensorDeviceState")] public CEnum<ESensorDeviceStates> SensorDeviceState { get; set; }
		[Ordinal(56)]  [RED("sensorWakeState")] public CEnum<ESensorDeviceWakeState> SensorWakeState { get; set; }
		[Ordinal(57)]  [RED("sensorWakeStatePrevious")] public CEnum<ESensorDeviceWakeState> SensorWakeStatePrevious { get; set; }
		[Ordinal(58)]  [RED("soundDetectionLoop")] public CName SoundDetectionLoop { get; set; }
		[Ordinal(59)]  [RED("soundDetectionLoopStop")] public CName SoundDetectionLoopStop { get; set; }
		[Ordinal(60)]  [RED("soundDeviceDestroyed")] public CName SoundDeviceDestroyed { get; set; }
		[Ordinal(61)]  [RED("soundDeviceOFF")] public CName SoundDeviceOFF { get; set; }
		[Ordinal(62)]  [RED("soundDeviceON")] public CName SoundDeviceON { get; set; }
		[Ordinal(63)]  [RED("targetForcedFormTagKill")] public CBool TargetForcedFormTagKill { get; set; }
		[Ordinal(64)]  [RED("targetLostBySensesDelayEventID")] public gameDelayID TargetLostBySensesDelayEventID { get; set; }
		[Ordinal(65)]  [RED("targetTrackerComponent")] public CHandle<AITargetTrackerComponent> TargetTrackerComponent { get; set; }
		[Ordinal(66)]  [RED("targetingComponent")] public CHandle<gameTargetingComponent> TargetingComponent { get; set; }
		[Ordinal(67)]  [RED("targetingDelayEventID")] public gameDelayID TargetingDelayEventID { get; set; }
		[Ordinal(68)]  [RED("targets")] public CArray<CHandle<Target>> Targets { get; set; }
		[Ordinal(69)]  [RED("visibleObjectComponent")] public CHandle<senseVisibleObjectComponent> VisibleObjectComponent { get; set; }
		[Ordinal(70)]  [RED("visionConeEffectInstance")] public CHandle<gameEffectInstance> VisionConeEffectInstance { get; set; }

		public SensorDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
