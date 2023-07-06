using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Device : gameDeviceBase
	{
		[Ordinal(36)] 
		[RED("controller")] 
		public CHandle<ScriptableDeviceComponent> Controller
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceComponent>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceComponent>>(value);
		}

		[Ordinal(37)] 
		[RED("wasVisible")] 
		public CBool WasVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("controllerTypeName")] 
		public CName ControllerTypeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(40)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		[Ordinal(41)] 
		[RED("uiComponent")] 
		public CWeakHandle<IWorldWidgetComponent> UiComponent
		{
			get => GetPropertyValue<CWeakHandle<IWorldWidgetComponent>>();
			set => SetPropertyValue<CWeakHandle<IWorldWidgetComponent>>(value);
		}

		[Ordinal(42)] 
		[RED("screenDefinition")] 
		public SUIScreenDefinition ScreenDefinition
		{
			get => GetPropertyValue<SUIScreenDefinition>();
			set => SetPropertyValue<SUIScreenDefinition>(value);
		}

		[Ordinal(43)] 
		[RED("isUIdirty")] 
		public CBool IsUIdirty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("personalLinkComponent")] 
		public CHandle<workWorkspotResourceComponent> PersonalLinkComponent
		{
			get => GetPropertyValue<CHandle<workWorkspotResourceComponent>>();
			set => SetPropertyValue<CHandle<workWorkspotResourceComponent>>(value);
		}

		[Ordinal(45)] 
		[RED("durabilityType")] 
		public CEnum<EDeviceDurabilityType> DurabilityType
		{
			get => GetPropertyValue<CEnum<EDeviceDurabilityType>>();
			set => SetPropertyValue<CEnum<EDeviceDurabilityType>>(value);
		}

		[Ordinal(46)] 
		[RED("disassemblableComponent")] 
		public CHandle<DisassemblableComponent> DisassemblableComponent
		{
			get => GetPropertyValue<CHandle<DisassemblableComponent>>();
			set => SetPropertyValue<CHandle<DisassemblableComponent>>(value);
		}

		[Ordinal(47)] 
		[RED("localization")] 
		public CHandle<entLocalizationStringComponent> Localization
		{
			get => GetPropertyValue<CHandle<entLocalizationStringComponent>>();
			set => SetPropertyValue<CHandle<entLocalizationStringComponent>>(value);
		}

		[Ordinal(48)] 
		[RED("IKslotComponent")] 
		public CHandle<entSlotComponent> IKslotComponent
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(49)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(50)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("isInsideLogicArea")] 
		public CBool IsInsideLogicArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("cameraComponent")] 
		public CHandle<gameCameraComponent> CameraComponent
		{
			get => GetPropertyValue<CHandle<gameCameraComponent>>();
			set => SetPropertyValue<CHandle<gameCameraComponent>>(value);
		}

		[Ordinal(53)] 
		[RED("cameraZoomComponent")] 
		public CHandle<gameCameraComponent> CameraZoomComponent
		{
			get => GetPropertyValue<CHandle<gameCameraComponent>>();
			set => SetPropertyValue<CHandle<gameCameraComponent>>(value);
		}

		[Ordinal(54)] 
		[RED("cameraZoomActive")] 
		public CBool CameraZoomActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("ToggleZoomInteractionWorkspot")] 
		public CHandle<workWorkspotResourceComponent> ToggleZoomInteractionWorkspot
		{
			get => GetPropertyValue<CHandle<workWorkspotResourceComponent>>();
			set => SetPropertyValue<CHandle<workWorkspotResourceComponent>>(value);
		}

		[Ordinal(56)] 
		[RED("ZoomUIListenerID")] 
		public CHandle<redCallbackObject> ZoomUIListenerID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(57)] 
		[RED("ZoomStateMachineListenerID")] 
		public CHandle<redCallbackObject> ZoomStateMachineListenerID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(58)] 
		[RED("advanceInteractionStateResolveDelayID")] 
		public gameDelayID AdvanceInteractionStateResolveDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(59)] 
		[RED("activeStatusEffect")] 
		public TweakDBID ActiveStatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(60)] 
		[RED("activeProgramToUploadOnNPC")] 
		public TweakDBID ActiveProgramToUploadOnNPC
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(61)] 
		[RED("isQhackUploadInProgerss")] 
		public CBool IsQhackUploadInProgerss
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("scanningTweakDBRecord")] 
		public TweakDBID ScanningTweakDBRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(63)] 
		[RED("updateRunning")] 
		public CBool UpdateRunning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("updateID")] 
		public gameDelayID UpdateID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(65)] 
		[RED("delayedUpdateDeviceStateID")] 
		public gameDelayID DelayedUpdateDeviceStateID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(66)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		[Ordinal(67)] 
		[RED("currentPlayerTargetCallbackID")] 
		public CHandle<redCallbackObject> CurrentPlayerTargetCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(68)] 
		[RED("wasLookedAtLast")] 
		public CBool WasLookedAtLast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(69)] 
		[RED("lastPingSourceID")] 
		public entEntityID LastPingSourceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(70)] 
		[RED("networkGridBeamFX")] 
		public gameFxResource NetworkGridBeamFX
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(71)] 
		[RED("fxResourceMapper")] 
		public CHandle<FxResourceMapperComponent> FxResourceMapper
		{
			get => GetPropertyValue<CHandle<FxResourceMapperComponent>>();
			set => SetPropertyValue<CHandle<FxResourceMapperComponent>>(value);
		}

		[Ordinal(72)] 
		[RED("effectVisualization")] 
		public CHandle<AreaEffectVisualizationComponent> EffectVisualization
		{
			get => GetPropertyValue<CHandle<AreaEffectVisualizationComponent>>();
			set => SetPropertyValue<CHandle<AreaEffectVisualizationComponent>>(value);
		}

		[Ordinal(73)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetPropertyValue<CHandle<ResourceLibraryComponent>>();
			set => SetPropertyValue<CHandle<ResourceLibraryComponent>>(value);
		}

		[Ordinal(74)] 
		[RED("gameplayRoleComponent")] 
		public CHandle<GameplayRoleComponent> GameplayRoleComponent
		{
			get => GetPropertyValue<CHandle<GameplayRoleComponent>>();
			set => SetPropertyValue<CHandle<GameplayRoleComponent>>(value);
		}

		[Ordinal(75)] 
		[RED("personalLinkHackSend")] 
		public CBool PersonalLinkHackSend
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(76)] 
		[RED("personalLinkFailsafeID")] 
		public gameDelayID PersonalLinkFailsafeID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(77)] 
		[RED("wasAnimationFastForwarded")] 
		public CBool WasAnimationFastForwarded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(78)] 
		[RED("contentScale")] 
		public TweakDBID ContentScale
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(79)] 
		[RED("networkGridBeamOffset")] 
		public Vector4 NetworkGridBeamOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(80)] 
		[RED("areaEffectsData")] 
		public CArray<SAreaEffectData> AreaEffectsData
		{
			get => GetPropertyValue<CArray<SAreaEffectData>>();
			set => SetPropertyValue<CArray<SAreaEffectData>>(value);
		}

		[Ordinal(81)] 
		[RED("areaEffectsInFocusMode")] 
		public CArray<SAreaEffectTargetData> AreaEffectsInFocusMode
		{
			get => GetPropertyValue<CArray<SAreaEffectTargetData>>();
			set => SetPropertyValue<CArray<SAreaEffectTargetData>>(value);
		}

		[Ordinal(82)] 
		[RED("debugOptions")] 
		public DebuggerProperties DebugOptions
		{
			get => GetPropertyValue<DebuggerProperties>();
			set => SetPropertyValue<DebuggerProperties>(value);
		}

		[Ordinal(83)] 
		[RED("workspotActivator")] 
		public CWeakHandle<gameObject> WorkspotActivator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public Device()
		{
			ControllerTypeName = "ScriptableDeviceComponent";
			ScreenDefinition = new SUIScreenDefinition();
			IsUIdirty = true;
			AdvanceInteractionStateResolveDelayID = new gameDelayID();
			UpdateID = new gameDelayID();
			DelayedUpdateDeviceStateID = new gameDelayID();
			LastPingSourceID = new entEntityID();
			NetworkGridBeamFX = new gameFxResource();
			PersonalLinkFailsafeID = new gameDelayID();
			NetworkGridBeamOffset = new Vector4();
			AreaEffectsData = new();
			AreaEffectsInFocusMode = new();
			DebugOptions = new DebuggerProperties { LayerIDs = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
