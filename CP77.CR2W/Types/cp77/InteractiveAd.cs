using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractiveAd : InteractiveDevice
	{
		[Ordinal(0)]  [RED("e3HighlightHackStarted")] public CBool E3HighlightHackStarted { get; set; }
		[Ordinal(1)]  [RED("e3ObjectRevealed")] public CBool E3ObjectRevealed { get; set; }
		[Ordinal(2)]  [RED("debugOptions")] public DebuggerProperties DebugOptions { get; set; }
		[Ordinal(3)]  [RED("forceRegisterInHudManager")] public CBool ForceRegisterInHudManager { get; set; }
		[Ordinal(4)]  [RED("prereqListeners")] public CArray<CHandle<GameObjectListener>> PrereqListeners { get; set; }
		[Ordinal(5)]  [RED("statusEffectListeners")] public CArray<CHandle<StatusEffectTriggerListener>> StatusEffectListeners { get; set; }
		[Ordinal(6)]  [RED("outlineRequestsManager")] public CHandle<OutlineRequestManager> OutlineRequestsManager { get; set; }
		[Ordinal(7)]  [RED("outlineFadeCounter")] public CInt32 OutlineFadeCounter { get; set; }
		[Ordinal(8)]  [RED("fadeOutStarted")] public CBool FadeOutStarted { get; set; }
		[Ordinal(9)]  [RED("lastEngineTime")] public CFloat LastEngineTime { get; set; }
		[Ordinal(10)]  [RED("accumulatedTimePasssed")] public CFloat AccumulatedTimePasssed { get; set; }
		[Ordinal(11)]  [RED("scanningComponent")] public CHandle<gameScanningComponent> ScanningComponent { get; set; }
		[Ordinal(12)]  [RED("visionComponent")] public CHandle<gameVisionModeComponent> VisionComponent { get; set; }
		[Ordinal(13)]  [RED("isHighlightedInFocusMode")] public CBool IsHighlightedInFocusMode { get; set; }
		[Ordinal(14)]  [RED("statusEffectComponent")] public CHandle<gameStatusEffectComponent> StatusEffectComponent { get; set; }
		[Ordinal(15)]  [RED("lastFrameGreen")] public CHandle<OutlineRequest> LastFrameGreen { get; set; }
		[Ordinal(16)]  [RED("lastFrameRed")] public CHandle<OutlineRequest> LastFrameRed { get; set; }
		[Ordinal(17)]  [RED("markAsQuest")] public CBool MarkAsQuest { get; set; }
		[Ordinal(18)]  [RED("forceHighlightSource")] public entEntityID ForceHighlightSource { get; set; }
		[Ordinal(19)]  [RED("workspotMapper")] public CHandle<WorkspotMapperComponent> WorkspotMapper { get; set; }
		[Ordinal(20)]  [RED("stimBroadcaster")] public CHandle<StimBroadcasterComponent> StimBroadcaster { get; set; }
		[Ordinal(21)]  [RED("uiSlotComponent")] public CHandle<entSlotComponent> UiSlotComponent { get; set; }
		[Ordinal(22)]  [RED("squadMemberComponent")] public CHandle<SquadMemberBaseComponent> SquadMemberComponent { get; set; }
		[Ordinal(23)]  [RED("sourceShootComponent")] public CHandle<gameSourceShootComponent> SourceShootComponent { get; set; }
		[Ordinal(24)]  [RED("targetShootComponent")] public CHandle<gameTargetShootComponent> TargetShootComponent { get; set; }
		[Ordinal(25)]  [RED("receivedDamageHistory")] public CArray<DamageHistoryEntry> ReceivedDamageHistory { get; set; }
		[Ordinal(26)]  [RED("forceDefeatReward")] public CBool ForceDefeatReward { get; set; }
		[Ordinal(27)]  [RED("killRewardDisabled")] public CBool KillRewardDisabled { get; set; }
		[Ordinal(28)]  [RED("willDieSoon")] public CBool WillDieSoon { get; set; }
		[Ordinal(29)]  [RED("isScannerDataDirty")] public CBool IsScannerDataDirty { get; set; }
		[Ordinal(30)]  [RED("hasVisibilityForcedInAnimSystem")] public CBool HasVisibilityForcedInAnimSystem { get; set; }
		[Ordinal(31)]  [RED("isDead")] public CBool IsDead { get; set; }
		[Ordinal(32)]  [RED("controller")] public CHandle<ScriptableDC> Controller { get; set; }
		[Ordinal(33)]  [RED("wasVisible")] public CBool WasVisible { get; set; }
		[Ordinal(34)]  [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(35)]  [RED("controllerTypeName")] public CName ControllerTypeName { get; set; }
		[Ordinal(36)]  [RED("deviceState")] public CEnum<EDeviceStatus> DeviceState { get; set; }
		[Ordinal(37)]  [RED("uiComponent")] public wCHandle<IWorldWidgetComponent> UiComponent { get; set; }
		[Ordinal(38)]  [RED("screenDefinition")] public SUIScreenDefinition ScreenDefinition { get; set; }
		[Ordinal(39)]  [RED("isUIdirty")] public CBool IsUIdirty { get; set; }
		[Ordinal(40)]  [RED("personalLinkComponent")] public CHandle<workWorkspotResourceComponent> PersonalLinkComponent { get; set; }
		[Ordinal(41)]  [RED("durabilityType")] public CEnum<EDeviceDurabilityType> DurabilityType { get; set; }
		[Ordinal(42)]  [RED("disassemblableComponent")] public CHandle<DisassemblableComponent> DisassemblableComponent { get; set; }
		[Ordinal(43)]  [RED("localization")] public CHandle<entLocalizationStringComponent> Localization { get; set; }
		[Ordinal(44)]  [RED("IKslotComponent")] public CHandle<entSlotComponent> IKslotComponent { get; set; }
		[Ordinal(45)]  [RED("ToggleZoomInteractionWorkspot")] public CHandle<workWorkspotResourceComponent> ToggleZoomInteractionWorkspot { get; set; }
		[Ordinal(46)]  [RED("cameraZoomComponent")] public CHandle<gameCameraComponent> CameraZoomComponent { get; set; }
		[Ordinal(47)]  [RED("slotComponent")] public CHandle<entSlotComponent> SlotComponent { get; set; }
		[Ordinal(48)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(49)]  [RED("isLogicready")] public CBool IsLogicready { get; set; }
		[Ordinal(50)]  [RED("isInsideLogicArea")] public CBool IsInsideLogicArea { get; set; }
		[Ordinal(51)]  [RED("cameraComponent")] public CHandle<gameCameraComponent> CameraComponent { get; set; }
		[Ordinal(52)]  [RED("ZoomUIListenerID")] public CUInt32 ZoomUIListenerID { get; set; }
		[Ordinal(53)]  [RED("ZoomStateMachineListenerID")] public CUInt32 ZoomStateMachineListenerID { get; set; }
		[Ordinal(54)]  [RED("activeStatusEffect")] public TweakDBID ActiveStatusEffect { get; set; }
		[Ordinal(55)]  [RED("activeProgramToUploadOnNPC")] public TweakDBID ActiveProgramToUploadOnNPC { get; set; }
		[Ordinal(56)]  [RED("isQhackUploadInProgerss")] public CBool IsQhackUploadInProgerss { get; set; }
		[Ordinal(57)]  [RED("scanningTweakDBRecord")] public TweakDBID ScanningTweakDBRecord { get; set; }
		[Ordinal(58)]  [RED("updateRunning")] public CBool UpdateRunning { get; set; }
		[Ordinal(59)]  [RED("updateID")] public gameDelayID UpdateID { get; set; }
		[Ordinal(60)]  [RED("delayedUpdateDeviceStateID")] public gameDelayID DelayedUpdateDeviceStateID { get; set; }
		[Ordinal(61)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(62)]  [RED("currentPlayerTargetCallbackID")] public CUInt32 CurrentPlayerTargetCallbackID { get; set; }
		[Ordinal(63)]  [RED("wasLookedAtLast")] public CBool WasLookedAtLast { get; set; }
		[Ordinal(64)]  [RED("lastPingSourceID")] public entEntityID LastPingSourceID { get; set; }
		[Ordinal(65)]  [RED("networkGridBeamFX")] public gameFxResource NetworkGridBeamFX { get; set; }
		[Ordinal(66)]  [RED("fxResourceMapper")] public CHandle<FxResourceMapperComponent> FxResourceMapper { get; set; }
		[Ordinal(67)]  [RED("effectVisualization")] public CHandle<AreaEffectVisualizationComponent> EffectVisualization { get; set; }
		[Ordinal(68)]  [RED("resourceLibraryComponent")] public CHandle<ResourceLibraryComponent> ResourceLibraryComponent { get; set; }
		[Ordinal(69)]  [RED("gameplayRoleComponent")] public CHandle<GameplayRoleComponent> GameplayRoleComponent { get; set; }
		[Ordinal(70)]  [RED("personalLinkHackSend")] public CBool PersonalLinkHackSend { get; set; }
		[Ordinal(71)]  [RED("personalLinkFailsafeID")] public gameDelayID PersonalLinkFailsafeID { get; set; }
		[Ordinal(72)]  [RED("wasAnimationFastForwarded")] public CBool WasAnimationFastForwarded { get; set; }
		[Ordinal(73)]  [RED("contentScale")] public TweakDBID ContentScale { get; set; }
		[Ordinal(74)]  [RED("networkGridBeamOffset")] public Vector4 NetworkGridBeamOffset { get; set; }
		[Ordinal(75)]  [RED("areaEffectsData")] public CArray<SAreaEffectData> AreaEffectsData { get; set; }
		[Ordinal(76)]  [RED("areaEffectsInFocusMode")] public CArray<SAreaEffectTargetData> AreaEffectsInFocusMode { get; set; }
		[Ordinal(77)]  [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(78)]  [RED("interactionIndicator")] public CHandle<gameLightComponent> InteractionIndicator { get; set; }
		[Ordinal(79)]  [RED("disableAreaIndicatorID")] public gameDelayID DisableAreaIndicatorID { get; set; }
		[Ordinal(80)]  [RED("delayedUIRefreshID")] public gameDelayID DelayedUIRefreshID { get; set; }
		[Ordinal(81)]  [RED("isPlayerAround")] public CBool IsPlayerAround { get; set; }
		[Ordinal(82)]  [RED("disableAreaIndicatorDelayActive")] public CBool DisableAreaIndicatorDelayActive { get; set; }
		[Ordinal(83)]  [RED("objectActionsCallbackCtrl")] public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl { get; set; }
		[Ordinal(84)]  [RED("triggerComponent")] public CHandle<gameStaticTriggerAreaComponent> TriggerComponent { get; set; }
		[Ordinal(85)]  [RED("triggerExitComponent")] public CHandle<gameStaticTriggerAreaComponent> TriggerExitComponent { get; set; }
		[Ordinal(86)]  [RED("aduiComponent")] public CHandle<WorldWidgetComponent> AduiComponent { get; set; }
		[Ordinal(87)]  [RED("showAd")] public CBool ShowAd { get; set; }
		[Ordinal(88)]  [RED("showVendor")] public CBool ShowVendor { get; set; }

		public InteractiveAd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
