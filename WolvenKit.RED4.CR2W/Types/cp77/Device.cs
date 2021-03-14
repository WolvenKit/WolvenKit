using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Device : gameDeviceBase
	{
		private CHandle<ScriptableDC> _controller;
		private CBool _wasVisible;
		private CBool _isVisible;
		private CName _controllerTypeName;
		private CEnum<EDeviceStatus> _deviceState;
		private wCHandle<IWorldWidgetComponent> _uiComponent;
		private SUIScreenDefinition _screenDefinition;
		private CBool _isUIdirty;
		private CHandle<workWorkspotResourceComponent> _personalLinkComponent;
		private CEnum<EDeviceDurabilityType> _durabilityType;
		private CHandle<DisassemblableComponent> _disassemblableComponent;
		private CHandle<entLocalizationStringComponent> _localization;
		private CHandle<entSlotComponent> _iKslotComponent;
		private CHandle<workWorkspotResourceComponent> _toggleZoomInteractionWorkspot;
		private CHandle<gameCameraComponent> _cameraZoomComponent;
		private CHandle<entSlotComponent> _slotComponent;
		private CBool _isInitialized;
		private CBool _isLogicready;
		private CBool _isInsideLogicArea;
		private CHandle<gameCameraComponent> _cameraComponent;
		private CUInt32 _zoomUIListenerID;
		private CUInt32 _zoomStateMachineListenerID;
		private TweakDBID _activeStatusEffect;
		private TweakDBID _activeProgramToUploadOnNPC;
		private CBool _isQhackUploadInProgerss;
		private TweakDBID _scanningTweakDBRecord;
		private CBool _updateRunning;
		private gameDelayID _updateID;
		private gameDelayID _delayedUpdateDeviceStateID;
		private CHandle<gameIBlackboard> _blackboard;
		private CUInt32 _currentPlayerTargetCallbackID;
		private CBool _wasLookedAtLast;
		private entEntityID _lastPingSourceID;
		private gameFxResource _networkGridBeamFX;
		private CHandle<FxResourceMapperComponent> _fxResourceMapper;
		private CHandle<AreaEffectVisualizationComponent> _effectVisualization;
		private CHandle<ResourceLibraryComponent> _resourceLibraryComponent;
		private CHandle<GameplayRoleComponent> _gameplayRoleComponent;
		private CBool _personalLinkHackSend;
		private gameDelayID _personalLinkFailsafeID;
		private CBool _wasAnimationFastForwarded;
		private TweakDBID _contentScale;
		private Vector4 _networkGridBeamOffset;
		private CArray<SAreaEffectData> _areaEffectsData;
		private CArray<SAreaEffectTargetData> _areaEffectsInFocusMode;
		private DebuggerProperties _debugOptions;

		[Ordinal(40)] 
		[RED("controller")] 
		public CHandle<ScriptableDC> Controller
		{
			get
			{
				if (_controller == null)
				{
					_controller = (CHandle<ScriptableDC>) CR2WTypeManager.Create("handle:ScriptableDC", "controller", cr2w, this);
				}
				return _controller;
			}
			set
			{
				if (_controller == value)
				{
					return;
				}
				_controller = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("wasVisible")] 
		public CBool WasVisible
		{
			get
			{
				if (_wasVisible == null)
				{
					_wasVisible = (CBool) CR2WTypeManager.Create("Bool", "wasVisible", cr2w, this);
				}
				return _wasVisible;
			}
			set
			{
				if (_wasVisible == value)
				{
					return;
				}
				_wasVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get
			{
				if (_isVisible == null)
				{
					_isVisible = (CBool) CR2WTypeManager.Create("Bool", "isVisible", cr2w, this);
				}
				return _isVisible;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				_isVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("controllerTypeName")] 
		public CName ControllerTypeName
		{
			get
			{
				if (_controllerTypeName == null)
				{
					_controllerTypeName = (CName) CR2WTypeManager.Create("CName", "controllerTypeName", cr2w, this);
				}
				return _controllerTypeName;
			}
			set
			{
				if (_controllerTypeName == value)
				{
					return;
				}
				_controllerTypeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get
			{
				if (_deviceState == null)
				{
					_deviceState = (CEnum<EDeviceStatus>) CR2WTypeManager.Create("EDeviceStatus", "deviceState", cr2w, this);
				}
				return _deviceState;
			}
			set
			{
				if (_deviceState == value)
				{
					return;
				}
				_deviceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("uiComponent")] 
		public wCHandle<IWorldWidgetComponent> UiComponent
		{
			get
			{
				if (_uiComponent == null)
				{
					_uiComponent = (wCHandle<IWorldWidgetComponent>) CR2WTypeManager.Create("whandle:IWorldWidgetComponent", "uiComponent", cr2w, this);
				}
				return _uiComponent;
			}
			set
			{
				if (_uiComponent == value)
				{
					return;
				}
				_uiComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("screenDefinition")] 
		public SUIScreenDefinition ScreenDefinition
		{
			get
			{
				if (_screenDefinition == null)
				{
					_screenDefinition = (SUIScreenDefinition) CR2WTypeManager.Create("SUIScreenDefinition", "screenDefinition", cr2w, this);
				}
				return _screenDefinition;
			}
			set
			{
				if (_screenDefinition == value)
				{
					return;
				}
				_screenDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("isUIdirty")] 
		public CBool IsUIdirty
		{
			get
			{
				if (_isUIdirty == null)
				{
					_isUIdirty = (CBool) CR2WTypeManager.Create("Bool", "isUIdirty", cr2w, this);
				}
				return _isUIdirty;
			}
			set
			{
				if (_isUIdirty == value)
				{
					return;
				}
				_isUIdirty = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("personalLinkComponent")] 
		public CHandle<workWorkspotResourceComponent> PersonalLinkComponent
		{
			get
			{
				if (_personalLinkComponent == null)
				{
					_personalLinkComponent = (CHandle<workWorkspotResourceComponent>) CR2WTypeManager.Create("handle:workWorkspotResourceComponent", "personalLinkComponent", cr2w, this);
				}
				return _personalLinkComponent;
			}
			set
			{
				if (_personalLinkComponent == value)
				{
					return;
				}
				_personalLinkComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("durabilityType")] 
		public CEnum<EDeviceDurabilityType> DurabilityType
		{
			get
			{
				if (_durabilityType == null)
				{
					_durabilityType = (CEnum<EDeviceDurabilityType>) CR2WTypeManager.Create("EDeviceDurabilityType", "durabilityType", cr2w, this);
				}
				return _durabilityType;
			}
			set
			{
				if (_durabilityType == value)
				{
					return;
				}
				_durabilityType = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("disassemblableComponent")] 
		public CHandle<DisassemblableComponent> DisassemblableComponent
		{
			get
			{
				if (_disassemblableComponent == null)
				{
					_disassemblableComponent = (CHandle<DisassemblableComponent>) CR2WTypeManager.Create("handle:DisassemblableComponent", "disassemblableComponent", cr2w, this);
				}
				return _disassemblableComponent;
			}
			set
			{
				if (_disassemblableComponent == value)
				{
					return;
				}
				_disassemblableComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("localization")] 
		public CHandle<entLocalizationStringComponent> Localization
		{
			get
			{
				if (_localization == null)
				{
					_localization = (CHandle<entLocalizationStringComponent>) CR2WTypeManager.Create("handle:entLocalizationStringComponent", "localization", cr2w, this);
				}
				return _localization;
			}
			set
			{
				if (_localization == value)
				{
					return;
				}
				_localization = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("IKslotComponent")] 
		public CHandle<entSlotComponent> IKslotComponent
		{
			get
			{
				if (_iKslotComponent == null)
				{
					_iKslotComponent = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "IKslotComponent", cr2w, this);
				}
				return _iKslotComponent;
			}
			set
			{
				if (_iKslotComponent == value)
				{
					return;
				}
				_iKslotComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("ToggleZoomInteractionWorkspot")] 
		public CHandle<workWorkspotResourceComponent> ToggleZoomInteractionWorkspot
		{
			get
			{
				if (_toggleZoomInteractionWorkspot == null)
				{
					_toggleZoomInteractionWorkspot = (CHandle<workWorkspotResourceComponent>) CR2WTypeManager.Create("handle:workWorkspotResourceComponent", "ToggleZoomInteractionWorkspot", cr2w, this);
				}
				return _toggleZoomInteractionWorkspot;
			}
			set
			{
				if (_toggleZoomInteractionWorkspot == value)
				{
					return;
				}
				_toggleZoomInteractionWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("cameraZoomComponent")] 
		public CHandle<gameCameraComponent> CameraZoomComponent
		{
			get
			{
				if (_cameraZoomComponent == null)
				{
					_cameraZoomComponent = (CHandle<gameCameraComponent>) CR2WTypeManager.Create("handle:gameCameraComponent", "cameraZoomComponent", cr2w, this);
				}
				return _cameraZoomComponent;
			}
			set
			{
				if (_cameraZoomComponent == value)
				{
					return;
				}
				_cameraZoomComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get
			{
				if (_slotComponent == null)
				{
					_slotComponent = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "slotComponent", cr2w, this);
				}
				return _slotComponent;
			}
			set
			{
				if (_slotComponent == value)
				{
					return;
				}
				_slotComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("isLogicready")] 
		public CBool IsLogicready
		{
			get
			{
				if (_isLogicready == null)
				{
					_isLogicready = (CBool) CR2WTypeManager.Create("Bool", "isLogicready", cr2w, this);
				}
				return _isLogicready;
			}
			set
			{
				if (_isLogicready == value)
				{
					return;
				}
				_isLogicready = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("isInsideLogicArea")] 
		public CBool IsInsideLogicArea
		{
			get
			{
				if (_isInsideLogicArea == null)
				{
					_isInsideLogicArea = (CBool) CR2WTypeManager.Create("Bool", "isInsideLogicArea", cr2w, this);
				}
				return _isInsideLogicArea;
			}
			set
			{
				if (_isInsideLogicArea == value)
				{
					return;
				}
				_isInsideLogicArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("cameraComponent")] 
		public CHandle<gameCameraComponent> CameraComponent
		{
			get
			{
				if (_cameraComponent == null)
				{
					_cameraComponent = (CHandle<gameCameraComponent>) CR2WTypeManager.Create("handle:gameCameraComponent", "cameraComponent", cr2w, this);
				}
				return _cameraComponent;
			}
			set
			{
				if (_cameraComponent == value)
				{
					return;
				}
				_cameraComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("ZoomUIListenerID")] 
		public CUInt32 ZoomUIListenerID
		{
			get
			{
				if (_zoomUIListenerID == null)
				{
					_zoomUIListenerID = (CUInt32) CR2WTypeManager.Create("Uint32", "ZoomUIListenerID", cr2w, this);
				}
				return _zoomUIListenerID;
			}
			set
			{
				if (_zoomUIListenerID == value)
				{
					return;
				}
				_zoomUIListenerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("ZoomStateMachineListenerID")] 
		public CUInt32 ZoomStateMachineListenerID
		{
			get
			{
				if (_zoomStateMachineListenerID == null)
				{
					_zoomStateMachineListenerID = (CUInt32) CR2WTypeManager.Create("Uint32", "ZoomStateMachineListenerID", cr2w, this);
				}
				return _zoomStateMachineListenerID;
			}
			set
			{
				if (_zoomStateMachineListenerID == value)
				{
					return;
				}
				_zoomStateMachineListenerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("activeStatusEffect")] 
		public TweakDBID ActiveStatusEffect
		{
			get
			{
				if (_activeStatusEffect == null)
				{
					_activeStatusEffect = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "activeStatusEffect", cr2w, this);
				}
				return _activeStatusEffect;
			}
			set
			{
				if (_activeStatusEffect == value)
				{
					return;
				}
				_activeStatusEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("activeProgramToUploadOnNPC")] 
		public TweakDBID ActiveProgramToUploadOnNPC
		{
			get
			{
				if (_activeProgramToUploadOnNPC == null)
				{
					_activeProgramToUploadOnNPC = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "activeProgramToUploadOnNPC", cr2w, this);
				}
				return _activeProgramToUploadOnNPC;
			}
			set
			{
				if (_activeProgramToUploadOnNPC == value)
				{
					return;
				}
				_activeProgramToUploadOnNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("isQhackUploadInProgerss")] 
		public CBool IsQhackUploadInProgerss
		{
			get
			{
				if (_isQhackUploadInProgerss == null)
				{
					_isQhackUploadInProgerss = (CBool) CR2WTypeManager.Create("Bool", "isQhackUploadInProgerss", cr2w, this);
				}
				return _isQhackUploadInProgerss;
			}
			set
			{
				if (_isQhackUploadInProgerss == value)
				{
					return;
				}
				_isQhackUploadInProgerss = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("scanningTweakDBRecord")] 
		public TweakDBID ScanningTweakDBRecord
		{
			get
			{
				if (_scanningTweakDBRecord == null)
				{
					_scanningTweakDBRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "scanningTweakDBRecord", cr2w, this);
				}
				return _scanningTweakDBRecord;
			}
			set
			{
				if (_scanningTweakDBRecord == value)
				{
					return;
				}
				_scanningTweakDBRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("updateRunning")] 
		public CBool UpdateRunning
		{
			get
			{
				if (_updateRunning == null)
				{
					_updateRunning = (CBool) CR2WTypeManager.Create("Bool", "updateRunning", cr2w, this);
				}
				return _updateRunning;
			}
			set
			{
				if (_updateRunning == value)
				{
					return;
				}
				_updateRunning = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("updateID")] 
		public gameDelayID UpdateID
		{
			get
			{
				if (_updateID == null)
				{
					_updateID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "updateID", cr2w, this);
				}
				return _updateID;
			}
			set
			{
				if (_updateID == value)
				{
					return;
				}
				_updateID = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("delayedUpdateDeviceStateID")] 
		public gameDelayID DelayedUpdateDeviceStateID
		{
			get
			{
				if (_delayedUpdateDeviceStateID == null)
				{
					_delayedUpdateDeviceStateID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayedUpdateDeviceStateID", cr2w, this);
				}
				return _delayedUpdateDeviceStateID;
			}
			set
			{
				if (_delayedUpdateDeviceStateID == value)
				{
					return;
				}
				_delayedUpdateDeviceStateID = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("currentPlayerTargetCallbackID")] 
		public CUInt32 CurrentPlayerTargetCallbackID
		{
			get
			{
				if (_currentPlayerTargetCallbackID == null)
				{
					_currentPlayerTargetCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "currentPlayerTargetCallbackID", cr2w, this);
				}
				return _currentPlayerTargetCallbackID;
			}
			set
			{
				if (_currentPlayerTargetCallbackID == value)
				{
					return;
				}
				_currentPlayerTargetCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("wasLookedAtLast")] 
		public CBool WasLookedAtLast
		{
			get
			{
				if (_wasLookedAtLast == null)
				{
					_wasLookedAtLast = (CBool) CR2WTypeManager.Create("Bool", "wasLookedAtLast", cr2w, this);
				}
				return _wasLookedAtLast;
			}
			set
			{
				if (_wasLookedAtLast == value)
				{
					return;
				}
				_wasLookedAtLast = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("lastPingSourceID")] 
		public entEntityID LastPingSourceID
		{
			get
			{
				if (_lastPingSourceID == null)
				{
					_lastPingSourceID = (entEntityID) CR2WTypeManager.Create("entEntityID", "lastPingSourceID", cr2w, this);
				}
				return _lastPingSourceID;
			}
			set
			{
				if (_lastPingSourceID == value)
				{
					return;
				}
				_lastPingSourceID = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("networkGridBeamFX")] 
		public gameFxResource NetworkGridBeamFX
		{
			get
			{
				if (_networkGridBeamFX == null)
				{
					_networkGridBeamFX = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "networkGridBeamFX", cr2w, this);
				}
				return _networkGridBeamFX;
			}
			set
			{
				if (_networkGridBeamFX == value)
				{
					return;
				}
				_networkGridBeamFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("fxResourceMapper")] 
		public CHandle<FxResourceMapperComponent> FxResourceMapper
		{
			get
			{
				if (_fxResourceMapper == null)
				{
					_fxResourceMapper = (CHandle<FxResourceMapperComponent>) CR2WTypeManager.Create("handle:FxResourceMapperComponent", "fxResourceMapper", cr2w, this);
				}
				return _fxResourceMapper;
			}
			set
			{
				if (_fxResourceMapper == value)
				{
					return;
				}
				_fxResourceMapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("effectVisualization")] 
		public CHandle<AreaEffectVisualizationComponent> EffectVisualization
		{
			get
			{
				if (_effectVisualization == null)
				{
					_effectVisualization = (CHandle<AreaEffectVisualizationComponent>) CR2WTypeManager.Create("handle:AreaEffectVisualizationComponent", "effectVisualization", cr2w, this);
				}
				return _effectVisualization;
			}
			set
			{
				if (_effectVisualization == value)
				{
					return;
				}
				_effectVisualization = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get
			{
				if (_resourceLibraryComponent == null)
				{
					_resourceLibraryComponent = (CHandle<ResourceLibraryComponent>) CR2WTypeManager.Create("handle:ResourceLibraryComponent", "resourceLibraryComponent", cr2w, this);
				}
				return _resourceLibraryComponent;
			}
			set
			{
				if (_resourceLibraryComponent == value)
				{
					return;
				}
				_resourceLibraryComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("gameplayRoleComponent")] 
		public CHandle<GameplayRoleComponent> GameplayRoleComponent
		{
			get
			{
				if (_gameplayRoleComponent == null)
				{
					_gameplayRoleComponent = (CHandle<GameplayRoleComponent>) CR2WTypeManager.Create("handle:GameplayRoleComponent", "gameplayRoleComponent", cr2w, this);
				}
				return _gameplayRoleComponent;
			}
			set
			{
				if (_gameplayRoleComponent == value)
				{
					return;
				}
				_gameplayRoleComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("personalLinkHackSend")] 
		public CBool PersonalLinkHackSend
		{
			get
			{
				if (_personalLinkHackSend == null)
				{
					_personalLinkHackSend = (CBool) CR2WTypeManager.Create("Bool", "personalLinkHackSend", cr2w, this);
				}
				return _personalLinkHackSend;
			}
			set
			{
				if (_personalLinkHackSend == value)
				{
					return;
				}
				_personalLinkHackSend = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("personalLinkFailsafeID")] 
		public gameDelayID PersonalLinkFailsafeID
		{
			get
			{
				if (_personalLinkFailsafeID == null)
				{
					_personalLinkFailsafeID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "personalLinkFailsafeID", cr2w, this);
				}
				return _personalLinkFailsafeID;
			}
			set
			{
				if (_personalLinkFailsafeID == value)
				{
					return;
				}
				_personalLinkFailsafeID = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("wasAnimationFastForwarded")] 
		public CBool WasAnimationFastForwarded
		{
			get
			{
				if (_wasAnimationFastForwarded == null)
				{
					_wasAnimationFastForwarded = (CBool) CR2WTypeManager.Create("Bool", "wasAnimationFastForwarded", cr2w, this);
				}
				return _wasAnimationFastForwarded;
			}
			set
			{
				if (_wasAnimationFastForwarded == value)
				{
					return;
				}
				_wasAnimationFastForwarded = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("contentScale")] 
		public TweakDBID ContentScale
		{
			get
			{
				if (_contentScale == null)
				{
					_contentScale = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "contentScale", cr2w, this);
				}
				return _contentScale;
			}
			set
			{
				if (_contentScale == value)
				{
					return;
				}
				_contentScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(82)] 
		[RED("networkGridBeamOffset")] 
		public Vector4 NetworkGridBeamOffset
		{
			get
			{
				if (_networkGridBeamOffset == null)
				{
					_networkGridBeamOffset = (Vector4) CR2WTypeManager.Create("Vector4", "networkGridBeamOffset", cr2w, this);
				}
				return _networkGridBeamOffset;
			}
			set
			{
				if (_networkGridBeamOffset == value)
				{
					return;
				}
				_networkGridBeamOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(83)] 
		[RED("areaEffectsData")] 
		public CArray<SAreaEffectData> AreaEffectsData
		{
			get
			{
				if (_areaEffectsData == null)
				{
					_areaEffectsData = (CArray<SAreaEffectData>) CR2WTypeManager.Create("array:SAreaEffectData", "areaEffectsData", cr2w, this);
				}
				return _areaEffectsData;
			}
			set
			{
				if (_areaEffectsData == value)
				{
					return;
				}
				_areaEffectsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(84)] 
		[RED("areaEffectsInFocusMode")] 
		public CArray<SAreaEffectTargetData> AreaEffectsInFocusMode
		{
			get
			{
				if (_areaEffectsInFocusMode == null)
				{
					_areaEffectsInFocusMode = (CArray<SAreaEffectTargetData>) CR2WTypeManager.Create("array:SAreaEffectTargetData", "areaEffectsInFocusMode", cr2w, this);
				}
				return _areaEffectsInFocusMode;
			}
			set
			{
				if (_areaEffectsInFocusMode == value)
				{
					return;
				}
				_areaEffectsInFocusMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(85)] 
		[RED("debugOptions")] 
		public DebuggerProperties DebugOptions
		{
			get
			{
				if (_debugOptions == null)
				{
					_debugOptions = (DebuggerProperties) CR2WTypeManager.Create("DebuggerProperties", "debugOptions", cr2w, this);
				}
				return _debugOptions;
			}
			set
			{
				if (_debugOptions == value)
				{
					return;
				}
				_debugOptions = value;
				PropertySet(this);
			}
		}

		public Device(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
