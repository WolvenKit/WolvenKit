using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Device : gameDeviceBase
	{
		private CHandle<ScriptableDC> _controller;
		private CBool _wasVisible;
		private CBool _isVisible;
		private CName _controllerTypeName;
		private CEnum<EDeviceStatus> _deviceState;
		private CWeakHandle<IWorldWidgetComponent> _uiComponent;
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
		private CBool _isInsideLogicArea;
		private CHandle<gameCameraComponent> _cameraComponent;
		private CHandle<redCallbackObject> _zoomUIListenerID;
		private CHandle<redCallbackObject> _zoomStateMachineListenerID;
		private TweakDBID _activeStatusEffect;
		private TweakDBID _activeProgramToUploadOnNPC;
		private CBool _isQhackUploadInProgerss;
		private TweakDBID _scanningTweakDBRecord;
		private CBool _updateRunning;
		private gameDelayID _updateID;
		private gameDelayID _delayedUpdateDeviceStateID;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<redCallbackObject> _currentPlayerTargetCallbackID;
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
		private CWeakHandle<gameObject> _workspotActivator;

		[Ordinal(41)] 
		[RED("controller")] 
		public CHandle<ScriptableDC> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(42)] 
		[RED("wasVisible")] 
		public CBool WasVisible
		{
			get => GetProperty(ref _wasVisible);
			set => SetProperty(ref _wasVisible, value);
		}

		[Ordinal(43)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}

		[Ordinal(44)] 
		[RED("controllerTypeName")] 
		public CName ControllerTypeName
		{
			get => GetProperty(ref _controllerTypeName);
			set => SetProperty(ref _controllerTypeName, value);
		}

		[Ordinal(45)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get => GetProperty(ref _deviceState);
			set => SetProperty(ref _deviceState, value);
		}

		[Ordinal(46)] 
		[RED("uiComponent")] 
		public CWeakHandle<IWorldWidgetComponent> UiComponent
		{
			get => GetProperty(ref _uiComponent);
			set => SetProperty(ref _uiComponent, value);
		}

		[Ordinal(47)] 
		[RED("screenDefinition")] 
		public SUIScreenDefinition ScreenDefinition
		{
			get => GetProperty(ref _screenDefinition);
			set => SetProperty(ref _screenDefinition, value);
		}

		[Ordinal(48)] 
		[RED("isUIdirty")] 
		public CBool IsUIdirty
		{
			get => GetProperty(ref _isUIdirty);
			set => SetProperty(ref _isUIdirty, value);
		}

		[Ordinal(49)] 
		[RED("personalLinkComponent")] 
		public CHandle<workWorkspotResourceComponent> PersonalLinkComponent
		{
			get => GetProperty(ref _personalLinkComponent);
			set => SetProperty(ref _personalLinkComponent, value);
		}

		[Ordinal(50)] 
		[RED("durabilityType")] 
		public CEnum<EDeviceDurabilityType> DurabilityType
		{
			get => GetProperty(ref _durabilityType);
			set => SetProperty(ref _durabilityType, value);
		}

		[Ordinal(51)] 
		[RED("disassemblableComponent")] 
		public CHandle<DisassemblableComponent> DisassemblableComponent
		{
			get => GetProperty(ref _disassemblableComponent);
			set => SetProperty(ref _disassemblableComponent, value);
		}

		[Ordinal(52)] 
		[RED("localization")] 
		public CHandle<entLocalizationStringComponent> Localization
		{
			get => GetProperty(ref _localization);
			set => SetProperty(ref _localization, value);
		}

		[Ordinal(53)] 
		[RED("IKslotComponent")] 
		public CHandle<entSlotComponent> IKslotComponent
		{
			get => GetProperty(ref _iKslotComponent);
			set => SetProperty(ref _iKslotComponent, value);
		}

		[Ordinal(54)] 
		[RED("ToggleZoomInteractionWorkspot")] 
		public CHandle<workWorkspotResourceComponent> ToggleZoomInteractionWorkspot
		{
			get => GetProperty(ref _toggleZoomInteractionWorkspot);
			set => SetProperty(ref _toggleZoomInteractionWorkspot, value);
		}

		[Ordinal(55)] 
		[RED("cameraZoomComponent")] 
		public CHandle<gameCameraComponent> CameraZoomComponent
		{
			get => GetProperty(ref _cameraZoomComponent);
			set => SetProperty(ref _cameraZoomComponent, value);
		}

		[Ordinal(56)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetProperty(ref _slotComponent);
			set => SetProperty(ref _slotComponent, value);
		}

		[Ordinal(57)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(58)] 
		[RED("isInsideLogicArea")] 
		public CBool IsInsideLogicArea
		{
			get => GetProperty(ref _isInsideLogicArea);
			set => SetProperty(ref _isInsideLogicArea, value);
		}

		[Ordinal(59)] 
		[RED("cameraComponent")] 
		public CHandle<gameCameraComponent> CameraComponent
		{
			get => GetProperty(ref _cameraComponent);
			set => SetProperty(ref _cameraComponent, value);
		}

		[Ordinal(60)] 
		[RED("ZoomUIListenerID")] 
		public CHandle<redCallbackObject> ZoomUIListenerID
		{
			get => GetProperty(ref _zoomUIListenerID);
			set => SetProperty(ref _zoomUIListenerID, value);
		}

		[Ordinal(61)] 
		[RED("ZoomStateMachineListenerID")] 
		public CHandle<redCallbackObject> ZoomStateMachineListenerID
		{
			get => GetProperty(ref _zoomStateMachineListenerID);
			set => SetProperty(ref _zoomStateMachineListenerID, value);
		}

		[Ordinal(62)] 
		[RED("activeStatusEffect")] 
		public TweakDBID ActiveStatusEffect
		{
			get => GetProperty(ref _activeStatusEffect);
			set => SetProperty(ref _activeStatusEffect, value);
		}

		[Ordinal(63)] 
		[RED("activeProgramToUploadOnNPC")] 
		public TweakDBID ActiveProgramToUploadOnNPC
		{
			get => GetProperty(ref _activeProgramToUploadOnNPC);
			set => SetProperty(ref _activeProgramToUploadOnNPC, value);
		}

		[Ordinal(64)] 
		[RED("isQhackUploadInProgerss")] 
		public CBool IsQhackUploadInProgerss
		{
			get => GetProperty(ref _isQhackUploadInProgerss);
			set => SetProperty(ref _isQhackUploadInProgerss, value);
		}

		[Ordinal(65)] 
		[RED("scanningTweakDBRecord")] 
		public TweakDBID ScanningTweakDBRecord
		{
			get => GetProperty(ref _scanningTweakDBRecord);
			set => SetProperty(ref _scanningTweakDBRecord, value);
		}

		[Ordinal(66)] 
		[RED("updateRunning")] 
		public CBool UpdateRunning
		{
			get => GetProperty(ref _updateRunning);
			set => SetProperty(ref _updateRunning, value);
		}

		[Ordinal(67)] 
		[RED("updateID")] 
		public gameDelayID UpdateID
		{
			get => GetProperty(ref _updateID);
			set => SetProperty(ref _updateID, value);
		}

		[Ordinal(68)] 
		[RED("delayedUpdateDeviceStateID")] 
		public gameDelayID DelayedUpdateDeviceStateID
		{
			get => GetProperty(ref _delayedUpdateDeviceStateID);
			set => SetProperty(ref _delayedUpdateDeviceStateID, value);
		}

		[Ordinal(69)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(70)] 
		[RED("currentPlayerTargetCallbackID")] 
		public CHandle<redCallbackObject> CurrentPlayerTargetCallbackID
		{
			get => GetProperty(ref _currentPlayerTargetCallbackID);
			set => SetProperty(ref _currentPlayerTargetCallbackID, value);
		}

		[Ordinal(71)] 
		[RED("wasLookedAtLast")] 
		public CBool WasLookedAtLast
		{
			get => GetProperty(ref _wasLookedAtLast);
			set => SetProperty(ref _wasLookedAtLast, value);
		}

		[Ordinal(72)] 
		[RED("lastPingSourceID")] 
		public entEntityID LastPingSourceID
		{
			get => GetProperty(ref _lastPingSourceID);
			set => SetProperty(ref _lastPingSourceID, value);
		}

		[Ordinal(73)] 
		[RED("networkGridBeamFX")] 
		public gameFxResource NetworkGridBeamFX
		{
			get => GetProperty(ref _networkGridBeamFX);
			set => SetProperty(ref _networkGridBeamFX, value);
		}

		[Ordinal(74)] 
		[RED("fxResourceMapper")] 
		public CHandle<FxResourceMapperComponent> FxResourceMapper
		{
			get => GetProperty(ref _fxResourceMapper);
			set => SetProperty(ref _fxResourceMapper, value);
		}

		[Ordinal(75)] 
		[RED("effectVisualization")] 
		public CHandle<AreaEffectVisualizationComponent> EffectVisualization
		{
			get => GetProperty(ref _effectVisualization);
			set => SetProperty(ref _effectVisualization, value);
		}

		[Ordinal(76)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetProperty(ref _resourceLibraryComponent);
			set => SetProperty(ref _resourceLibraryComponent, value);
		}

		[Ordinal(77)] 
		[RED("gameplayRoleComponent")] 
		public CHandle<GameplayRoleComponent> GameplayRoleComponent
		{
			get => GetProperty(ref _gameplayRoleComponent);
			set => SetProperty(ref _gameplayRoleComponent, value);
		}

		[Ordinal(78)] 
		[RED("personalLinkHackSend")] 
		public CBool PersonalLinkHackSend
		{
			get => GetProperty(ref _personalLinkHackSend);
			set => SetProperty(ref _personalLinkHackSend, value);
		}

		[Ordinal(79)] 
		[RED("personalLinkFailsafeID")] 
		public gameDelayID PersonalLinkFailsafeID
		{
			get => GetProperty(ref _personalLinkFailsafeID);
			set => SetProperty(ref _personalLinkFailsafeID, value);
		}

		[Ordinal(80)] 
		[RED("wasAnimationFastForwarded")] 
		public CBool WasAnimationFastForwarded
		{
			get => GetProperty(ref _wasAnimationFastForwarded);
			set => SetProperty(ref _wasAnimationFastForwarded, value);
		}

		[Ordinal(81)] 
		[RED("contentScale")] 
		public TweakDBID ContentScale
		{
			get => GetProperty(ref _contentScale);
			set => SetProperty(ref _contentScale, value);
		}

		[Ordinal(82)] 
		[RED("networkGridBeamOffset")] 
		public Vector4 NetworkGridBeamOffset
		{
			get => GetProperty(ref _networkGridBeamOffset);
			set => SetProperty(ref _networkGridBeamOffset, value);
		}

		[Ordinal(83)] 
		[RED("areaEffectsData")] 
		public CArray<SAreaEffectData> AreaEffectsData
		{
			get => GetProperty(ref _areaEffectsData);
			set => SetProperty(ref _areaEffectsData, value);
		}

		[Ordinal(84)] 
		[RED("areaEffectsInFocusMode")] 
		public CArray<SAreaEffectTargetData> AreaEffectsInFocusMode
		{
			get => GetProperty(ref _areaEffectsInFocusMode);
			set => SetProperty(ref _areaEffectsInFocusMode, value);
		}

		[Ordinal(85)] 
		[RED("debugOptions")] 
		public DebuggerProperties DebugOptions
		{
			get => GetProperty(ref _debugOptions);
			set => SetProperty(ref _debugOptions, value);
		}

		[Ordinal(86)] 
		[RED("workspotActivator")] 
		public CWeakHandle<gameObject> WorkspotActivator
		{
			get => GetProperty(ref _workspotActivator);
			set => SetProperty(ref _workspotActivator, value);
		}
	}
}
