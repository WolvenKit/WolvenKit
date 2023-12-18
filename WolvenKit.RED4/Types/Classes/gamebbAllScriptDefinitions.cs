using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamebbAllScriptDefinitions : IScriptable
	{
		[Ordinal(0)] 
		[RED("PlayerStateMachine")] 
		public CHandle<PlayerStateMachineDef> PlayerStateMachine
		{
			get => GetPropertyValue<CHandle<PlayerStateMachineDef>>();
			set => SetPropertyValue<CHandle<PlayerStateMachineDef>>(value);
		}

		[Ordinal(1)] 
		[RED("PlayerPerkData")] 
		public CHandle<PlayerPerkDataDef> PlayerPerkData
		{
			get => GetPropertyValue<CHandle<PlayerPerkDataDef>>();
			set => SetPropertyValue<CHandle<PlayerPerkDataDef>>(value);
		}

		[Ordinal(2)] 
		[RED("PlayerQuickHackData")] 
		public CHandle<PlayerQuickHackDataDef> PlayerQuickHackData
		{
			get => GetPropertyValue<CHandle<PlayerQuickHackDataDef>>();
			set => SetPropertyValue<CHandle<PlayerQuickHackDataDef>>(value);
		}

		[Ordinal(3)] 
		[RED("EffectSharedData")] 
		public CHandle<EffectSharedDataDef> EffectSharedData
		{
			get => GetPropertyValue<CHandle<EffectSharedDataDef>>();
			set => SetPropertyValue<CHandle<EffectSharedDataDef>>(value);
		}

		[Ordinal(4)] 
		[RED("FollowNPC")] 
		public CHandle<FollowNPCDef> FollowNPC
		{
			get => GetPropertyValue<CHandle<FollowNPCDef>>();
			set => SetPropertyValue<CHandle<FollowNPCDef>>(value);
		}

		[Ordinal(5)] 
		[RED("AISquadBlackBoard")] 
		public CHandle<AISquadBlackBoardDef> AISquadBlackBoard
		{
			get => GetPropertyValue<CHandle<AISquadBlackBoardDef>>();
			set => SetPropertyValue<CHandle<AISquadBlackBoardDef>>(value);
		}

		[Ordinal(6)] 
		[RED("Puppet")] 
		public CHandle<PuppetDef> Puppet
		{
			get => GetPropertyValue<CHandle<PuppetDef>>();
			set => SetPropertyValue<CHandle<PuppetDef>>(value);
		}

		[Ordinal(7)] 
		[RED("PuppetState")] 
		public CHandle<PuppetStateDef> PuppetState
		{
			get => GetPropertyValue<CHandle<PuppetStateDef>>();
			set => SetPropertyValue<CHandle<PuppetStateDef>>(value);
		}

		[Ordinal(8)] 
		[RED("PuppetReaction")] 
		public CHandle<PuppetReactionDef> PuppetReaction
		{
			get => GetPropertyValue<CHandle<PuppetReactionDef>>();
			set => SetPropertyValue<CHandle<PuppetReactionDef>>(value);
		}

		[Ordinal(9)] 
		[RED("LocalPlayer")] 
		public CHandle<PuppetReactionDef> LocalPlayer
		{
			get => GetPropertyValue<CHandle<PuppetReactionDef>>();
			set => SetPropertyValue<CHandle<PuppetReactionDef>>(value);
		}

		[Ordinal(10)] 
		[RED("UIGameData")] 
		public CHandle<UIGameDataDef> UIGameData
		{
			get => GetPropertyValue<CHandle<UIGameDataDef>>();
			set => SetPropertyValue<CHandle<UIGameDataDef>>(value);
		}

		[Ordinal(11)] 
		[RED("UIInteractions")] 
		public CHandle<UIInteractionsDef> UIInteractions
		{
			get => GetPropertyValue<CHandle<UIInteractionsDef>>();
			set => SetPropertyValue<CHandle<UIInteractionsDef>>(value);
		}

		[Ordinal(12)] 
		[RED("Weapon")] 
		public CHandle<WeaponDataDef> Weapon
		{
			get => GetPropertyValue<CHandle<WeaponDataDef>>();
			set => SetPropertyValue<CHandle<WeaponDataDef>>(value);
		}

		[Ordinal(13)] 
		[RED("DeviceTakeControl")] 
		public CHandle<DeviceTakeControlDef> DeviceTakeControl
		{
			get => GetPropertyValue<CHandle<DeviceTakeControlDef>>();
			set => SetPropertyValue<CHandle<DeviceTakeControlDef>>(value);
		}

		[Ordinal(14)] 
		[RED("TaggedObjectsList")] 
		public CHandle<TaggedObjectsListDef> TaggedObjectsList
		{
			get => GetPropertyValue<CHandle<TaggedObjectsListDef>>();
			set => SetPropertyValue<CHandle<TaggedObjectsListDef>>(value);
		}

		[Ordinal(15)] 
		[RED("AdHocAnimation")] 
		public CHandle<AdHocAnimationDef> AdHocAnimation
		{
			get => GetPropertyValue<CHandle<AdHocAnimationDef>>();
			set => SetPropertyValue<CHandle<AdHocAnimationDef>>(value);
		}

		[Ordinal(16)] 
		[RED("QuickMeleeData")] 
		public CHandle<QuickMeleeDataDef> QuickMeleeData
		{
			get => GetPropertyValue<CHandle<QuickMeleeDataDef>>();
			set => SetPropertyValue<CHandle<QuickMeleeDataDef>>(value);
		}

		[Ordinal(17)] 
		[RED("Vehicle")] 
		public CHandle<VehicleDef> Vehicle
		{
			get => GetPropertyValue<CHandle<VehicleDef>>();
			set => SetPropertyValue<CHandle<VehicleDef>>(value);
		}

		[Ordinal(18)] 
		[RED("VehicleSummonData")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonData
		{
			get => GetPropertyValue<CHandle<VehicleSummonDataDef>>();
			set => SetPropertyValue<CHandle<VehicleSummonDataDef>>(value);
		}

		[Ordinal(19)] 
		[RED("VehiclePurchaseData")] 
		public CHandle<VehiclePurchaseDataDef> VehiclePurchaseData
		{
			get => GetPropertyValue<CHandle<VehiclePurchaseDataDef>>();
			set => SetPropertyValue<CHandle<VehiclePurchaseDataDef>>(value);
		}

		[Ordinal(20)] 
		[RED("Braindance")] 
		public CHandle<BraindanceBlackboardDef> Braindance
		{
			get => GetPropertyValue<CHandle<BraindanceBlackboardDef>>();
			set => SetPropertyValue<CHandle<BraindanceBlackboardDef>>(value);
		}

		[Ordinal(21)] 
		[RED("HackingMinigame")] 
		public CHandle<HackingMinigameDef> HackingMinigame
		{
			get => GetPropertyValue<CHandle<HackingMinigameDef>>();
			set => SetPropertyValue<CHandle<HackingMinigameDef>>(value);
		}

		[Ordinal(22)] 
		[RED("HackingData")] 
		public CHandle<HackingDataDef> HackingData
		{
			get => GetPropertyValue<CHandle<HackingDataDef>>();
			set => SetPropertyValue<CHandle<HackingDataDef>>(value);
		}

		[Ordinal(23)] 
		[RED("AIShooting")] 
		public CHandle<AIShootingDataDef> AIShooting
		{
			get => GetPropertyValue<CHandle<AIShootingDataDef>>();
			set => SetPropertyValue<CHandle<AIShootingDataDef>>(value);
		}

		[Ordinal(24)] 
		[RED("AICover")] 
		public CHandle<AICoverDataDef> AICover
		{
			get => GetPropertyValue<CHandle<AICoverDataDef>>();
			set => SetPropertyValue<CHandle<AICoverDataDef>>(value);
		}

		[Ordinal(25)] 
		[RED("AIAction")] 
		public CHandle<AIActionDataDef> AIAction
		{
			get => GetPropertyValue<CHandle<AIActionDataDef>>();
			set => SetPropertyValue<CHandle<AIActionDataDef>>(value);
		}

		[Ordinal(26)] 
		[RED("AIPrereqs")] 
		public CHandle<AIPrereqsDataDef> AIPrereqs
		{
			get => GetPropertyValue<CHandle<AIPrereqsDataDef>>();
			set => SetPropertyValue<CHandle<AIPrereqsDataDef>>(value);
		}

		[Ordinal(27)] 
		[RED("AIPatrol")] 
		public CHandle<AIPatrolDef> AIPatrol
		{
			get => GetPropertyValue<CHandle<AIPatrolDef>>();
			set => SetPropertyValue<CHandle<AIPatrolDef>>(value);
		}

		[Ordinal(28)] 
		[RED("AIAlertedPatrol")] 
		public CHandle<AIAlertedPatrolDef> AIAlertedPatrol
		{
			get => GetPropertyValue<CHandle<AIAlertedPatrolDef>>();
			set => SetPropertyValue<CHandle<AIAlertedPatrolDef>>(value);
		}

		[Ordinal(29)] 
		[RED("VendorRegister")] 
		public CHandle<VendorRegisterBlackBoardDef> VendorRegister
		{
			get => GetPropertyValue<CHandle<VendorRegisterBlackBoardDef>>();
			set => SetPropertyValue<CHandle<VendorRegisterBlackBoardDef>>(value);
		}

		[Ordinal(30)] 
		[RED("AIFollowSlot")] 
		public CHandle<AIFollowSlotDef> AIFollowSlot
		{
			get => GetPropertyValue<CHandle<AIFollowSlotDef>>();
			set => SetPropertyValue<CHandle<AIFollowSlotDef>>(value);
		}

		[Ordinal(31)] 
		[RED("AIActionBossData")] 
		public CHandle<AIActionBossDataDef> AIActionBossData
		{
			get => GetPropertyValue<CHandle<AIActionBossDataDef>>();
			set => SetPropertyValue<CHandle<AIActionBossDataDef>>(value);
		}

		[Ordinal(32)] 
		[RED("UI_System")] 
		public CHandle<UI_SystemDef> UI_System
		{
			get => GetPropertyValue<CHandle<UI_SystemDef>>();
			set => SetPropertyValue<CHandle<UI_SystemDef>>(value);
		}

		[Ordinal(33)] 
		[RED("UI_ActiveVehicleData")] 
		public CHandle<UI_ActiveVehicleDataDef> UI_ActiveVehicleData
		{
			get => GetPropertyValue<CHandle<UI_ActiveVehicleDataDef>>();
			set => SetPropertyValue<CHandle<UI_ActiveVehicleDataDef>>(value);
		}

		[Ordinal(34)] 
		[RED("UIWorldBoundaries")] 
		public CHandle<UIWorldBoundariesDef> UIWorldBoundaries
		{
			get => GetPropertyValue<CHandle<UIWorldBoundariesDef>>();
			set => SetPropertyValue<CHandle<UIWorldBoundariesDef>>(value);
		}

		[Ordinal(35)] 
		[RED("UI_PlayerStats")] 
		public CHandle<UI_PlayerStatsDef> UI_PlayerStats
		{
			get => GetPropertyValue<CHandle<UI_PlayerStatsDef>>();
			set => SetPropertyValue<CHandle<UI_PlayerStatsDef>>(value);
		}

		[Ordinal(36)] 
		[RED("UI_EquipmentData")] 
		public CHandle<UI_EquipmentDataDef> UI_EquipmentData
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDataDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDataDef>>(value);
		}

		[Ordinal(37)] 
		[RED("UI_PlayerBioMonitor")] 
		public CHandle<UI_PlayerBioMonitorDef> UI_PlayerBioMonitor
		{
			get => GetPropertyValue<CHandle<UI_PlayerBioMonitorDef>>();
			set => SetPropertyValue<CHandle<UI_PlayerBioMonitorDef>>(value);
		}

		[Ordinal(38)] 
		[RED("FastTRavelSystem")] 
		public CHandle<FastTRavelSystemDef> FastTRavelSystem
		{
			get => GetPropertyValue<CHandle<FastTRavelSystemDef>>();
			set => SetPropertyValue<CHandle<FastTRavelSystemDef>>(value);
		}

		[Ordinal(39)] 
		[RED("UI_ComDevice")] 
		public CHandle<UI_ComDeviceDef> UI_ComDevice
		{
			get => GetPropertyValue<CHandle<UI_ComDeviceDef>>();
			set => SetPropertyValue<CHandle<UI_ComDeviceDef>>(value);
		}

		[Ordinal(40)] 
		[RED("UI_Scanner")] 
		public CHandle<UI_ScannerDef> UI_Scanner
		{
			get => GetPropertyValue<CHandle<UI_ScannerDef>>();
			set => SetPropertyValue<CHandle<UI_ScannerDef>>(value);
		}

		[Ordinal(41)] 
		[RED("UI_ScannerModules")] 
		public CHandle<UI_ScannerModulesDef> UI_ScannerModules
		{
			get => GetPropertyValue<CHandle<UI_ScannerModulesDef>>();
			set => SetPropertyValue<CHandle<UI_ScannerModulesDef>>(value);
		}

		[Ordinal(42)] 
		[RED("UI_WantedBar")] 
		public CHandle<UI_WantedBarDef> UI_WantedBar
		{
			get => GetPropertyValue<CHandle<UI_WantedBarDef>>();
			set => SetPropertyValue<CHandle<UI_WantedBarDef>>(value);
		}

		[Ordinal(43)] 
		[RED("UI_FastForward")] 
		public CHandle<UI_FastForwardDef> UI_FastForward
		{
			get => GetPropertyValue<CHandle<UI_FastForwardDef>>();
			set => SetPropertyValue<CHandle<UI_FastForwardDef>>(value);
		}

		[Ordinal(44)] 
		[RED("UI_HUDProgressBar")] 
		public CHandle<UI_HUDProgressBarDef> UI_HUDProgressBar
		{
			get => GetPropertyValue<CHandle<UI_HUDProgressBarDef>>();
			set => SetPropertyValue<CHandle<UI_HUDProgressBarDef>>(value);
		}

		[Ordinal(45)] 
		[RED("UI_HUDSignalProgressBar")] 
		public CHandle<UI_HUDSignalProgressBarDef> UI_HUDSignalProgressBar
		{
			get => GetPropertyValue<CHandle<UI_HUDSignalProgressBarDef>>();
			set => SetPropertyValue<CHandle<UI_HUDSignalProgressBarDef>>(value);
		}

		[Ordinal(46)] 
		[RED("UI_HUDCountdownTimer")] 
		public CHandle<UI_HUDCountdownTimerDef> UI_HUDCountdownTimer
		{
			get => GetPropertyValue<CHandle<UI_HUDCountdownTimerDef>>();
			set => SetPropertyValue<CHandle<UI_HUDCountdownTimerDef>>(value);
		}

		[Ordinal(47)] 
		[RED("UI_Hotkeys")] 
		public CHandle<UI_HotkeysDef> UI_Hotkeys
		{
			get => GetPropertyValue<CHandle<UI_HotkeysDef>>();
			set => SetPropertyValue<CHandle<UI_HotkeysDef>>(value);
		}

		[Ordinal(48)] 
		[RED("DeviceBaseBlackboard")] 
		public CHandle<DeviceBaseBlackboardDef> DeviceBaseBlackboard
		{
			get => GetPropertyValue<CHandle<DeviceBaseBlackboardDef>>();
			set => SetPropertyValue<CHandle<DeviceBaseBlackboardDef>>(value);
		}

		[Ordinal(49)] 
		[RED("TVDeviceBlackboard")] 
		public CHandle<TVDeviceBlackboardDef> TVDeviceBlackboard
		{
			get => GetPropertyValue<CHandle<TVDeviceBlackboardDef>>();
			set => SetPropertyValue<CHandle<TVDeviceBlackboardDef>>(value);
		}

		[Ordinal(50)] 
		[RED("ArcadeMachineBlackBoard")] 
		public CHandle<ArcadeMachineBlackboardDef> ArcadeMachineBlackBoard
		{
			get => GetPropertyValue<CHandle<ArcadeMachineBlackboardDef>>();
			set => SetPropertyValue<CHandle<ArcadeMachineBlackboardDef>>(value);
		}

		[Ordinal(51)] 
		[RED("ElectricBoxBlackBoard")] 
		public CHandle<ElectricBoxBlackboardDef> ElectricBoxBlackBoard
		{
			get => GetPropertyValue<CHandle<ElectricBoxBlackboardDef>>();
			set => SetPropertyValue<CHandle<ElectricBoxBlackboardDef>>(value);
		}

		[Ordinal(52)] 
		[RED("LcdScreenBlackBoard")] 
		public CHandle<LcdScreenBlackBoardDef> LcdScreenBlackBoard
		{
			get => GetPropertyValue<CHandle<LcdScreenBlackBoardDef>>();
			set => SetPropertyValue<CHandle<LcdScreenBlackBoardDef>>(value);
		}

		[Ordinal(53)] 
		[RED("NcartTimetableBlackboard")] 
		public CHandle<NcartTimetableBlackboardDef> NcartTimetableBlackboard
		{
			get => GetPropertyValue<CHandle<NcartTimetableBlackboardDef>>();
			set => SetPropertyValue<CHandle<NcartTimetableBlackboardDef>>(value);
		}

		[Ordinal(54)] 
		[RED("IntercomBlackboard")] 
		public CHandle<IntercomBlackboardDef> IntercomBlackboard
		{
			get => GetPropertyValue<CHandle<IntercomBlackboardDef>>();
			set => SetPropertyValue<CHandle<IntercomBlackboardDef>>(value);
		}

		[Ordinal(55)] 
		[RED("ElevatorDeviceBlackboard")] 
		public CHandle<ElevatorDeviceBlackboardDef> ElevatorDeviceBlackboard
		{
			get => GetPropertyValue<CHandle<ElevatorDeviceBlackboardDef>>();
			set => SetPropertyValue<CHandle<ElevatorDeviceBlackboardDef>>(value);
		}

		[Ordinal(56)] 
		[RED("VendingMachineDeviceBlackboard")] 
		public CHandle<VendingMachineDeviceBlackboardDef> VendingMachineDeviceBlackboard
		{
			get => GetPropertyValue<CHandle<VendingMachineDeviceBlackboardDef>>();
			set => SetPropertyValue<CHandle<VendingMachineDeviceBlackboardDef>>(value);
		}

		[Ordinal(57)] 
		[RED("InteractiveDeviceBlackboard")] 
		public CHandle<InteractiveDeviceBlackboardDef> InteractiveDeviceBlackboard
		{
			get => GetPropertyValue<CHandle<InteractiveDeviceBlackboardDef>>();
			set => SetPropertyValue<CHandle<InteractiveDeviceBlackboardDef>>(value);
		}

		[Ordinal(58)] 
		[RED("MasterDeviceBaseBlackboard")] 
		public CHandle<MasterDeviceBaseBlackboardDef> MasterDeviceBaseBlackboard
		{
			get => GetPropertyValue<CHandle<MasterDeviceBaseBlackboardDef>>();
			set => SetPropertyValue<CHandle<MasterDeviceBaseBlackboardDef>>(value);
		}

		[Ordinal(59)] 
		[RED("ComputerDeviceBlackboard")] 
		public CHandle<ComputerDeviceBlackboardDef> ComputerDeviceBlackboard
		{
			get => GetPropertyValue<CHandle<ComputerDeviceBlackboardDef>>();
			set => SetPropertyValue<CHandle<ComputerDeviceBlackboardDef>>(value);
		}

		[Ordinal(60)] 
		[RED("DataTermDeviceBlackboard")] 
		public CHandle<DataTermDeviceBlackboardDef> DataTermDeviceBlackboard
		{
			get => GetPropertyValue<CHandle<DataTermDeviceBlackboardDef>>();
			set => SetPropertyValue<CHandle<DataTermDeviceBlackboardDef>>(value);
		}

		[Ordinal(61)] 
		[RED("NetworkBlackboard")] 
		public CHandle<NetworkBlackboardDef> NetworkBlackboard
		{
			get => GetPropertyValue<CHandle<NetworkBlackboardDef>>();
			set => SetPropertyValue<CHandle<NetworkBlackboardDef>>(value);
		}

		[Ordinal(62)] 
		[RED("StorageBlackboard")] 
		public CHandle<StorageBlackboardDef> StorageBlackboard
		{
			get => GetPropertyValue<CHandle<StorageBlackboardDef>>();
			set => SetPropertyValue<CHandle<StorageBlackboardDef>>(value);
		}

		[Ordinal(63)] 
		[RED("BackdoorBlackboard")] 
		public CHandle<BackDoorDeviceBlackboardDef> BackdoorBlackboard
		{
			get => GetPropertyValue<CHandle<BackDoorDeviceBlackboardDef>>();
			set => SetPropertyValue<CHandle<BackDoorDeviceBlackboardDef>>(value);
		}

		[Ordinal(64)] 
		[RED("ConfessionalBlackboard")] 
		public CHandle<ConfessionalBlackboardDef> ConfessionalBlackboard
		{
			get => GetPropertyValue<CHandle<ConfessionalBlackboardDef>>();
			set => SetPropertyValue<CHandle<ConfessionalBlackboardDef>>(value);
		}

		[Ordinal(65)] 
		[RED("JukeboxBlackboard")] 
		public CHandle<JukeboxBlackboardDef> JukeboxBlackboard
		{
			get => GetPropertyValue<CHandle<JukeboxBlackboardDef>>();
			set => SetPropertyValue<CHandle<JukeboxBlackboardDef>>(value);
		}

		[Ordinal(66)] 
		[RED("MenuEventBlackboard")] 
		public CHandle<MenuEventBlackboardDef> MenuEventBlackboard
		{
			get => GetPropertyValue<CHandle<MenuEventBlackboardDef>>();
			set => SetPropertyValue<CHandle<MenuEventBlackboardDef>>(value);
		}

		[Ordinal(67)] 
		[RED("NumericDisplay")] 
		public CHandle<NumericDisplayBlackboardDef> NumericDisplay
		{
			get => GetPropertyValue<CHandle<NumericDisplayBlackboardDef>>();
			set => SetPropertyValue<CHandle<NumericDisplayBlackboardDef>>(value);
		}

		[Ordinal(68)] 
		[RED("SniperNestDeviceBlackboard")] 
		public CHandle<SniperNestDeviceBlackboardDef> SniperNestDeviceBlackboard
		{
			get => GetPropertyValue<CHandle<SniperNestDeviceBlackboardDef>>();
			set => SetPropertyValue<CHandle<SniperNestDeviceBlackboardDef>>(value);
		}

		[Ordinal(69)] 
		[RED("UI_NPCNextToTheCrosshair")] 
		public CHandle<UI_NPCNextToTheCrosshairDef> UI_NPCNextToTheCrosshair
		{
			get => GetPropertyValue<CHandle<UI_NPCNextToTheCrosshairDef>>();
			set => SetPropertyValue<CHandle<UI_NPCNextToTheCrosshairDef>>(value);
		}

		[Ordinal(70)] 
		[RED("UI_NameplateData")] 
		public CHandle<UI_NameplateDataDef> UI_NameplateData
		{
			get => GetPropertyValue<CHandle<UI_NameplateDataDef>>();
			set => SetPropertyValue<CHandle<UI_NameplateDataDef>>(value);
		}

		[Ordinal(71)] 
		[RED("UI_DamageInfo")] 
		public CHandle<UI_DamageInfoDef> UI_DamageInfo
		{
			get => GetPropertyValue<CHandle<UI_DamageInfoDef>>();
			set => SetPropertyValue<CHandle<UI_DamageInfoDef>>(value);
		}

		[Ordinal(72)] 
		[RED("UI_InterfaceOptions")] 
		public CHandle<UI_InterfaceOptionsDef> UI_InterfaceOptions
		{
			get => GetPropertyValue<CHandle<UI_InterfaceOptionsDef>>();
			set => SetPropertyValue<CHandle<UI_InterfaceOptionsDef>>(value);
		}

		[Ordinal(73)] 
		[RED("UI_CompassInfo")] 
		public CHandle<UI_CompassInfoDef> UI_CompassInfo
		{
			get => GetPropertyValue<CHandle<UI_CompassInfoDef>>();
			set => SetPropertyValue<CHandle<UI_CompassInfoDef>>(value);
		}

		[Ordinal(74)] 
		[RED("UI_ActiveWeaponData")] 
		public CHandle<UI_ActiveWeaponDataDef> UI_ActiveWeaponData
		{
			get => GetPropertyValue<CHandle<UI_ActiveWeaponDataDef>>();
			set => SetPropertyValue<CHandle<UI_ActiveWeaponDataDef>>(value);
		}

		[Ordinal(75)] 
		[RED("UI_TargetingInfo")] 
		public CHandle<UI_TargetingInfoDef> UI_TargetingInfo
		{
			get => GetPropertyValue<CHandle<UI_TargetingInfoDef>>();
			set => SetPropertyValue<CHandle<UI_TargetingInfoDef>>(value);
		}

		[Ordinal(76)] 
		[RED("UI_Notifications")] 
		public CHandle<UI_NotificationsDef> UI_Notifications
		{
			get => GetPropertyValue<CHandle<UI_NotificationsDef>>();
			set => SetPropertyValue<CHandle<UI_NotificationsDef>>(value);
		}

		[Ordinal(77)] 
		[RED("LeftHandCyberware")] 
		public CHandle<LeftHandCyberwareDataDef> LeftHandCyberware
		{
			get => GetPropertyValue<CHandle<LeftHandCyberwareDataDef>>();
			set => SetPropertyValue<CHandle<LeftHandCyberwareDataDef>>(value);
		}

		[Ordinal(78)] 
		[RED("CoverAction")] 
		public CHandle<CoverActionDataDef> CoverAction
		{
			get => GetPropertyValue<CHandle<CoverActionDataDef>>();
			set => SetPropertyValue<CHandle<CoverActionDataDef>>(value);
		}

		[Ordinal(79)] 
		[RED("UI_QuickSlotsData")] 
		public CHandle<UI_QuickSlotsDataDef> UI_QuickSlotsData
		{
			get => GetPropertyValue<CHandle<UI_QuickSlotsDataDef>>();
			set => SetPropertyValue<CHandle<UI_QuickSlotsDataDef>>(value);
		}

		[Ordinal(80)] 
		[RED("UI_VisionMode")] 
		public CHandle<UI_VisionModeDef> UI_VisionMode
		{
			get => GetPropertyValue<CHandle<UI_VisionModeDef>>();
			set => SetPropertyValue<CHandle<UI_VisionModeDef>>(value);
		}

		[Ordinal(81)] 
		[RED("UI_HudTooltip")] 
		public CHandle<UI_HudTooltipDef> UI_HudTooltip
		{
			get => GetPropertyValue<CHandle<UI_HudTooltipDef>>();
			set => SetPropertyValue<CHandle<UI_HudTooltipDef>>(value);
		}

		[Ordinal(82)] 
		[RED("UI_HudButtonHelp")] 
		public CHandle<UI_HudButtonHelpDef> UI_HudButtonHelp
		{
			get => GetPropertyValue<CHandle<UI_HudButtonHelpDef>>();
			set => SetPropertyValue<CHandle<UI_HudButtonHelpDef>>(value);
		}

		[Ordinal(83)] 
		[RED("UI_ActivityLog")] 
		public CHandle<UI_ActivityLogDef> UI_ActivityLog
		{
			get => GetPropertyValue<CHandle<UI_ActivityLogDef>>();
			set => SetPropertyValue<CHandle<UI_ActivityLogDef>>(value);
		}

		[Ordinal(84)] 
		[RED("UI_LevelUp")] 
		public CHandle<UI_LevelUpDef> UI_LevelUp
		{
			get => GetPropertyValue<CHandle<UI_LevelUpDef>>();
			set => SetPropertyValue<CHandle<UI_LevelUpDef>>(value);
		}

		[Ordinal(85)] 
		[RED("UI_Vendor")] 
		public CHandle<UI_VendorDef> UI_Vendor
		{
			get => GetPropertyValue<CHandle<UI_VendorDef>>();
			set => SetPropertyValue<CHandle<UI_VendorDef>>(value);
		}

		[Ordinal(86)] 
		[RED("UI_Briefing")] 
		public CHandle<UI_BriefingDef> UI_Briefing
		{
			get => GetPropertyValue<CHandle<UI_BriefingDef>>();
			set => SetPropertyValue<CHandle<UI_BriefingDef>>(value);
		}

		[Ordinal(87)] 
		[RED("UI_ItemModSystem")] 
		public CHandle<UI_ItemModSystemDef> UI_ItemModSystem
		{
			get => GetPropertyValue<CHandle<UI_ItemModSystemDef>>();
			set => SetPropertyValue<CHandle<UI_ItemModSystemDef>>(value);
		}

		[Ordinal(88)] 
		[RED("UI_CodexSystem")] 
		public CHandle<UI_CodexSystemDef> UI_CodexSystem
		{
			get => GetPropertyValue<CHandle<UI_CodexSystemDef>>();
			set => SetPropertyValue<CHandle<UI_CodexSystemDef>>(value);
		}

		[Ordinal(89)] 
		[RED("UI_Equipment")] 
		public CHandle<UI_EquipmentDef> UI_Equipment
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(90)] 
		[RED("UI_Inventory")] 
		public CHandle<UI_InventoryDef> UI_Inventory
		{
			get => GetPropertyValue<CHandle<UI_InventoryDef>>();
			set => SetPropertyValue<CHandle<UI_InventoryDef>>(value);
		}

		[Ordinal(91)] 
		[RED("UI_Crafting")] 
		public CHandle<UI_CraftingDef> UI_Crafting
		{
			get => GetPropertyValue<CHandle<UI_CraftingDef>>();
			set => SetPropertyValue<CHandle<UI_CraftingDef>>(value);
		}

		[Ordinal(92)] 
		[RED("UI_Map")] 
		public CHandle<UI_MapDef> UI_Map
		{
			get => GetPropertyValue<CHandle<UI_MapDef>>();
			set => SetPropertyValue<CHandle<UI_MapDef>>(value);
		}

		[Ordinal(93)] 
		[RED("UI_CpoCharacterSelection")] 
		public CHandle<UI_CpoCharacterSelectionDef> UI_CpoCharacterSelection
		{
			get => GetPropertyValue<CHandle<UI_CpoCharacterSelectionDef>>();
			set => SetPropertyValue<CHandle<UI_CpoCharacterSelectionDef>>(value);
		}

		[Ordinal(94)] 
		[RED("UI_ChatBox")] 
		public CHandle<UI_ChatBoxDef> UI_ChatBox
		{
			get => GetPropertyValue<CHandle<UI_ChatBoxDef>>();
			set => SetPropertyValue<CHandle<UI_ChatBoxDef>>(value);
		}

		[Ordinal(95)] 
		[RED("UI_HUDNarrationLog")] 
		public CHandle<UI_HUDNarrationLogDef> UI_HUDNarrationLog
		{
			get => GetPropertyValue<CHandle<UI_HUDNarrationLogDef>>();
			set => SetPropertyValue<CHandle<UI_HUDNarrationLogDef>>(value);
		}

		[Ordinal(96)] 
		[RED("UI_NarrativePlate")] 
		public CHandle<UI_NarrativePlateDef> UI_NarrativePlate
		{
			get => GetPropertyValue<CHandle<UI_NarrativePlateDef>>();
			set => SetPropertyValue<CHandle<UI_NarrativePlateDef>>(value);
		}

		[Ordinal(97)] 
		[RED("UI_Crosshair")] 
		public CHandle<UI_CrosshairDef> UI_Crosshair
		{
			get => GetPropertyValue<CHandle<UI_CrosshairDef>>();
			set => SetPropertyValue<CHandle<UI_CrosshairDef>>(value);
		}

		[Ordinal(98)] 
		[RED("UI_ItemLog")] 
		public CHandle<UI_ItemLogDef> UI_ItemLog
		{
			get => GetPropertyValue<CHandle<UI_ItemLogDef>>();
			set => SetPropertyValue<CHandle<UI_ItemLogDef>>(value);
		}

		[Ordinal(99)] 
		[RED("UI_HUDButtonHints")] 
		public CHandle<UI_HUDButtonHintDef> UI_HUDButtonHints
		{
			get => GetPropertyValue<CHandle<UI_HUDButtonHintDef>>();
			set => SetPropertyValue<CHandle<UI_HUDButtonHintDef>>(value);
		}

		[Ordinal(100)] 
		[RED("UI_Companion")] 
		public CHandle<UI_CompanionDef> UI_Companion
		{
			get => GetPropertyValue<CHandle<UI_CompanionDef>>();
			set => SetPropertyValue<CHandle<UI_CompanionDef>>(value);
		}

		[Ordinal(101)] 
		[RED("UI_CustomQuestNotification")] 
		public CHandle<UI_CustomQuestNotificationDef> UI_CustomQuestNotification
		{
			get => GetPropertyValue<CHandle<UI_CustomQuestNotificationDef>>();
			set => SetPropertyValue<CHandle<UI_CustomQuestNotificationDef>>(value);
		}

		[Ordinal(102)] 
		[RED("HUD_Manager")] 
		public CHandle<HUDManagerDef> HUD_Manager
		{
			get => GetPropertyValue<CHandle<HUDManagerDef>>();
			set => SetPropertyValue<CHandle<HUDManagerDef>>(value);
		}

		[Ordinal(103)] 
		[RED("UI_Hacking")] 
		public CHandle<UI_HackingDef> UI_Hacking
		{
			get => GetPropertyValue<CHandle<UI_HackingDef>>();
			set => SetPropertyValue<CHandle<UI_HackingDef>>(value);
		}

		[Ordinal(104)] 
		[RED("UI_Stealth")] 
		public CHandle<UI_StealthDef> UI_Stealth
		{
			get => GetPropertyValue<CHandle<UI_StealthDef>>();
			set => SetPropertyValue<CHandle<UI_StealthDef>>(value);
		}

		[Ordinal(105)] 
		[RED("UI_TopbarHubMenu")] 
		public CHandle<UI_TopbarHubMenuDef> UI_TopbarHubMenu
		{
			get => GetPropertyValue<CHandle<UI_TopbarHubMenuDef>>();
			set => SetPropertyValue<CHandle<UI_TopbarHubMenuDef>>(value);
		}

		[Ordinal(106)] 
		[RED("UI_LocalPlayer")] 
		public CHandle<LocalPlayerDef> UI_LocalPlayer
		{
			get => GetPropertyValue<CHandle<LocalPlayerDef>>();
			set => SetPropertyValue<CHandle<LocalPlayerDef>>(value);
		}

		[Ordinal(107)] 
		[RED("UI_SceneScreen")] 
		public CHandle<UI_SceneScreenDef> UI_SceneScreen
		{
			get => GetPropertyValue<CHandle<UI_SceneScreenDef>>();
			set => SetPropertyValue<CHandle<UI_SceneScreenDef>>(value);
		}

		[Ordinal(108)] 
		[RED("UI_PointOfNoReturnRewardScreen")] 
		public CHandle<UI_PointOfNoReturnRewardScreenDef> UI_PointOfNoReturnRewardScreen
		{
			get => GetPropertyValue<CHandle<UI_PointOfNoReturnRewardScreenDef>>();
			set => SetPropertyValue<CHandle<UI_PointOfNoReturnRewardScreenDef>>(value);
		}

		[Ordinal(109)] 
		[RED("TokenUpgradedCyberwareBlackboard")] 
		public CHandle<TokenUpgradedCyberwareBlackboardDef> TokenUpgradedCyberwareBlackboard
		{
			get => GetPropertyValue<CHandle<TokenUpgradedCyberwareBlackboardDef>>();
			set => SetPropertyValue<CHandle<TokenUpgradedCyberwareBlackboardDef>>(value);
		}

		[Ordinal(110)] 
		[RED("CombatGadget")] 
		public CHandle<CombatGadgetDataDef> CombatGadget
		{
			get => GetPropertyValue<CHandle<CombatGadgetDataDef>>();
			set => SetPropertyValue<CHandle<CombatGadgetDataDef>>(value);
		}

		[Ordinal(111)] 
		[RED("Mines")] 
		public CHandle<MinesDataDef> Mines
		{
			get => GetPropertyValue<CHandle<MinesDataDef>>();
			set => SetPropertyValue<CHandle<MinesDataDef>>(value);
		}

		[Ordinal(112)] 
		[RED("DebugData")] 
		public CHandle<DebugDataDef> DebugData
		{
			get => GetPropertyValue<CHandle<DebugDataDef>>();
			set => SetPropertyValue<CHandle<DebugDataDef>>(value);
		}

		[Ordinal(113)] 
		[RED("DeviceDebug")] 
		public CHandle<DeviceDebugDef> DeviceDebug
		{
			get => GetPropertyValue<CHandle<DeviceDebugDef>>();
			set => SetPropertyValue<CHandle<DeviceDebugDef>>(value);
		}

		[Ordinal(114)] 
		[RED("ChargedGrenadesBlackBoard")] 
		public CHandle<ChargedGrenadesBlackBoardDef> ChargedGrenadesBlackBoard
		{
			get => GetPropertyValue<CHandle<ChargedGrenadesBlackBoardDef>>();
			set => SetPropertyValue<CHandle<ChargedGrenadesBlackBoardDef>>(value);
		}

		[Ordinal(115)] 
		[RED("ChargedHealingBlackBoard")] 
		public CHandle<ChargedHealingBlackBoardDef> ChargedHealingBlackBoard
		{
			get => GetPropertyValue<CHandle<ChargedHealingBlackBoardDef>>();
			set => SetPropertyValue<CHandle<ChargedHealingBlackBoardDef>>(value);
		}

		[Ordinal(116)] 
		[RED("BlackwallDeathAnim")] 
		public CHandle<BlackwallAnimDef> BlackwallDeathAnim
		{
			get => GetPropertyValue<CHandle<BlackwallAnimDef>>();
			set => SetPropertyValue<CHandle<BlackwallAnimDef>>(value);
		}

		[Ordinal(117)] 
		[RED("CustomCentaurBlackboard")] 
		public CHandle<CustomCentaurBlackboardDef> CustomCentaurBlackboard
		{
			get => GetPropertyValue<CHandle<CustomCentaurBlackboardDef>>();
			set => SetPropertyValue<CHandle<CustomCentaurBlackboardDef>>(value);
		}

		[Ordinal(118)] 
		[RED("CW_MuteArm")] 
		public CHandle<CW_MuteArmDef> CW_MuteArm
		{
			get => GetPropertyValue<CHandle<CW_MuteArmDef>>();
			set => SetPropertyValue<CHandle<CW_MuteArmDef>>(value);
		}

		[Ordinal(119)] 
		[RED("PhotoMode")] 
		public CHandle<PhotoModeDef> PhotoMode
		{
			get => GetPropertyValue<CHandle<PhotoModeDef>>();
			set => SetPropertyValue<CHandle<PhotoModeDef>>(value);
		}

		[Ordinal(120)] 
		[RED("GameplaySettings")] 
		public CHandle<GameplaySettingsDef> GameplaySettings
		{
			get => GetPropertyValue<CHandle<GameplaySettingsDef>>();
			set => SetPropertyValue<CHandle<GameplaySettingsDef>>(value);
		}

		[Ordinal(121)] 
		[RED("InputSchemes")] 
		public CHandle<InputSchemesDef> InputSchemes
		{
			get => GetPropertyValue<CHandle<InputSchemesDef>>();
			set => SetPropertyValue<CHandle<InputSchemesDef>>(value);
		}

		[Ordinal(122)] 
		[RED("PoliceChaseParams")] 
		public CHandle<PoliceChaseParamsDef> PoliceChaseParams
		{
			get => GetPropertyValue<CHandle<PoliceChaseParamsDef>>();
			set => SetPropertyValue<CHandle<PoliceChaseParamsDef>>(value);
		}

		public gamebbAllScriptDefinitions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
