using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SensorDevice : ExplosiveDevice
	{
		private CHandle<gameAttitudeAgent> _attitudeAgent;
		private CHandle<senseComponent> _senseComponent;
		private CHandle<senseVisibleObjectComponent> _visibleObjectComponent;
		private CHandle<entSlotComponent> _forwardFaceSlotComponent;
		private CHandle<gameTargetingComponent> _targetingComponent;
		private CHandle<AITargetTrackerComponent> _targetTrackerComponent;
		private CHandle<gameCameraComponent> _cameraComponentInverted;
		private CArray<CHandle<Target>> _targets;
		private wCHandle<gameObject> _currentlyFollowedTarget;
		private CHandle<entLookAtAddEvent> _currentLookAtEventVert;
		private CHandle<entLookAtAddEvent> _currentLookAtEventHor;
		private CArray<CHandle<TargetedObjectDeathListener>> _hPListenersList;
		private CEnum<ESensorDeviceStates> _sensorDeviceState;
		private CEnum<ESensorDeviceWakeState> _sensorWakeState;
		private CEnum<ESensorDeviceWakeState> _sensorWakeStatePrevious;
		private gameDelayID _targetingDelayEventID;
		private CBool _hack_isTargetingDelayEventFilled;
		private gameDelayID _currentResolveDelayEventID;
		private CBool _hack_isResolveDelayEventFilled;
		private CHandle<AnimFeature_SensorDevice> _animFeatureData;
		private CName _animFeatureDataName;
		private gameDelayID _targetLostBySensesDelayEventID;
		private CBool _hack_isTargetLostBySensesDelEvtFilled;
		private CName _initialAttitude;
		private CFloat _detectionFactorMultiplier;
		private CHandle<redCallbackObject> _taggedListenerCallback;
		private CArray<CHandle<gameLightComponent>> _lightScanRefs;
		private CArray<CHandle<gameLightComponent>> _lightAttitudeRefs;
		private CArray<CHandle<gameLightComponent>> _lightInfoRefs;
		private LedColors_SensorDevice _lightColors;
		private CHandle<gamedataDeviceFX_Record> _deviceFXRecord;
		private CHandle<gameEffectInstance> _scanGameEffect;
		private CName _scanFXSlotName;
		private CHandle<gameEffectInstance> _visionConeEffectInstance;
		private CHandle<gameEffectInstance> _idleGameEffectInstance;
		private CBool _targetForcedFormTagKill;
		private CBool _hasSupport;
		private TweakDBID _defaultSensePreset;
		private CArray<CName> _elementsToHideOnTCS;
		private CArray<CHandle<entIPlacedComponent>> _elementsToHideOnTCSRefs;
		private CArray<wCHandle<gameObject>> _previoustagKillList;
		private CBool _playIdleSoundOnIdle;
		private CName _idleSound;
		private CName _idleSoundStop;
		private CName _soundDeviceON;
		private CName _soundDeviceOFF;
		private CBool _idleSoundIsPlaying;
		private CName _soundDeviceDestroyed;
		private CName _soundDetectionLoop;
		private CName _soundDetectionLoopStop;
		private CBool _isPLAYERSAFETargetLock;
		private CBool _playerDetected;
		private CBool _clientForceSetAnimFeature;
		private PlayerControlDeviceData _playerControlData;
		private CFloat _engineTimeInSec;
		private CFloat _tCExitEngineTime;
		private CBool _hack_wasTargetReevaluated;
		private CBool _hack_wasSSOutupFromSelf;
		private CInt32 _degbu_SS_inputsSend;
		private CInt32 _debug_SS_inputsSendTargetLock;
		private CInt32 _debug_SS_inputsSendIntresting;
		private CInt32 _debug_SS_inputsSendLoseTarget;
		private CInt32 _debug_SS_outputRecieved;
		private CInt32 _debug_SS_outputFormSelfRecieved;
		private CInt32 _debug_SS_outputFromElseRecieved;
		private CInt32 _debug_SS_reevaluatesDone;
		private CInt32 _debug_SS_trespassingRecieved;
		private CInt32 _debug_SS_TargetAssessmentRequest;
		private CFloat _minPitch;
		private CFloat _maxPitch;
		private CFloat _minYaw;
		private CFloat _maxYaw;

		[Ordinal(120)] 
		[RED("attitudeAgent")] 
		public CHandle<gameAttitudeAgent> AttitudeAgent
		{
			get => GetProperty(ref _attitudeAgent);
			set => SetProperty(ref _attitudeAgent, value);
		}

		[Ordinal(121)] 
		[RED("senseComponent")] 
		public CHandle<senseComponent> SenseComponent
		{
			get => GetProperty(ref _senseComponent);
			set => SetProperty(ref _senseComponent, value);
		}

		[Ordinal(122)] 
		[RED("visibleObjectComponent")] 
		public CHandle<senseVisibleObjectComponent> VisibleObjectComponent
		{
			get => GetProperty(ref _visibleObjectComponent);
			set => SetProperty(ref _visibleObjectComponent, value);
		}

		[Ordinal(123)] 
		[RED("forwardFaceSlotComponent")] 
		public CHandle<entSlotComponent> ForwardFaceSlotComponent
		{
			get => GetProperty(ref _forwardFaceSlotComponent);
			set => SetProperty(ref _forwardFaceSlotComponent, value);
		}

		[Ordinal(124)] 
		[RED("targetingComponent")] 
		public CHandle<gameTargetingComponent> TargetingComponent
		{
			get => GetProperty(ref _targetingComponent);
			set => SetProperty(ref _targetingComponent, value);
		}

		[Ordinal(125)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetProperty(ref _targetTrackerComponent);
			set => SetProperty(ref _targetTrackerComponent, value);
		}

		[Ordinal(126)] 
		[RED("cameraComponentInverted")] 
		public CHandle<gameCameraComponent> CameraComponentInverted
		{
			get => GetProperty(ref _cameraComponentInverted);
			set => SetProperty(ref _cameraComponentInverted, value);
		}

		[Ordinal(127)] 
		[RED("targets")] 
		public CArray<CHandle<Target>> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(128)] 
		[RED("currentlyFollowedTarget")] 
		public wCHandle<gameObject> CurrentlyFollowedTarget
		{
			get => GetProperty(ref _currentlyFollowedTarget);
			set => SetProperty(ref _currentlyFollowedTarget, value);
		}

		[Ordinal(129)] 
		[RED("currentLookAtEventVert")] 
		public CHandle<entLookAtAddEvent> CurrentLookAtEventVert
		{
			get => GetProperty(ref _currentLookAtEventVert);
			set => SetProperty(ref _currentLookAtEventVert, value);
		}

		[Ordinal(130)] 
		[RED("currentLookAtEventHor")] 
		public CHandle<entLookAtAddEvent> CurrentLookAtEventHor
		{
			get => GetProperty(ref _currentLookAtEventHor);
			set => SetProperty(ref _currentLookAtEventHor, value);
		}

		[Ordinal(131)] 
		[RED("HPListenersList")] 
		public CArray<CHandle<TargetedObjectDeathListener>> HPListenersList
		{
			get => GetProperty(ref _hPListenersList);
			set => SetProperty(ref _hPListenersList, value);
		}

		[Ordinal(132)] 
		[RED("sensorDeviceState")] 
		public CEnum<ESensorDeviceStates> SensorDeviceState
		{
			get => GetProperty(ref _sensorDeviceState);
			set => SetProperty(ref _sensorDeviceState, value);
		}

		[Ordinal(133)] 
		[RED("sensorWakeState")] 
		public CEnum<ESensorDeviceWakeState> SensorWakeState
		{
			get => GetProperty(ref _sensorWakeState);
			set => SetProperty(ref _sensorWakeState, value);
		}

		[Ordinal(134)] 
		[RED("sensorWakeStatePrevious")] 
		public CEnum<ESensorDeviceWakeState> SensorWakeStatePrevious
		{
			get => GetProperty(ref _sensorWakeStatePrevious);
			set => SetProperty(ref _sensorWakeStatePrevious, value);
		}

		[Ordinal(135)] 
		[RED("targetingDelayEventID")] 
		public gameDelayID TargetingDelayEventID
		{
			get => GetProperty(ref _targetingDelayEventID);
			set => SetProperty(ref _targetingDelayEventID, value);
		}

		[Ordinal(136)] 
		[RED("hack_isTargetingDelayEventFilled")] 
		public CBool Hack_isTargetingDelayEventFilled
		{
			get => GetProperty(ref _hack_isTargetingDelayEventFilled);
			set => SetProperty(ref _hack_isTargetingDelayEventFilled, value);
		}

		[Ordinal(137)] 
		[RED("currentResolveDelayEventID")] 
		public gameDelayID CurrentResolveDelayEventID
		{
			get => GetProperty(ref _currentResolveDelayEventID);
			set => SetProperty(ref _currentResolveDelayEventID, value);
		}

		[Ordinal(138)] 
		[RED("hack_isResolveDelayEventFilled")] 
		public CBool Hack_isResolveDelayEventFilled
		{
			get => GetProperty(ref _hack_isResolveDelayEventFilled);
			set => SetProperty(ref _hack_isResolveDelayEventFilled, value);
		}

		[Ordinal(139)] 
		[RED("animFeatureData")] 
		public CHandle<AnimFeature_SensorDevice> AnimFeatureData
		{
			get => GetProperty(ref _animFeatureData);
			set => SetProperty(ref _animFeatureData, value);
		}

		[Ordinal(140)] 
		[RED("animFeatureDataName")] 
		public CName AnimFeatureDataName
		{
			get => GetProperty(ref _animFeatureDataName);
			set => SetProperty(ref _animFeatureDataName, value);
		}

		[Ordinal(141)] 
		[RED("targetLostBySensesDelayEventID")] 
		public gameDelayID TargetLostBySensesDelayEventID
		{
			get => GetProperty(ref _targetLostBySensesDelayEventID);
			set => SetProperty(ref _targetLostBySensesDelayEventID, value);
		}

		[Ordinal(142)] 
		[RED("hack_isTargetLostBySensesDelEvtFilled")] 
		public CBool Hack_isTargetLostBySensesDelEvtFilled
		{
			get => GetProperty(ref _hack_isTargetLostBySensesDelEvtFilled);
			set => SetProperty(ref _hack_isTargetLostBySensesDelEvtFilled, value);
		}

		[Ordinal(143)] 
		[RED("initialAttitude")] 
		public CName InitialAttitude
		{
			get => GetProperty(ref _initialAttitude);
			set => SetProperty(ref _initialAttitude, value);
		}

		[Ordinal(144)] 
		[RED("detectionFactorMultiplier")] 
		public CFloat DetectionFactorMultiplier
		{
			get => GetProperty(ref _detectionFactorMultiplier);
			set => SetProperty(ref _detectionFactorMultiplier, value);
		}

		[Ordinal(145)] 
		[RED("taggedListenerCallback")] 
		public CHandle<redCallbackObject> TaggedListenerCallback
		{
			get => GetProperty(ref _taggedListenerCallback);
			set => SetProperty(ref _taggedListenerCallback, value);
		}

		[Ordinal(146)] 
		[RED("lightScanRefs")] 
		public CArray<CHandle<gameLightComponent>> LightScanRefs
		{
			get => GetProperty(ref _lightScanRefs);
			set => SetProperty(ref _lightScanRefs, value);
		}

		[Ordinal(147)] 
		[RED("lightAttitudeRefs")] 
		public CArray<CHandle<gameLightComponent>> LightAttitudeRefs
		{
			get => GetProperty(ref _lightAttitudeRefs);
			set => SetProperty(ref _lightAttitudeRefs, value);
		}

		[Ordinal(148)] 
		[RED("lightInfoRefs")] 
		public CArray<CHandle<gameLightComponent>> LightInfoRefs
		{
			get => GetProperty(ref _lightInfoRefs);
			set => SetProperty(ref _lightInfoRefs, value);
		}

		[Ordinal(149)] 
		[RED("lightColors")] 
		public LedColors_SensorDevice LightColors
		{
			get => GetProperty(ref _lightColors);
			set => SetProperty(ref _lightColors, value);
		}

		[Ordinal(150)] 
		[RED("deviceFXRecord")] 
		public CHandle<gamedataDeviceFX_Record> DeviceFXRecord
		{
			get => GetProperty(ref _deviceFXRecord);
			set => SetProperty(ref _deviceFXRecord, value);
		}

		[Ordinal(151)] 
		[RED("scanGameEffect")] 
		public CHandle<gameEffectInstance> ScanGameEffect
		{
			get => GetProperty(ref _scanGameEffect);
			set => SetProperty(ref _scanGameEffect, value);
		}

		[Ordinal(152)] 
		[RED("scanFXSlotName")] 
		public CName ScanFXSlotName
		{
			get => GetProperty(ref _scanFXSlotName);
			set => SetProperty(ref _scanFXSlotName, value);
		}

		[Ordinal(153)] 
		[RED("visionConeEffectInstance")] 
		public CHandle<gameEffectInstance> VisionConeEffectInstance
		{
			get => GetProperty(ref _visionConeEffectInstance);
			set => SetProperty(ref _visionConeEffectInstance, value);
		}

		[Ordinal(154)] 
		[RED("idleGameEffectInstance")] 
		public CHandle<gameEffectInstance> IdleGameEffectInstance
		{
			get => GetProperty(ref _idleGameEffectInstance);
			set => SetProperty(ref _idleGameEffectInstance, value);
		}

		[Ordinal(155)] 
		[RED("targetForcedFormTagKill")] 
		public CBool TargetForcedFormTagKill
		{
			get => GetProperty(ref _targetForcedFormTagKill);
			set => SetProperty(ref _targetForcedFormTagKill, value);
		}

		[Ordinal(156)] 
		[RED("hasSupport")] 
		public CBool HasSupport
		{
			get => GetProperty(ref _hasSupport);
			set => SetProperty(ref _hasSupport, value);
		}

		[Ordinal(157)] 
		[RED("defaultSensePreset")] 
		public TweakDBID DefaultSensePreset
		{
			get => GetProperty(ref _defaultSensePreset);
			set => SetProperty(ref _defaultSensePreset, value);
		}

		[Ordinal(158)] 
		[RED("elementsToHideOnTCS")] 
		public CArray<CName> ElementsToHideOnTCS
		{
			get => GetProperty(ref _elementsToHideOnTCS);
			set => SetProperty(ref _elementsToHideOnTCS, value);
		}

		[Ordinal(159)] 
		[RED("elementsToHideOnTCSRefs")] 
		public CArray<CHandle<entIPlacedComponent>> ElementsToHideOnTCSRefs
		{
			get => GetProperty(ref _elementsToHideOnTCSRefs);
			set => SetProperty(ref _elementsToHideOnTCSRefs, value);
		}

		[Ordinal(160)] 
		[RED("previoustagKillList")] 
		public CArray<wCHandle<gameObject>> PrevioustagKillList
		{
			get => GetProperty(ref _previoustagKillList);
			set => SetProperty(ref _previoustagKillList, value);
		}

		[Ordinal(161)] 
		[RED("playIdleSoundOnIdle")] 
		public CBool PlayIdleSoundOnIdle
		{
			get => GetProperty(ref _playIdleSoundOnIdle);
			set => SetProperty(ref _playIdleSoundOnIdle, value);
		}

		[Ordinal(162)] 
		[RED("idleSound")] 
		public CName IdleSound
		{
			get => GetProperty(ref _idleSound);
			set => SetProperty(ref _idleSound, value);
		}

		[Ordinal(163)] 
		[RED("idleSoundStop")] 
		public CName IdleSoundStop
		{
			get => GetProperty(ref _idleSoundStop);
			set => SetProperty(ref _idleSoundStop, value);
		}

		[Ordinal(164)] 
		[RED("soundDeviceON")] 
		public CName SoundDeviceON
		{
			get => GetProperty(ref _soundDeviceON);
			set => SetProperty(ref _soundDeviceON, value);
		}

		[Ordinal(165)] 
		[RED("soundDeviceOFF")] 
		public CName SoundDeviceOFF
		{
			get => GetProperty(ref _soundDeviceOFF);
			set => SetProperty(ref _soundDeviceOFF, value);
		}

		[Ordinal(166)] 
		[RED("idleSoundIsPlaying")] 
		public CBool IdleSoundIsPlaying
		{
			get => GetProperty(ref _idleSoundIsPlaying);
			set => SetProperty(ref _idleSoundIsPlaying, value);
		}

		[Ordinal(167)] 
		[RED("soundDeviceDestroyed")] 
		public CName SoundDeviceDestroyed
		{
			get => GetProperty(ref _soundDeviceDestroyed);
			set => SetProperty(ref _soundDeviceDestroyed, value);
		}

		[Ordinal(168)] 
		[RED("soundDetectionLoop")] 
		public CName SoundDetectionLoop
		{
			get => GetProperty(ref _soundDetectionLoop);
			set => SetProperty(ref _soundDetectionLoop, value);
		}

		[Ordinal(169)] 
		[RED("soundDetectionLoopStop")] 
		public CName SoundDetectionLoopStop
		{
			get => GetProperty(ref _soundDetectionLoopStop);
			set => SetProperty(ref _soundDetectionLoopStop, value);
		}

		[Ordinal(170)] 
		[RED("isPLAYERSAFETargetLock")] 
		public CBool IsPLAYERSAFETargetLock
		{
			get => GetProperty(ref _isPLAYERSAFETargetLock);
			set => SetProperty(ref _isPLAYERSAFETargetLock, value);
		}

		[Ordinal(171)] 
		[RED("playerDetected")] 
		public CBool PlayerDetected
		{
			get => GetProperty(ref _playerDetected);
			set => SetProperty(ref _playerDetected, value);
		}

		[Ordinal(172)] 
		[RED("clientForceSetAnimFeature")] 
		public CBool ClientForceSetAnimFeature
		{
			get => GetProperty(ref _clientForceSetAnimFeature);
			set => SetProperty(ref _clientForceSetAnimFeature, value);
		}

		[Ordinal(173)] 
		[RED("playerControlData")] 
		public PlayerControlDeviceData PlayerControlData
		{
			get => GetProperty(ref _playerControlData);
			set => SetProperty(ref _playerControlData, value);
		}

		[Ordinal(174)] 
		[RED("engineTimeInSec")] 
		public CFloat EngineTimeInSec
		{
			get => GetProperty(ref _engineTimeInSec);
			set => SetProperty(ref _engineTimeInSec, value);
		}

		[Ordinal(175)] 
		[RED("TCExitEngineTime")] 
		public CFloat TCExitEngineTime
		{
			get => GetProperty(ref _tCExitEngineTime);
			set => SetProperty(ref _tCExitEngineTime, value);
		}

		[Ordinal(176)] 
		[RED("hack_wasTargetReevaluated")] 
		public CBool Hack_wasTargetReevaluated
		{
			get => GetProperty(ref _hack_wasTargetReevaluated);
			set => SetProperty(ref _hack_wasTargetReevaluated, value);
		}

		[Ordinal(177)] 
		[RED("hack_wasSSOutupFromSelf")] 
		public CBool Hack_wasSSOutupFromSelf
		{
			get => GetProperty(ref _hack_wasSSOutupFromSelf);
			set => SetProperty(ref _hack_wasSSOutupFromSelf, value);
		}

		[Ordinal(178)] 
		[RED("degbu_SS_inputsSend")] 
		public CInt32 Degbu_SS_inputsSend
		{
			get => GetProperty(ref _degbu_SS_inputsSend);
			set => SetProperty(ref _degbu_SS_inputsSend, value);
		}

		[Ordinal(179)] 
		[RED("debug_SS_inputsSendTargetLock")] 
		public CInt32 Debug_SS_inputsSendTargetLock
		{
			get => GetProperty(ref _debug_SS_inputsSendTargetLock);
			set => SetProperty(ref _debug_SS_inputsSendTargetLock, value);
		}

		[Ordinal(180)] 
		[RED("debug_SS_inputsSendIntresting")] 
		public CInt32 Debug_SS_inputsSendIntresting
		{
			get => GetProperty(ref _debug_SS_inputsSendIntresting);
			set => SetProperty(ref _debug_SS_inputsSendIntresting, value);
		}

		[Ordinal(181)] 
		[RED("debug_SS_inputsSendLoseTarget")] 
		public CInt32 Debug_SS_inputsSendLoseTarget
		{
			get => GetProperty(ref _debug_SS_inputsSendLoseTarget);
			set => SetProperty(ref _debug_SS_inputsSendLoseTarget, value);
		}

		[Ordinal(182)] 
		[RED("debug_SS_outputRecieved")] 
		public CInt32 Debug_SS_outputRecieved
		{
			get => GetProperty(ref _debug_SS_outputRecieved);
			set => SetProperty(ref _debug_SS_outputRecieved, value);
		}

		[Ordinal(183)] 
		[RED("debug_SS_outputFormSelfRecieved")] 
		public CInt32 Debug_SS_outputFormSelfRecieved
		{
			get => GetProperty(ref _debug_SS_outputFormSelfRecieved);
			set => SetProperty(ref _debug_SS_outputFormSelfRecieved, value);
		}

		[Ordinal(184)] 
		[RED("debug_SS_outputFromElseRecieved")] 
		public CInt32 Debug_SS_outputFromElseRecieved
		{
			get => GetProperty(ref _debug_SS_outputFromElseRecieved);
			set => SetProperty(ref _debug_SS_outputFromElseRecieved, value);
		}

		[Ordinal(185)] 
		[RED("debug_SS_reevaluatesDone")] 
		public CInt32 Debug_SS_reevaluatesDone
		{
			get => GetProperty(ref _debug_SS_reevaluatesDone);
			set => SetProperty(ref _debug_SS_reevaluatesDone, value);
		}

		[Ordinal(186)] 
		[RED("debug_SS_trespassingRecieved")] 
		public CInt32 Debug_SS_trespassingRecieved
		{
			get => GetProperty(ref _debug_SS_trespassingRecieved);
			set => SetProperty(ref _debug_SS_trespassingRecieved, value);
		}

		[Ordinal(187)] 
		[RED("debug_SS_TargetAssessmentRequest")] 
		public CInt32 Debug_SS_TargetAssessmentRequest
		{
			get => GetProperty(ref _debug_SS_TargetAssessmentRequest);
			set => SetProperty(ref _debug_SS_TargetAssessmentRequest, value);
		}

		[Ordinal(188)] 
		[RED("minPitch")] 
		public CFloat MinPitch
		{
			get => GetProperty(ref _minPitch);
			set => SetProperty(ref _minPitch, value);
		}

		[Ordinal(189)] 
		[RED("maxPitch")] 
		public CFloat MaxPitch
		{
			get => GetProperty(ref _maxPitch);
			set => SetProperty(ref _maxPitch, value);
		}

		[Ordinal(190)] 
		[RED("minYaw")] 
		public CFloat MinYaw
		{
			get => GetProperty(ref _minYaw);
			set => SetProperty(ref _minYaw, value);
		}

		[Ordinal(191)] 
		[RED("maxYaw")] 
		public CFloat MaxYaw
		{
			get => GetProperty(ref _maxYaw);
			set => SetProperty(ref _maxYaw, value);
		}

		public SensorDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
