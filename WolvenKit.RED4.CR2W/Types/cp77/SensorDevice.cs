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

		[Ordinal(116)] 
		[RED("attitudeAgent")] 
		public CHandle<gameAttitudeAgent> AttitudeAgent
		{
			get
			{
				if (_attitudeAgent == null)
				{
					_attitudeAgent = (CHandle<gameAttitudeAgent>) CR2WTypeManager.Create("handle:gameAttitudeAgent", "attitudeAgent", cr2w, this);
				}
				return _attitudeAgent;
			}
			set
			{
				if (_attitudeAgent == value)
				{
					return;
				}
				_attitudeAgent = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("senseComponent")] 
		public CHandle<senseComponent> SenseComponent
		{
			get
			{
				if (_senseComponent == null)
				{
					_senseComponent = (CHandle<senseComponent>) CR2WTypeManager.Create("handle:senseComponent", "senseComponent", cr2w, this);
				}
				return _senseComponent;
			}
			set
			{
				if (_senseComponent == value)
				{
					return;
				}
				_senseComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("visibleObjectComponent")] 
		public CHandle<senseVisibleObjectComponent> VisibleObjectComponent
		{
			get
			{
				if (_visibleObjectComponent == null)
				{
					_visibleObjectComponent = (CHandle<senseVisibleObjectComponent>) CR2WTypeManager.Create("handle:senseVisibleObjectComponent", "visibleObjectComponent", cr2w, this);
				}
				return _visibleObjectComponent;
			}
			set
			{
				if (_visibleObjectComponent == value)
				{
					return;
				}
				_visibleObjectComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(119)] 
		[RED("forwardFaceSlotComponent")] 
		public CHandle<entSlotComponent> ForwardFaceSlotComponent
		{
			get
			{
				if (_forwardFaceSlotComponent == null)
				{
					_forwardFaceSlotComponent = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "forwardFaceSlotComponent", cr2w, this);
				}
				return _forwardFaceSlotComponent;
			}
			set
			{
				if (_forwardFaceSlotComponent == value)
				{
					return;
				}
				_forwardFaceSlotComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(120)] 
		[RED("targetingComponent")] 
		public CHandle<gameTargetingComponent> TargetingComponent
		{
			get
			{
				if (_targetingComponent == null)
				{
					_targetingComponent = (CHandle<gameTargetingComponent>) CR2WTypeManager.Create("handle:gameTargetingComponent", "targetingComponent", cr2w, this);
				}
				return _targetingComponent;
			}
			set
			{
				if (_targetingComponent == value)
				{
					return;
				}
				_targetingComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(121)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get
			{
				if (_targetTrackerComponent == null)
				{
					_targetTrackerComponent = (CHandle<AITargetTrackerComponent>) CR2WTypeManager.Create("handle:AITargetTrackerComponent", "targetTrackerComponent", cr2w, this);
				}
				return _targetTrackerComponent;
			}
			set
			{
				if (_targetTrackerComponent == value)
				{
					return;
				}
				_targetTrackerComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(122)] 
		[RED("cameraComponentInverted")] 
		public CHandle<gameCameraComponent> CameraComponentInverted
		{
			get
			{
				if (_cameraComponentInverted == null)
				{
					_cameraComponentInverted = (CHandle<gameCameraComponent>) CR2WTypeManager.Create("handle:gameCameraComponent", "cameraComponentInverted", cr2w, this);
				}
				return _cameraComponentInverted;
			}
			set
			{
				if (_cameraComponentInverted == value)
				{
					return;
				}
				_cameraComponentInverted = value;
				PropertySet(this);
			}
		}

		[Ordinal(123)] 
		[RED("targets")] 
		public CArray<CHandle<Target>> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<CHandle<Target>>) CR2WTypeManager.Create("array:handle:Target", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		[Ordinal(124)] 
		[RED("currentlyFollowedTarget")] 
		public wCHandle<gameObject> CurrentlyFollowedTarget
		{
			get
			{
				if (_currentlyFollowedTarget == null)
				{
					_currentlyFollowedTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "currentlyFollowedTarget", cr2w, this);
				}
				return _currentlyFollowedTarget;
			}
			set
			{
				if (_currentlyFollowedTarget == value)
				{
					return;
				}
				_currentlyFollowedTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(125)] 
		[RED("currentLookAtEventVert")] 
		public CHandle<entLookAtAddEvent> CurrentLookAtEventVert
		{
			get
			{
				if (_currentLookAtEventVert == null)
				{
					_currentLookAtEventVert = (CHandle<entLookAtAddEvent>) CR2WTypeManager.Create("handle:entLookAtAddEvent", "currentLookAtEventVert", cr2w, this);
				}
				return _currentLookAtEventVert;
			}
			set
			{
				if (_currentLookAtEventVert == value)
				{
					return;
				}
				_currentLookAtEventVert = value;
				PropertySet(this);
			}
		}

		[Ordinal(126)] 
		[RED("currentLookAtEventHor")] 
		public CHandle<entLookAtAddEvent> CurrentLookAtEventHor
		{
			get
			{
				if (_currentLookAtEventHor == null)
				{
					_currentLookAtEventHor = (CHandle<entLookAtAddEvent>) CR2WTypeManager.Create("handle:entLookAtAddEvent", "currentLookAtEventHor", cr2w, this);
				}
				return _currentLookAtEventHor;
			}
			set
			{
				if (_currentLookAtEventHor == value)
				{
					return;
				}
				_currentLookAtEventHor = value;
				PropertySet(this);
			}
		}

		[Ordinal(127)] 
		[RED("HPListenersList")] 
		public CArray<CHandle<TargetedObjectDeathListener>> HPListenersList
		{
			get
			{
				if (_hPListenersList == null)
				{
					_hPListenersList = (CArray<CHandle<TargetedObjectDeathListener>>) CR2WTypeManager.Create("array:handle:TargetedObjectDeathListener", "HPListenersList", cr2w, this);
				}
				return _hPListenersList;
			}
			set
			{
				if (_hPListenersList == value)
				{
					return;
				}
				_hPListenersList = value;
				PropertySet(this);
			}
		}

		[Ordinal(128)] 
		[RED("sensorDeviceState")] 
		public CEnum<ESensorDeviceStates> SensorDeviceState
		{
			get
			{
				if (_sensorDeviceState == null)
				{
					_sensorDeviceState = (CEnum<ESensorDeviceStates>) CR2WTypeManager.Create("ESensorDeviceStates", "sensorDeviceState", cr2w, this);
				}
				return _sensorDeviceState;
			}
			set
			{
				if (_sensorDeviceState == value)
				{
					return;
				}
				_sensorDeviceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(129)] 
		[RED("sensorWakeState")] 
		public CEnum<ESensorDeviceWakeState> SensorWakeState
		{
			get
			{
				if (_sensorWakeState == null)
				{
					_sensorWakeState = (CEnum<ESensorDeviceWakeState>) CR2WTypeManager.Create("ESensorDeviceWakeState", "sensorWakeState", cr2w, this);
				}
				return _sensorWakeState;
			}
			set
			{
				if (_sensorWakeState == value)
				{
					return;
				}
				_sensorWakeState = value;
				PropertySet(this);
			}
		}

		[Ordinal(130)] 
		[RED("sensorWakeStatePrevious")] 
		public CEnum<ESensorDeviceWakeState> SensorWakeStatePrevious
		{
			get
			{
				if (_sensorWakeStatePrevious == null)
				{
					_sensorWakeStatePrevious = (CEnum<ESensorDeviceWakeState>) CR2WTypeManager.Create("ESensorDeviceWakeState", "sensorWakeStatePrevious", cr2w, this);
				}
				return _sensorWakeStatePrevious;
			}
			set
			{
				if (_sensorWakeStatePrevious == value)
				{
					return;
				}
				_sensorWakeStatePrevious = value;
				PropertySet(this);
			}
		}

		[Ordinal(131)] 
		[RED("targetingDelayEventID")] 
		public gameDelayID TargetingDelayEventID
		{
			get
			{
				if (_targetingDelayEventID == null)
				{
					_targetingDelayEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "targetingDelayEventID", cr2w, this);
				}
				return _targetingDelayEventID;
			}
			set
			{
				if (_targetingDelayEventID == value)
				{
					return;
				}
				_targetingDelayEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(132)] 
		[RED("hack_isTargetingDelayEventFilled")] 
		public CBool Hack_isTargetingDelayEventFilled
		{
			get
			{
				if (_hack_isTargetingDelayEventFilled == null)
				{
					_hack_isTargetingDelayEventFilled = (CBool) CR2WTypeManager.Create("Bool", "hack_isTargetingDelayEventFilled", cr2w, this);
				}
				return _hack_isTargetingDelayEventFilled;
			}
			set
			{
				if (_hack_isTargetingDelayEventFilled == value)
				{
					return;
				}
				_hack_isTargetingDelayEventFilled = value;
				PropertySet(this);
			}
		}

		[Ordinal(133)] 
		[RED("currentResolveDelayEventID")] 
		public gameDelayID CurrentResolveDelayEventID
		{
			get
			{
				if (_currentResolveDelayEventID == null)
				{
					_currentResolveDelayEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "currentResolveDelayEventID", cr2w, this);
				}
				return _currentResolveDelayEventID;
			}
			set
			{
				if (_currentResolveDelayEventID == value)
				{
					return;
				}
				_currentResolveDelayEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(134)] 
		[RED("hack_isResolveDelayEventFilled")] 
		public CBool Hack_isResolveDelayEventFilled
		{
			get
			{
				if (_hack_isResolveDelayEventFilled == null)
				{
					_hack_isResolveDelayEventFilled = (CBool) CR2WTypeManager.Create("Bool", "hack_isResolveDelayEventFilled", cr2w, this);
				}
				return _hack_isResolveDelayEventFilled;
			}
			set
			{
				if (_hack_isResolveDelayEventFilled == value)
				{
					return;
				}
				_hack_isResolveDelayEventFilled = value;
				PropertySet(this);
			}
		}

		[Ordinal(135)] 
		[RED("animFeatureData")] 
		public CHandle<AnimFeature_SensorDevice> AnimFeatureData
		{
			get
			{
				if (_animFeatureData == null)
				{
					_animFeatureData = (CHandle<AnimFeature_SensorDevice>) CR2WTypeManager.Create("handle:AnimFeature_SensorDevice", "animFeatureData", cr2w, this);
				}
				return _animFeatureData;
			}
			set
			{
				if (_animFeatureData == value)
				{
					return;
				}
				_animFeatureData = value;
				PropertySet(this);
			}
		}

		[Ordinal(136)] 
		[RED("animFeatureDataName")] 
		public CName AnimFeatureDataName
		{
			get
			{
				if (_animFeatureDataName == null)
				{
					_animFeatureDataName = (CName) CR2WTypeManager.Create("CName", "animFeatureDataName", cr2w, this);
				}
				return _animFeatureDataName;
			}
			set
			{
				if (_animFeatureDataName == value)
				{
					return;
				}
				_animFeatureDataName = value;
				PropertySet(this);
			}
		}

		[Ordinal(137)] 
		[RED("targetLostBySensesDelayEventID")] 
		public gameDelayID TargetLostBySensesDelayEventID
		{
			get
			{
				if (_targetLostBySensesDelayEventID == null)
				{
					_targetLostBySensesDelayEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "targetLostBySensesDelayEventID", cr2w, this);
				}
				return _targetLostBySensesDelayEventID;
			}
			set
			{
				if (_targetLostBySensesDelayEventID == value)
				{
					return;
				}
				_targetLostBySensesDelayEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(138)] 
		[RED("hack_isTargetLostBySensesDelEvtFilled")] 
		public CBool Hack_isTargetLostBySensesDelEvtFilled
		{
			get
			{
				if (_hack_isTargetLostBySensesDelEvtFilled == null)
				{
					_hack_isTargetLostBySensesDelEvtFilled = (CBool) CR2WTypeManager.Create("Bool", "hack_isTargetLostBySensesDelEvtFilled", cr2w, this);
				}
				return _hack_isTargetLostBySensesDelEvtFilled;
			}
			set
			{
				if (_hack_isTargetLostBySensesDelEvtFilled == value)
				{
					return;
				}
				_hack_isTargetLostBySensesDelEvtFilled = value;
				PropertySet(this);
			}
		}

		[Ordinal(139)] 
		[RED("initialAttitude")] 
		public CName InitialAttitude
		{
			get
			{
				if (_initialAttitude == null)
				{
					_initialAttitude = (CName) CR2WTypeManager.Create("CName", "initialAttitude", cr2w, this);
				}
				return _initialAttitude;
			}
			set
			{
				if (_initialAttitude == value)
				{
					return;
				}
				_initialAttitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(140)] 
		[RED("detectionFactorMultiplier")] 
		public CFloat DetectionFactorMultiplier
		{
			get
			{
				if (_detectionFactorMultiplier == null)
				{
					_detectionFactorMultiplier = (CFloat) CR2WTypeManager.Create("Float", "detectionFactorMultiplier", cr2w, this);
				}
				return _detectionFactorMultiplier;
			}
			set
			{
				if (_detectionFactorMultiplier == value)
				{
					return;
				}
				_detectionFactorMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(141)] 
		[RED("lightScanRefs")] 
		public CArray<CHandle<gameLightComponent>> LightScanRefs
		{
			get
			{
				if (_lightScanRefs == null)
				{
					_lightScanRefs = (CArray<CHandle<gameLightComponent>>) CR2WTypeManager.Create("array:handle:gameLightComponent", "lightScanRefs", cr2w, this);
				}
				return _lightScanRefs;
			}
			set
			{
				if (_lightScanRefs == value)
				{
					return;
				}
				_lightScanRefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(142)] 
		[RED("lightAttitudeRefs")] 
		public CArray<CHandle<gameLightComponent>> LightAttitudeRefs
		{
			get
			{
				if (_lightAttitudeRefs == null)
				{
					_lightAttitudeRefs = (CArray<CHandle<gameLightComponent>>) CR2WTypeManager.Create("array:handle:gameLightComponent", "lightAttitudeRefs", cr2w, this);
				}
				return _lightAttitudeRefs;
			}
			set
			{
				if (_lightAttitudeRefs == value)
				{
					return;
				}
				_lightAttitudeRefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(143)] 
		[RED("lightInfoRefs")] 
		public CArray<CHandle<gameLightComponent>> LightInfoRefs
		{
			get
			{
				if (_lightInfoRefs == null)
				{
					_lightInfoRefs = (CArray<CHandle<gameLightComponent>>) CR2WTypeManager.Create("array:handle:gameLightComponent", "lightInfoRefs", cr2w, this);
				}
				return _lightInfoRefs;
			}
			set
			{
				if (_lightInfoRefs == value)
				{
					return;
				}
				_lightInfoRefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(144)] 
		[RED("lightColors")] 
		public LedColors_SensorDevice LightColors
		{
			get
			{
				if (_lightColors == null)
				{
					_lightColors = (LedColors_SensorDevice) CR2WTypeManager.Create("LedColors_SensorDevice", "lightColors", cr2w, this);
				}
				return _lightColors;
			}
			set
			{
				if (_lightColors == value)
				{
					return;
				}
				_lightColors = value;
				PropertySet(this);
			}
		}

		[Ordinal(145)] 
		[RED("deviceFXRecord")] 
		public CHandle<gamedataDeviceFX_Record> DeviceFXRecord
		{
			get
			{
				if (_deviceFXRecord == null)
				{
					_deviceFXRecord = (CHandle<gamedataDeviceFX_Record>) CR2WTypeManager.Create("handle:gamedataDeviceFX_Record", "deviceFXRecord", cr2w, this);
				}
				return _deviceFXRecord;
			}
			set
			{
				if (_deviceFXRecord == value)
				{
					return;
				}
				_deviceFXRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(146)] 
		[RED("scanGameEffect")] 
		public CHandle<gameEffectInstance> ScanGameEffect
		{
			get
			{
				if (_scanGameEffect == null)
				{
					_scanGameEffect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "scanGameEffect", cr2w, this);
				}
				return _scanGameEffect;
			}
			set
			{
				if (_scanGameEffect == value)
				{
					return;
				}
				_scanGameEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(147)] 
		[RED("scanFXSlotName")] 
		public CName ScanFXSlotName
		{
			get
			{
				if (_scanFXSlotName == null)
				{
					_scanFXSlotName = (CName) CR2WTypeManager.Create("CName", "scanFXSlotName", cr2w, this);
				}
				return _scanFXSlotName;
			}
			set
			{
				if (_scanFXSlotName == value)
				{
					return;
				}
				_scanFXSlotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(148)] 
		[RED("visionConeEffectInstance")] 
		public CHandle<gameEffectInstance> VisionConeEffectInstance
		{
			get
			{
				if (_visionConeEffectInstance == null)
				{
					_visionConeEffectInstance = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "visionConeEffectInstance", cr2w, this);
				}
				return _visionConeEffectInstance;
			}
			set
			{
				if (_visionConeEffectInstance == value)
				{
					return;
				}
				_visionConeEffectInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(149)] 
		[RED("idleGameEffectInstance")] 
		public CHandle<gameEffectInstance> IdleGameEffectInstance
		{
			get
			{
				if (_idleGameEffectInstance == null)
				{
					_idleGameEffectInstance = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "idleGameEffectInstance", cr2w, this);
				}
				return _idleGameEffectInstance;
			}
			set
			{
				if (_idleGameEffectInstance == value)
				{
					return;
				}
				_idleGameEffectInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(150)] 
		[RED("targetForcedFormTagKill")] 
		public CBool TargetForcedFormTagKill
		{
			get
			{
				if (_targetForcedFormTagKill == null)
				{
					_targetForcedFormTagKill = (CBool) CR2WTypeManager.Create("Bool", "targetForcedFormTagKill", cr2w, this);
				}
				return _targetForcedFormTagKill;
			}
			set
			{
				if (_targetForcedFormTagKill == value)
				{
					return;
				}
				_targetForcedFormTagKill = value;
				PropertySet(this);
			}
		}

		[Ordinal(151)] 
		[RED("hasSupport")] 
		public CBool HasSupport
		{
			get
			{
				if (_hasSupport == null)
				{
					_hasSupport = (CBool) CR2WTypeManager.Create("Bool", "hasSupport", cr2w, this);
				}
				return _hasSupport;
			}
			set
			{
				if (_hasSupport == value)
				{
					return;
				}
				_hasSupport = value;
				PropertySet(this);
			}
		}

		[Ordinal(152)] 
		[RED("defaultSensePreset")] 
		public TweakDBID DefaultSensePreset
		{
			get
			{
				if (_defaultSensePreset == null)
				{
					_defaultSensePreset = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "defaultSensePreset", cr2w, this);
				}
				return _defaultSensePreset;
			}
			set
			{
				if (_defaultSensePreset == value)
				{
					return;
				}
				_defaultSensePreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(153)] 
		[RED("elementsToHideOnTCS")] 
		public CArray<CName> ElementsToHideOnTCS
		{
			get
			{
				if (_elementsToHideOnTCS == null)
				{
					_elementsToHideOnTCS = (CArray<CName>) CR2WTypeManager.Create("array:CName", "elementsToHideOnTCS", cr2w, this);
				}
				return _elementsToHideOnTCS;
			}
			set
			{
				if (_elementsToHideOnTCS == value)
				{
					return;
				}
				_elementsToHideOnTCS = value;
				PropertySet(this);
			}
		}

		[Ordinal(154)] 
		[RED("elementsToHideOnTCSRefs")] 
		public CArray<CHandle<entIPlacedComponent>> ElementsToHideOnTCSRefs
		{
			get
			{
				if (_elementsToHideOnTCSRefs == null)
				{
					_elementsToHideOnTCSRefs = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "elementsToHideOnTCSRefs", cr2w, this);
				}
				return _elementsToHideOnTCSRefs;
			}
			set
			{
				if (_elementsToHideOnTCSRefs == value)
				{
					return;
				}
				_elementsToHideOnTCSRefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(155)] 
		[RED("previoustagKillList")] 
		public CArray<wCHandle<gameObject>> PrevioustagKillList
		{
			get
			{
				if (_previoustagKillList == null)
				{
					_previoustagKillList = (CArray<wCHandle<gameObject>>) CR2WTypeManager.Create("array:whandle:gameObject", "previoustagKillList", cr2w, this);
				}
				return _previoustagKillList;
			}
			set
			{
				if (_previoustagKillList == value)
				{
					return;
				}
				_previoustagKillList = value;
				PropertySet(this);
			}
		}

		[Ordinal(156)] 
		[RED("playIdleSoundOnIdle")] 
		public CBool PlayIdleSoundOnIdle
		{
			get
			{
				if (_playIdleSoundOnIdle == null)
				{
					_playIdleSoundOnIdle = (CBool) CR2WTypeManager.Create("Bool", "playIdleSoundOnIdle", cr2w, this);
				}
				return _playIdleSoundOnIdle;
			}
			set
			{
				if (_playIdleSoundOnIdle == value)
				{
					return;
				}
				_playIdleSoundOnIdle = value;
				PropertySet(this);
			}
		}

		[Ordinal(157)] 
		[RED("idleSound")] 
		public CName IdleSound
		{
			get
			{
				if (_idleSound == null)
				{
					_idleSound = (CName) CR2WTypeManager.Create("CName", "idleSound", cr2w, this);
				}
				return _idleSound;
			}
			set
			{
				if (_idleSound == value)
				{
					return;
				}
				_idleSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(158)] 
		[RED("idleSoundStop")] 
		public CName IdleSoundStop
		{
			get
			{
				if (_idleSoundStop == null)
				{
					_idleSoundStop = (CName) CR2WTypeManager.Create("CName", "idleSoundStop", cr2w, this);
				}
				return _idleSoundStop;
			}
			set
			{
				if (_idleSoundStop == value)
				{
					return;
				}
				_idleSoundStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(159)] 
		[RED("soundDeviceON")] 
		public CName SoundDeviceON
		{
			get
			{
				if (_soundDeviceON == null)
				{
					_soundDeviceON = (CName) CR2WTypeManager.Create("CName", "soundDeviceON", cr2w, this);
				}
				return _soundDeviceON;
			}
			set
			{
				if (_soundDeviceON == value)
				{
					return;
				}
				_soundDeviceON = value;
				PropertySet(this);
			}
		}

		[Ordinal(160)] 
		[RED("soundDeviceOFF")] 
		public CName SoundDeviceOFF
		{
			get
			{
				if (_soundDeviceOFF == null)
				{
					_soundDeviceOFF = (CName) CR2WTypeManager.Create("CName", "soundDeviceOFF", cr2w, this);
				}
				return _soundDeviceOFF;
			}
			set
			{
				if (_soundDeviceOFF == value)
				{
					return;
				}
				_soundDeviceOFF = value;
				PropertySet(this);
			}
		}

		[Ordinal(161)] 
		[RED("idleSoundIsPlaying")] 
		public CBool IdleSoundIsPlaying
		{
			get
			{
				if (_idleSoundIsPlaying == null)
				{
					_idleSoundIsPlaying = (CBool) CR2WTypeManager.Create("Bool", "idleSoundIsPlaying", cr2w, this);
				}
				return _idleSoundIsPlaying;
			}
			set
			{
				if (_idleSoundIsPlaying == value)
				{
					return;
				}
				_idleSoundIsPlaying = value;
				PropertySet(this);
			}
		}

		[Ordinal(162)] 
		[RED("soundDeviceDestroyed")] 
		public CName SoundDeviceDestroyed
		{
			get
			{
				if (_soundDeviceDestroyed == null)
				{
					_soundDeviceDestroyed = (CName) CR2WTypeManager.Create("CName", "soundDeviceDestroyed", cr2w, this);
				}
				return _soundDeviceDestroyed;
			}
			set
			{
				if (_soundDeviceDestroyed == value)
				{
					return;
				}
				_soundDeviceDestroyed = value;
				PropertySet(this);
			}
		}

		[Ordinal(163)] 
		[RED("soundDetectionLoop")] 
		public CName SoundDetectionLoop
		{
			get
			{
				if (_soundDetectionLoop == null)
				{
					_soundDetectionLoop = (CName) CR2WTypeManager.Create("CName", "soundDetectionLoop", cr2w, this);
				}
				return _soundDetectionLoop;
			}
			set
			{
				if (_soundDetectionLoop == value)
				{
					return;
				}
				_soundDetectionLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(164)] 
		[RED("soundDetectionLoopStop")] 
		public CName SoundDetectionLoopStop
		{
			get
			{
				if (_soundDetectionLoopStop == null)
				{
					_soundDetectionLoopStop = (CName) CR2WTypeManager.Create("CName", "soundDetectionLoopStop", cr2w, this);
				}
				return _soundDetectionLoopStop;
			}
			set
			{
				if (_soundDetectionLoopStop == value)
				{
					return;
				}
				_soundDetectionLoopStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(165)] 
		[RED("isPLAYERSAFETargetLock")] 
		public CBool IsPLAYERSAFETargetLock
		{
			get
			{
				if (_isPLAYERSAFETargetLock == null)
				{
					_isPLAYERSAFETargetLock = (CBool) CR2WTypeManager.Create("Bool", "isPLAYERSAFETargetLock", cr2w, this);
				}
				return _isPLAYERSAFETargetLock;
			}
			set
			{
				if (_isPLAYERSAFETargetLock == value)
				{
					return;
				}
				_isPLAYERSAFETargetLock = value;
				PropertySet(this);
			}
		}

		[Ordinal(166)] 
		[RED("playerDetected")] 
		public CBool PlayerDetected
		{
			get
			{
				if (_playerDetected == null)
				{
					_playerDetected = (CBool) CR2WTypeManager.Create("Bool", "playerDetected", cr2w, this);
				}
				return _playerDetected;
			}
			set
			{
				if (_playerDetected == value)
				{
					return;
				}
				_playerDetected = value;
				PropertySet(this);
			}
		}

		[Ordinal(167)] 
		[RED("clientForceSetAnimFeature")] 
		public CBool ClientForceSetAnimFeature
		{
			get
			{
				if (_clientForceSetAnimFeature == null)
				{
					_clientForceSetAnimFeature = (CBool) CR2WTypeManager.Create("Bool", "clientForceSetAnimFeature", cr2w, this);
				}
				return _clientForceSetAnimFeature;
			}
			set
			{
				if (_clientForceSetAnimFeature == value)
				{
					return;
				}
				_clientForceSetAnimFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(168)] 
		[RED("playerControlData")] 
		public PlayerControlDeviceData PlayerControlData
		{
			get
			{
				if (_playerControlData == null)
				{
					_playerControlData = (PlayerControlDeviceData) CR2WTypeManager.Create("PlayerControlDeviceData", "playerControlData", cr2w, this);
				}
				return _playerControlData;
			}
			set
			{
				if (_playerControlData == value)
				{
					return;
				}
				_playerControlData = value;
				PropertySet(this);
			}
		}

		[Ordinal(169)] 
		[RED("engineTimeInSec")] 
		public CFloat EngineTimeInSec
		{
			get
			{
				if (_engineTimeInSec == null)
				{
					_engineTimeInSec = (CFloat) CR2WTypeManager.Create("Float", "engineTimeInSec", cr2w, this);
				}
				return _engineTimeInSec;
			}
			set
			{
				if (_engineTimeInSec == value)
				{
					return;
				}
				_engineTimeInSec = value;
				PropertySet(this);
			}
		}

		[Ordinal(170)] 
		[RED("TCExitEngineTime")] 
		public CFloat TCExitEngineTime
		{
			get
			{
				if (_tCExitEngineTime == null)
				{
					_tCExitEngineTime = (CFloat) CR2WTypeManager.Create("Float", "TCExitEngineTime", cr2w, this);
				}
				return _tCExitEngineTime;
			}
			set
			{
				if (_tCExitEngineTime == value)
				{
					return;
				}
				_tCExitEngineTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(171)] 
		[RED("hack_wasTargetReevaluated")] 
		public CBool Hack_wasTargetReevaluated
		{
			get
			{
				if (_hack_wasTargetReevaluated == null)
				{
					_hack_wasTargetReevaluated = (CBool) CR2WTypeManager.Create("Bool", "hack_wasTargetReevaluated", cr2w, this);
				}
				return _hack_wasTargetReevaluated;
			}
			set
			{
				if (_hack_wasTargetReevaluated == value)
				{
					return;
				}
				_hack_wasTargetReevaluated = value;
				PropertySet(this);
			}
		}

		[Ordinal(172)] 
		[RED("hack_wasSSOutupFromSelf")] 
		public CBool Hack_wasSSOutupFromSelf
		{
			get
			{
				if (_hack_wasSSOutupFromSelf == null)
				{
					_hack_wasSSOutupFromSelf = (CBool) CR2WTypeManager.Create("Bool", "hack_wasSSOutupFromSelf", cr2w, this);
				}
				return _hack_wasSSOutupFromSelf;
			}
			set
			{
				if (_hack_wasSSOutupFromSelf == value)
				{
					return;
				}
				_hack_wasSSOutupFromSelf = value;
				PropertySet(this);
			}
		}

		[Ordinal(173)] 
		[RED("degbu_SS_inputsSend")] 
		public CInt32 Degbu_SS_inputsSend
		{
			get
			{
				if (_degbu_SS_inputsSend == null)
				{
					_degbu_SS_inputsSend = (CInt32) CR2WTypeManager.Create("Int32", "degbu_SS_inputsSend", cr2w, this);
				}
				return _degbu_SS_inputsSend;
			}
			set
			{
				if (_degbu_SS_inputsSend == value)
				{
					return;
				}
				_degbu_SS_inputsSend = value;
				PropertySet(this);
			}
		}

		[Ordinal(174)] 
		[RED("debug_SS_inputsSendTargetLock")] 
		public CInt32 Debug_SS_inputsSendTargetLock
		{
			get
			{
				if (_debug_SS_inputsSendTargetLock == null)
				{
					_debug_SS_inputsSendTargetLock = (CInt32) CR2WTypeManager.Create("Int32", "debug_SS_inputsSendTargetLock", cr2w, this);
				}
				return _debug_SS_inputsSendTargetLock;
			}
			set
			{
				if (_debug_SS_inputsSendTargetLock == value)
				{
					return;
				}
				_debug_SS_inputsSendTargetLock = value;
				PropertySet(this);
			}
		}

		[Ordinal(175)] 
		[RED("debug_SS_inputsSendIntresting")] 
		public CInt32 Debug_SS_inputsSendIntresting
		{
			get
			{
				if (_debug_SS_inputsSendIntresting == null)
				{
					_debug_SS_inputsSendIntresting = (CInt32) CR2WTypeManager.Create("Int32", "debug_SS_inputsSendIntresting", cr2w, this);
				}
				return _debug_SS_inputsSendIntresting;
			}
			set
			{
				if (_debug_SS_inputsSendIntresting == value)
				{
					return;
				}
				_debug_SS_inputsSendIntresting = value;
				PropertySet(this);
			}
		}

		[Ordinal(176)] 
		[RED("debug_SS_inputsSendLoseTarget")] 
		public CInt32 Debug_SS_inputsSendLoseTarget
		{
			get
			{
				if (_debug_SS_inputsSendLoseTarget == null)
				{
					_debug_SS_inputsSendLoseTarget = (CInt32) CR2WTypeManager.Create("Int32", "debug_SS_inputsSendLoseTarget", cr2w, this);
				}
				return _debug_SS_inputsSendLoseTarget;
			}
			set
			{
				if (_debug_SS_inputsSendLoseTarget == value)
				{
					return;
				}
				_debug_SS_inputsSendLoseTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(177)] 
		[RED("debug_SS_outputRecieved")] 
		public CInt32 Debug_SS_outputRecieved
		{
			get
			{
				if (_debug_SS_outputRecieved == null)
				{
					_debug_SS_outputRecieved = (CInt32) CR2WTypeManager.Create("Int32", "debug_SS_outputRecieved", cr2w, this);
				}
				return _debug_SS_outputRecieved;
			}
			set
			{
				if (_debug_SS_outputRecieved == value)
				{
					return;
				}
				_debug_SS_outputRecieved = value;
				PropertySet(this);
			}
		}

		[Ordinal(178)] 
		[RED("debug_SS_outputFormSelfRecieved")] 
		public CInt32 Debug_SS_outputFormSelfRecieved
		{
			get
			{
				if (_debug_SS_outputFormSelfRecieved == null)
				{
					_debug_SS_outputFormSelfRecieved = (CInt32) CR2WTypeManager.Create("Int32", "debug_SS_outputFormSelfRecieved", cr2w, this);
				}
				return _debug_SS_outputFormSelfRecieved;
			}
			set
			{
				if (_debug_SS_outputFormSelfRecieved == value)
				{
					return;
				}
				_debug_SS_outputFormSelfRecieved = value;
				PropertySet(this);
			}
		}

		[Ordinal(179)] 
		[RED("debug_SS_outputFromElseRecieved")] 
		public CInt32 Debug_SS_outputFromElseRecieved
		{
			get
			{
				if (_debug_SS_outputFromElseRecieved == null)
				{
					_debug_SS_outputFromElseRecieved = (CInt32) CR2WTypeManager.Create("Int32", "debug_SS_outputFromElseRecieved", cr2w, this);
				}
				return _debug_SS_outputFromElseRecieved;
			}
			set
			{
				if (_debug_SS_outputFromElseRecieved == value)
				{
					return;
				}
				_debug_SS_outputFromElseRecieved = value;
				PropertySet(this);
			}
		}

		[Ordinal(180)] 
		[RED("debug_SS_reevaluatesDone")] 
		public CInt32 Debug_SS_reevaluatesDone
		{
			get
			{
				if (_debug_SS_reevaluatesDone == null)
				{
					_debug_SS_reevaluatesDone = (CInt32) CR2WTypeManager.Create("Int32", "debug_SS_reevaluatesDone", cr2w, this);
				}
				return _debug_SS_reevaluatesDone;
			}
			set
			{
				if (_debug_SS_reevaluatesDone == value)
				{
					return;
				}
				_debug_SS_reevaluatesDone = value;
				PropertySet(this);
			}
		}

		[Ordinal(181)] 
		[RED("debug_SS_trespassingRecieved")] 
		public CInt32 Debug_SS_trespassingRecieved
		{
			get
			{
				if (_debug_SS_trespassingRecieved == null)
				{
					_debug_SS_trespassingRecieved = (CInt32) CR2WTypeManager.Create("Int32", "debug_SS_trespassingRecieved", cr2w, this);
				}
				return _debug_SS_trespassingRecieved;
			}
			set
			{
				if (_debug_SS_trespassingRecieved == value)
				{
					return;
				}
				_debug_SS_trespassingRecieved = value;
				PropertySet(this);
			}
		}

		[Ordinal(182)] 
		[RED("debug_SS_TargetAssessmentRequest")] 
		public CInt32 Debug_SS_TargetAssessmentRequest
		{
			get
			{
				if (_debug_SS_TargetAssessmentRequest == null)
				{
					_debug_SS_TargetAssessmentRequest = (CInt32) CR2WTypeManager.Create("Int32", "debug_SS_TargetAssessmentRequest", cr2w, this);
				}
				return _debug_SS_TargetAssessmentRequest;
			}
			set
			{
				if (_debug_SS_TargetAssessmentRequest == value)
				{
					return;
				}
				_debug_SS_TargetAssessmentRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(183)] 
		[RED("minPitch")] 
		public CFloat MinPitch
		{
			get
			{
				if (_minPitch == null)
				{
					_minPitch = (CFloat) CR2WTypeManager.Create("Float", "minPitch", cr2w, this);
				}
				return _minPitch;
			}
			set
			{
				if (_minPitch == value)
				{
					return;
				}
				_minPitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(184)] 
		[RED("maxPitch")] 
		public CFloat MaxPitch
		{
			get
			{
				if (_maxPitch == null)
				{
					_maxPitch = (CFloat) CR2WTypeManager.Create("Float", "maxPitch", cr2w, this);
				}
				return _maxPitch;
			}
			set
			{
				if (_maxPitch == value)
				{
					return;
				}
				_maxPitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(185)] 
		[RED("minYaw")] 
		public CFloat MinYaw
		{
			get
			{
				if (_minYaw == null)
				{
					_minYaw = (CFloat) CR2WTypeManager.Create("Float", "minYaw", cr2w, this);
				}
				return _minYaw;
			}
			set
			{
				if (_minYaw == value)
				{
					return;
				}
				_minYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(186)] 
		[RED("maxYaw")] 
		public CFloat MaxYaw
		{
			get
			{
				if (_maxYaw == null)
				{
					_maxYaw = (CFloat) CR2WTypeManager.Create("Float", "maxYaw", cr2w, this);
				}
				return _maxYaw;
			}
			set
			{
				if (_maxYaw == value)
				{
					return;
				}
				_maxYaw = value;
				PropertySet(this);
			}
		}

		public SensorDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
