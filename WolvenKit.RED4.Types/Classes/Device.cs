using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Device : gameDeviceBase
	{
		[Ordinal(41)] 
		[RED("controller")] 
		public CHandle<ScriptableDC> Controller
		{
			get => GetPropertyValue<CHandle<ScriptableDC>>();
			set => SetPropertyValue<CHandle<ScriptableDC>>(value);
		}

		[Ordinal(42)] 
		[RED("wasVisible")] 
		public CBool WasVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("controllerTypeName")] 
		public CName ControllerTypeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(45)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		[Ordinal(46)] 
		[RED("uiComponent")] 
		public CWeakHandle<IWorldWidgetComponent> UiComponent
		{
			get => GetPropertyValue<CWeakHandle<IWorldWidgetComponent>>();
			set => SetPropertyValue<CWeakHandle<IWorldWidgetComponent>>(value);
		}

		[Ordinal(47)] 
		[RED("screenDefinition")] 
		public SUIScreenDefinition ScreenDefinition
		{
			get => GetPropertyValue<SUIScreenDefinition>();
			set => SetPropertyValue<SUIScreenDefinition>(value);
		}

		[Ordinal(48)] 
		[RED("isUIdirty")] 
		public CBool IsUIdirty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("personalLinkComponent")] 
		public CHandle<workWorkspotResourceComponent> PersonalLinkComponent
		{
			get => GetPropertyValue<CHandle<workWorkspotResourceComponent>>();
			set => SetPropertyValue<CHandle<workWorkspotResourceComponent>>(value);
		}

		[Ordinal(50)] 
		[RED("durabilityType")] 
		public CEnum<EDeviceDurabilityType> DurabilityType
		{
			get => GetPropertyValue<CEnum<EDeviceDurabilityType>>();
			set => SetPropertyValue<CEnum<EDeviceDurabilityType>>(value);
		}

		[Ordinal(51)] 
		[RED("disassemblableComponent")] 
		public CHandle<DisassemblableComponent> DisassemblableComponent
		{
			get => GetPropertyValue<CHandle<DisassemblableComponent>>();
			set => SetPropertyValue<CHandle<DisassemblableComponent>>(value);
		}

		[Ordinal(52)] 
		[RED("localization")] 
		public CHandle<entLocalizationStringComponent> Localization
		{
			get => GetPropertyValue<CHandle<entLocalizationStringComponent>>();
			set => SetPropertyValue<CHandle<entLocalizationStringComponent>>(value);
		}

		[Ordinal(53)] 
		[RED("IKslotComponent")] 
		public CHandle<entSlotComponent> IKslotComponent
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(54)] 
		[RED("ToggleZoomInteractionWorkspot")] 
		public CHandle<workWorkspotResourceComponent> ToggleZoomInteractionWorkspot
		{
			get => GetPropertyValue<CHandle<workWorkspotResourceComponent>>();
			set => SetPropertyValue<CHandle<workWorkspotResourceComponent>>(value);
		}

		[Ordinal(55)] 
		[RED("cameraZoomComponent")] 
		public CHandle<gameCameraComponent> CameraZoomComponent
		{
			get => GetPropertyValue<CHandle<gameCameraComponent>>();
			set => SetPropertyValue<CHandle<gameCameraComponent>>(value);
		}

		[Ordinal(56)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(57)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("isInsideLogicArea")] 
		public CBool IsInsideLogicArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("cameraComponent")] 
		public CHandle<gameCameraComponent> CameraComponent
		{
			get => GetPropertyValue<CHandle<gameCameraComponent>>();
			set => SetPropertyValue<CHandle<gameCameraComponent>>(value);
		}

		[Ordinal(60)] 
		[RED("ZoomUIListenerID")] 
		public CHandle<redCallbackObject> ZoomUIListenerID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(61)] 
		[RED("ZoomStateMachineListenerID")] 
		public CHandle<redCallbackObject> ZoomStateMachineListenerID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(62)] 
		[RED("activeStatusEffect")] 
		public TweakDBID ActiveStatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(63)] 
		[RED("activeProgramToUploadOnNPC")] 
		public TweakDBID ActiveProgramToUploadOnNPC
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(64)] 
		[RED("isQhackUploadInProgerss")] 
		public CBool IsQhackUploadInProgerss
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("scanningTweakDBRecord")] 
		public TweakDBID ScanningTweakDBRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(66)] 
		[RED("updateRunning")] 
		public CBool UpdateRunning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("updateID")] 
		public gameDelayID UpdateID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(68)] 
		[RED("delayedUpdateDeviceStateID")] 
		public gameDelayID DelayedUpdateDeviceStateID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(69)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		[Ordinal(70)] 
		[RED("currentPlayerTargetCallbackID")] 
		public CHandle<redCallbackObject> CurrentPlayerTargetCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(71)] 
		[RED("wasLookedAtLast")] 
		public CBool WasLookedAtLast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("lastPingSourceID")] 
		public entEntityID LastPingSourceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(73)] 
		[RED("networkGridBeamFX")] 
		public gameFxResource NetworkGridBeamFX
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(74)] 
		[RED("fxResourceMapper")] 
		public CHandle<FxResourceMapperComponent> FxResourceMapper
		{
			get => GetPropertyValue<CHandle<FxResourceMapperComponent>>();
			set => SetPropertyValue<CHandle<FxResourceMapperComponent>>(value);
		}

		[Ordinal(75)] 
		[RED("effectVisualization")] 
		public CHandle<AreaEffectVisualizationComponent> EffectVisualization
		{
			get => GetPropertyValue<CHandle<AreaEffectVisualizationComponent>>();
			set => SetPropertyValue<CHandle<AreaEffectVisualizationComponent>>(value);
		}

		[Ordinal(76)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetPropertyValue<CHandle<ResourceLibraryComponent>>();
			set => SetPropertyValue<CHandle<ResourceLibraryComponent>>(value);
		}

		[Ordinal(77)] 
		[RED("gameplayRoleComponent")] 
		public CHandle<GameplayRoleComponent> GameplayRoleComponent
		{
			get => GetPropertyValue<CHandle<GameplayRoleComponent>>();
			set => SetPropertyValue<CHandle<GameplayRoleComponent>>(value);
		}

		[Ordinal(78)] 
		[RED("personalLinkHackSend")] 
		public CBool PersonalLinkHackSend
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(79)] 
		[RED("personalLinkFailsafeID")] 
		public gameDelayID PersonalLinkFailsafeID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(80)] 
		[RED("wasAnimationFastForwarded")] 
		public CBool WasAnimationFastForwarded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(81)] 
		[RED("contentScale")] 
		public TweakDBID ContentScale
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(82)] 
		[RED("networkGridBeamOffset")] 
		public Vector4 NetworkGridBeamOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(83)] 
		[RED("areaEffectsData")] 
		public CArray<SAreaEffectData> AreaEffectsData
		{
			get => GetPropertyValue<CArray<SAreaEffectData>>();
			set => SetPropertyValue<CArray<SAreaEffectData>>(value);
		}

		[Ordinal(84)] 
		[RED("areaEffectsInFocusMode")] 
		public CArray<SAreaEffectTargetData> AreaEffectsInFocusMode
		{
			get => GetPropertyValue<CArray<SAreaEffectTargetData>>();
			set => SetPropertyValue<CArray<SAreaEffectTargetData>>(value);
		}

		[Ordinal(85)] 
		[RED("debugOptions")] 
		public DebuggerProperties DebugOptions
		{
			get => GetPropertyValue<DebuggerProperties>();
			set => SetPropertyValue<DebuggerProperties>(value);
		}

		[Ordinal(86)] 
		[RED("workspotActivator")] 
		public CWeakHandle<gameObject> WorkspotActivator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public Device()
		{
			ControllerTypeName = "ScriptableDC";
			ScreenDefinition = new();
			IsUIdirty = true;
			UpdateID = new();
			DelayedUpdateDeviceStateID = new();
			LastPingSourceID = new();
			NetworkGridBeamFX = new();
			PersonalLinkFailsafeID = new();
			NetworkGridBeamOffset = new();
			AreaEffectsData = new();
			AreaEffectsInFocusMode = new();
			DebugOptions = new() { LayerIDs = new() };
		}
	}
}
