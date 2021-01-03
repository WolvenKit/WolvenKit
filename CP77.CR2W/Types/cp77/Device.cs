using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Device : gameDeviceBase
	{
		[Ordinal(0)]  [RED("IKslotComponent")] public CHandle<entSlotComponent> IKslotComponent { get; set; }
		[Ordinal(1)]  [RED("ToggleZoomInteractionWorkspot")] public CHandle<workWorkspotResourceComponent> ToggleZoomInteractionWorkspot { get; set; }
		[Ordinal(2)]  [RED("ZoomStateMachineListenerID")] public CUInt32 ZoomStateMachineListenerID { get; set; }
		[Ordinal(3)]  [RED("ZoomUIListenerID")] public CUInt32 ZoomUIListenerID { get; set; }
		[Ordinal(4)]  [RED("activeProgramToUploadOnNPC")] public TweakDBID ActiveProgramToUploadOnNPC { get; set; }
		[Ordinal(5)]  [RED("activeStatusEffect")] public TweakDBID ActiveStatusEffect { get; set; }
		[Ordinal(6)]  [RED("areaEffectsData")] public CArray<SAreaEffectData> AreaEffectsData { get; set; }
		[Ordinal(7)]  [RED("areaEffectsInFocusMode")] public CArray<SAreaEffectTargetData> AreaEffectsInFocusMode { get; set; }
		[Ordinal(8)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(9)]  [RED("cameraComponent")] public CHandle<gameCameraComponent> CameraComponent { get; set; }
		[Ordinal(10)]  [RED("cameraZoomComponent")] public CHandle<gameCameraComponent> CameraZoomComponent { get; set; }
		[Ordinal(11)]  [RED("contentScale")] public TweakDBID ContentScale { get; set; }
		[Ordinal(12)]  [RED("controller")] public CHandle<ScriptableDC> Controller { get; set; }
		[Ordinal(13)]  [RED("controllerTypeName")] public CName ControllerTypeName { get; set; }
		[Ordinal(14)]  [RED("currentPlayerTargetCallbackID")] public CUInt32 CurrentPlayerTargetCallbackID { get; set; }
		[Ordinal(15)]  [RED("debugOptions")] public DebuggerProperties DebugOptions { get; set; }
		[Ordinal(16)]  [RED("delayedUpdateDeviceStateID")] public gameDelayID DelayedUpdateDeviceStateID { get; set; }
		[Ordinal(17)]  [RED("deviceState")] public CEnum<EDeviceStatus> DeviceState { get; set; }
		[Ordinal(18)]  [RED("disassemblableComponent")] public CHandle<DisassemblableComponent> DisassemblableComponent { get; set; }
		[Ordinal(19)]  [RED("durabilityType")] public CEnum<EDeviceDurabilityType> DurabilityType { get; set; }
		[Ordinal(20)]  [RED("effectVisualization")] public CHandle<AreaEffectVisualizationComponent> EffectVisualization { get; set; }
		[Ordinal(21)]  [RED("fxResourceMapper")] public CHandle<FxResourceMapperComponent> FxResourceMapper { get; set; }
		[Ordinal(22)]  [RED("gameplayRoleComponent")] public CHandle<GameplayRoleComponent> GameplayRoleComponent { get; set; }
		[Ordinal(23)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(24)]  [RED("isInsideLogicArea")] public CBool IsInsideLogicArea { get; set; }
		[Ordinal(25)]  [RED("isLogicready")] public CBool IsLogicready { get; set; }
		[Ordinal(26)]  [RED("isQhackUploadInProgerss")] public CBool IsQhackUploadInProgerss { get; set; }
		[Ordinal(27)]  [RED("isUIdirty")] public CBool IsUIdirty { get; set; }
		[Ordinal(28)]  [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(29)]  [RED("lastPingSourceID")] public entEntityID LastPingSourceID { get; set; }
		[Ordinal(30)]  [RED("localization")] public CHandle<entLocalizationStringComponent> Localization { get; set; }
		[Ordinal(31)]  [RED("networkGridBeamFX")] public gameFxResource NetworkGridBeamFX { get; set; }
		[Ordinal(32)]  [RED("networkGridBeamOffset")] public Vector4 NetworkGridBeamOffset { get; set; }
		[Ordinal(33)]  [RED("personalLinkComponent")] public CHandle<workWorkspotResourceComponent> PersonalLinkComponent { get; set; }
		[Ordinal(34)]  [RED("personalLinkFailsafeID")] public gameDelayID PersonalLinkFailsafeID { get; set; }
		[Ordinal(35)]  [RED("personalLinkHackSend")] public CBool PersonalLinkHackSend { get; set; }
		[Ordinal(36)]  [RED("resourceLibraryComponent")] public CHandle<ResourceLibraryComponent> ResourceLibraryComponent { get; set; }
		[Ordinal(37)]  [RED("scanningTweakDBRecord")] public TweakDBID ScanningTweakDBRecord { get; set; }
		[Ordinal(38)]  [RED("screenDefinition")] public SUIScreenDefinition ScreenDefinition { get; set; }
		[Ordinal(39)]  [RED("slotComponent")] public CHandle<entSlotComponent> SlotComponent { get; set; }
		[Ordinal(40)]  [RED("uiComponent")] public wCHandle<IWorldWidgetComponent> UiComponent { get; set; }
		[Ordinal(41)]  [RED("updateID")] public gameDelayID UpdateID { get; set; }
		[Ordinal(42)]  [RED("updateRunning")] public CBool UpdateRunning { get; set; }
		[Ordinal(43)]  [RED("wasAnimationFastForwarded")] public CBool WasAnimationFastForwarded { get; set; }
		[Ordinal(44)]  [RED("wasLookedAtLast")] public CBool WasLookedAtLast { get; set; }
		[Ordinal(45)]  [RED("wasVisible")] public CBool WasVisible { get; set; }

		public Device(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
