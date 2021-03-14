using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamebbAllScriptDefinitions : IScriptable
	{
		private CHandle<PlayerStateMachineDef> _playerStateMachine;
		private CHandle<PlayerPerkDataDef> _playerPerkData;
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
		private CHandle<SceneGameplayOverridesDef> _sceneGameplayOverrides;
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
			get
			{
				if (_playerStateMachine == null)
				{
					_playerStateMachine = (CHandle<PlayerStateMachineDef>) CR2WTypeManager.Create("handle:PlayerStateMachineDef", "PlayerStateMachine", cr2w, this);
				}
				return _playerStateMachine;
			}
			set
			{
				if (_playerStateMachine == value)
				{
					return;
				}
				_playerStateMachine = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("PlayerPerkData")] 
		public CHandle<PlayerPerkDataDef> PlayerPerkData
		{
			get
			{
				if (_playerPerkData == null)
				{
					_playerPerkData = (CHandle<PlayerPerkDataDef>) CR2WTypeManager.Create("handle:PlayerPerkDataDef", "PlayerPerkData", cr2w, this);
				}
				return _playerPerkData;
			}
			set
			{
				if (_playerPerkData == value)
				{
					return;
				}
				_playerPerkData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("EffectSharedData")] 
		public CHandle<EffectSharedDataDef> EffectSharedData
		{
			get
			{
				if (_effectSharedData == null)
				{
					_effectSharedData = (CHandle<EffectSharedDataDef>) CR2WTypeManager.Create("handle:EffectSharedDataDef", "EffectSharedData", cr2w, this);
				}
				return _effectSharedData;
			}
			set
			{
				if (_effectSharedData == value)
				{
					return;
				}
				_effectSharedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("FollowNPC")] 
		public CHandle<FollowNPCDef> FollowNPC
		{
			get
			{
				if (_followNPC == null)
				{
					_followNPC = (CHandle<FollowNPCDef>) CR2WTypeManager.Create("handle:FollowNPCDef", "FollowNPC", cr2w, this);
				}
				return _followNPC;
			}
			set
			{
				if (_followNPC == value)
				{
					return;
				}
				_followNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("AISquadBlackBoard")] 
		public CHandle<AISquadBlackBoardDef> AISquadBlackBoard
		{
			get
			{
				if (_aISquadBlackBoard == null)
				{
					_aISquadBlackBoard = (CHandle<AISquadBlackBoardDef>) CR2WTypeManager.Create("handle:AISquadBlackBoardDef", "AISquadBlackBoard", cr2w, this);
				}
				return _aISquadBlackBoard;
			}
			set
			{
				if (_aISquadBlackBoard == value)
				{
					return;
				}
				_aISquadBlackBoard = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("Puppet")] 
		public CHandle<PuppetDef> Puppet
		{
			get
			{
				if (_puppet == null)
				{
					_puppet = (CHandle<PuppetDef>) CR2WTypeManager.Create("handle:PuppetDef", "Puppet", cr2w, this);
				}
				return _puppet;
			}
			set
			{
				if (_puppet == value)
				{
					return;
				}
				_puppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("PuppetState")] 
		public CHandle<PuppetStateDef> PuppetState
		{
			get
			{
				if (_puppetState == null)
				{
					_puppetState = (CHandle<PuppetStateDef>) CR2WTypeManager.Create("handle:PuppetStateDef", "PuppetState", cr2w, this);
				}
				return _puppetState;
			}
			set
			{
				if (_puppetState == value)
				{
					return;
				}
				_puppetState = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("PuppetReaction")] 
		public CHandle<PuppetReactionDef> PuppetReaction
		{
			get
			{
				if (_puppetReaction == null)
				{
					_puppetReaction = (CHandle<PuppetReactionDef>) CR2WTypeManager.Create("handle:PuppetReactionDef", "PuppetReaction", cr2w, this);
				}
				return _puppetReaction;
			}
			set
			{
				if (_puppetReaction == value)
				{
					return;
				}
				_puppetReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("LocalPlayer")] 
		public CHandle<PuppetReactionDef> LocalPlayer
		{
			get
			{
				if (_localPlayer == null)
				{
					_localPlayer = (CHandle<PuppetReactionDef>) CR2WTypeManager.Create("handle:PuppetReactionDef", "LocalPlayer", cr2w, this);
				}
				return _localPlayer;
			}
			set
			{
				if (_localPlayer == value)
				{
					return;
				}
				_localPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("UIGameData")] 
		public CHandle<UIGameDataDef> UIGameData
		{
			get
			{
				if (_uIGameData == null)
				{
					_uIGameData = (CHandle<UIGameDataDef>) CR2WTypeManager.Create("handle:UIGameDataDef", "UIGameData", cr2w, this);
				}
				return _uIGameData;
			}
			set
			{
				if (_uIGameData == value)
				{
					return;
				}
				_uIGameData = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("UIInteractions")] 
		public CHandle<UIInteractionsDef> UIInteractions
		{
			get
			{
				if (_uIInteractions == null)
				{
					_uIInteractions = (CHandle<UIInteractionsDef>) CR2WTypeManager.Create("handle:UIInteractionsDef", "UIInteractions", cr2w, this);
				}
				return _uIInteractions;
			}
			set
			{
				if (_uIInteractions == value)
				{
					return;
				}
				_uIInteractions = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("Weapon")] 
		public CHandle<WeaponDataDef> Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (CHandle<WeaponDataDef>) CR2WTypeManager.Create("handle:WeaponDataDef", "Weapon", cr2w, this);
				}
				return _weapon;
			}
			set
			{
				if (_weapon == value)
				{
					return;
				}
				_weapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("DeviceTakeControl")] 
		public CHandle<DeviceTakeControlDef> DeviceTakeControl
		{
			get
			{
				if (_deviceTakeControl == null)
				{
					_deviceTakeControl = (CHandle<DeviceTakeControlDef>) CR2WTypeManager.Create("handle:DeviceTakeControlDef", "DeviceTakeControl", cr2w, this);
				}
				return _deviceTakeControl;
			}
			set
			{
				if (_deviceTakeControl == value)
				{
					return;
				}
				_deviceTakeControl = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("TaggedObjectsList")] 
		public CHandle<TaggedObjectsListDef> TaggedObjectsList
		{
			get
			{
				if (_taggedObjectsList == null)
				{
					_taggedObjectsList = (CHandle<TaggedObjectsListDef>) CR2WTypeManager.Create("handle:TaggedObjectsListDef", "TaggedObjectsList", cr2w, this);
				}
				return _taggedObjectsList;
			}
			set
			{
				if (_taggedObjectsList == value)
				{
					return;
				}
				_taggedObjectsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("AdHocAnimation")] 
		public CHandle<AdHocAnimationDef> AdHocAnimation
		{
			get
			{
				if (_adHocAnimation == null)
				{
					_adHocAnimation = (CHandle<AdHocAnimationDef>) CR2WTypeManager.Create("handle:AdHocAnimationDef", "AdHocAnimation", cr2w, this);
				}
				return _adHocAnimation;
			}
			set
			{
				if (_adHocAnimation == value)
				{
					return;
				}
				_adHocAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("QuickMeleeData")] 
		public CHandle<QuickMeleeDataDef> QuickMeleeData
		{
			get
			{
				if (_quickMeleeData == null)
				{
					_quickMeleeData = (CHandle<QuickMeleeDataDef>) CR2WTypeManager.Create("handle:QuickMeleeDataDef", "QuickMeleeData", cr2w, this);
				}
				return _quickMeleeData;
			}
			set
			{
				if (_quickMeleeData == value)
				{
					return;
				}
				_quickMeleeData = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("Vehicle")] 
		public CHandle<VehicleDef> Vehicle
		{
			get
			{
				if (_vehicle == null)
				{
					_vehicle = (CHandle<VehicleDef>) CR2WTypeManager.Create("handle:VehicleDef", "Vehicle", cr2w, this);
				}
				return _vehicle;
			}
			set
			{
				if (_vehicle == value)
				{
					return;
				}
				_vehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("VehicleSummonData")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonData
		{
			get
			{
				if (_vehicleSummonData == null)
				{
					_vehicleSummonData = (CHandle<VehicleSummonDataDef>) CR2WTypeManager.Create("handle:VehicleSummonDataDef", "VehicleSummonData", cr2w, this);
				}
				return _vehicleSummonData;
			}
			set
			{
				if (_vehicleSummonData == value)
				{
					return;
				}
				_vehicleSummonData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("SceneGameplayOverrides")] 
		public CHandle<SceneGameplayOverridesDef> SceneGameplayOverrides
		{
			get
			{
				if (_sceneGameplayOverrides == null)
				{
					_sceneGameplayOverrides = (CHandle<SceneGameplayOverridesDef>) CR2WTypeManager.Create("handle:SceneGameplayOverridesDef", "SceneGameplayOverrides", cr2w, this);
				}
				return _sceneGameplayOverrides;
			}
			set
			{
				if (_sceneGameplayOverrides == value)
				{
					return;
				}
				_sceneGameplayOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("Braindance")] 
		public CHandle<BraindanceBlackboardDef> Braindance
		{
			get
			{
				if (_braindance == null)
				{
					_braindance = (CHandle<BraindanceBlackboardDef>) CR2WTypeManager.Create("handle:BraindanceBlackboardDef", "Braindance", cr2w, this);
				}
				return _braindance;
			}
			set
			{
				if (_braindance == value)
				{
					return;
				}
				_braindance = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("HackingMinigame")] 
		public CHandle<HackingMinigameDef> HackingMinigame
		{
			get
			{
				if (_hackingMinigame == null)
				{
					_hackingMinigame = (CHandle<HackingMinigameDef>) CR2WTypeManager.Create("handle:HackingMinigameDef", "HackingMinigame", cr2w, this);
				}
				return _hackingMinigame;
			}
			set
			{
				if (_hackingMinigame == value)
				{
					return;
				}
				_hackingMinigame = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("HackingData")] 
		public CHandle<HackingDataDef> HackingData
		{
			get
			{
				if (_hackingData == null)
				{
					_hackingData = (CHandle<HackingDataDef>) CR2WTypeManager.Create("handle:HackingDataDef", "HackingData", cr2w, this);
				}
				return _hackingData;
			}
			set
			{
				if (_hackingData == value)
				{
					return;
				}
				_hackingData = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("AIShooting")] 
		public CHandle<AIShootingDataDef> AIShooting
		{
			get
			{
				if (_aIShooting == null)
				{
					_aIShooting = (CHandle<AIShootingDataDef>) CR2WTypeManager.Create("handle:AIShootingDataDef", "AIShooting", cr2w, this);
				}
				return _aIShooting;
			}
			set
			{
				if (_aIShooting == value)
				{
					return;
				}
				_aIShooting = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("AICover")] 
		public CHandle<AICoverDataDef> AICover
		{
			get
			{
				if (_aICover == null)
				{
					_aICover = (CHandle<AICoverDataDef>) CR2WTypeManager.Create("handle:AICoverDataDef", "AICover", cr2w, this);
				}
				return _aICover;
			}
			set
			{
				if (_aICover == value)
				{
					return;
				}
				_aICover = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("AIAction")] 
		public CHandle<AIActionDataDef> AIAction
		{
			get
			{
				if (_aIAction == null)
				{
					_aIAction = (CHandle<AIActionDataDef>) CR2WTypeManager.Create("handle:AIActionDataDef", "AIAction", cr2w, this);
				}
				return _aIAction;
			}
			set
			{
				if (_aIAction == value)
				{
					return;
				}
				_aIAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("AIPatrol")] 
		public CHandle<AIPatrolDef> AIPatrol
		{
			get
			{
				if (_aIPatrol == null)
				{
					_aIPatrol = (CHandle<AIPatrolDef>) CR2WTypeManager.Create("handle:AIPatrolDef", "AIPatrol", cr2w, this);
				}
				return _aIPatrol;
			}
			set
			{
				if (_aIPatrol == value)
				{
					return;
				}
				_aIPatrol = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("AIAlertedPatrol")] 
		public CHandle<AIAlertedPatrolDef> AIAlertedPatrol
		{
			get
			{
				if (_aIAlertedPatrol == null)
				{
					_aIAlertedPatrol = (CHandle<AIAlertedPatrolDef>) CR2WTypeManager.Create("handle:AIAlertedPatrolDef", "AIAlertedPatrol", cr2w, this);
				}
				return _aIAlertedPatrol;
			}
			set
			{
				if (_aIAlertedPatrol == value)
				{
					return;
				}
				_aIAlertedPatrol = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("VendorRegister")] 
		public CHandle<VendorRegisterBlackBoardDef> VendorRegister
		{
			get
			{
				if (_vendorRegister == null)
				{
					_vendorRegister = (CHandle<VendorRegisterBlackBoardDef>) CR2WTypeManager.Create("handle:VendorRegisterBlackBoardDef", "VendorRegister", cr2w, this);
				}
				return _vendorRegister;
			}
			set
			{
				if (_vendorRegister == value)
				{
					return;
				}
				_vendorRegister = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("AIFollowSlot")] 
		public CHandle<AIFollowSlotDef> AIFollowSlot
		{
			get
			{
				if (_aIFollowSlot == null)
				{
					_aIFollowSlot = (CHandle<AIFollowSlotDef>) CR2WTypeManager.Create("handle:AIFollowSlotDef", "AIFollowSlot", cr2w, this);
				}
				return _aIFollowSlot;
			}
			set
			{
				if (_aIFollowSlot == value)
				{
					return;
				}
				_aIFollowSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("AIActionBossData")] 
		public CHandle<AIActionBossDataDef> AIActionBossData
		{
			get
			{
				if (_aIActionBossData == null)
				{
					_aIActionBossData = (CHandle<AIActionBossDataDef>) CR2WTypeManager.Create("handle:AIActionBossDataDef", "AIActionBossData", cr2w, this);
				}
				return _aIActionBossData;
			}
			set
			{
				if (_aIActionBossData == value)
				{
					return;
				}
				_aIActionBossData = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("UI_System")] 
		public CHandle<UI_SystemDef> UI_System
		{
			get
			{
				if (_uI_System == null)
				{
					_uI_System = (CHandle<UI_SystemDef>) CR2WTypeManager.Create("handle:UI_SystemDef", "UI_System", cr2w, this);
				}
				return _uI_System;
			}
			set
			{
				if (_uI_System == value)
				{
					return;
				}
				_uI_System = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("UI_ActiveVehicleData")] 
		public CHandle<UI_ActiveVehicleDataDef> UI_ActiveVehicleData
		{
			get
			{
				if (_uI_ActiveVehicleData == null)
				{
					_uI_ActiveVehicleData = (CHandle<UI_ActiveVehicleDataDef>) CR2WTypeManager.Create("handle:UI_ActiveVehicleDataDef", "UI_ActiveVehicleData", cr2w, this);
				}
				return _uI_ActiveVehicleData;
			}
			set
			{
				if (_uI_ActiveVehicleData == value)
				{
					return;
				}
				_uI_ActiveVehicleData = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("UIWorldBoundaries")] 
		public CHandle<UIWorldBoundariesDef> UIWorldBoundaries
		{
			get
			{
				if (_uIWorldBoundaries == null)
				{
					_uIWorldBoundaries = (CHandle<UIWorldBoundariesDef>) CR2WTypeManager.Create("handle:UIWorldBoundariesDef", "UIWorldBoundaries", cr2w, this);
				}
				return _uIWorldBoundaries;
			}
			set
			{
				if (_uIWorldBoundaries == value)
				{
					return;
				}
				_uIWorldBoundaries = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("UI_PlayerStats")] 
		public CHandle<UI_PlayerStatsDef> UI_PlayerStats
		{
			get
			{
				if (_uI_PlayerStats == null)
				{
					_uI_PlayerStats = (CHandle<UI_PlayerStatsDef>) CR2WTypeManager.Create("handle:UI_PlayerStatsDef", "UI_PlayerStats", cr2w, this);
				}
				return _uI_PlayerStats;
			}
			set
			{
				if (_uI_PlayerStats == value)
				{
					return;
				}
				_uI_PlayerStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("UI_EquipmentData")] 
		public CHandle<UI_EquipmentDataDef> UI_EquipmentData
		{
			get
			{
				if (_uI_EquipmentData == null)
				{
					_uI_EquipmentData = (CHandle<UI_EquipmentDataDef>) CR2WTypeManager.Create("handle:UI_EquipmentDataDef", "UI_EquipmentData", cr2w, this);
				}
				return _uI_EquipmentData;
			}
			set
			{
				if (_uI_EquipmentData == value)
				{
					return;
				}
				_uI_EquipmentData = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("UI_PlayerBioMonitor")] 
		public CHandle<UI_PlayerBioMonitorDef> UI_PlayerBioMonitor
		{
			get
			{
				if (_uI_PlayerBioMonitor == null)
				{
					_uI_PlayerBioMonitor = (CHandle<UI_PlayerBioMonitorDef>) CR2WTypeManager.Create("handle:UI_PlayerBioMonitorDef", "UI_PlayerBioMonitor", cr2w, this);
				}
				return _uI_PlayerBioMonitor;
			}
			set
			{
				if (_uI_PlayerBioMonitor == value)
				{
					return;
				}
				_uI_PlayerBioMonitor = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("FastTRavelSystem")] 
		public CHandle<FastTRavelSystemDef> FastTRavelSystem
		{
			get
			{
				if (_fastTRavelSystem == null)
				{
					_fastTRavelSystem = (CHandle<FastTRavelSystemDef>) CR2WTypeManager.Create("handle:FastTRavelSystemDef", "FastTRavelSystem", cr2w, this);
				}
				return _fastTRavelSystem;
			}
			set
			{
				if (_fastTRavelSystem == value)
				{
					return;
				}
				_fastTRavelSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("UI_ComDevice")] 
		public CHandle<UI_ComDeviceDef> UI_ComDevice
		{
			get
			{
				if (_uI_ComDevice == null)
				{
					_uI_ComDevice = (CHandle<UI_ComDeviceDef>) CR2WTypeManager.Create("handle:UI_ComDeviceDef", "UI_ComDevice", cr2w, this);
				}
				return _uI_ComDevice;
			}
			set
			{
				if (_uI_ComDevice == value)
				{
					return;
				}
				_uI_ComDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("UI_Scanner")] 
		public CHandle<UI_ScannerDef> UI_Scanner
		{
			get
			{
				if (_uI_Scanner == null)
				{
					_uI_Scanner = (CHandle<UI_ScannerDef>) CR2WTypeManager.Create("handle:UI_ScannerDef", "UI_Scanner", cr2w, this);
				}
				return _uI_Scanner;
			}
			set
			{
				if (_uI_Scanner == value)
				{
					return;
				}
				_uI_Scanner = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("UI_ScannerModules")] 
		public CHandle<UI_ScannerModulesDef> UI_ScannerModules
		{
			get
			{
				if (_uI_ScannerModules == null)
				{
					_uI_ScannerModules = (CHandle<UI_ScannerModulesDef>) CR2WTypeManager.Create("handle:UI_ScannerModulesDef", "UI_ScannerModules", cr2w, this);
				}
				return _uI_ScannerModules;
			}
			set
			{
				if (_uI_ScannerModules == value)
				{
					return;
				}
				_uI_ScannerModules = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("UI_WantedBar")] 
		public CHandle<UI_WantedBarDef> UI_WantedBar
		{
			get
			{
				if (_uI_WantedBar == null)
				{
					_uI_WantedBar = (CHandle<UI_WantedBarDef>) CR2WTypeManager.Create("handle:UI_WantedBarDef", "UI_WantedBar", cr2w, this);
				}
				return _uI_WantedBar;
			}
			set
			{
				if (_uI_WantedBar == value)
				{
					return;
				}
				_uI_WantedBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("UI_FastForward")] 
		public CHandle<UI_FastForwardDef> UI_FastForward
		{
			get
			{
				if (_uI_FastForward == null)
				{
					_uI_FastForward = (CHandle<UI_FastForwardDef>) CR2WTypeManager.Create("handle:UI_FastForwardDef", "UI_FastForward", cr2w, this);
				}
				return _uI_FastForward;
			}
			set
			{
				if (_uI_FastForward == value)
				{
					return;
				}
				_uI_FastForward = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("UI_HUDProgressBar")] 
		public CHandle<UI_HUDProgressBarDef> UI_HUDProgressBar
		{
			get
			{
				if (_uI_HUDProgressBar == null)
				{
					_uI_HUDProgressBar = (CHandle<UI_HUDProgressBarDef>) CR2WTypeManager.Create("handle:UI_HUDProgressBarDef", "UI_HUDProgressBar", cr2w, this);
				}
				return _uI_HUDProgressBar;
			}
			set
			{
				if (_uI_HUDProgressBar == value)
				{
					return;
				}
				_uI_HUDProgressBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("UI_HUDSignalProgressBar")] 
		public CHandle<UI_HUDSignalProgressBarDef> UI_HUDSignalProgressBar
		{
			get
			{
				if (_uI_HUDSignalProgressBar == null)
				{
					_uI_HUDSignalProgressBar = (CHandle<UI_HUDSignalProgressBarDef>) CR2WTypeManager.Create("handle:UI_HUDSignalProgressBarDef", "UI_HUDSignalProgressBar", cr2w, this);
				}
				return _uI_HUDSignalProgressBar;
			}
			set
			{
				if (_uI_HUDSignalProgressBar == value)
				{
					return;
				}
				_uI_HUDSignalProgressBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("UI_Hotkeys")] 
		public CHandle<UI_HotkeysDef> UI_Hotkeys
		{
			get
			{
				if (_uI_Hotkeys == null)
				{
					_uI_Hotkeys = (CHandle<UI_HotkeysDef>) CR2WTypeManager.Create("handle:UI_HotkeysDef", "UI_Hotkeys", cr2w, this);
				}
				return _uI_Hotkeys;
			}
			set
			{
				if (_uI_Hotkeys == value)
				{
					return;
				}
				_uI_Hotkeys = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("DeviceBaseBlackboard")] 
		public CHandle<DeviceBaseBlackboardDef> DeviceBaseBlackboard
		{
			get
			{
				if (_deviceBaseBlackboard == null)
				{
					_deviceBaseBlackboard = (CHandle<DeviceBaseBlackboardDef>) CR2WTypeManager.Create("handle:DeviceBaseBlackboardDef", "DeviceBaseBlackboard", cr2w, this);
				}
				return _deviceBaseBlackboard;
			}
			set
			{
				if (_deviceBaseBlackboard == value)
				{
					return;
				}
				_deviceBaseBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("TVDeviceBlackboard")] 
		public CHandle<TVDeviceBlackboardDef> TVDeviceBlackboard
		{
			get
			{
				if (_tVDeviceBlackboard == null)
				{
					_tVDeviceBlackboard = (CHandle<TVDeviceBlackboardDef>) CR2WTypeManager.Create("handle:TVDeviceBlackboardDef", "TVDeviceBlackboard", cr2w, this);
				}
				return _tVDeviceBlackboard;
			}
			set
			{
				if (_tVDeviceBlackboard == value)
				{
					return;
				}
				_tVDeviceBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("ArcadeMachineBlackBoard")] 
		public CHandle<ArcadeMachineBlackboardDef> ArcadeMachineBlackBoard
		{
			get
			{
				if (_arcadeMachineBlackBoard == null)
				{
					_arcadeMachineBlackBoard = (CHandle<ArcadeMachineBlackboardDef>) CR2WTypeManager.Create("handle:ArcadeMachineBlackboardDef", "ArcadeMachineBlackBoard", cr2w, this);
				}
				return _arcadeMachineBlackBoard;
			}
			set
			{
				if (_arcadeMachineBlackBoard == value)
				{
					return;
				}
				_arcadeMachineBlackBoard = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("LcdScreenBlackBoard")] 
		public CHandle<LcdScreenBlackBoardDef> LcdScreenBlackBoard
		{
			get
			{
				if (_lcdScreenBlackBoard == null)
				{
					_lcdScreenBlackBoard = (CHandle<LcdScreenBlackBoardDef>) CR2WTypeManager.Create("handle:LcdScreenBlackBoardDef", "LcdScreenBlackBoard", cr2w, this);
				}
				return _lcdScreenBlackBoard;
			}
			set
			{
				if (_lcdScreenBlackBoard == value)
				{
					return;
				}
				_lcdScreenBlackBoard = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("NcartTimetableBlackboard")] 
		public CHandle<NcartTimetableBlackboardDef> NcartTimetableBlackboard
		{
			get
			{
				if (_ncartTimetableBlackboard == null)
				{
					_ncartTimetableBlackboard = (CHandle<NcartTimetableBlackboardDef>) CR2WTypeManager.Create("handle:NcartTimetableBlackboardDef", "NcartTimetableBlackboard", cr2w, this);
				}
				return _ncartTimetableBlackboard;
			}
			set
			{
				if (_ncartTimetableBlackboard == value)
				{
					return;
				}
				_ncartTimetableBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("IntercomBlackboard")] 
		public CHandle<IntercomBlackboardDef> IntercomBlackboard
		{
			get
			{
				if (_intercomBlackboard == null)
				{
					_intercomBlackboard = (CHandle<IntercomBlackboardDef>) CR2WTypeManager.Create("handle:IntercomBlackboardDef", "IntercomBlackboard", cr2w, this);
				}
				return _intercomBlackboard;
			}
			set
			{
				if (_intercomBlackboard == value)
				{
					return;
				}
				_intercomBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("ElevatorDeviceBlackboard")] 
		public CHandle<ElevatorDeviceBlackboardDef> ElevatorDeviceBlackboard
		{
			get
			{
				if (_elevatorDeviceBlackboard == null)
				{
					_elevatorDeviceBlackboard = (CHandle<ElevatorDeviceBlackboardDef>) CR2WTypeManager.Create("handle:ElevatorDeviceBlackboardDef", "ElevatorDeviceBlackboard", cr2w, this);
				}
				return _elevatorDeviceBlackboard;
			}
			set
			{
				if (_elevatorDeviceBlackboard == value)
				{
					return;
				}
				_elevatorDeviceBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("VendingMachineDeviceBlackboard")] 
		public CHandle<VendingMachineDeviceBlackboardDef> VendingMachineDeviceBlackboard
		{
			get
			{
				if (_vendingMachineDeviceBlackboard == null)
				{
					_vendingMachineDeviceBlackboard = (CHandle<VendingMachineDeviceBlackboardDef>) CR2WTypeManager.Create("handle:VendingMachineDeviceBlackboardDef", "VendingMachineDeviceBlackboard", cr2w, this);
				}
				return _vendingMachineDeviceBlackboard;
			}
			set
			{
				if (_vendingMachineDeviceBlackboard == value)
				{
					return;
				}
				_vendingMachineDeviceBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("InteractiveDeviceBlackboard")] 
		public CHandle<InteractiveDeviceBlackboardDef> InteractiveDeviceBlackboard
		{
			get
			{
				if (_interactiveDeviceBlackboard == null)
				{
					_interactiveDeviceBlackboard = (CHandle<InteractiveDeviceBlackboardDef>) CR2WTypeManager.Create("handle:InteractiveDeviceBlackboardDef", "InteractiveDeviceBlackboard", cr2w, this);
				}
				return _interactiveDeviceBlackboard;
			}
			set
			{
				if (_interactiveDeviceBlackboard == value)
				{
					return;
				}
				_interactiveDeviceBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("MasterDeviceBaseBlackboard")] 
		public CHandle<MasterDeviceBaseBlackboardDef> MasterDeviceBaseBlackboard
		{
			get
			{
				if (_masterDeviceBaseBlackboard == null)
				{
					_masterDeviceBaseBlackboard = (CHandle<MasterDeviceBaseBlackboardDef>) CR2WTypeManager.Create("handle:MasterDeviceBaseBlackboardDef", "MasterDeviceBaseBlackboard", cr2w, this);
				}
				return _masterDeviceBaseBlackboard;
			}
			set
			{
				if (_masterDeviceBaseBlackboard == value)
				{
					return;
				}
				_masterDeviceBaseBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("ComputerDeviceBlackboard")] 
		public CHandle<ComputerDeviceBlackboardDef> ComputerDeviceBlackboard
		{
			get
			{
				if (_computerDeviceBlackboard == null)
				{
					_computerDeviceBlackboard = (CHandle<ComputerDeviceBlackboardDef>) CR2WTypeManager.Create("handle:ComputerDeviceBlackboardDef", "ComputerDeviceBlackboard", cr2w, this);
				}
				return _computerDeviceBlackboard;
			}
			set
			{
				if (_computerDeviceBlackboard == value)
				{
					return;
				}
				_computerDeviceBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("DataTermDeviceBlackboard")] 
		public CHandle<DataTermDeviceBlackboardDef> DataTermDeviceBlackboard
		{
			get
			{
				if (_dataTermDeviceBlackboard == null)
				{
					_dataTermDeviceBlackboard = (CHandle<DataTermDeviceBlackboardDef>) CR2WTypeManager.Create("handle:DataTermDeviceBlackboardDef", "DataTermDeviceBlackboard", cr2w, this);
				}
				return _dataTermDeviceBlackboard;
			}
			set
			{
				if (_dataTermDeviceBlackboard == value)
				{
					return;
				}
				_dataTermDeviceBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("NetworkBlackboard")] 
		public CHandle<NetworkBlackboardDef> NetworkBlackboard
		{
			get
			{
				if (_networkBlackboard == null)
				{
					_networkBlackboard = (CHandle<NetworkBlackboardDef>) CR2WTypeManager.Create("handle:NetworkBlackboardDef", "NetworkBlackboard", cr2w, this);
				}
				return _networkBlackboard;
			}
			set
			{
				if (_networkBlackboard == value)
				{
					return;
				}
				_networkBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("StorageBlackboard")] 
		public CHandle<StorageBlackboardDef> StorageBlackboard
		{
			get
			{
				if (_storageBlackboard == null)
				{
					_storageBlackboard = (CHandle<StorageBlackboardDef>) CR2WTypeManager.Create("handle:StorageBlackboardDef", "StorageBlackboard", cr2w, this);
				}
				return _storageBlackboard;
			}
			set
			{
				if (_storageBlackboard == value)
				{
					return;
				}
				_storageBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("BackdoorBlackboard")] 
		public CHandle<BackDoorDeviceBlackboardDef> BackdoorBlackboard
		{
			get
			{
				if (_backdoorBlackboard == null)
				{
					_backdoorBlackboard = (CHandle<BackDoorDeviceBlackboardDef>) CR2WTypeManager.Create("handle:BackDoorDeviceBlackboardDef", "BackdoorBlackboard", cr2w, this);
				}
				return _backdoorBlackboard;
			}
			set
			{
				if (_backdoorBlackboard == value)
				{
					return;
				}
				_backdoorBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("ConfessionalBlackboard")] 
		public CHandle<ConfessionalBlackboardDef> ConfessionalBlackboard
		{
			get
			{
				if (_confessionalBlackboard == null)
				{
					_confessionalBlackboard = (CHandle<ConfessionalBlackboardDef>) CR2WTypeManager.Create("handle:ConfessionalBlackboardDef", "ConfessionalBlackboard", cr2w, this);
				}
				return _confessionalBlackboard;
			}
			set
			{
				if (_confessionalBlackboard == value)
				{
					return;
				}
				_confessionalBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("JukeboxBlackboard")] 
		public CHandle<JukeboxBlackboardDef> JukeboxBlackboard
		{
			get
			{
				if (_jukeboxBlackboard == null)
				{
					_jukeboxBlackboard = (CHandle<JukeboxBlackboardDef>) CR2WTypeManager.Create("handle:JukeboxBlackboardDef", "JukeboxBlackboard", cr2w, this);
				}
				return _jukeboxBlackboard;
			}
			set
			{
				if (_jukeboxBlackboard == value)
				{
					return;
				}
				_jukeboxBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("MenuEventBlackboard")] 
		public CHandle<MenuEventBlackboardDef> MenuEventBlackboard
		{
			get
			{
				if (_menuEventBlackboard == null)
				{
					_menuEventBlackboard = (CHandle<MenuEventBlackboardDef>) CR2WTypeManager.Create("handle:MenuEventBlackboardDef", "MenuEventBlackboard", cr2w, this);
				}
				return _menuEventBlackboard;
			}
			set
			{
				if (_menuEventBlackboard == value)
				{
					return;
				}
				_menuEventBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("UI_NPCNextToTheCrosshair")] 
		public CHandle<UI_NPCNextToTheCrosshairDef> UI_NPCNextToTheCrosshair
		{
			get
			{
				if (_uI_NPCNextToTheCrosshair == null)
				{
					_uI_NPCNextToTheCrosshair = (CHandle<UI_NPCNextToTheCrosshairDef>) CR2WTypeManager.Create("handle:UI_NPCNextToTheCrosshairDef", "UI_NPCNextToTheCrosshair", cr2w, this);
				}
				return _uI_NPCNextToTheCrosshair;
			}
			set
			{
				if (_uI_NPCNextToTheCrosshair == value)
				{
					return;
				}
				_uI_NPCNextToTheCrosshair = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("UI_NameplateData")] 
		public CHandle<UI_NameplateDataDef> UI_NameplateData
		{
			get
			{
				if (_uI_NameplateData == null)
				{
					_uI_NameplateData = (CHandle<UI_NameplateDataDef>) CR2WTypeManager.Create("handle:UI_NameplateDataDef", "UI_NameplateData", cr2w, this);
				}
				return _uI_NameplateData;
			}
			set
			{
				if (_uI_NameplateData == value)
				{
					return;
				}
				_uI_NameplateData = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("UI_DamageInfo")] 
		public CHandle<UI_DamageInfoDef> UI_DamageInfo
		{
			get
			{
				if (_uI_DamageInfo == null)
				{
					_uI_DamageInfo = (CHandle<UI_DamageInfoDef>) CR2WTypeManager.Create("handle:UI_DamageInfoDef", "UI_DamageInfo", cr2w, this);
				}
				return _uI_DamageInfo;
			}
			set
			{
				if (_uI_DamageInfo == value)
				{
					return;
				}
				_uI_DamageInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("UI_CompassInfo")] 
		public CHandle<UI_CompassInfoDef> UI_CompassInfo
		{
			get
			{
				if (_uI_CompassInfo == null)
				{
					_uI_CompassInfo = (CHandle<UI_CompassInfoDef>) CR2WTypeManager.Create("handle:UI_CompassInfoDef", "UI_CompassInfo", cr2w, this);
				}
				return _uI_CompassInfo;
			}
			set
			{
				if (_uI_CompassInfo == value)
				{
					return;
				}
				_uI_CompassInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("UI_ActiveWeaponData")] 
		public CHandle<UI_ActiveWeaponDataDef> UI_ActiveWeaponData
		{
			get
			{
				if (_uI_ActiveWeaponData == null)
				{
					_uI_ActiveWeaponData = (CHandle<UI_ActiveWeaponDataDef>) CR2WTypeManager.Create("handle:UI_ActiveWeaponDataDef", "UI_ActiveWeaponData", cr2w, this);
				}
				return _uI_ActiveWeaponData;
			}
			set
			{
				if (_uI_ActiveWeaponData == value)
				{
					return;
				}
				_uI_ActiveWeaponData = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("UI_TargetingInfo")] 
		public CHandle<UI_TargetingInfoDef> UI_TargetingInfo
		{
			get
			{
				if (_uI_TargetingInfo == null)
				{
					_uI_TargetingInfo = (CHandle<UI_TargetingInfoDef>) CR2WTypeManager.Create("handle:UI_TargetingInfoDef", "UI_TargetingInfo", cr2w, this);
				}
				return _uI_TargetingInfo;
			}
			set
			{
				if (_uI_TargetingInfo == value)
				{
					return;
				}
				_uI_TargetingInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("UI_Notifications")] 
		public CHandle<UI_NotificationsDef> UI_Notifications
		{
			get
			{
				if (_uI_Notifications == null)
				{
					_uI_Notifications = (CHandle<UI_NotificationsDef>) CR2WTypeManager.Create("handle:UI_NotificationsDef", "UI_Notifications", cr2w, this);
				}
				return _uI_Notifications;
			}
			set
			{
				if (_uI_Notifications == value)
				{
					return;
				}
				_uI_Notifications = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("LeftHandCyberware")] 
		public CHandle<LeftHandCyberwareDataDef> LeftHandCyberware
		{
			get
			{
				if (_leftHandCyberware == null)
				{
					_leftHandCyberware = (CHandle<LeftHandCyberwareDataDef>) CR2WTypeManager.Create("handle:LeftHandCyberwareDataDef", "LeftHandCyberware", cr2w, this);
				}
				return _leftHandCyberware;
			}
			set
			{
				if (_leftHandCyberware == value)
				{
					return;
				}
				_leftHandCyberware = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("CoverAction")] 
		public CHandle<CoverActionDataDef> CoverAction
		{
			get
			{
				if (_coverAction == null)
				{
					_coverAction = (CHandle<CoverActionDataDef>) CR2WTypeManager.Create("handle:CoverActionDataDef", "CoverAction", cr2w, this);
				}
				return _coverAction;
			}
			set
			{
				if (_coverAction == value)
				{
					return;
				}
				_coverAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("UI_QuickSlotsData")] 
		public CHandle<UI_QuickSlotsDataDef> UI_QuickSlotsData
		{
			get
			{
				if (_uI_QuickSlotsData == null)
				{
					_uI_QuickSlotsData = (CHandle<UI_QuickSlotsDataDef>) CR2WTypeManager.Create("handle:UI_QuickSlotsDataDef", "UI_QuickSlotsData", cr2w, this);
				}
				return _uI_QuickSlotsData;
			}
			set
			{
				if (_uI_QuickSlotsData == value)
				{
					return;
				}
				_uI_QuickSlotsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("UI_VisionMode")] 
		public CHandle<UI_VisionModeDef> UI_VisionMode
		{
			get
			{
				if (_uI_VisionMode == null)
				{
					_uI_VisionMode = (CHandle<UI_VisionModeDef>) CR2WTypeManager.Create("handle:UI_VisionModeDef", "UI_VisionMode", cr2w, this);
				}
				return _uI_VisionMode;
			}
			set
			{
				if (_uI_VisionMode == value)
				{
					return;
				}
				_uI_VisionMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("UI_HudTooltip")] 
		public CHandle<UI_HudTooltipDef> UI_HudTooltip
		{
			get
			{
				if (_uI_HudTooltip == null)
				{
					_uI_HudTooltip = (CHandle<UI_HudTooltipDef>) CR2WTypeManager.Create("handle:UI_HudTooltipDef", "UI_HudTooltip", cr2w, this);
				}
				return _uI_HudTooltip;
			}
			set
			{
				if (_uI_HudTooltip == value)
				{
					return;
				}
				_uI_HudTooltip = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("UI_HudButtonHelp")] 
		public CHandle<UI_HudButtonHelpDef> UI_HudButtonHelp
		{
			get
			{
				if (_uI_HudButtonHelp == null)
				{
					_uI_HudButtonHelp = (CHandle<UI_HudButtonHelpDef>) CR2WTypeManager.Create("handle:UI_HudButtonHelpDef", "UI_HudButtonHelp", cr2w, this);
				}
				return _uI_HudButtonHelp;
			}
			set
			{
				if (_uI_HudButtonHelp == value)
				{
					return;
				}
				_uI_HudButtonHelp = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("UI_ActivityLog")] 
		public CHandle<UI_ActivityLogDef> UI_ActivityLog
		{
			get
			{
				if (_uI_ActivityLog == null)
				{
					_uI_ActivityLog = (CHandle<UI_ActivityLogDef>) CR2WTypeManager.Create("handle:UI_ActivityLogDef", "UI_ActivityLog", cr2w, this);
				}
				return _uI_ActivityLog;
			}
			set
			{
				if (_uI_ActivityLog == value)
				{
					return;
				}
				_uI_ActivityLog = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("UI_LevelUp")] 
		public CHandle<UI_LevelUpDef> UI_LevelUp
		{
			get
			{
				if (_uI_LevelUp == null)
				{
					_uI_LevelUp = (CHandle<UI_LevelUpDef>) CR2WTypeManager.Create("handle:UI_LevelUpDef", "UI_LevelUp", cr2w, this);
				}
				return _uI_LevelUp;
			}
			set
			{
				if (_uI_LevelUp == value)
				{
					return;
				}
				_uI_LevelUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("UI_Vendor")] 
		public CHandle<UI_VendorDef> UI_Vendor
		{
			get
			{
				if (_uI_Vendor == null)
				{
					_uI_Vendor = (CHandle<UI_VendorDef>) CR2WTypeManager.Create("handle:UI_VendorDef", "UI_Vendor", cr2w, this);
				}
				return _uI_Vendor;
			}
			set
			{
				if (_uI_Vendor == value)
				{
					return;
				}
				_uI_Vendor = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("UI_Briefing")] 
		public CHandle<UI_BriefingDef> UI_Briefing
		{
			get
			{
				if (_uI_Briefing == null)
				{
					_uI_Briefing = (CHandle<UI_BriefingDef>) CR2WTypeManager.Create("handle:UI_BriefingDef", "UI_Briefing", cr2w, this);
				}
				return _uI_Briefing;
			}
			set
			{
				if (_uI_Briefing == value)
				{
					return;
				}
				_uI_Briefing = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("UI_ItemModSystem")] 
		public CHandle<UI_ItemModSystemDef> UI_ItemModSystem
		{
			get
			{
				if (_uI_ItemModSystem == null)
				{
					_uI_ItemModSystem = (CHandle<UI_ItemModSystemDef>) CR2WTypeManager.Create("handle:UI_ItemModSystemDef", "UI_ItemModSystem", cr2w, this);
				}
				return _uI_ItemModSystem;
			}
			set
			{
				if (_uI_ItemModSystem == value)
				{
					return;
				}
				_uI_ItemModSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("UI_CodexSystem")] 
		public CHandle<UI_CodexSystemDef> UI_CodexSystem
		{
			get
			{
				if (_uI_CodexSystem == null)
				{
					_uI_CodexSystem = (CHandle<UI_CodexSystemDef>) CR2WTypeManager.Create("handle:UI_CodexSystemDef", "UI_CodexSystem", cr2w, this);
				}
				return _uI_CodexSystem;
			}
			set
			{
				if (_uI_CodexSystem == value)
				{
					return;
				}
				_uI_CodexSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(82)] 
		[RED("UI_Equipment")] 
		public CHandle<UI_EquipmentDef> UI_Equipment
		{
			get
			{
				if (_uI_Equipment == null)
				{
					_uI_Equipment = (CHandle<UI_EquipmentDef>) CR2WTypeManager.Create("handle:UI_EquipmentDef", "UI_Equipment", cr2w, this);
				}
				return _uI_Equipment;
			}
			set
			{
				if (_uI_Equipment == value)
				{
					return;
				}
				_uI_Equipment = value;
				PropertySet(this);
			}
		}

		[Ordinal(83)] 
		[RED("UI_Crafting")] 
		public CHandle<UI_CraftingDef> UI_Crafting
		{
			get
			{
				if (_uI_Crafting == null)
				{
					_uI_Crafting = (CHandle<UI_CraftingDef>) CR2WTypeManager.Create("handle:UI_CraftingDef", "UI_Crafting", cr2w, this);
				}
				return _uI_Crafting;
			}
			set
			{
				if (_uI_Crafting == value)
				{
					return;
				}
				_uI_Crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(84)] 
		[RED("UI_Map")] 
		public CHandle<UI_MapDef> UI_Map
		{
			get
			{
				if (_uI_Map == null)
				{
					_uI_Map = (CHandle<UI_MapDef>) CR2WTypeManager.Create("handle:UI_MapDef", "UI_Map", cr2w, this);
				}
				return _uI_Map;
			}
			set
			{
				if (_uI_Map == value)
				{
					return;
				}
				_uI_Map = value;
				PropertySet(this);
			}
		}

		[Ordinal(85)] 
		[RED("UI_CpoCharacterSelection")] 
		public CHandle<UI_CpoCharacterSelectionDef> UI_CpoCharacterSelection
		{
			get
			{
				if (_uI_CpoCharacterSelection == null)
				{
					_uI_CpoCharacterSelection = (CHandle<UI_CpoCharacterSelectionDef>) CR2WTypeManager.Create("handle:UI_CpoCharacterSelectionDef", "UI_CpoCharacterSelection", cr2w, this);
				}
				return _uI_CpoCharacterSelection;
			}
			set
			{
				if (_uI_CpoCharacterSelection == value)
				{
					return;
				}
				_uI_CpoCharacterSelection = value;
				PropertySet(this);
			}
		}

		[Ordinal(86)] 
		[RED("UI_ChatBox")] 
		public CHandle<UI_ChatBoxDef> UI_ChatBox
		{
			get
			{
				if (_uI_ChatBox == null)
				{
					_uI_ChatBox = (CHandle<UI_ChatBoxDef>) CR2WTypeManager.Create("handle:UI_ChatBoxDef", "UI_ChatBox", cr2w, this);
				}
				return _uI_ChatBox;
			}
			set
			{
				if (_uI_ChatBox == value)
				{
					return;
				}
				_uI_ChatBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("UI_HUDNarrationLog")] 
		public CHandle<UI_HUDNarrationLogDef> UI_HUDNarrationLog
		{
			get
			{
				if (_uI_HUDNarrationLog == null)
				{
					_uI_HUDNarrationLog = (CHandle<UI_HUDNarrationLogDef>) CR2WTypeManager.Create("handle:UI_HUDNarrationLogDef", "UI_HUDNarrationLog", cr2w, this);
				}
				return _uI_HUDNarrationLog;
			}
			set
			{
				if (_uI_HUDNarrationLog == value)
				{
					return;
				}
				_uI_HUDNarrationLog = value;
				PropertySet(this);
			}
		}

		[Ordinal(88)] 
		[RED("UI_NarrativePlate")] 
		public CHandle<UI_NarrativePlateDef> UI_NarrativePlate
		{
			get
			{
				if (_uI_NarrativePlate == null)
				{
					_uI_NarrativePlate = (CHandle<UI_NarrativePlateDef>) CR2WTypeManager.Create("handle:UI_NarrativePlateDef", "UI_NarrativePlate", cr2w, this);
				}
				return _uI_NarrativePlate;
			}
			set
			{
				if (_uI_NarrativePlate == value)
				{
					return;
				}
				_uI_NarrativePlate = value;
				PropertySet(this);
			}
		}

		[Ordinal(89)] 
		[RED("UI_Crosshair")] 
		public CHandle<UI_CrosshairDef> UI_Crosshair
		{
			get
			{
				if (_uI_Crosshair == null)
				{
					_uI_Crosshair = (CHandle<UI_CrosshairDef>) CR2WTypeManager.Create("handle:UI_CrosshairDef", "UI_Crosshair", cr2w, this);
				}
				return _uI_Crosshair;
			}
			set
			{
				if (_uI_Crosshair == value)
				{
					return;
				}
				_uI_Crosshair = value;
				PropertySet(this);
			}
		}

		[Ordinal(90)] 
		[RED("UI_ItemLog")] 
		public CHandle<UI_ItemLogDef> UI_ItemLog
		{
			get
			{
				if (_uI_ItemLog == null)
				{
					_uI_ItemLog = (CHandle<UI_ItemLogDef>) CR2WTypeManager.Create("handle:UI_ItemLogDef", "UI_ItemLog", cr2w, this);
				}
				return _uI_ItemLog;
			}
			set
			{
				if (_uI_ItemLog == value)
				{
					return;
				}
				_uI_ItemLog = value;
				PropertySet(this);
			}
		}

		[Ordinal(91)] 
		[RED("UI_HUDButtonHints")] 
		public CHandle<UI_HUDButtonHintDef> UI_HUDButtonHints
		{
			get
			{
				if (_uI_HUDButtonHints == null)
				{
					_uI_HUDButtonHints = (CHandle<UI_HUDButtonHintDef>) CR2WTypeManager.Create("handle:UI_HUDButtonHintDef", "UI_HUDButtonHints", cr2w, this);
				}
				return _uI_HUDButtonHints;
			}
			set
			{
				if (_uI_HUDButtonHints == value)
				{
					return;
				}
				_uI_HUDButtonHints = value;
				PropertySet(this);
			}
		}

		[Ordinal(92)] 
		[RED("UI_Companion")] 
		public CHandle<UI_CompanionDef> UI_Companion
		{
			get
			{
				if (_uI_Companion == null)
				{
					_uI_Companion = (CHandle<UI_CompanionDef>) CR2WTypeManager.Create("handle:UI_CompanionDef", "UI_Companion", cr2w, this);
				}
				return _uI_Companion;
			}
			set
			{
				if (_uI_Companion == value)
				{
					return;
				}
				_uI_Companion = value;
				PropertySet(this);
			}
		}

		[Ordinal(93)] 
		[RED("UI_CustomQuestNotification")] 
		public CHandle<UI_CustomQuestNotificationDef> UI_CustomQuestNotification
		{
			get
			{
				if (_uI_CustomQuestNotification == null)
				{
					_uI_CustomQuestNotification = (CHandle<UI_CustomQuestNotificationDef>) CR2WTypeManager.Create("handle:UI_CustomQuestNotificationDef", "UI_CustomQuestNotification", cr2w, this);
				}
				return _uI_CustomQuestNotification;
			}
			set
			{
				if (_uI_CustomQuestNotification == value)
				{
					return;
				}
				_uI_CustomQuestNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("HUD_Manager")] 
		public CHandle<HUDManagerDef> HUD_Manager
		{
			get
			{
				if (_hUD_Manager == null)
				{
					_hUD_Manager = (CHandle<HUDManagerDef>) CR2WTypeManager.Create("handle:HUDManagerDef", "HUD_Manager", cr2w, this);
				}
				return _hUD_Manager;
			}
			set
			{
				if (_hUD_Manager == value)
				{
					return;
				}
				_hUD_Manager = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("UI_Hacking")] 
		public CHandle<UI_HackingDef> UI_Hacking
		{
			get
			{
				if (_uI_Hacking == null)
				{
					_uI_Hacking = (CHandle<UI_HackingDef>) CR2WTypeManager.Create("handle:UI_HackingDef", "UI_Hacking", cr2w, this);
				}
				return _uI_Hacking;
			}
			set
			{
				if (_uI_Hacking == value)
				{
					return;
				}
				_uI_Hacking = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("UI_Stealth")] 
		public CHandle<UI_StealthDef> UI_Stealth
		{
			get
			{
				if (_uI_Stealth == null)
				{
					_uI_Stealth = (CHandle<UI_StealthDef>) CR2WTypeManager.Create("handle:UI_StealthDef", "UI_Stealth", cr2w, this);
				}
				return _uI_Stealth;
			}
			set
			{
				if (_uI_Stealth == value)
				{
					return;
				}
				_uI_Stealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("UI_TopbarHubMenu")] 
		public CHandle<UI_TopbarHubMenuDef> UI_TopbarHubMenu
		{
			get
			{
				if (_uI_TopbarHubMenu == null)
				{
					_uI_TopbarHubMenu = (CHandle<UI_TopbarHubMenuDef>) CR2WTypeManager.Create("handle:UI_TopbarHubMenuDef", "UI_TopbarHubMenu", cr2w, this);
				}
				return _uI_TopbarHubMenu;
			}
			set
			{
				if (_uI_TopbarHubMenu == value)
				{
					return;
				}
				_uI_TopbarHubMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("UI_LocalPlayer")] 
		public CHandle<LocalPlayerDef> UI_LocalPlayer
		{
			get
			{
				if (_uI_LocalPlayer == null)
				{
					_uI_LocalPlayer = (CHandle<LocalPlayerDef>) CR2WTypeManager.Create("handle:LocalPlayerDef", "UI_LocalPlayer", cr2w, this);
				}
				return _uI_LocalPlayer;
			}
			set
			{
				if (_uI_LocalPlayer == value)
				{
					return;
				}
				_uI_LocalPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("UI_SceneScreen")] 
		public CHandle<UI_SceneScreenDef> UI_SceneScreen
		{
			get
			{
				if (_uI_SceneScreen == null)
				{
					_uI_SceneScreen = (CHandle<UI_SceneScreenDef>) CR2WTypeManager.Create("handle:UI_SceneScreenDef", "UI_SceneScreen", cr2w, this);
				}
				return _uI_SceneScreen;
			}
			set
			{
				if (_uI_SceneScreen == value)
				{
					return;
				}
				_uI_SceneScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("CombatGadget")] 
		public CHandle<CombatGadgetDataDef> CombatGadget
		{
			get
			{
				if (_combatGadget == null)
				{
					_combatGadget = (CHandle<CombatGadgetDataDef>) CR2WTypeManager.Create("handle:CombatGadgetDataDef", "CombatGadget", cr2w, this);
				}
				return _combatGadget;
			}
			set
			{
				if (_combatGadget == value)
				{
					return;
				}
				_combatGadget = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("Mines")] 
		public CHandle<MinesDataDef> Mines
		{
			get
			{
				if (_mines == null)
				{
					_mines = (CHandle<MinesDataDef>) CR2WTypeManager.Create("handle:MinesDataDef", "Mines", cr2w, this);
				}
				return _mines;
			}
			set
			{
				if (_mines == value)
				{
					return;
				}
				_mines = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("DebugData")] 
		public CHandle<DebugDataDef> DebugData
		{
			get
			{
				if (_debugData == null)
				{
					_debugData = (CHandle<DebugDataDef>) CR2WTypeManager.Create("handle:DebugDataDef", "DebugData", cr2w, this);
				}
				return _debugData;
			}
			set
			{
				if (_debugData == value)
				{
					return;
				}
				_debugData = value;
				PropertySet(this);
			}
		}

		[Ordinal(103)] 
		[RED("DeviceDebug")] 
		public CHandle<DeviceDebugDef> DeviceDebug
		{
			get
			{
				if (_deviceDebug == null)
				{
					_deviceDebug = (CHandle<DeviceDebugDef>) CR2WTypeManager.Create("handle:DeviceDebugDef", "DeviceDebug", cr2w, this);
				}
				return _deviceDebug;
			}
			set
			{
				if (_deviceDebug == value)
				{
					return;
				}
				_deviceDebug = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("CustomCentaurBlackboard")] 
		public CHandle<CustomCentaurBlackboardDef> CustomCentaurBlackboard
		{
			get
			{
				if (_customCentaurBlackboard == null)
				{
					_customCentaurBlackboard = (CHandle<CustomCentaurBlackboardDef>) CR2WTypeManager.Create("handle:CustomCentaurBlackboardDef", "CustomCentaurBlackboard", cr2w, this);
				}
				return _customCentaurBlackboard;
			}
			set
			{
				if (_customCentaurBlackboard == value)
				{
					return;
				}
				_customCentaurBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("CW_MuteArm")] 
		public CHandle<CW_MuteArmDef> CW_MuteArm
		{
			get
			{
				if (_cW_MuteArm == null)
				{
					_cW_MuteArm = (CHandle<CW_MuteArmDef>) CR2WTypeManager.Create("handle:CW_MuteArmDef", "CW_MuteArm", cr2w, this);
				}
				return _cW_MuteArm;
			}
			set
			{
				if (_cW_MuteArm == value)
				{
					return;
				}
				_cW_MuteArm = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("PhotoMode")] 
		public CHandle<PhotoModeDef> PhotoMode
		{
			get
			{
				if (_photoMode == null)
				{
					_photoMode = (CHandle<PhotoModeDef>) CR2WTypeManager.Create("handle:PhotoModeDef", "PhotoMode", cr2w, this);
				}
				return _photoMode;
			}
			set
			{
				if (_photoMode == value)
				{
					return;
				}
				_photoMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("GameplaySettings")] 
		public CHandle<GameplaySettingsDef> GameplaySettings
		{
			get
			{
				if (_gameplaySettings == null)
				{
					_gameplaySettings = (CHandle<GameplaySettingsDef>) CR2WTypeManager.Create("handle:GameplaySettingsDef", "GameplaySettings", cr2w, this);
				}
				return _gameplaySettings;
			}
			set
			{
				if (_gameplaySettings == value)
				{
					return;
				}
				_gameplaySettings = value;
				PropertySet(this);
			}
		}

		public gamebbAllScriptDefinitions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
