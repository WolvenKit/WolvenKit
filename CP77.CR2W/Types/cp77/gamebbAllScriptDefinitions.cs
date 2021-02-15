using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamebbAllScriptDefinitions : IScriptable
	{
		[Ordinal(0)] [RED("PlayerStateMachine")] public CHandle<PlayerStateMachineDef> PlayerStateMachine { get; set; }
		[Ordinal(1)] [RED("PlayerPerkData")] public CHandle<PlayerPerkDataDef> PlayerPerkData { get; set; }
		[Ordinal(2)] [RED("EffectSharedData")] public CHandle<EffectSharedDataDef> EffectSharedData { get; set; }
		[Ordinal(3)] [RED("FollowNPC")] public CHandle<FollowNPCDef> FollowNPC { get; set; }
		[Ordinal(4)] [RED("AISquadBlackBoard")] public CHandle<AISquadBlackBoardDef> AISquadBlackBoard { get; set; }
		[Ordinal(5)] [RED("Puppet")] public CHandle<PuppetDef> Puppet { get; set; }
		[Ordinal(6)] [RED("PuppetState")] public CHandle<PuppetStateDef> PuppetState { get; set; }
		[Ordinal(7)] [RED("PuppetReaction")] public CHandle<PuppetReactionDef> PuppetReaction { get; set; }
		[Ordinal(8)] [RED("LocalPlayer")] public CHandle<PuppetReactionDef> LocalPlayer { get; set; }
		[Ordinal(9)] [RED("UIGameData")] public CHandle<UIGameDataDef> UIGameData { get; set; }
		[Ordinal(10)] [RED("UIInteractions")] public CHandle<UIInteractionsDef> UIInteractions { get; set; }
		[Ordinal(11)] [RED("Weapon")] public CHandle<WeaponDataDef> Weapon { get; set; }
		[Ordinal(12)] [RED("DeviceTakeControl")] public CHandle<DeviceTakeControlDef> DeviceTakeControl { get; set; }
		[Ordinal(13)] [RED("TaggedObjectsList")] public CHandle<TaggedObjectsListDef> TaggedObjectsList { get; set; }
		[Ordinal(14)] [RED("AdHocAnimation")] public CHandle<AdHocAnimationDef> AdHocAnimation { get; set; }
		[Ordinal(15)] [RED("QuickMeleeData")] public CHandle<QuickMeleeDataDef> QuickMeleeData { get; set; }
		[Ordinal(16)] [RED("Vehicle")] public CHandle<VehicleDef> Vehicle { get; set; }
		[Ordinal(17)] [RED("VehicleSummonData")] public CHandle<VehicleSummonDataDef> VehicleSummonData { get; set; }
		[Ordinal(18)] [RED("SceneGameplayOverrides")] public CHandle<SceneGameplayOverridesDef> SceneGameplayOverrides { get; set; }
		[Ordinal(19)] [RED("Braindance")] public CHandle<BraindanceBlackboardDef> Braindance { get; set; }
		[Ordinal(20)] [RED("HackingMinigame")] public CHandle<HackingMinigameDef> HackingMinigame { get; set; }
		[Ordinal(21)] [RED("HackingData")] public CHandle<HackingDataDef> HackingData { get; set; }
		[Ordinal(22)] [RED("AIShooting")] public CHandle<AIShootingDataDef> AIShooting { get; set; }
		[Ordinal(23)] [RED("AICover")] public CHandle<AICoverDataDef> AICover { get; set; }
		[Ordinal(24)] [RED("AIAction")] public CHandle<AIActionDataDef> AIAction { get; set; }
		[Ordinal(25)] [RED("AIPatrol")] public CHandle<AIPatrolDef> AIPatrol { get; set; }
		[Ordinal(26)] [RED("AIAlertedPatrol")] public CHandle<AIAlertedPatrolDef> AIAlertedPatrol { get; set; }
		[Ordinal(27)] [RED("VendorRegister")] public CHandle<VendorRegisterBlackBoardDef> VendorRegister { get; set; }
		[Ordinal(28)] [RED("AIFollowSlot")] public CHandle<AIFollowSlotDef> AIFollowSlot { get; set; }
		[Ordinal(29)] [RED("AIActionBossData")] public CHandle<AIActionBossDataDef> AIActionBossData { get; set; }
		[Ordinal(30)] [RED("UI_System")] public CHandle<UI_SystemDef> UI_System { get; set; }
		[Ordinal(31)] [RED("UI_ActiveVehicleData")] public CHandle<UI_ActiveVehicleDataDef> UI_ActiveVehicleData { get; set; }
		[Ordinal(32)] [RED("UIWorldBoundaries")] public CHandle<UIWorldBoundariesDef> UIWorldBoundaries { get; set; }
		[Ordinal(33)] [RED("UI_PlayerStats")] public CHandle<UI_PlayerStatsDef> UI_PlayerStats { get; set; }
		[Ordinal(34)] [RED("UI_EquipmentData")] public CHandle<UI_EquipmentDataDef> UI_EquipmentData { get; set; }
		[Ordinal(35)] [RED("UI_PlayerBioMonitor")] public CHandle<UI_PlayerBioMonitorDef> UI_PlayerBioMonitor { get; set; }
		[Ordinal(36)] [RED("FastTRavelSystem")] public CHandle<FastTRavelSystemDef> FastTRavelSystem { get; set; }
		[Ordinal(37)] [RED("UI_ComDevice")] public CHandle<UI_ComDeviceDef> UI_ComDevice { get; set; }
		[Ordinal(38)] [RED("UI_Scanner")] public CHandle<UI_ScannerDef> UI_Scanner { get; set; }
		[Ordinal(39)] [RED("UI_ScannerModules")] public CHandle<UI_ScannerModulesDef> UI_ScannerModules { get; set; }
		[Ordinal(40)] [RED("UI_WantedBar")] public CHandle<UI_WantedBarDef> UI_WantedBar { get; set; }
		[Ordinal(41)] [RED("UI_FastForward")] public CHandle<UI_FastForwardDef> UI_FastForward { get; set; }
		[Ordinal(42)] [RED("UI_HUDProgressBar")] public CHandle<UI_HUDProgressBarDef> UI_HUDProgressBar { get; set; }
		[Ordinal(43)] [RED("UI_HUDSignalProgressBar")] public CHandle<UI_HUDSignalProgressBarDef> UI_HUDSignalProgressBar { get; set; }
		[Ordinal(44)] [RED("UI_Hotkeys")] public CHandle<UI_HotkeysDef> UI_Hotkeys { get; set; }
		[Ordinal(45)] [RED("DeviceBaseBlackboard")] public CHandle<DeviceBaseBlackboardDef> DeviceBaseBlackboard { get; set; }
		[Ordinal(46)] [RED("TVDeviceBlackboard")] public CHandle<TVDeviceBlackboardDef> TVDeviceBlackboard { get; set; }
		[Ordinal(47)] [RED("ArcadeMachineBlackBoard")] public CHandle<ArcadeMachineBlackboardDef> ArcadeMachineBlackBoard { get; set; }
		[Ordinal(48)] [RED("LcdScreenBlackBoard")] public CHandle<LcdScreenBlackBoardDef> LcdScreenBlackBoard { get; set; }
		[Ordinal(49)] [RED("NcartTimetableBlackboard")] public CHandle<NcartTimetableBlackboardDef> NcartTimetableBlackboard { get; set; }
		[Ordinal(50)] [RED("IntercomBlackboard")] public CHandle<IntercomBlackboardDef> IntercomBlackboard { get; set; }
		[Ordinal(51)] [RED("ElevatorDeviceBlackboard")] public CHandle<ElevatorDeviceBlackboardDef> ElevatorDeviceBlackboard { get; set; }
		[Ordinal(52)] [RED("VendingMachineDeviceBlackboard")] public CHandle<VendingMachineDeviceBlackboardDef> VendingMachineDeviceBlackboard { get; set; }
		[Ordinal(53)] [RED("InteractiveDeviceBlackboard")] public CHandle<InteractiveDeviceBlackboardDef> InteractiveDeviceBlackboard { get; set; }
		[Ordinal(54)] [RED("MasterDeviceBaseBlackboard")] public CHandle<MasterDeviceBaseBlackboardDef> MasterDeviceBaseBlackboard { get; set; }
		[Ordinal(55)] [RED("ComputerDeviceBlackboard")] public CHandle<ComputerDeviceBlackboardDef> ComputerDeviceBlackboard { get; set; }
		[Ordinal(56)] [RED("DataTermDeviceBlackboard")] public CHandle<DataTermDeviceBlackboardDef> DataTermDeviceBlackboard { get; set; }
		[Ordinal(57)] [RED("NetworkBlackboard")] public CHandle<NetworkBlackboardDef> NetworkBlackboard { get; set; }
		[Ordinal(58)] [RED("StorageBlackboard")] public CHandle<StorageBlackboardDef> StorageBlackboard { get; set; }
		[Ordinal(59)] [RED("BackdoorBlackboard")] public CHandle<BackDoorDeviceBlackboardDef> BackdoorBlackboard { get; set; }
		[Ordinal(60)] [RED("ConfessionalBlackboard")] public CHandle<ConfessionalBlackboardDef> ConfessionalBlackboard { get; set; }
		[Ordinal(61)] [RED("JukeboxBlackboard")] public CHandle<JukeboxBlackboardDef> JukeboxBlackboard { get; set; }
		[Ordinal(62)] [RED("MenuEventBlackboard")] public CHandle<MenuEventBlackboardDef> MenuEventBlackboard { get; set; }
		[Ordinal(63)] [RED("UI_NPCNextToTheCrosshair")] public CHandle<UI_NPCNextToTheCrosshairDef> UI_NPCNextToTheCrosshair { get; set; }
		[Ordinal(64)] [RED("UI_NameplateData")] public CHandle<UI_NameplateDataDef> UI_NameplateData { get; set; }
		[Ordinal(65)] [RED("UI_DamageInfo")] public CHandle<UI_DamageInfoDef> UI_DamageInfo { get; set; }
		[Ordinal(66)] [RED("UI_CompassInfo")] public CHandle<UI_CompassInfoDef> UI_CompassInfo { get; set; }
		[Ordinal(67)] [RED("UI_ActiveWeaponData")] public CHandle<UI_ActiveWeaponDataDef> UI_ActiveWeaponData { get; set; }
		[Ordinal(68)] [RED("UI_TargetingInfo")] public CHandle<UI_TargetingInfoDef> UI_TargetingInfo { get; set; }
		[Ordinal(69)] [RED("UI_Notifications")] public CHandle<UI_NotificationsDef> UI_Notifications { get; set; }
		[Ordinal(70)] [RED("LeftHandCyberware")] public CHandle<LeftHandCyberwareDataDef> LeftHandCyberware { get; set; }
		[Ordinal(71)] [RED("CoverAction")] public CHandle<CoverActionDataDef> CoverAction { get; set; }
		[Ordinal(72)] [RED("UI_QuickSlotsData")] public CHandle<UI_QuickSlotsDataDef> UI_QuickSlotsData { get; set; }
		[Ordinal(73)] [RED("UI_VisionMode")] public CHandle<UI_VisionModeDef> UI_VisionMode { get; set; }
		[Ordinal(74)] [RED("UI_HudTooltip")] public CHandle<UI_HudTooltipDef> UI_HudTooltip { get; set; }
		[Ordinal(75)] [RED("UI_HudButtonHelp")] public CHandle<UI_HudButtonHelpDef> UI_HudButtonHelp { get; set; }
		[Ordinal(76)] [RED("UI_ActivityLog")] public CHandle<UI_ActivityLogDef> UI_ActivityLog { get; set; }
		[Ordinal(77)] [RED("UI_LevelUp")] public CHandle<UI_LevelUpDef> UI_LevelUp { get; set; }
		[Ordinal(78)] [RED("UI_Vendor")] public CHandle<UI_VendorDef> UI_Vendor { get; set; }
		[Ordinal(79)] [RED("UI_Briefing")] public CHandle<UI_BriefingDef> UI_Briefing { get; set; }
		[Ordinal(80)] [RED("UI_ItemModSystem")] public CHandle<UI_ItemModSystemDef> UI_ItemModSystem { get; set; }
		[Ordinal(81)] [RED("UI_CodexSystem")] public CHandle<UI_CodexSystemDef> UI_CodexSystem { get; set; }
		[Ordinal(82)] [RED("UI_Equipment")] public CHandle<UI_EquipmentDef> UI_Equipment { get; set; }
		[Ordinal(83)] [RED("UI_Crafting")] public CHandle<UI_CraftingDef> UI_Crafting { get; set; }
		[Ordinal(84)] [RED("UI_Map")] public CHandle<UI_MapDef> UI_Map { get; set; }
		[Ordinal(85)] [RED("UI_CpoCharacterSelection")] public CHandle<UI_CpoCharacterSelectionDef> UI_CpoCharacterSelection { get; set; }
		[Ordinal(86)] [RED("UI_ChatBox")] public CHandle<UI_ChatBoxDef> UI_ChatBox { get; set; }
		[Ordinal(87)] [RED("UI_HUDNarrationLog")] public CHandle<UI_HUDNarrationLogDef> UI_HUDNarrationLog { get; set; }
		[Ordinal(88)] [RED("UI_NarrativePlate")] public CHandle<UI_NarrativePlateDef> UI_NarrativePlate { get; set; }
		[Ordinal(89)] [RED("UI_Crosshair")] public CHandle<UI_CrosshairDef> UI_Crosshair { get; set; }
		[Ordinal(90)] [RED("UI_ItemLog")] public CHandle<UI_ItemLogDef> UI_ItemLog { get; set; }
		[Ordinal(91)] [RED("UI_HUDButtonHints")] public CHandle<UI_HUDButtonHintDef> UI_HUDButtonHints { get; set; }
		[Ordinal(92)] [RED("UI_Companion")] public CHandle<UI_CompanionDef> UI_Companion { get; set; }
		[Ordinal(93)] [RED("UI_CustomQuestNotification")] public CHandle<UI_CustomQuestNotificationDef> UI_CustomQuestNotification { get; set; }
		[Ordinal(94)] [RED("HUD_Manager")] public CHandle<HUDManagerDef> HUD_Manager { get; set; }
		[Ordinal(95)] [RED("UI_Hacking")] public CHandle<UI_HackingDef> UI_Hacking { get; set; }
		[Ordinal(96)] [RED("UI_Stealth")] public CHandle<UI_StealthDef> UI_Stealth { get; set; }
		[Ordinal(97)] [RED("UI_TopbarHubMenu")] public CHandle<UI_TopbarHubMenuDef> UI_TopbarHubMenu { get; set; }
		[Ordinal(98)] [RED("UI_LocalPlayer")] public CHandle<LocalPlayerDef> UI_LocalPlayer { get; set; }
		[Ordinal(99)] [RED("UI_SceneScreen")] public CHandle<UI_SceneScreenDef> UI_SceneScreen { get; set; }
		[Ordinal(100)] [RED("CombatGadget")] public CHandle<CombatGadgetDataDef> CombatGadget { get; set; }
		[Ordinal(101)] [RED("Mines")] public CHandle<MinesDataDef> Mines { get; set; }
		[Ordinal(102)] [RED("DebugData")] public CHandle<DebugDataDef> DebugData { get; set; }
		[Ordinal(103)] [RED("DeviceDebug")] public CHandle<DeviceDebugDef> DeviceDebug { get; set; }
		[Ordinal(104)] [RED("CustomCentaurBlackboard")] public CHandle<CustomCentaurBlackboardDef> CustomCentaurBlackboard { get; set; }
		[Ordinal(105)] [RED("CW_MuteArm")] public CHandle<CW_MuteArmDef> CW_MuteArm { get; set; }
		[Ordinal(106)] [RED("PhotoMode")] public CHandle<PhotoModeDef> PhotoMode { get; set; }
		[Ordinal(107)] [RED("GameplaySettings")] public CHandle<GameplaySettingsDef> GameplaySettings { get; set; }

		public gamebbAllScriptDefinitions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
