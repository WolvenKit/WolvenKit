using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamebbAllScriptDefinitions : IScriptable
	{
		private CHandle<PlayerStateMachineDef> _playerStateMachine;
		private CHandle<PlayerPerkDataDef> _playerPerkData;
		private CHandle<PlayerQuickHackDataDef> _playerQuickHackData;
		private CHandle<EffectSharedDataDef> _effectSharedData;
		private CHandle<FollowNPCDef> _followNPC;
		private CHandle<AISquadBlackBoardDef> _aISquadBlackBoard;
		private CHandle<PuppetDef> _puppet;
		private CHandle<PuppetStateDef> _puppetState;
		private CHandle<PuppetReactionDef> _puppetReaction;
		private CHandle<PuppetReactionDef> _localPlayer;
		private CHandle<UIGameDataDef> _uIGameData;
		private CHandle<UIInteractionsDef> _uIInteractions;
		private CHandle<WeaponDataDef> _weapon;
		private CHandle<DeviceTakeControlDef> _deviceTakeControl;
		private CHandle<TaggedObjectsListDef> _taggedObjectsList;
		private CHandle<AdHocAnimationDef> _adHocAnimation;
		private CHandle<QuickMeleeDataDef> _quickMeleeData;
		private CHandle<VehicleDef> _vehicle;
		private CHandle<VehicleSummonDataDef> _vehicleSummonData;
		private CHandle<BraindanceBlackboardDef> _braindance;
		private CHandle<HackingMinigameDef> _hackingMinigame;
		private CHandle<HackingDataDef> _hackingData;
		private CHandle<AIShootingDataDef> _aIShooting;
		private CHandle<AICoverDataDef> _aICover;
		private CHandle<AIActionDataDef> _aIAction;
		private CHandle<AIPatrolDef> _aIPatrol;
		private CHandle<AIAlertedPatrolDef> _aIAlertedPatrol;
		private CHandle<VendorRegisterBlackBoardDef> _vendorRegister;
		private CHandle<AIFollowSlotDef> _aIFollowSlot;
		private CHandle<AIActionBossDataDef> _aIActionBossData;
		private CHandle<UI_SystemDef> _uI_System;
		private CHandle<UI_ActiveVehicleDataDef> _uI_ActiveVehicleData;
		private CHandle<UIWorldBoundariesDef> _uIWorldBoundaries;
		private CHandle<UI_PlayerStatsDef> _uI_PlayerStats;
		private CHandle<UI_EquipmentDataDef> _uI_EquipmentData;
		private CHandle<UI_PlayerBioMonitorDef> _uI_PlayerBioMonitor;
		private CHandle<FastTRavelSystemDef> _fastTRavelSystem;
		private CHandle<UI_ComDeviceDef> _uI_ComDevice;
		private CHandle<UI_ScannerDef> _uI_Scanner;
		private CHandle<UI_ScannerModulesDef> _uI_ScannerModules;
		private CHandle<UI_WantedBarDef> _uI_WantedBar;
		private CHandle<UI_FastForwardDef> _uI_FastForward;
		private CHandle<UI_HUDProgressBarDef> _uI_HUDProgressBar;
		private CHandle<UI_HUDSignalProgressBarDef> _uI_HUDSignalProgressBar;
		private CHandle<UI_HotkeysDef> _uI_Hotkeys;
		private CHandle<DeviceBaseBlackboardDef> _deviceBaseBlackboard;
		private CHandle<TVDeviceBlackboardDef> _tVDeviceBlackboard;
		private CHandle<ArcadeMachineBlackboardDef> _arcadeMachineBlackBoard;
		private CHandle<LcdScreenBlackBoardDef> _lcdScreenBlackBoard;
		private CHandle<NcartTimetableBlackboardDef> _ncartTimetableBlackboard;
		private CHandle<IntercomBlackboardDef> _intercomBlackboard;
		private CHandle<ElevatorDeviceBlackboardDef> _elevatorDeviceBlackboard;
		private CHandle<VendingMachineDeviceBlackboardDef> _vendingMachineDeviceBlackboard;
		private CHandle<InteractiveDeviceBlackboardDef> _interactiveDeviceBlackboard;
		private CHandle<MasterDeviceBaseBlackboardDef> _masterDeviceBaseBlackboard;
		private CHandle<ComputerDeviceBlackboardDef> _computerDeviceBlackboard;
		private CHandle<DataTermDeviceBlackboardDef> _dataTermDeviceBlackboard;
		private CHandle<NetworkBlackboardDef> _networkBlackboard;
		private CHandle<StorageBlackboardDef> _storageBlackboard;
		private CHandle<BackDoorDeviceBlackboardDef> _backdoorBlackboard;
		private CHandle<ConfessionalBlackboardDef> _confessionalBlackboard;
		private CHandle<JukeboxBlackboardDef> _jukeboxBlackboard;
		private CHandle<MenuEventBlackboardDef> _menuEventBlackboard;
		private CHandle<UI_NPCNextToTheCrosshairDef> _uI_NPCNextToTheCrosshair;
		private CHandle<UI_NameplateDataDef> _uI_NameplateData;
		private CHandle<UI_DamageInfoDef> _uI_DamageInfo;
		private CHandle<UI_InterfaceOptionsDef> _uI_InterfaceOptions;
		private CHandle<UI_CompassInfoDef> _uI_CompassInfo;
		private CHandle<UI_ActiveWeaponDataDef> _uI_ActiveWeaponData;
		private CHandle<UI_TargetingInfoDef> _uI_TargetingInfo;
		private CHandle<UI_NotificationsDef> _uI_Notifications;
		private CHandle<LeftHandCyberwareDataDef> _leftHandCyberware;
		private CHandle<CoverActionDataDef> _coverAction;
		private CHandle<UI_QuickSlotsDataDef> _uI_QuickSlotsData;
		private CHandle<UI_VisionModeDef> _uI_VisionMode;
		private CHandle<UI_HudTooltipDef> _uI_HudTooltip;
		private CHandle<UI_HudButtonHelpDef> _uI_HudButtonHelp;
		private CHandle<UI_ActivityLogDef> _uI_ActivityLog;
		private CHandle<UI_LevelUpDef> _uI_LevelUp;
		private CHandle<UI_VendorDef> _uI_Vendor;
		private CHandle<UI_BriefingDef> _uI_Briefing;
		private CHandle<UI_ItemModSystemDef> _uI_ItemModSystem;
		private CHandle<UI_CodexSystemDef> _uI_CodexSystem;
		private CHandle<UI_EquipmentDef> _uI_Equipment;
		private CHandle<UI_CraftingDef> _uI_Crafting;
		private CHandle<UI_MapDef> _uI_Map;
		private CHandle<UI_CpoCharacterSelectionDef> _uI_CpoCharacterSelection;
		private CHandle<UI_ChatBoxDef> _uI_ChatBox;
		private CHandle<UI_HUDNarrationLogDef> _uI_HUDNarrationLog;
		private CHandle<UI_NarrativePlateDef> _uI_NarrativePlate;
		private CHandle<UI_CrosshairDef> _uI_Crosshair;
		private CHandle<UI_ItemLogDef> _uI_ItemLog;
		private CHandle<UI_HUDButtonHintDef> _uI_HUDButtonHints;
		private CHandle<UI_CompanionDef> _uI_Companion;
		private CHandle<UI_CustomQuestNotificationDef> _uI_CustomQuestNotification;
		private CHandle<HUDManagerDef> _hUD_Manager;
		private CHandle<UI_HackingDef> _uI_Hacking;
		private CHandle<UI_StealthDef> _uI_Stealth;
		private CHandle<UI_TopbarHubMenuDef> _uI_TopbarHubMenu;
		private CHandle<LocalPlayerDef> _uI_LocalPlayer;
		private CHandle<UI_SceneScreenDef> _uI_SceneScreen;
		private CHandle<UI_PointOfNoReturnRewardScreenDef> _uI_PointOfNoReturnRewardScreen;
		private CHandle<CombatGadgetDataDef> _combatGadget;
		private CHandle<MinesDataDef> _mines;
		private CHandle<DebugDataDef> _debugData;
		private CHandle<DeviceDebugDef> _deviceDebug;
		private CHandle<CustomCentaurBlackboardDef> _customCentaurBlackboard;
		private CHandle<CW_MuteArmDef> _cW_MuteArm;
		private CHandle<PhotoModeDef> _photoMode;
		private CHandle<GameplaySettingsDef> _gameplaySettings;

		[Ordinal(0)] 
		[RED("PlayerStateMachine")] 
		public CHandle<PlayerStateMachineDef> PlayerStateMachine
		{
			get => GetProperty(ref _playerStateMachine);
			set => SetProperty(ref _playerStateMachine, value);
		}

		[Ordinal(1)] 
		[RED("PlayerPerkData")] 
		public CHandle<PlayerPerkDataDef> PlayerPerkData
		{
			get => GetProperty(ref _playerPerkData);
			set => SetProperty(ref _playerPerkData, value);
		}

		[Ordinal(2)] 
		[RED("PlayerQuickHackData")] 
		public CHandle<PlayerQuickHackDataDef> PlayerQuickHackData
		{
			get => GetProperty(ref _playerQuickHackData);
			set => SetProperty(ref _playerQuickHackData, value);
		}

		[Ordinal(3)] 
		[RED("EffectSharedData")] 
		public CHandle<EffectSharedDataDef> EffectSharedData
		{
			get => GetProperty(ref _effectSharedData);
			set => SetProperty(ref _effectSharedData, value);
		}

		[Ordinal(4)] 
		[RED("FollowNPC")] 
		public CHandle<FollowNPCDef> FollowNPC
		{
			get => GetProperty(ref _followNPC);
			set => SetProperty(ref _followNPC, value);
		}

		[Ordinal(5)] 
		[RED("AISquadBlackBoard")] 
		public CHandle<AISquadBlackBoardDef> AISquadBlackBoard
		{
			get => GetProperty(ref _aISquadBlackBoard);
			set => SetProperty(ref _aISquadBlackBoard, value);
		}

		[Ordinal(6)] 
		[RED("Puppet")] 
		public CHandle<PuppetDef> Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(7)] 
		[RED("PuppetState")] 
		public CHandle<PuppetStateDef> PuppetState
		{
			get => GetProperty(ref _puppetState);
			set => SetProperty(ref _puppetState, value);
		}

		[Ordinal(8)] 
		[RED("PuppetReaction")] 
		public CHandle<PuppetReactionDef> PuppetReaction
		{
			get => GetProperty(ref _puppetReaction);
			set => SetProperty(ref _puppetReaction, value);
		}

		[Ordinal(9)] 
		[RED("LocalPlayer")] 
		public CHandle<PuppetReactionDef> LocalPlayer
		{
			get => GetProperty(ref _localPlayer);
			set => SetProperty(ref _localPlayer, value);
		}

		[Ordinal(10)] 
		[RED("UIGameData")] 
		public CHandle<UIGameDataDef> UIGameData
		{
			get => GetProperty(ref _uIGameData);
			set => SetProperty(ref _uIGameData, value);
		}

		[Ordinal(11)] 
		[RED("UIInteractions")] 
		public CHandle<UIInteractionsDef> UIInteractions
		{
			get => GetProperty(ref _uIInteractions);
			set => SetProperty(ref _uIInteractions, value);
		}

		[Ordinal(12)] 
		[RED("Weapon")] 
		public CHandle<WeaponDataDef> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(13)] 
		[RED("DeviceTakeControl")] 
		public CHandle<DeviceTakeControlDef> DeviceTakeControl
		{
			get => GetProperty(ref _deviceTakeControl);
			set => SetProperty(ref _deviceTakeControl, value);
		}

		[Ordinal(14)] 
		[RED("TaggedObjectsList")] 
		public CHandle<TaggedObjectsListDef> TaggedObjectsList
		{
			get => GetProperty(ref _taggedObjectsList);
			set => SetProperty(ref _taggedObjectsList, value);
		}

		[Ordinal(15)] 
		[RED("AdHocAnimation")] 
		public CHandle<AdHocAnimationDef> AdHocAnimation
		{
			get => GetProperty(ref _adHocAnimation);
			set => SetProperty(ref _adHocAnimation, value);
		}

		[Ordinal(16)] 
		[RED("QuickMeleeData")] 
		public CHandle<QuickMeleeDataDef> QuickMeleeData
		{
			get => GetProperty(ref _quickMeleeData);
			set => SetProperty(ref _quickMeleeData, value);
		}

		[Ordinal(17)] 
		[RED("Vehicle")] 
		public CHandle<VehicleDef> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(18)] 
		[RED("VehicleSummonData")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonData
		{
			get => GetProperty(ref _vehicleSummonData);
			set => SetProperty(ref _vehicleSummonData, value);
		}

		[Ordinal(19)] 
		[RED("Braindance")] 
		public CHandle<BraindanceBlackboardDef> Braindance
		{
			get => GetProperty(ref _braindance);
			set => SetProperty(ref _braindance, value);
		}

		[Ordinal(20)] 
		[RED("HackingMinigame")] 
		public CHandle<HackingMinigameDef> HackingMinigame
		{
			get => GetProperty(ref _hackingMinigame);
			set => SetProperty(ref _hackingMinigame, value);
		}

		[Ordinal(21)] 
		[RED("HackingData")] 
		public CHandle<HackingDataDef> HackingData
		{
			get => GetProperty(ref _hackingData);
			set => SetProperty(ref _hackingData, value);
		}

		[Ordinal(22)] 
		[RED("AIShooting")] 
		public CHandle<AIShootingDataDef> AIShooting
		{
			get => GetProperty(ref _aIShooting);
			set => SetProperty(ref _aIShooting, value);
		}

		[Ordinal(23)] 
		[RED("AICover")] 
		public CHandle<AICoverDataDef> AICover
		{
			get => GetProperty(ref _aICover);
			set => SetProperty(ref _aICover, value);
		}

		[Ordinal(24)] 
		[RED("AIAction")] 
		public CHandle<AIActionDataDef> AIAction
		{
			get => GetProperty(ref _aIAction);
			set => SetProperty(ref _aIAction, value);
		}

		[Ordinal(25)] 
		[RED("AIPatrol")] 
		public CHandle<AIPatrolDef> AIPatrol
		{
			get => GetProperty(ref _aIPatrol);
			set => SetProperty(ref _aIPatrol, value);
		}

		[Ordinal(26)] 
		[RED("AIAlertedPatrol")] 
		public CHandle<AIAlertedPatrolDef> AIAlertedPatrol
		{
			get => GetProperty(ref _aIAlertedPatrol);
			set => SetProperty(ref _aIAlertedPatrol, value);
		}

		[Ordinal(27)] 
		[RED("VendorRegister")] 
		public CHandle<VendorRegisterBlackBoardDef> VendorRegister
		{
			get => GetProperty(ref _vendorRegister);
			set => SetProperty(ref _vendorRegister, value);
		}

		[Ordinal(28)] 
		[RED("AIFollowSlot")] 
		public CHandle<AIFollowSlotDef> AIFollowSlot
		{
			get => GetProperty(ref _aIFollowSlot);
			set => SetProperty(ref _aIFollowSlot, value);
		}

		[Ordinal(29)] 
		[RED("AIActionBossData")] 
		public CHandle<AIActionBossDataDef> AIActionBossData
		{
			get => GetProperty(ref _aIActionBossData);
			set => SetProperty(ref _aIActionBossData, value);
		}

		[Ordinal(30)] 
		[RED("UI_System")] 
		public CHandle<UI_SystemDef> UI_System
		{
			get => GetProperty(ref _uI_System);
			set => SetProperty(ref _uI_System, value);
		}

		[Ordinal(31)] 
		[RED("UI_ActiveVehicleData")] 
		public CHandle<UI_ActiveVehicleDataDef> UI_ActiveVehicleData
		{
			get => GetProperty(ref _uI_ActiveVehicleData);
			set => SetProperty(ref _uI_ActiveVehicleData, value);
		}

		[Ordinal(32)] 
		[RED("UIWorldBoundaries")] 
		public CHandle<UIWorldBoundariesDef> UIWorldBoundaries
		{
			get => GetProperty(ref _uIWorldBoundaries);
			set => SetProperty(ref _uIWorldBoundaries, value);
		}

		[Ordinal(33)] 
		[RED("UI_PlayerStats")] 
		public CHandle<UI_PlayerStatsDef> UI_PlayerStats
		{
			get => GetProperty(ref _uI_PlayerStats);
			set => SetProperty(ref _uI_PlayerStats, value);
		}

		[Ordinal(34)] 
		[RED("UI_EquipmentData")] 
		public CHandle<UI_EquipmentDataDef> UI_EquipmentData
		{
			get => GetProperty(ref _uI_EquipmentData);
			set => SetProperty(ref _uI_EquipmentData, value);
		}

		[Ordinal(35)] 
		[RED("UI_PlayerBioMonitor")] 
		public CHandle<UI_PlayerBioMonitorDef> UI_PlayerBioMonitor
		{
			get => GetProperty(ref _uI_PlayerBioMonitor);
			set => SetProperty(ref _uI_PlayerBioMonitor, value);
		}

		[Ordinal(36)] 
		[RED("FastTRavelSystem")] 
		public CHandle<FastTRavelSystemDef> FastTRavelSystem
		{
			get => GetProperty(ref _fastTRavelSystem);
			set => SetProperty(ref _fastTRavelSystem, value);
		}

		[Ordinal(37)] 
		[RED("UI_ComDevice")] 
		public CHandle<UI_ComDeviceDef> UI_ComDevice
		{
			get => GetProperty(ref _uI_ComDevice);
			set => SetProperty(ref _uI_ComDevice, value);
		}

		[Ordinal(38)] 
		[RED("UI_Scanner")] 
		public CHandle<UI_ScannerDef> UI_Scanner
		{
			get => GetProperty(ref _uI_Scanner);
			set => SetProperty(ref _uI_Scanner, value);
		}

		[Ordinal(39)] 
		[RED("UI_ScannerModules")] 
		public CHandle<UI_ScannerModulesDef> UI_ScannerModules
		{
			get => GetProperty(ref _uI_ScannerModules);
			set => SetProperty(ref _uI_ScannerModules, value);
		}

		[Ordinal(40)] 
		[RED("UI_WantedBar")] 
		public CHandle<UI_WantedBarDef> UI_WantedBar
		{
			get => GetProperty(ref _uI_WantedBar);
			set => SetProperty(ref _uI_WantedBar, value);
		}

		[Ordinal(41)] 
		[RED("UI_FastForward")] 
		public CHandle<UI_FastForwardDef> UI_FastForward
		{
			get => GetProperty(ref _uI_FastForward);
			set => SetProperty(ref _uI_FastForward, value);
		}

		[Ordinal(42)] 
		[RED("UI_HUDProgressBar")] 
		public CHandle<UI_HUDProgressBarDef> UI_HUDProgressBar
		{
			get => GetProperty(ref _uI_HUDProgressBar);
			set => SetProperty(ref _uI_HUDProgressBar, value);
		}

		[Ordinal(43)] 
		[RED("UI_HUDSignalProgressBar")] 
		public CHandle<UI_HUDSignalProgressBarDef> UI_HUDSignalProgressBar
		{
			get => GetProperty(ref _uI_HUDSignalProgressBar);
			set => SetProperty(ref _uI_HUDSignalProgressBar, value);
		}

		[Ordinal(44)] 
		[RED("UI_Hotkeys")] 
		public CHandle<UI_HotkeysDef> UI_Hotkeys
		{
			get => GetProperty(ref _uI_Hotkeys);
			set => SetProperty(ref _uI_Hotkeys, value);
		}

		[Ordinal(45)] 
		[RED("DeviceBaseBlackboard")] 
		public CHandle<DeviceBaseBlackboardDef> DeviceBaseBlackboard
		{
			get => GetProperty(ref _deviceBaseBlackboard);
			set => SetProperty(ref _deviceBaseBlackboard, value);
		}

		[Ordinal(46)] 
		[RED("TVDeviceBlackboard")] 
		public CHandle<TVDeviceBlackboardDef> TVDeviceBlackboard
		{
			get => GetProperty(ref _tVDeviceBlackboard);
			set => SetProperty(ref _tVDeviceBlackboard, value);
		}

		[Ordinal(47)] 
		[RED("ArcadeMachineBlackBoard")] 
		public CHandle<ArcadeMachineBlackboardDef> ArcadeMachineBlackBoard
		{
			get => GetProperty(ref _arcadeMachineBlackBoard);
			set => SetProperty(ref _arcadeMachineBlackBoard, value);
		}

		[Ordinal(48)] 
		[RED("LcdScreenBlackBoard")] 
		public CHandle<LcdScreenBlackBoardDef> LcdScreenBlackBoard
		{
			get => GetProperty(ref _lcdScreenBlackBoard);
			set => SetProperty(ref _lcdScreenBlackBoard, value);
		}

		[Ordinal(49)] 
		[RED("NcartTimetableBlackboard")] 
		public CHandle<NcartTimetableBlackboardDef> NcartTimetableBlackboard
		{
			get => GetProperty(ref _ncartTimetableBlackboard);
			set => SetProperty(ref _ncartTimetableBlackboard, value);
		}

		[Ordinal(50)] 
		[RED("IntercomBlackboard")] 
		public CHandle<IntercomBlackboardDef> IntercomBlackboard
		{
			get => GetProperty(ref _intercomBlackboard);
			set => SetProperty(ref _intercomBlackboard, value);
		}

		[Ordinal(51)] 
		[RED("ElevatorDeviceBlackboard")] 
		public CHandle<ElevatorDeviceBlackboardDef> ElevatorDeviceBlackboard
		{
			get => GetProperty(ref _elevatorDeviceBlackboard);
			set => SetProperty(ref _elevatorDeviceBlackboard, value);
		}

		[Ordinal(52)] 
		[RED("VendingMachineDeviceBlackboard")] 
		public CHandle<VendingMachineDeviceBlackboardDef> VendingMachineDeviceBlackboard
		{
			get => GetProperty(ref _vendingMachineDeviceBlackboard);
			set => SetProperty(ref _vendingMachineDeviceBlackboard, value);
		}

		[Ordinal(53)] 
		[RED("InteractiveDeviceBlackboard")] 
		public CHandle<InteractiveDeviceBlackboardDef> InteractiveDeviceBlackboard
		{
			get => GetProperty(ref _interactiveDeviceBlackboard);
			set => SetProperty(ref _interactiveDeviceBlackboard, value);
		}

		[Ordinal(54)] 
		[RED("MasterDeviceBaseBlackboard")] 
		public CHandle<MasterDeviceBaseBlackboardDef> MasterDeviceBaseBlackboard
		{
			get => GetProperty(ref _masterDeviceBaseBlackboard);
			set => SetProperty(ref _masterDeviceBaseBlackboard, value);
		}

		[Ordinal(55)] 
		[RED("ComputerDeviceBlackboard")] 
		public CHandle<ComputerDeviceBlackboardDef> ComputerDeviceBlackboard
		{
			get => GetProperty(ref _computerDeviceBlackboard);
			set => SetProperty(ref _computerDeviceBlackboard, value);
		}

		[Ordinal(56)] 
		[RED("DataTermDeviceBlackboard")] 
		public CHandle<DataTermDeviceBlackboardDef> DataTermDeviceBlackboard
		{
			get => GetProperty(ref _dataTermDeviceBlackboard);
			set => SetProperty(ref _dataTermDeviceBlackboard, value);
		}

		[Ordinal(57)] 
		[RED("NetworkBlackboard")] 
		public CHandle<NetworkBlackboardDef> NetworkBlackboard
		{
			get => GetProperty(ref _networkBlackboard);
			set => SetProperty(ref _networkBlackboard, value);
		}

		[Ordinal(58)] 
		[RED("StorageBlackboard")] 
		public CHandle<StorageBlackboardDef> StorageBlackboard
		{
			get => GetProperty(ref _storageBlackboard);
			set => SetProperty(ref _storageBlackboard, value);
		}

		[Ordinal(59)] 
		[RED("BackdoorBlackboard")] 
		public CHandle<BackDoorDeviceBlackboardDef> BackdoorBlackboard
		{
			get => GetProperty(ref _backdoorBlackboard);
			set => SetProperty(ref _backdoorBlackboard, value);
		}

		[Ordinal(60)] 
		[RED("ConfessionalBlackboard")] 
		public CHandle<ConfessionalBlackboardDef> ConfessionalBlackboard
		{
			get => GetProperty(ref _confessionalBlackboard);
			set => SetProperty(ref _confessionalBlackboard, value);
		}

		[Ordinal(61)] 
		[RED("JukeboxBlackboard")] 
		public CHandle<JukeboxBlackboardDef> JukeboxBlackboard
		{
			get => GetProperty(ref _jukeboxBlackboard);
			set => SetProperty(ref _jukeboxBlackboard, value);
		}

		[Ordinal(62)] 
		[RED("MenuEventBlackboard")] 
		public CHandle<MenuEventBlackboardDef> MenuEventBlackboard
		{
			get => GetProperty(ref _menuEventBlackboard);
			set => SetProperty(ref _menuEventBlackboard, value);
		}

		[Ordinal(63)] 
		[RED("UI_NPCNextToTheCrosshair")] 
		public CHandle<UI_NPCNextToTheCrosshairDef> UI_NPCNextToTheCrosshair
		{
			get => GetProperty(ref _uI_NPCNextToTheCrosshair);
			set => SetProperty(ref _uI_NPCNextToTheCrosshair, value);
		}

		[Ordinal(64)] 
		[RED("UI_NameplateData")] 
		public CHandle<UI_NameplateDataDef> UI_NameplateData
		{
			get => GetProperty(ref _uI_NameplateData);
			set => SetProperty(ref _uI_NameplateData, value);
		}

		[Ordinal(65)] 
		[RED("UI_DamageInfo")] 
		public CHandle<UI_DamageInfoDef> UI_DamageInfo
		{
			get => GetProperty(ref _uI_DamageInfo);
			set => SetProperty(ref _uI_DamageInfo, value);
		}

		[Ordinal(66)] 
		[RED("UI_InterfaceOptions")] 
		public CHandle<UI_InterfaceOptionsDef> UI_InterfaceOptions
		{
			get => GetProperty(ref _uI_InterfaceOptions);
			set => SetProperty(ref _uI_InterfaceOptions, value);
		}

		[Ordinal(67)] 
		[RED("UI_CompassInfo")] 
		public CHandle<UI_CompassInfoDef> UI_CompassInfo
		{
			get => GetProperty(ref _uI_CompassInfo);
			set => SetProperty(ref _uI_CompassInfo, value);
		}

		[Ordinal(68)] 
		[RED("UI_ActiveWeaponData")] 
		public CHandle<UI_ActiveWeaponDataDef> UI_ActiveWeaponData
		{
			get => GetProperty(ref _uI_ActiveWeaponData);
			set => SetProperty(ref _uI_ActiveWeaponData, value);
		}

		[Ordinal(69)] 
		[RED("UI_TargetingInfo")] 
		public CHandle<UI_TargetingInfoDef> UI_TargetingInfo
		{
			get => GetProperty(ref _uI_TargetingInfo);
			set => SetProperty(ref _uI_TargetingInfo, value);
		}

		[Ordinal(70)] 
		[RED("UI_Notifications")] 
		public CHandle<UI_NotificationsDef> UI_Notifications
		{
			get => GetProperty(ref _uI_Notifications);
			set => SetProperty(ref _uI_Notifications, value);
		}

		[Ordinal(71)] 
		[RED("LeftHandCyberware")] 
		public CHandle<LeftHandCyberwareDataDef> LeftHandCyberware
		{
			get => GetProperty(ref _leftHandCyberware);
			set => SetProperty(ref _leftHandCyberware, value);
		}

		[Ordinal(72)] 
		[RED("CoverAction")] 
		public CHandle<CoverActionDataDef> CoverAction
		{
			get => GetProperty(ref _coverAction);
			set => SetProperty(ref _coverAction, value);
		}

		[Ordinal(73)] 
		[RED("UI_QuickSlotsData")] 
		public CHandle<UI_QuickSlotsDataDef> UI_QuickSlotsData
		{
			get => GetProperty(ref _uI_QuickSlotsData);
			set => SetProperty(ref _uI_QuickSlotsData, value);
		}

		[Ordinal(74)] 
		[RED("UI_VisionMode")] 
		public CHandle<UI_VisionModeDef> UI_VisionMode
		{
			get => GetProperty(ref _uI_VisionMode);
			set => SetProperty(ref _uI_VisionMode, value);
		}

		[Ordinal(75)] 
		[RED("UI_HudTooltip")] 
		public CHandle<UI_HudTooltipDef> UI_HudTooltip
		{
			get => GetProperty(ref _uI_HudTooltip);
			set => SetProperty(ref _uI_HudTooltip, value);
		}

		[Ordinal(76)] 
		[RED("UI_HudButtonHelp")] 
		public CHandle<UI_HudButtonHelpDef> UI_HudButtonHelp
		{
			get => GetProperty(ref _uI_HudButtonHelp);
			set => SetProperty(ref _uI_HudButtonHelp, value);
		}

		[Ordinal(77)] 
		[RED("UI_ActivityLog")] 
		public CHandle<UI_ActivityLogDef> UI_ActivityLog
		{
			get => GetProperty(ref _uI_ActivityLog);
			set => SetProperty(ref _uI_ActivityLog, value);
		}

		[Ordinal(78)] 
		[RED("UI_LevelUp")] 
		public CHandle<UI_LevelUpDef> UI_LevelUp
		{
			get => GetProperty(ref _uI_LevelUp);
			set => SetProperty(ref _uI_LevelUp, value);
		}

		[Ordinal(79)] 
		[RED("UI_Vendor")] 
		public CHandle<UI_VendorDef> UI_Vendor
		{
			get => GetProperty(ref _uI_Vendor);
			set => SetProperty(ref _uI_Vendor, value);
		}

		[Ordinal(80)] 
		[RED("UI_Briefing")] 
		public CHandle<UI_BriefingDef> UI_Briefing
		{
			get => GetProperty(ref _uI_Briefing);
			set => SetProperty(ref _uI_Briefing, value);
		}

		[Ordinal(81)] 
		[RED("UI_ItemModSystem")] 
		public CHandle<UI_ItemModSystemDef> UI_ItemModSystem
		{
			get => GetProperty(ref _uI_ItemModSystem);
			set => SetProperty(ref _uI_ItemModSystem, value);
		}

		[Ordinal(82)] 
		[RED("UI_CodexSystem")] 
		public CHandle<UI_CodexSystemDef> UI_CodexSystem
		{
			get => GetProperty(ref _uI_CodexSystem);
			set => SetProperty(ref _uI_CodexSystem, value);
		}

		[Ordinal(83)] 
		[RED("UI_Equipment")] 
		public CHandle<UI_EquipmentDef> UI_Equipment
		{
			get => GetProperty(ref _uI_Equipment);
			set => SetProperty(ref _uI_Equipment, value);
		}

		[Ordinal(84)] 
		[RED("UI_Crafting")] 
		public CHandle<UI_CraftingDef> UI_Crafting
		{
			get => GetProperty(ref _uI_Crafting);
			set => SetProperty(ref _uI_Crafting, value);
		}

		[Ordinal(85)] 
		[RED("UI_Map")] 
		public CHandle<UI_MapDef> UI_Map
		{
			get => GetProperty(ref _uI_Map);
			set => SetProperty(ref _uI_Map, value);
		}

		[Ordinal(86)] 
		[RED("UI_CpoCharacterSelection")] 
		public CHandle<UI_CpoCharacterSelectionDef> UI_CpoCharacterSelection
		{
			get => GetProperty(ref _uI_CpoCharacterSelection);
			set => SetProperty(ref _uI_CpoCharacterSelection, value);
		}

		[Ordinal(87)] 
		[RED("UI_ChatBox")] 
		public CHandle<UI_ChatBoxDef> UI_ChatBox
		{
			get => GetProperty(ref _uI_ChatBox);
			set => SetProperty(ref _uI_ChatBox, value);
		}

		[Ordinal(88)] 
		[RED("UI_HUDNarrationLog")] 
		public CHandle<UI_HUDNarrationLogDef> UI_HUDNarrationLog
		{
			get => GetProperty(ref _uI_HUDNarrationLog);
			set => SetProperty(ref _uI_HUDNarrationLog, value);
		}

		[Ordinal(89)] 
		[RED("UI_NarrativePlate")] 
		public CHandle<UI_NarrativePlateDef> UI_NarrativePlate
		{
			get => GetProperty(ref _uI_NarrativePlate);
			set => SetProperty(ref _uI_NarrativePlate, value);
		}

		[Ordinal(90)] 
		[RED("UI_Crosshair")] 
		public CHandle<UI_CrosshairDef> UI_Crosshair
		{
			get => GetProperty(ref _uI_Crosshair);
			set => SetProperty(ref _uI_Crosshair, value);
		}

		[Ordinal(91)] 
		[RED("UI_ItemLog")] 
		public CHandle<UI_ItemLogDef> UI_ItemLog
		{
			get => GetProperty(ref _uI_ItemLog);
			set => SetProperty(ref _uI_ItemLog, value);
		}

		[Ordinal(92)] 
		[RED("UI_HUDButtonHints")] 
		public CHandle<UI_HUDButtonHintDef> UI_HUDButtonHints
		{
			get => GetProperty(ref _uI_HUDButtonHints);
			set => SetProperty(ref _uI_HUDButtonHints, value);
		}

		[Ordinal(93)] 
		[RED("UI_Companion")] 
		public CHandle<UI_CompanionDef> UI_Companion
		{
			get => GetProperty(ref _uI_Companion);
			set => SetProperty(ref _uI_Companion, value);
		}

		[Ordinal(94)] 
		[RED("UI_CustomQuestNotification")] 
		public CHandle<UI_CustomQuestNotificationDef> UI_CustomQuestNotification
		{
			get => GetProperty(ref _uI_CustomQuestNotification);
			set => SetProperty(ref _uI_CustomQuestNotification, value);
		}

		[Ordinal(95)] 
		[RED("HUD_Manager")] 
		public CHandle<HUDManagerDef> HUD_Manager
		{
			get => GetProperty(ref _hUD_Manager);
			set => SetProperty(ref _hUD_Manager, value);
		}

		[Ordinal(96)] 
		[RED("UI_Hacking")] 
		public CHandle<UI_HackingDef> UI_Hacking
		{
			get => GetProperty(ref _uI_Hacking);
			set => SetProperty(ref _uI_Hacking, value);
		}

		[Ordinal(97)] 
		[RED("UI_Stealth")] 
		public CHandle<UI_StealthDef> UI_Stealth
		{
			get => GetProperty(ref _uI_Stealth);
			set => SetProperty(ref _uI_Stealth, value);
		}

		[Ordinal(98)] 
		[RED("UI_TopbarHubMenu")] 
		public CHandle<UI_TopbarHubMenuDef> UI_TopbarHubMenu
		{
			get => GetProperty(ref _uI_TopbarHubMenu);
			set => SetProperty(ref _uI_TopbarHubMenu, value);
		}

		[Ordinal(99)] 
		[RED("UI_LocalPlayer")] 
		public CHandle<LocalPlayerDef> UI_LocalPlayer
		{
			get => GetProperty(ref _uI_LocalPlayer);
			set => SetProperty(ref _uI_LocalPlayer, value);
		}

		[Ordinal(100)] 
		[RED("UI_SceneScreen")] 
		public CHandle<UI_SceneScreenDef> UI_SceneScreen
		{
			get => GetProperty(ref _uI_SceneScreen);
			set => SetProperty(ref _uI_SceneScreen, value);
		}

		[Ordinal(101)] 
		[RED("UI_PointOfNoReturnRewardScreen")] 
		public CHandle<UI_PointOfNoReturnRewardScreenDef> UI_PointOfNoReturnRewardScreen
		{
			get => GetProperty(ref _uI_PointOfNoReturnRewardScreen);
			set => SetProperty(ref _uI_PointOfNoReturnRewardScreen, value);
		}

		[Ordinal(102)] 
		[RED("CombatGadget")] 
		public CHandle<CombatGadgetDataDef> CombatGadget
		{
			get => GetProperty(ref _combatGadget);
			set => SetProperty(ref _combatGadget, value);
		}

		[Ordinal(103)] 
		[RED("Mines")] 
		public CHandle<MinesDataDef> Mines
		{
			get => GetProperty(ref _mines);
			set => SetProperty(ref _mines, value);
		}

		[Ordinal(104)] 
		[RED("DebugData")] 
		public CHandle<DebugDataDef> DebugData
		{
			get => GetProperty(ref _debugData);
			set => SetProperty(ref _debugData, value);
		}

		[Ordinal(105)] 
		[RED("DeviceDebug")] 
		public CHandle<DeviceDebugDef> DeviceDebug
		{
			get => GetProperty(ref _deviceDebug);
			set => SetProperty(ref _deviceDebug, value);
		}

		[Ordinal(106)] 
		[RED("CustomCentaurBlackboard")] 
		public CHandle<CustomCentaurBlackboardDef> CustomCentaurBlackboard
		{
			get => GetProperty(ref _customCentaurBlackboard);
			set => SetProperty(ref _customCentaurBlackboard, value);
		}

		[Ordinal(107)] 
		[RED("CW_MuteArm")] 
		public CHandle<CW_MuteArmDef> CW_MuteArm
		{
			get => GetProperty(ref _cW_MuteArm);
			set => SetProperty(ref _cW_MuteArm, value);
		}

		[Ordinal(108)] 
		[RED("PhotoMode")] 
		public CHandle<PhotoModeDef> PhotoMode
		{
			get => GetProperty(ref _photoMode);
			set => SetProperty(ref _photoMode, value);
		}

		[Ordinal(109)] 
		[RED("GameplaySettings")] 
		public CHandle<GameplaySettingsDef> GameplaySettings
		{
			get => GetProperty(ref _gameplaySettings);
			set => SetProperty(ref _gameplaySettings, value);
		}
	}
}
