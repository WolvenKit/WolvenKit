using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SensorDevice : ExplosiveDevice
	{
		[Ordinal(116)] [RED("attitudeAgent")] public CHandle<gameAttitudeAgent> AttitudeAgent { get; set; }
		[Ordinal(117)] [RED("senseComponent")] public CHandle<senseComponent> SenseComponent { get; set; }
		[Ordinal(118)] [RED("visibleObjectComponent")] public CHandle<senseVisibleObjectComponent> VisibleObjectComponent { get; set; }
		[Ordinal(119)] [RED("forwardFaceSlotComponent")] public CHandle<entSlotComponent> ForwardFaceSlotComponent { get; set; }
		[Ordinal(120)] [RED("targetingComponent")] public CHandle<gameTargetingComponent> TargetingComponent { get; set; }
		[Ordinal(121)] [RED("targetTrackerComponent")] public CHandle<AITargetTrackerComponent> TargetTrackerComponent { get; set; }
		[Ordinal(122)] [RED("cameraComponentInverted")] public CHandle<gameCameraComponent> CameraComponentInverted { get; set; }
		[Ordinal(123)] [RED("targets")] public CArray<CHandle<Target>> Targets { get; set; }
		[Ordinal(124)] [RED("currentlyFollowedTarget")] public wCHandle<gameObject> CurrentlyFollowedTarget { get; set; }
		[Ordinal(125)] [RED("currentLookAtEventVert")] public CHandle<entLookAtAddEvent> CurrentLookAtEventVert { get; set; }
		[Ordinal(126)] [RED("currentLookAtEventHor")] public CHandle<entLookAtAddEvent> CurrentLookAtEventHor { get; set; }
		[Ordinal(127)] [RED("HPListenersList")] public CArray<CHandle<TargetedObjectDeathListener>> HPListenersList { get; set; }
		[Ordinal(128)] [RED("sensorDeviceState")] public CEnum<ESensorDeviceStates> SensorDeviceState { get; set; }
		[Ordinal(129)] [RED("sensorWakeState")] public CEnum<ESensorDeviceWakeState> SensorWakeState { get; set; }
		[Ordinal(130)] [RED("sensorWakeStatePrevious")] public CEnum<ESensorDeviceWakeState> SensorWakeStatePrevious { get; set; }
		[Ordinal(131)] [RED("targetingDelayEventID")] public gameDelayID TargetingDelayEventID { get; set; }
		[Ordinal(132)] [RED("hack_isTargetingDelayEventFilled")] public CBool Hack_isTargetingDelayEventFilled { get; set; }
		[Ordinal(133)] [RED("currentResolveDelayEventID")] public gameDelayID CurrentResolveDelayEventID { get; set; }
		[Ordinal(134)] [RED("hack_isResolveDelayEventFilled")] public CBool Hack_isResolveDelayEventFilled { get; set; }
		[Ordinal(135)] [RED("animFeatureData")] public CHandle<AnimFeature_SensorDevice> AnimFeatureData { get; set; }
		[Ordinal(136)] [RED("animFeatureDataName")] public CName AnimFeatureDataName { get; set; }
		[Ordinal(137)] [RED("targetLostBySensesDelayEventID")] public gameDelayID TargetLostBySensesDelayEventID { get; set; }
		[Ordinal(138)] [RED("hack_isTargetLostBySensesDelEvtFilled")] public CBool Hack_isTargetLostBySensesDelEvtFilled { get; set; }
		[Ordinal(139)] [RED("initialAttitude")] public CName InitialAttitude { get; set; }
		[Ordinal(140)] [RED("detectionFactorMultiplier")] public CFloat DetectionFactorMultiplier { get; set; }
		[Ordinal(141)] [RED("lightScanRefs")] public CArray<CHandle<gameLightComponent>> LightScanRefs { get; set; }
		[Ordinal(142)] [RED("lightAttitudeRefs")] public CArray<CHandle<gameLightComponent>> LightAttitudeRefs { get; set; }
		[Ordinal(143)] [RED("lightInfoRefs")] public CArray<CHandle<gameLightComponent>> LightInfoRefs { get; set; }
		[Ordinal(144)] [RED("lightColors")] public LedColors_SensorDevice LightColors { get; set; }
		[Ordinal(145)] [RED("deviceFXRecord")] public CHandle<gamedataDeviceFX_Record> DeviceFXRecord { get; set; }
		[Ordinal(146)] [RED("scanGameEffect")] public CHandle<gameEffectInstance> ScanGameEffect { get; set; }
		[Ordinal(147)] [RED("scanFXSlotName")] public CName ScanFXSlotName { get; set; }
		[Ordinal(148)] [RED("visionConeEffectInstance")] public CHandle<gameEffectInstance> VisionConeEffectInstance { get; set; }
		[Ordinal(149)] [RED("idleGameEffectInstance")] public CHandle<gameEffectInstance> IdleGameEffectInstance { get; set; }
		[Ordinal(150)] [RED("targetForcedFormTagKill")] public CBool TargetForcedFormTagKill { get; set; }
		[Ordinal(151)] [RED("hasSupport")] public CBool HasSupport { get; set; }
		[Ordinal(152)] [RED("defaultSensePreset")] public TweakDBID DefaultSensePreset { get; set; }
		[Ordinal(153)] [RED("elementsToHideOnTCS")] public CArray<CName> ElementsToHideOnTCS { get; set; }
		[Ordinal(154)] [RED("elementsToHideOnTCSRefs")] public CArray<CHandle<entIPlacedComponent>> ElementsToHideOnTCSRefs { get; set; }
		[Ordinal(155)] [RED("previoustagKillList")] public CArray<wCHandle<gameObject>> PrevioustagKillList { get; set; }
		[Ordinal(156)] [RED("playIdleSoundOnIdle")] public CBool PlayIdleSoundOnIdle { get; set; }
		[Ordinal(157)] [RED("idleSound")] public CName IdleSound { get; set; }
		[Ordinal(158)] [RED("idleSoundStop")] public CName IdleSoundStop { get; set; }
		[Ordinal(159)] [RED("soundDeviceON")] public CName SoundDeviceON { get; set; }
		[Ordinal(160)] [RED("soundDeviceOFF")] public CName SoundDeviceOFF { get; set; }
		[Ordinal(161)] [RED("idleSoundIsPlaying")] public CBool IdleSoundIsPlaying { get; set; }
		[Ordinal(162)] [RED("soundDeviceDestroyed")] public CName SoundDeviceDestroyed { get; set; }
		[Ordinal(163)] [RED("soundDetectionLoop")] public CName SoundDetectionLoop { get; set; }
		[Ordinal(164)] [RED("soundDetectionLoopStop")] public CName SoundDetectionLoopStop { get; set; }
		[Ordinal(165)] [RED("isPLAYERSAFETargetLock")] public CBool IsPLAYERSAFETargetLock { get; set; }
		[Ordinal(166)] [RED("playerDetected")] public CBool PlayerDetected { get; set; }
		[Ordinal(167)] [RED("clientForceSetAnimFeature")] public CBool ClientForceSetAnimFeature { get; set; }
		[Ordinal(168)] [RED("playerControlData")] public PlayerControlDeviceData PlayerControlData { get; set; }
		[Ordinal(169)] [RED("engineTimeInSec")] public CFloat EngineTimeInSec { get; set; }
		[Ordinal(170)] [RED("TCExitEngineTime")] public CFloat TCExitEngineTime { get; set; }
		[Ordinal(171)] [RED("hack_wasTargetReevaluated")] public CBool Hack_wasTargetReevaluated { get; set; }
		[Ordinal(172)] [RED("hack_wasSSOutupFromSelf")] public CBool Hack_wasSSOutupFromSelf { get; set; }
		[Ordinal(173)] [RED("degbu_SS_inputsSend")] public CInt32 Degbu_SS_inputsSend { get; set; }
		[Ordinal(174)] [RED("debug_SS_inputsSendTargetLock")] public CInt32 Debug_SS_inputsSendTargetLock { get; set; }
		[Ordinal(175)] [RED("debug_SS_inputsSendIntresting")] public CInt32 Debug_SS_inputsSendIntresting { get; set; }
		[Ordinal(176)] [RED("debug_SS_inputsSendLoseTarget")] public CInt32 Debug_SS_inputsSendLoseTarget { get; set; }
		[Ordinal(177)] [RED("debug_SS_outputRecieved")] public CInt32 Debug_SS_outputRecieved { get; set; }
		[Ordinal(178)] [RED("debug_SS_outputFormSelfRecieved")] public CInt32 Debug_SS_outputFormSelfRecieved { get; set; }
		[Ordinal(179)] [RED("debug_SS_outputFromElseRecieved")] public CInt32 Debug_SS_outputFromElseRecieved { get; set; }
		[Ordinal(180)] [RED("debug_SS_reevaluatesDone")] public CInt32 Debug_SS_reevaluatesDone { get; set; }
		[Ordinal(181)] [RED("debug_SS_trespassingRecieved")] public CInt32 Debug_SS_trespassingRecieved { get; set; }
		[Ordinal(182)] [RED("debug_SS_TargetAssessmentRequest")] public CInt32 Debug_SS_TargetAssessmentRequest { get; set; }
		[Ordinal(183)] [RED("minPitch")] public CFloat MinPitch { get; set; }
		[Ordinal(184)] [RED("maxPitch")] public CFloat MaxPitch { get; set; }
		[Ordinal(185)] [RED("minYaw")] public CFloat MinYaw { get; set; }
		[Ordinal(186)] [RED("maxYaw")] public CFloat MaxYaw { get; set; }

		public SensorDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
