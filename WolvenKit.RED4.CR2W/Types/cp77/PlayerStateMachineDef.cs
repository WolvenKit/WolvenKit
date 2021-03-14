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
			get
			{
				if (_locomotion == null)
				{
					_locomotion = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Locomotion", cr2w, this);
				}
				return _locomotion;
			}
			set
			{
				if (_locomotion == value)
				{
					return;
				}
				_locomotion = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("LocomotionDetailed")] 
		public gamebbScriptID_Int32 LocomotionDetailed
		{
			get
			{
				if (_locomotionDetailed == null)
				{
					_locomotionDetailed = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "LocomotionDetailed", cr2w, this);
				}
				return _locomotionDetailed;
			}
			set
			{
				if (_locomotionDetailed == value)
				{
					return;
				}
				_locomotionDetailed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("HighLevel")] 
		public gamebbScriptID_Int32 HighLevel
		{
			get
			{
				if (_highLevel == null)
				{
					_highLevel = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "HighLevel", cr2w, this);
				}
				return _highLevel;
			}
			set
			{
				if (_highLevel == value)
				{
					return;
				}
				_highLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("UpperBody")] 
		public gamebbScriptID_Int32 UpperBody
		{
			get
			{
				if (_upperBody == null)
				{
					_upperBody = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "UpperBody", cr2w, this);
				}
				return _upperBody;
			}
			set
			{
				if (_upperBody == value)
				{
					return;
				}
				_upperBody = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("TimeDilation")] 
		public gamebbScriptID_Int32 TimeDilation
		{
			get
			{
				if (_timeDilation == null)
				{
					_timeDilation = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "TimeDilation", cr2w, this);
				}
				return _timeDilation;
			}
			set
			{
				if (_timeDilation == value)
				{
					return;
				}
				_timeDilation = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("Weapon")] 
		public gamebbScriptID_Int32 Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Weapon", cr2w, this);
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

		[Ordinal(6)] 
		[RED("Melee")] 
		public gamebbScriptID_Int32 Melee
		{
			get
			{
				if (_melee == null)
				{
					_melee = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Melee", cr2w, this);
				}
				return _melee;
			}
			set
			{
				if (_melee == value)
				{
					return;
				}
				_melee = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("UI")] 
		public gamebbScriptID_Int32 UI
		{
			get
			{
				if (_uI == null)
				{
					_uI = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "UI", cr2w, this);
				}
				return _uI;
			}
			set
			{
				if (_uI == value)
				{
					return;
				}
				_uI = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("Crosshair")] 
		public gamebbScriptID_Int32 Crosshair
		{
			get
			{
				if (_crosshair == null)
				{
					_crosshair = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Crosshair", cr2w, this);
				}
				return _crosshair;
			}
			set
			{
				if (_crosshair == value)
				{
					return;
				}
				_crosshair = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Reaction")] 
		public gamebbScriptID_Int32 Reaction
		{
			get
			{
				if (_reaction == null)
				{
					_reaction = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Reaction", cr2w, this);
				}
				return _reaction;
			}
			set
			{
				if (_reaction == value)
				{
					return;
				}
				_reaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("Zones")] 
		public gamebbScriptID_Int32 Zones
		{
			get
			{
				if (_zones == null)
				{
					_zones = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Zones", cr2w, this);
				}
				return _zones;
			}
			set
			{
				if (_zones == value)
				{
					return;
				}
				_zones = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("SecurityZoneData")] 
		public gamebbScriptID_Variant SecurityZoneData
		{
			get
			{
				if (_securityZoneData == null)
				{
					_securityZoneData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "SecurityZoneData", cr2w, this);
				}
				return _securityZoneData;
			}
			set
			{
				if (_securityZoneData == value)
				{
					return;
				}
				_securityZoneData = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("Vision")] 
		public gamebbScriptID_Int32 Vision
		{
			get
			{
				if (_vision == null)
				{
					_vision = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Vision", cr2w, this);
				}
				return _vision;
			}
			set
			{
				if (_vision == value)
				{
					return;
				}
				_vision = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("VisionDebug")] 
		public gamebbScriptID_Int32 VisionDebug
		{
			get
			{
				if (_visionDebug == null)
				{
					_visionDebug = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "VisionDebug", cr2w, this);
				}
				return _visionDebug;
			}
			set
			{
				if (_visionDebug == value)
				{
					return;
				}
				_visionDebug = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("SceneTier")] 
		public gamebbScriptID_Int32 SceneTier
		{
			get
			{
				if (_sceneTier == null)
				{
					_sceneTier = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "SceneTier", cr2w, this);
				}
				return _sceneTier;
			}
			set
			{
				if (_sceneTier == value)
				{
					return;
				}
				_sceneTier = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("CombatGadget")] 
		public gamebbScriptID_Int32 CombatGadget
		{
			get
			{
				if (_combatGadget == null)
				{
					_combatGadget = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "CombatGadget", cr2w, this);
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

		[Ordinal(16)] 
		[RED("LastCombatGadgetUsed")] 
		public gamebbScriptID_Variant LastCombatGadgetUsed
		{
			get
			{
				if (_lastCombatGadgetUsed == null)
				{
					_lastCombatGadgetUsed = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "LastCombatGadgetUsed", cr2w, this);
				}
				return _lastCombatGadgetUsed;
			}
			set
			{
				if (_lastCombatGadgetUsed == value)
				{
					return;
				}
				_lastCombatGadgetUsed = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("Consumable")] 
		public gamebbScriptID_Int32 Consumable
		{
			get
			{
				if (_consumable == null)
				{
					_consumable = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Consumable", cr2w, this);
				}
				return _consumable;
			}
			set
			{
				if (_consumable == value)
				{
					return;
				}
				_consumable = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("Vehicle")] 
		public gamebbScriptID_Int32 Vehicle
		{
			get
			{
				if (_vehicle == null)
				{
					_vehicle = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Vehicle", cr2w, this);
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

		[Ordinal(19)] 
		[RED("ZoomLevel")] 
		public gamebbScriptID_Float ZoomLevel
		{
			get
			{
				if (_zoomLevel == null)
				{
					_zoomLevel = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "ZoomLevel", cr2w, this);
				}
				return _zoomLevel;
			}
			set
			{
				if (_zoomLevel == value)
				{
					return;
				}
				_zoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("MaxZoomLevel")] 
		public gamebbScriptID_Int32 MaxZoomLevel
		{
			get
			{
				if (_maxZoomLevel == null)
				{
					_maxZoomLevel = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "MaxZoomLevel", cr2w, this);
				}
				return _maxZoomLevel;
			}
			set
			{
				if (_maxZoomLevel == value)
				{
					return;
				}
				_maxZoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("ToggleFireMode")] 
		public gamebbScriptID_Bool ToggleFireMode
		{
			get
			{
				if (_toggleFireMode == null)
				{
					_toggleFireMode = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ToggleFireMode", cr2w, this);
				}
				return _toggleFireMode;
			}
			set
			{
				if (_toggleFireMode == value)
				{
					return;
				}
				_toggleFireMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("SwitchWeapon")] 
		public gamebbScriptID_Bool SwitchWeapon
		{
			get
			{
				if (_switchWeapon == null)
				{
					_switchWeapon = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "SwitchWeapon", cr2w, this);
				}
				return _switchWeapon;
			}
			set
			{
				if (_switchWeapon == value)
				{
					return;
				}
				_switchWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("IsDoorInteractionActive")] 
		public gamebbScriptID_Bool IsDoorInteractionActive
		{
			get
			{
				if (_isDoorInteractionActive == null)
				{
					_isDoorInteractionActive = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsDoorInteractionActive", cr2w, this);
				}
				return _isDoorInteractionActive;
			}
			set
			{
				if (_isDoorInteractionActive == value)
				{
					return;
				}
				_isDoorInteractionActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("IsInteractingWithDevice")] 
		public gamebbScriptID_Bool IsInteractingWithDevice
		{
			get
			{
				if (_isInteractingWithDevice == null)
				{
					_isInteractingWithDevice = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsInteractingWithDevice", cr2w, this);
				}
				return _isInteractingWithDevice;
			}
			set
			{
				if (_isInteractingWithDevice == value)
				{
					return;
				}
				_isInteractingWithDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("IsForceOpeningDoor")] 
		public gamebbScriptID_Bool IsForceOpeningDoor
		{
			get
			{
				if (_isForceOpeningDoor == null)
				{
					_isForceOpeningDoor = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsForceOpeningDoor", cr2w, this);
				}
				return _isForceOpeningDoor;
			}
			set
			{
				if (_isForceOpeningDoor == value)
				{
					return;
				}
				_isForceOpeningDoor = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("IsControllingDevice")] 
		public gamebbScriptID_Bool IsControllingDevice
		{
			get
			{
				if (_isControllingDevice == null)
				{
					_isControllingDevice = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsControllingDevice", cr2w, this);
				}
				return _isControllingDevice;
			}
			set
			{
				if (_isControllingDevice == value)
				{
					return;
				}
				_isControllingDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("IsUIZoomDevice")] 
		public gamebbScriptID_Bool IsUIZoomDevice
		{
			get
			{
				if (_isUIZoomDevice == null)
				{
					_isUIZoomDevice = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsUIZoomDevice", cr2w, this);
				}
				return _isUIZoomDevice;
			}
			set
			{
				if (_isUIZoomDevice == value)
				{
					return;
				}
				_isUIZoomDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("UseUnarmed")] 
		public gamebbScriptID_Bool UseUnarmed
		{
			get
			{
				if (_useUnarmed == null)
				{
					_useUnarmed = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "UseUnarmed", cr2w, this);
				}
				return _useUnarmed;
			}
			set
			{
				if (_useUnarmed == value)
				{
					return;
				}
				_useUnarmed = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("Berserk")] 
		public gamebbScriptID_Int32 Berserk
		{
			get
			{
				if (_berserk == null)
				{
					_berserk = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Berserk", cr2w, this);
				}
				return _berserk;
			}
			set
			{
				if (_berserk == value)
				{
					return;
				}
				_berserk = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("ActiveCyberware")] 
		public gamebbScriptID_Int32 ActiveCyberware
		{
			get
			{
				if (_activeCyberware == null)
				{
					_activeCyberware = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ActiveCyberware", cr2w, this);
				}
				return _activeCyberware;
			}
			set
			{
				if (_activeCyberware == value)
				{
					return;
				}
				_activeCyberware = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("Whip")] 
		public gamebbScriptID_Int32 Whip
		{
			get
			{
				if (_whip == null)
				{
					_whip = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Whip", cr2w, this);
				}
				return _whip;
			}
			set
			{
				if (_whip == value)
				{
					return;
				}
				_whip = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("DEBUG_SilencedWeapon")] 
		public gamebbScriptID_Bool DEBUG_SilencedWeapon
		{
			get
			{
				if (_dEBUG_SilencedWeapon == null)
				{
					_dEBUG_SilencedWeapon = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "DEBUG_SilencedWeapon", cr2w, this);
				}
				return _dEBUG_SilencedWeapon;
			}
			set
			{
				if (_dEBUG_SilencedWeapon == value)
				{
					return;
				}
				_dEBUG_SilencedWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("LeftHandCyberware")] 
		public gamebbScriptID_Int32 LeftHandCyberware
		{
			get
			{
				if (_leftHandCyberware == null)
				{
					_leftHandCyberware = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "LeftHandCyberware", cr2w, this);
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

		[Ordinal(34)] 
		[RED("UseLeftHand")] 
		public gamebbScriptID_Bool UseLeftHand
		{
			get
			{
				if (_useLeftHand == null)
				{
					_useLeftHand = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "UseLeftHand", cr2w, this);
				}
				return _useLeftHand;
			}
			set
			{
				if (_useLeftHand == value)
				{
					return;
				}
				_useLeftHand = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("MeleeWeapon")] 
		public gamebbScriptID_Int32 MeleeWeapon
		{
			get
			{
				if (_meleeWeapon == null)
				{
					_meleeWeapon = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "MeleeWeapon", cr2w, this);
				}
				return _meleeWeapon;
			}
			set
			{
				if (_meleeWeapon == value)
				{
					return;
				}
				_meleeWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("Carrying")] 
		public gamebbScriptID_Bool Carrying
		{
			get
			{
				if (_carrying == null)
				{
					_carrying = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "Carrying", cr2w, this);
				}
				return _carrying;
			}
			set
			{
				if (_carrying == value)
				{
					return;
				}
				_carrying = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("CarryingDisposal")] 
		public gamebbScriptID_Bool CarryingDisposal
		{
			get
			{
				if (_carryingDisposal == null)
				{
					_carryingDisposal = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "CarryingDisposal", cr2w, this);
				}
				return _carryingDisposal;
			}
			set
			{
				if (_carryingDisposal == value)
				{
					return;
				}
				_carryingDisposal = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("CurrentElevator")] 
		public gamebbScriptID_Variant CurrentElevator
		{
			get
			{
				if (_currentElevator == null)
				{
					_currentElevator = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "CurrentElevator", cr2w, this);
				}
				return _currentElevator;
			}
			set
			{
				if (_currentElevator == value)
				{
					return;
				}
				_currentElevator = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("IsPlayerInsideElevator")] 
		public gamebbScriptID_Bool IsPlayerInsideElevator
		{
			get
			{
				if (_isPlayerInsideElevator == null)
				{
					_isPlayerInsideElevator = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsPlayerInsideElevator", cr2w, this);
				}
				return _isPlayerInsideElevator;
			}
			set
			{
				if (_isPlayerInsideElevator == value)
				{
					return;
				}
				_isPlayerInsideElevator = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("IsPlayerInsideMovingElevator")] 
		public gamebbScriptID_Bool IsPlayerInsideMovingElevator
		{
			get
			{
				if (_isPlayerInsideMovingElevator == null)
				{
					_isPlayerInsideMovingElevator = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsPlayerInsideMovingElevator", cr2w, this);
				}
				return _isPlayerInsideMovingElevator;
			}
			set
			{
				if (_isPlayerInsideMovingElevator == value)
				{
					return;
				}
				_isPlayerInsideMovingElevator = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("Combat")] 
		public gamebbScriptID_Int32 Combat
		{
			get
			{
				if (_combat == null)
				{
					_combat = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Combat", cr2w, this);
				}
				return _combat;
			}
			set
			{
				if (_combat == value)
				{
					return;
				}
				_combat = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("Stamina")] 
		public gamebbScriptID_Int32 Stamina
		{
			get
			{
				if (_stamina == null)
				{
					_stamina = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Stamina", cr2w, this);
				}
				return _stamina;
			}
			set
			{
				if (_stamina == value)
				{
					return;
				}
				_stamina = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("Vitals")] 
		public gamebbScriptID_Int32 Vitals
		{
			get
			{
				if (_vitals == null)
				{
					_vitals = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Vitals", cr2w, this);
				}
				return _vitals;
			}
			set
			{
				if (_vitals == value)
				{
					return;
				}
				_vitals = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("Takedown")] 
		public gamebbScriptID_Int32 Takedown
		{
			get
			{
				if (_takedown == null)
				{
					_takedown = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Takedown", cr2w, this);
				}
				return _takedown;
			}
			set
			{
				if (_takedown == value)
				{
					return;
				}
				_takedown = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("Fall")] 
		public gamebbScriptID_Int32 Fall
		{
			get
			{
				if (_fall == null)
				{
					_fall = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Fall", cr2w, this);
				}
				return _fall;
			}
			set
			{
				if (_fall == value)
				{
					return;
				}
				_fall = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("Landing")] 
		public gamebbScriptID_Int32 Landing
		{
			get
			{
				if (_landing == null)
				{
					_landing = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Landing", cr2w, this);
				}
				return _landing;
			}
			set
			{
				if (_landing == value)
				{
					return;
				}
				_landing = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("UsingCover")] 
		public gamebbScriptID_Bool UsingCover
		{
			get
			{
				if (_usingCover == null)
				{
					_usingCover = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "UsingCover", cr2w, this);
				}
				return _usingCover;
			}
			set
			{
				if (_usingCover == value)
				{
					return;
				}
				_usingCover = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("IsInMinigame")] 
		public gamebbScriptID_Bool IsInMinigame
		{
			get
			{
				if (_isInMinigame == null)
				{
					_isInMinigame = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsInMinigame", cr2w, this);
				}
				return _isInMinigame;
			}
			set
			{
				if (_isInMinigame == value)
				{
					return;
				}
				_isInMinigame = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("IsUploadingQuickHack")] 
		public gamebbScriptID_Int32 IsUploadingQuickHack
		{
			get
			{
				if (_isUploadingQuickHack == null)
				{
					_isUploadingQuickHack = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "IsUploadingQuickHack", cr2w, this);
				}
				return _isUploadingQuickHack;
			}
			set
			{
				if (_isUploadingQuickHack == value)
				{
					return;
				}
				_isUploadingQuickHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("EntityIDTargetingPlayer")] 
		public gamebbScriptID_EntityID EntityIDTargetingPlayer
		{
			get
			{
				if (_entityIDTargetingPlayer == null)
				{
					_entityIDTargetingPlayer = (gamebbScriptID_EntityID) CR2WTypeManager.Create("gamebbScriptID_EntityID", "EntityIDTargetingPlayer", cr2w, this);
				}
				return _entityIDTargetingPlayer;
			}
			set
			{
				if (_entityIDTargetingPlayer == value)
				{
					return;
				}
				_entityIDTargetingPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("Swimming")] 
		public gamebbScriptID_Int32 Swimming
		{
			get
			{
				if (_swimming == null)
				{
					_swimming = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Swimming", cr2w, this);
				}
				return _swimming;
			}
			set
			{
				if (_swimming == value)
				{
					return;
				}
				_swimming = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("BodyCarrying")] 
		public gamebbScriptID_Int32 BodyCarrying
		{
			get
			{
				if (_bodyCarrying == null)
				{
					_bodyCarrying = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "BodyCarrying", cr2w, this);
				}
				return _bodyCarrying;
			}
			set
			{
				if (_bodyCarrying == value)
				{
					return;
				}
				_bodyCarrying = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("BodyCarryingLocomotion")] 
		public gamebbScriptID_Int32 BodyCarryingLocomotion
		{
			get
			{
				if (_bodyCarryingLocomotion == null)
				{
					_bodyCarryingLocomotion = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "BodyCarryingLocomotion", cr2w, this);
				}
				return _bodyCarryingLocomotion;
			}
			set
			{
				if (_bodyCarryingLocomotion == value)
				{
					return;
				}
				_bodyCarryingLocomotion = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("BodyDisposalDetailed")] 
		public gamebbScriptID_Int32 BodyDisposalDetailed
		{
			get
			{
				if (_bodyDisposalDetailed == null)
				{
					_bodyDisposalDetailed = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "BodyDisposalDetailed", cr2w, this);
				}
				return _bodyDisposalDetailed;
			}
			set
			{
				if (_bodyDisposalDetailed == value)
				{
					return;
				}
				_bodyDisposalDetailed = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("DisplayDeathMenu")] 
		public gamebbScriptID_Bool DisplayDeathMenu
		{
			get
			{
				if (_displayDeathMenu == null)
				{
					_displayDeathMenu = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "DisplayDeathMenu", cr2w, this);
				}
				return _displayDeathMenu;
			}
			set
			{
				if (_displayDeathMenu == value)
				{
					return;
				}
				_displayDeathMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("OverrideQuickHackPanelDilation")] 
		public gamebbScriptID_Bool OverrideQuickHackPanelDilation
		{
			get
			{
				if (_overrideQuickHackPanelDilation == null)
				{
					_overrideQuickHackPanelDilation = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "OverrideQuickHackPanelDilation", cr2w, this);
				}
				return _overrideQuickHackPanelDilation;
			}
			set
			{
				if (_overrideQuickHackPanelDilation == value)
				{
					return;
				}
				_overrideQuickHackPanelDilation = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("NanoWireLaunchMode")] 
		public gamebbScriptID_Int32 NanoWireLaunchMode
		{
			get
			{
				if (_nanoWireLaunchMode == null)
				{
					_nanoWireLaunchMode = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "NanoWireLaunchMode", cr2w, this);
				}
				return _nanoWireLaunchMode;
			}
			set
			{
				if (_nanoWireLaunchMode == value)
				{
					return;
				}
				_nanoWireLaunchMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("IsMovingHorizontally")] 
		public gamebbScriptID_Bool IsMovingHorizontally
		{
			get
			{
				if (_isMovingHorizontally == null)
				{
					_isMovingHorizontally = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsMovingHorizontally", cr2w, this);
				}
				return _isMovingHorizontally;
			}
			set
			{
				if (_isMovingHorizontally == value)
				{
					return;
				}
				_isMovingHorizontally = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("IsMovingVertically")] 
		public gamebbScriptID_Bool IsMovingVertically
		{
			get
			{
				if (_isMovingVertically == null)
				{
					_isMovingVertically = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsMovingVertically", cr2w, this);
				}
				return _isMovingVertically;
			}
			set
			{
				if (_isMovingVertically == value)
				{
					return;
				}
				_isMovingVertically = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("ActionRestriction")] 
		public gamebbScriptID_Variant ActionRestriction
		{
			get
			{
				if (_actionRestriction == null)
				{
					_actionRestriction = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ActionRestriction", cr2w, this);
				}
				return _actionRestriction;
			}
			set
			{
				if (_actionRestriction == value)
				{
					return;
				}
				_actionRestriction = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("MeleeLeap")] 
		public gamebbScriptID_Bool MeleeLeap
		{
			get
			{
				if (_meleeLeap == null)
				{
					_meleeLeap = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "MeleeLeap", cr2w, this);
				}
				return _meleeLeap;
			}
			set
			{
				if (_meleeLeap == value)
				{
					return;
				}
				_meleeLeap = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("IsInWorkspot")] 
		public gamebbScriptID_Int32 IsInWorkspot
		{
			get
			{
				if (_isInWorkspot == null)
				{
					_isInWorkspot = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "IsInWorkspot", cr2w, this);
				}
				return _isInWorkspot;
			}
			set
			{
				if (_isInWorkspot == value)
				{
					return;
				}
				_isInWorkspot = value;
				PropertySet(this);
			}
		}

		public PlayerStateMachineDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
