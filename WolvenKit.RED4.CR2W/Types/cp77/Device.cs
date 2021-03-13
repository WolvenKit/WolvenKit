using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Device : gameDeviceBase
	{
		[Ordinal(40)] [RED("controller")] public CHandle<ScriptableDC> Controller { get; set; }
		[Ordinal(41)] [RED("wasVisible")] public CBool WasVisible { get; set; }
		[Ordinal(42)] [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(43)] [RED("controllerTypeName")] public CName ControllerTypeName { get; set; }
		[Ordinal(44)] [RED("deviceState")] public CEnum<EDeviceStatus> DeviceState { get; set; }
		[Ordinal(45)] [RED("uiComponent")] public wCHandle<IWorldWidgetComponent> UiComponent { get; set; }
		[Ordinal(46)] [RED("screenDefinition")] public SUIScreenDefinition ScreenDefinition { get; set; }
		[Ordinal(47)] [RED("isUIdirty")] public CBool IsUIdirty { get; set; }
		[Ordinal(48)] [RED("personalLinkComponent")] public CHandle<workWorkspotResourceComponent> PersonalLinkComponent { get; set; }
		[Ordinal(49)] [RED("durabilityType")] public CEnum<EDeviceDurabilityType> DurabilityType { get; set; }
		[Ordinal(50)] [RED("disassemblableComponent")] public CHandle<DisassemblableComponent> DisassemblableComponent { get; set; }
		[Ordinal(51)] [RED("localization")] public CHandle<entLocalizationStringComponent> Localization { get; set; }
		[Ordinal(52)] [RED("IKslotComponent")] public CHandle<entSlotComponent> IKslotComponent { get; set; }
		[Ordinal(53)] [RED("ToggleZoomInteractionWorkspot")] public CHandle<workWorkspotResourceComponent> ToggleZoomInteractionWorkspot { get; set; }
		[Ordinal(54)] [RED("cameraZoomComponent")] public CHandle<gameCameraComponent> CameraZoomComponent { get; set; }
		[Ordinal(55)] [RED("slotComponent")] public CHandle<entSlotComponent> SlotComponent { get; set; }
		[Ordinal(56)] [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(57)] [RED("isLogicready")] public CBool IsLogicready { get; set; }
		[Ordinal(58)] [RED("isInsideLogicArea")] public CBool IsInsideLogicArea { get; set; }
		[Ordinal(59)] [RED("cameraComponent")] public CHandle<gameCameraComponent> CameraComponent { get; set; }
		[Ordinal(60)] [RED("ZoomUIListenerID")] public CUInt32 ZoomUIListenerID { get; set; }
		[Ordinal(61)] [RED("ZoomStateMachineListenerID")] public CUInt32 ZoomStateMachineListenerID { get; set; }
		[Ordinal(62)] [RED("activeStatusEffect")] public TweakDBID ActiveStatusEffect { get; set; }
		[Ordinal(63)] [RED("activeProgramToUploadOnNPC")] public TweakDBID ActiveProgramToUploadOnNPC { get; set; }
		[Ordinal(64)] [RED("isQhackUploadInProgerss")] public CBool IsQhackUploadInProgerss { get; set; }
		[Ordinal(65)] [RED("scanningTweakDBRecord")] public TweakDBID ScanningTweakDBRecord { get; set; }
		[Ordinal(66)] [RED("updateRunning")] public CBool UpdateRunning { get; set; }
		[Ordinal(67)] [RED("updateID")] public gameDelayID UpdateID { get; set; }
		[Ordinal(68)] [RED("delayedUpdateDeviceStateID")] public gameDelayID DelayedUpdateDeviceStateID { get; set; }
		[Ordinal(69)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(70)] [RED("currentPlayerTargetCallbackID")] public CUInt32 CurrentPlayerTargetCallbackID { get; set; }
		[Ordinal(71)] [RED("wasLookedAtLast")] public CBool WasLookedAtLast { get; set; }
		[Ordinal(72)] [RED("lastPingSourceID")] public entEntityID LastPingSourceID { get; set; }
		[Ordinal(73)] [RED("networkGridBeamFX")] public gameFxResource NetworkGridBeamFX { get; set; }
		[Ordinal(74)] [RED("fxResourceMapper")] public CHandle<FxResourceMapperComponent> FxResourceMapper { get; set; }
		[Ordinal(75)] [RED("effectVisualization")] public CHandle<AreaEffectVisualizationComponent> EffectVisualization { get; set; }
		[Ordinal(76)] [RED("resourceLibraryComponent")] public CHandle<ResourceLibraryComponent> ResourceLibraryComponent { get; set; }
		[Ordinal(77)] [RED("gameplayRoleComponent")] public CHandle<GameplayRoleComponent> GameplayRoleComponent { get; set; }
		[Ordinal(78)] [RED("personalLinkHackSend")] public CBool PersonalLinkHackSend { get; set; }
		[Ordinal(79)] [RED("personalLinkFailsafeID")] public gameDelayID PersonalLinkFailsafeID { get; set; }
		[Ordinal(80)] [RED("wasAnimationFastForwarded")] public CBool WasAnimationFastForwarded { get; set; }
		[Ordinal(81)] [RED("contentScale")] public TweakDBID ContentScale { get; set; }
		[Ordinal(82)] [RED("networkGridBeamOffset")] public Vector4 NetworkGridBeamOffset { get; set; }
		[Ordinal(83)] [RED("areaEffectsData")] public CArray<SAreaEffectData> AreaEffectsData { get; set; }
		[Ordinal(84)] [RED("areaEffectsInFocusMode")] public CArray<SAreaEffectTargetData> AreaEffectsInFocusMode { get; set; }
		[Ordinal(85)] [RED("debugOptions")] public DebuggerProperties DebugOptions { get; set; }

		public Device(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
