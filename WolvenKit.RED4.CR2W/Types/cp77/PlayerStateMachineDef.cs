using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerStateMachineDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _locomotion;
		private gamebbScriptID_Int32 _locomotionDetailed;
		private gamebbScriptID_Int32 _highLevel;
		private gamebbScriptID_Int32 _upperBody;
		private gamebbScriptID_Int32 _timeDilation;
		private gamebbScriptID_Int32 _weapon;
		private gamebbScriptID_Int32 _melee;
		private gamebbScriptID_Int32 _uI;
		private gamebbScriptID_Int32 _crosshair;
		private gamebbScriptID_Int32 _reaction;
		private gamebbScriptID_Int32 _zones;
		private gamebbScriptID_Variant _securityZoneData;
		private gamebbScriptID_Int32 _vision;
		private gamebbScriptID_Int32 _visionDebug;
		private gamebbScriptID_Int32 _sceneTier;
		private gamebbScriptID_Int32 _combatGadget;
		private gamebbScriptID_Variant _lastCombatGadgetUsed;
		private gamebbScriptID_Int32 _consumable;
		private gamebbScriptID_Int32 _vehicle;
		private gamebbScriptID_Float _zoomLevel;
		private gamebbScriptID_Int32 _maxZoomLevel;
		private gamebbScriptID_Bool _toggleFireMode;
		private gamebbScriptID_Bool _switchWeapon;
		private gamebbScriptID_Bool _isDoorInteractionActive;
		private gamebbScriptID_Bool _isInteractingWithDevice;
		private gamebbScriptID_Bool _isForceOpeningDoor;
		private gamebbScriptID_Bool _isControllingDevice;
		private gamebbScriptID_Bool _isUIZoomDevice;
		private gamebbScriptID_Bool _useUnarmed;
		private gamebbScriptID_Int32 _berserk;
		private gamebbScriptID_Int32 _activeCyberware;
		private gamebbScriptID_Int32 _whip;
		private gamebbScriptID_Bool _dEBUG_SilencedWeapon;
		private gamebbScriptID_Int32 _leftHandCyberware;
		private gamebbScriptID_Bool _useLeftHand;
		private gamebbScriptID_Int32 _meleeWeapon;
		private gamebbScriptID_Bool _carrying;
		private gamebbScriptID_Bool _carryingDisposal;
		private gamebbScriptID_Variant _currentElevator;
		private gamebbScriptID_Bool _isPlayerInsideElevator;
		private gamebbScriptID_Bool _isPlayerInsideMovingElevator;
		private gamebbScriptID_Int32 _combat;
		private gamebbScriptID_Int32 _stamina;
		private gamebbScriptID_Int32 _vitals;
		private gamebbScriptID_Int32 _takedown;
		private gamebbScriptID_Int32 _fall;
		private gamebbScriptID_Int32 _landing;
		private gamebbScriptID_Bool _usingCover;
		private gamebbScriptID_Bool _isInMinigame;
		private gamebbScriptID_Int32 _isUploadingQuickHack;
		private gamebbScriptID_EntityID _entityIDTargetingPlayer;
		private gamebbScriptID_Int32 _swimming;
		private gamebbScriptID_Int32 _bodyCarrying;
		private gamebbScriptID_Int32 _bodyCarryingLocomotion;
		private gamebbScriptID_Int32 _bodyDisposalDetailed;
		private gamebbScriptID_Bool _displayDeathMenu;
		private gamebbScriptID_Bool _overrideQuickHackPanelDilation;
		private gamebbScriptID_Int32 _nanoWireLaunchMode;
		private gamebbScriptID_Bool _isMovingHorizontally;
		private gamebbScriptID_Bool _isMovingVertically;
		private gamebbScriptID_Variant _actionRestriction;
		private gamebbScriptID_Bool _meleeLeap;
		private gamebbScriptID_Int32 _isInWorkspot;

		[Ordinal(0)] 
		[RED("Locomotion")] 
		public gamebbScriptID_Int32 Locomotion
		{
			get => GetProperty(ref _locomotion);
			set => SetProperty(ref _locomotion, value);
		}

		[Ordinal(1)] 
		[RED("LocomotionDetailed")] 
		public gamebbScriptID_Int32 LocomotionDetailed
		{
			get => GetProperty(ref _locomotionDetailed);
			set => SetProperty(ref _locomotionDetailed, value);
		}

		[Ordinal(2)] 
		[RED("HighLevel")] 
		public gamebbScriptID_Int32 HighLevel
		{
			get => GetProperty(ref _highLevel);
			set => SetProperty(ref _highLevel, value);
		}

		[Ordinal(3)] 
		[RED("UpperBody")] 
		public gamebbScriptID_Int32 UpperBody
		{
			get => GetProperty(ref _upperBody);
			set => SetProperty(ref _upperBody, value);
		}

		[Ordinal(4)] 
		[RED("TimeDilation")] 
		public gamebbScriptID_Int32 TimeDilation
		{
			get => GetProperty(ref _timeDilation);
			set => SetProperty(ref _timeDilation, value);
		}

		[Ordinal(5)] 
		[RED("Weapon")] 
		public gamebbScriptID_Int32 Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(6)] 
		[RED("Melee")] 
		public gamebbScriptID_Int32 Melee
		{
			get => GetProperty(ref _melee);
			set => SetProperty(ref _melee, value);
		}

		[Ordinal(7)] 
		[RED("UI")] 
		public gamebbScriptID_Int32 UI
		{
			get => GetProperty(ref _uI);
			set => SetProperty(ref _uI, value);
		}

		[Ordinal(8)] 
		[RED("Crosshair")] 
		public gamebbScriptID_Int32 Crosshair
		{
			get => GetProperty(ref _crosshair);
			set => SetProperty(ref _crosshair, value);
		}

		[Ordinal(9)] 
		[RED("Reaction")] 
		public gamebbScriptID_Int32 Reaction
		{
			get => GetProperty(ref _reaction);
			set => SetProperty(ref _reaction, value);
		}

		[Ordinal(10)] 
		[RED("Zones")] 
		public gamebbScriptID_Int32 Zones
		{
			get => GetProperty(ref _zones);
			set => SetProperty(ref _zones, value);
		}

		[Ordinal(11)] 
		[RED("SecurityZoneData")] 
		public gamebbScriptID_Variant SecurityZoneData
		{
			get => GetProperty(ref _securityZoneData);
			set => SetProperty(ref _securityZoneData, value);
		}

		[Ordinal(12)] 
		[RED("Vision")] 
		public gamebbScriptID_Int32 Vision
		{
			get => GetProperty(ref _vision);
			set => SetProperty(ref _vision, value);
		}

		[Ordinal(13)] 
		[RED("VisionDebug")] 
		public gamebbScriptID_Int32 VisionDebug
		{
			get => GetProperty(ref _visionDebug);
			set => SetProperty(ref _visionDebug, value);
		}

		[Ordinal(14)] 
		[RED("SceneTier")] 
		public gamebbScriptID_Int32 SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(15)] 
		[RED("CombatGadget")] 
		public gamebbScriptID_Int32 CombatGadget
		{
			get => GetProperty(ref _combatGadget);
			set => SetProperty(ref _combatGadget, value);
		}

		[Ordinal(16)] 
		[RED("LastCombatGadgetUsed")] 
		public gamebbScriptID_Variant LastCombatGadgetUsed
		{
			get => GetProperty(ref _lastCombatGadgetUsed);
			set => SetProperty(ref _lastCombatGadgetUsed, value);
		}

		[Ordinal(17)] 
		[RED("Consumable")] 
		public gamebbScriptID_Int32 Consumable
		{
			get => GetProperty(ref _consumable);
			set => SetProperty(ref _consumable, value);
		}

		[Ordinal(18)] 
		[RED("Vehicle")] 
		public gamebbScriptID_Int32 Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(19)] 
		[RED("ZoomLevel")] 
		public gamebbScriptID_Float ZoomLevel
		{
			get => GetProperty(ref _zoomLevel);
			set => SetProperty(ref _zoomLevel, value);
		}

		[Ordinal(20)] 
		[RED("MaxZoomLevel")] 
		public gamebbScriptID_Int32 MaxZoomLevel
		{
			get => GetProperty(ref _maxZoomLevel);
			set => SetProperty(ref _maxZoomLevel, value);
		}

		[Ordinal(21)] 
		[RED("ToggleFireMode")] 
		public gamebbScriptID_Bool ToggleFireMode
		{
			get => GetProperty(ref _toggleFireMode);
			set => SetProperty(ref _toggleFireMode, value);
		}

		[Ordinal(22)] 
		[RED("SwitchWeapon")] 
		public gamebbScriptID_Bool SwitchWeapon
		{
			get => GetProperty(ref _switchWeapon);
			set => SetProperty(ref _switchWeapon, value);
		}

		[Ordinal(23)] 
		[RED("IsDoorInteractionActive")] 
		public gamebbScriptID_Bool IsDoorInteractionActive
		{
			get => GetProperty(ref _isDoorInteractionActive);
			set => SetProperty(ref _isDoorInteractionActive, value);
		}

		[Ordinal(24)] 
		[RED("IsInteractingWithDevice")] 
		public gamebbScriptID_Bool IsInteractingWithDevice
		{
			get => GetProperty(ref _isInteractingWithDevice);
			set => SetProperty(ref _isInteractingWithDevice, value);
		}

		[Ordinal(25)] 
		[RED("IsForceOpeningDoor")] 
		public gamebbScriptID_Bool IsForceOpeningDoor
		{
			get => GetProperty(ref _isForceOpeningDoor);
			set => SetProperty(ref _isForceOpeningDoor, value);
		}

		[Ordinal(26)] 
		[RED("IsControllingDevice")] 
		public gamebbScriptID_Bool IsControllingDevice
		{
			get => GetProperty(ref _isControllingDevice);
			set => SetProperty(ref _isControllingDevice, value);
		}

		[Ordinal(27)] 
		[RED("IsUIZoomDevice")] 
		public gamebbScriptID_Bool IsUIZoomDevice
		{
			get => GetProperty(ref _isUIZoomDevice);
			set => SetProperty(ref _isUIZoomDevice, value);
		}

		[Ordinal(28)] 
		[RED("UseUnarmed")] 
		public gamebbScriptID_Bool UseUnarmed
		{
			get => GetProperty(ref _useUnarmed);
			set => SetProperty(ref _useUnarmed, value);
		}

		[Ordinal(29)] 
		[RED("Berserk")] 
		public gamebbScriptID_Int32 Berserk
		{
			get => GetProperty(ref _berserk);
			set => SetProperty(ref _berserk, value);
		}

		[Ordinal(30)] 
		[RED("ActiveCyberware")] 
		public gamebbScriptID_Int32 ActiveCyberware
		{
			get => GetProperty(ref _activeCyberware);
			set => SetProperty(ref _activeCyberware, value);
		}

		[Ordinal(31)] 
		[RED("Whip")] 
		public gamebbScriptID_Int32 Whip
		{
			get => GetProperty(ref _whip);
			set => SetProperty(ref _whip, value);
		}

		[Ordinal(32)] 
		[RED("DEBUG_SilencedWeapon")] 
		public gamebbScriptID_Bool DEBUG_SilencedWeapon
		{
			get => GetProperty(ref _dEBUG_SilencedWeapon);
			set => SetProperty(ref _dEBUG_SilencedWeapon, value);
		}

		[Ordinal(33)] 
		[RED("LeftHandCyberware")] 
		public gamebbScriptID_Int32 LeftHandCyberware
		{
			get => GetProperty(ref _leftHandCyberware);
			set => SetProperty(ref _leftHandCyberware, value);
		}

		[Ordinal(34)] 
		[RED("UseLeftHand")] 
		public gamebbScriptID_Bool UseLeftHand
		{
			get => GetProperty(ref _useLeftHand);
			set => SetProperty(ref _useLeftHand, value);
		}

		[Ordinal(35)] 
		[RED("MeleeWeapon")] 
		public gamebbScriptID_Int32 MeleeWeapon
		{
			get => GetProperty(ref _meleeWeapon);
			set => SetProperty(ref _meleeWeapon, value);
		}

		[Ordinal(36)] 
		[RED("Carrying")] 
		public gamebbScriptID_Bool Carrying
		{
			get => GetProperty(ref _carrying);
			set => SetProperty(ref _carrying, value);
		}

		[Ordinal(37)] 
		[RED("CarryingDisposal")] 
		public gamebbScriptID_Bool CarryingDisposal
		{
			get => GetProperty(ref _carryingDisposal);
			set => SetProperty(ref _carryingDisposal, value);
		}

		[Ordinal(38)] 
		[RED("CurrentElevator")] 
		public gamebbScriptID_Variant CurrentElevator
		{
			get => GetProperty(ref _currentElevator);
			set => SetProperty(ref _currentElevator, value);
		}

		[Ordinal(39)] 
		[RED("IsPlayerInsideElevator")] 
		public gamebbScriptID_Bool IsPlayerInsideElevator
		{
			get => GetProperty(ref _isPlayerInsideElevator);
			set => SetProperty(ref _isPlayerInsideElevator, value);
		}

		[Ordinal(40)] 
		[RED("IsPlayerInsideMovingElevator")] 
		public gamebbScriptID_Bool IsPlayerInsideMovingElevator
		{
			get => GetProperty(ref _isPlayerInsideMovingElevator);
			set => SetProperty(ref _isPlayerInsideMovingElevator, value);
		}

		[Ordinal(41)] 
		[RED("Combat")] 
		public gamebbScriptID_Int32 Combat
		{
			get => GetProperty(ref _combat);
			set => SetProperty(ref _combat, value);
		}

		[Ordinal(42)] 
		[RED("Stamina")] 
		public gamebbScriptID_Int32 Stamina
		{
			get => GetProperty(ref _stamina);
			set => SetProperty(ref _stamina, value);
		}

		[Ordinal(43)] 
		[RED("Vitals")] 
		public gamebbScriptID_Int32 Vitals
		{
			get => GetProperty(ref _vitals);
			set => SetProperty(ref _vitals, value);
		}

		[Ordinal(44)] 
		[RED("Takedown")] 
		public gamebbScriptID_Int32 Takedown
		{
			get => GetProperty(ref _takedown);
			set => SetProperty(ref _takedown, value);
		}

		[Ordinal(45)] 
		[RED("Fall")] 
		public gamebbScriptID_Int32 Fall
		{
			get => GetProperty(ref _fall);
			set => SetProperty(ref _fall, value);
		}

		[Ordinal(46)] 
		[RED("Landing")] 
		public gamebbScriptID_Int32 Landing
		{
			get => GetProperty(ref _landing);
			set => SetProperty(ref _landing, value);
		}

		[Ordinal(47)] 
		[RED("UsingCover")] 
		public gamebbScriptID_Bool UsingCover
		{
			get => GetProperty(ref _usingCover);
			set => SetProperty(ref _usingCover, value);
		}

		[Ordinal(48)] 
		[RED("IsInMinigame")] 
		public gamebbScriptID_Bool IsInMinigame
		{
			get => GetProperty(ref _isInMinigame);
			set => SetProperty(ref _isInMinigame, value);
		}

		[Ordinal(49)] 
		[RED("IsUploadingQuickHack")] 
		public gamebbScriptID_Int32 IsUploadingQuickHack
		{
			get => GetProperty(ref _isUploadingQuickHack);
			set => SetProperty(ref _isUploadingQuickHack, value);
		}

		[Ordinal(50)] 
		[RED("EntityIDTargetingPlayer")] 
		public gamebbScriptID_EntityID EntityIDTargetingPlayer
		{
			get => GetProperty(ref _entityIDTargetingPlayer);
			set => SetProperty(ref _entityIDTargetingPlayer, value);
		}

		[Ordinal(51)] 
		[RED("Swimming")] 
		public gamebbScriptID_Int32 Swimming
		{
			get => GetProperty(ref _swimming);
			set => SetProperty(ref _swimming, value);
		}

		[Ordinal(52)] 
		[RED("BodyCarrying")] 
		public gamebbScriptID_Int32 BodyCarrying
		{
			get => GetProperty(ref _bodyCarrying);
			set => SetProperty(ref _bodyCarrying, value);
		}

		[Ordinal(53)] 
		[RED("BodyCarryingLocomotion")] 
		public gamebbScriptID_Int32 BodyCarryingLocomotion
		{
			get => GetProperty(ref _bodyCarryingLocomotion);
			set => SetProperty(ref _bodyCarryingLocomotion, value);
		}

		[Ordinal(54)] 
		[RED("BodyDisposalDetailed")] 
		public gamebbScriptID_Int32 BodyDisposalDetailed
		{
			get => GetProperty(ref _bodyDisposalDetailed);
			set => SetProperty(ref _bodyDisposalDetailed, value);
		}

		[Ordinal(55)] 
		[RED("DisplayDeathMenu")] 
		public gamebbScriptID_Bool DisplayDeathMenu
		{
			get => GetProperty(ref _displayDeathMenu);
			set => SetProperty(ref _displayDeathMenu, value);
		}

		[Ordinal(56)] 
		[RED("OverrideQuickHackPanelDilation")] 
		public gamebbScriptID_Bool OverrideQuickHackPanelDilation
		{
			get => GetProperty(ref _overrideQuickHackPanelDilation);
			set => SetProperty(ref _overrideQuickHackPanelDilation, value);
		}

		[Ordinal(57)] 
		[RED("NanoWireLaunchMode")] 
		public gamebbScriptID_Int32 NanoWireLaunchMode
		{
			get => GetProperty(ref _nanoWireLaunchMode);
			set => SetProperty(ref _nanoWireLaunchMode, value);
		}

		[Ordinal(58)] 
		[RED("IsMovingHorizontally")] 
		public gamebbScriptID_Bool IsMovingHorizontally
		{
			get => GetProperty(ref _isMovingHorizontally);
			set => SetProperty(ref _isMovingHorizontally, value);
		}

		[Ordinal(59)] 
		[RED("IsMovingVertically")] 
		public gamebbScriptID_Bool IsMovingVertically
		{
			get => GetProperty(ref _isMovingVertically);
			set => SetProperty(ref _isMovingVertically, value);
		}

		[Ordinal(60)] 
		[RED("ActionRestriction")] 
		public gamebbScriptID_Variant ActionRestriction
		{
			get => GetProperty(ref _actionRestriction);
			set => SetProperty(ref _actionRestriction, value);
		}

		[Ordinal(61)] 
		[RED("MeleeLeap")] 
		public gamebbScriptID_Bool MeleeLeap
		{
			get => GetProperty(ref _meleeLeap);
			set => SetProperty(ref _meleeLeap, value);
		}

		[Ordinal(62)] 
		[RED("IsInWorkspot")] 
		public gamebbScriptID_Int32 IsInWorkspot
		{
			get => GetProperty(ref _isInWorkspot);
			set => SetProperty(ref _isInWorkspot, value);
		}

		public PlayerStateMachineDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
