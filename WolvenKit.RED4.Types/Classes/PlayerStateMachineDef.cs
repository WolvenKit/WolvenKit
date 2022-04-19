using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerStateMachineDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("Locomotion")] 
		public gamebbScriptID_Int32 Locomotion
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("LocomotionDetailed")] 
		public gamebbScriptID_Int32 LocomotionDetailed
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(2)] 
		[RED("HighLevel")] 
		public gamebbScriptID_Int32 HighLevel
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(3)] 
		[RED("UpperBody")] 
		public gamebbScriptID_Int32 UpperBody
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("TimeDilation")] 
		public gamebbScriptID_Int32 TimeDilation
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(5)] 
		[RED("Weapon")] 
		public gamebbScriptID_Int32 Weapon
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(6)] 
		[RED("Melee")] 
		public gamebbScriptID_Int32 Melee
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(7)] 
		[RED("UI")] 
		public gamebbScriptID_Int32 UI
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(8)] 
		[RED("Crosshair")] 
		public gamebbScriptID_Int32 Crosshair
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(9)] 
		[RED("Reaction")] 
		public gamebbScriptID_Int32 Reaction
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(10)] 
		[RED("Zones")] 
		public gamebbScriptID_Int32 Zones
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(11)] 
		[RED("SecurityZoneData")] 
		public gamebbScriptID_Variant SecurityZoneData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(12)] 
		[RED("Vision")] 
		public gamebbScriptID_Int32 Vision
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(13)] 
		[RED("VisionDebug")] 
		public gamebbScriptID_Int32 VisionDebug
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(14)] 
		[RED("SceneTier")] 
		public gamebbScriptID_Int32 SceneTier
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(15)] 
		[RED("CombatGadget")] 
		public gamebbScriptID_Int32 CombatGadget
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(16)] 
		[RED("LastCombatGadgetUsed")] 
		public gamebbScriptID_Variant LastCombatGadgetUsed
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(17)] 
		[RED("Consumable")] 
		public gamebbScriptID_Int32 Consumable
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(18)] 
		[RED("Vehicle")] 
		public gamebbScriptID_Int32 Vehicle
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(19)] 
		[RED("MountedToCombatVehicle")] 
		public gamebbScriptID_Bool MountedToCombatVehicle
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(20)] 
		[RED("MountedToVehicle")] 
		public gamebbScriptID_Bool MountedToVehicle
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(21)] 
		[RED("ZoomLevel")] 
		public gamebbScriptID_Float ZoomLevel
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(22)] 
		[RED("MaxZoomLevel")] 
		public gamebbScriptID_Int32 MaxZoomLevel
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(23)] 
		[RED("ToggleFireMode")] 
		public gamebbScriptID_Bool ToggleFireMode
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(24)] 
		[RED("SwitchWeapon")] 
		public gamebbScriptID_Bool SwitchWeapon
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(25)] 
		[RED("IsDoorInteractionActive")] 
		public gamebbScriptID_Bool IsDoorInteractionActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(26)] 
		[RED("IsInteractingWithDevice")] 
		public gamebbScriptID_Bool IsInteractingWithDevice
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(27)] 
		[RED("IsInteractingViaPersonalLink")] 
		public gamebbScriptID_Bool IsInteractingViaPersonalLink
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(28)] 
		[RED("IsForceOpeningDoor")] 
		public gamebbScriptID_Bool IsForceOpeningDoor
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(29)] 
		[RED("IsControllingDevice")] 
		public gamebbScriptID_Bool IsControllingDevice
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(30)] 
		[RED("IsUIZoomDevice")] 
		public gamebbScriptID_Bool IsUIZoomDevice
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(31)] 
		[RED("UseUnarmed")] 
		public gamebbScriptID_Bool UseUnarmed
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(32)] 
		[RED("Berserk")] 
		public gamebbScriptID_Int32 Berserk
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(33)] 
		[RED("ActiveCyberware")] 
		public gamebbScriptID_Int32 ActiveCyberware
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(34)] 
		[RED("Whip")] 
		public gamebbScriptID_Int32 Whip
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(35)] 
		[RED("DEBUG_SilencedWeapon")] 
		public gamebbScriptID_Bool DEBUG_SilencedWeapon
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(36)] 
		[RED("LeftHandCyberware")] 
		public gamebbScriptID_Int32 LeftHandCyberware
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(37)] 
		[RED("UseLeftHand")] 
		public gamebbScriptID_Bool UseLeftHand
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(38)] 
		[RED("MeleeWeapon")] 
		public gamebbScriptID_Int32 MeleeWeapon
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(39)] 
		[RED("Carrying")] 
		public gamebbScriptID_Bool Carrying
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(40)] 
		[RED("CarryingDisposal")] 
		public gamebbScriptID_Bool CarryingDisposal
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(41)] 
		[RED("CurrentElevator")] 
		public gamebbScriptID_Variant CurrentElevator
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(42)] 
		[RED("IsPlayerInsideElevator")] 
		public gamebbScriptID_Bool IsPlayerInsideElevator
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(43)] 
		[RED("IsPlayerInsideMovingElevator")] 
		public gamebbScriptID_Bool IsPlayerInsideMovingElevator
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(44)] 
		[RED("Combat")] 
		public gamebbScriptID_Int32 Combat
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(45)] 
		[RED("Stamina")] 
		public gamebbScriptID_Int32 Stamina
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(46)] 
		[RED("Vitals")] 
		public gamebbScriptID_Int32 Vitals
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(47)] 
		[RED("Takedown")] 
		public gamebbScriptID_Int32 Takedown
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(48)] 
		[RED("Fall")] 
		public gamebbScriptID_Int32 Fall
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(49)] 
		[RED("Landing")] 
		public gamebbScriptID_Int32 Landing
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(50)] 
		[RED("UsingCover")] 
		public gamebbScriptID_Bool UsingCover
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(51)] 
		[RED("IsInMinigame")] 
		public gamebbScriptID_Bool IsInMinigame
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(52)] 
		[RED("IsUploadingQuickHack")] 
		public gamebbScriptID_Int32 IsUploadingQuickHack
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(53)] 
		[RED("EntityIDTargetingPlayer")] 
		public gamebbScriptID_EntityID EntityIDTargetingPlayer
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(54)] 
		[RED("Swimming")] 
		public gamebbScriptID_Int32 Swimming
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(55)] 
		[RED("BodyCarrying")] 
		public gamebbScriptID_Int32 BodyCarrying
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(56)] 
		[RED("BodyCarryingLocomotion")] 
		public gamebbScriptID_Int32 BodyCarryingLocomotion
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(57)] 
		[RED("BodyDisposalDetailed")] 
		public gamebbScriptID_Int32 BodyDisposalDetailed
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(58)] 
		[RED("DisplayDeathMenu")] 
		public gamebbScriptID_Bool DisplayDeathMenu
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(59)] 
		[RED("OverrideQuickHackPanelDilation")] 
		public gamebbScriptID_Bool OverrideQuickHackPanelDilation
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(60)] 
		[RED("NanoWireLaunchMode")] 
		public gamebbScriptID_Int32 NanoWireLaunchMode
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(61)] 
		[RED("IsMovingHorizontally")] 
		public gamebbScriptID_Bool IsMovingHorizontally
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(62)] 
		[RED("IsMovingVertically")] 
		public gamebbScriptID_Bool IsMovingVertically
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(63)] 
		[RED("ActionRestriction")] 
		public gamebbScriptID_Variant ActionRestriction
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(64)] 
		[RED("MeleeLeap")] 
		public gamebbScriptID_Bool MeleeLeap
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(65)] 
		[RED("IsInWorkspot")] 
		public gamebbScriptID_Int32 IsInWorkspot
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(66)] 
		[RED("QuestForceShoot")] 
		public gamebbScriptID_Bool QuestForceShoot
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(67)] 
		[RED("LadderCameraParams")] 
		public gamebbScriptID_Int32 LadderCameraParams
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(68)] 
		[RED("SceneAimForced")] 
		public gamebbScriptID_Bool SceneAimForced
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(69)] 
		[RED("SceneSafeForced")] 
		public gamebbScriptID_Bool SceneSafeForced
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(70)] 
		[RED("SceneWeaponLoweringSpeedOverride")] 
		public gamebbScriptID_Float SceneWeaponLoweringSpeedOverride
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(71)] 
		[RED("IgnoreBarbedWireStateEnterTime")] 
		public gamebbScriptID_Float IgnoreBarbedWireStateEnterTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(72)] 
		[RED("IsInLoreAnimationScene")] 
		public gamebbScriptID_Bool IsInLoreAnimationScene
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public PlayerStateMachineDef()
		{
			Locomotion = new();
			LocomotionDetailed = new();
			HighLevel = new();
			UpperBody = new();
			TimeDilation = new();
			Weapon = new();
			Melee = new();
			UI = new();
			Crosshair = new();
			Reaction = new();
			Zones = new();
			SecurityZoneData = new();
			Vision = new();
			VisionDebug = new();
			SceneTier = new();
			CombatGadget = new();
			LastCombatGadgetUsed = new();
			Consumable = new();
			Vehicle = new();
			MountedToCombatVehicle = new();
			MountedToVehicle = new();
			ZoomLevel = new();
			MaxZoomLevel = new();
			ToggleFireMode = new();
			SwitchWeapon = new();
			IsDoorInteractionActive = new();
			IsInteractingWithDevice = new();
			IsInteractingViaPersonalLink = new();
			IsForceOpeningDoor = new();
			IsControllingDevice = new();
			IsUIZoomDevice = new();
			UseUnarmed = new();
			Berserk = new();
			ActiveCyberware = new();
			Whip = new();
			DEBUG_SilencedWeapon = new();
			LeftHandCyberware = new();
			UseLeftHand = new();
			MeleeWeapon = new();
			Carrying = new();
			CarryingDisposal = new();
			CurrentElevator = new();
			IsPlayerInsideElevator = new();
			IsPlayerInsideMovingElevator = new();
			Combat = new();
			Stamina = new();
			Vitals = new();
			Takedown = new();
			Fall = new();
			Landing = new();
			UsingCover = new();
			IsInMinigame = new();
			IsUploadingQuickHack = new();
			EntityIDTargetingPlayer = new();
			Swimming = new();
			BodyCarrying = new();
			BodyCarryingLocomotion = new();
			BodyDisposalDetailed = new();
			DisplayDeathMenu = new();
			OverrideQuickHackPanelDilation = new();
			NanoWireLaunchMode = new();
			IsMovingHorizontally = new();
			IsMovingVertically = new();
			ActionRestriction = new();
			MeleeLeap = new();
			IsInWorkspot = new();
			QuestForceShoot = new();
			LadderCameraParams = new();
			SceneAimForced = new();
			SceneSafeForced = new();
			SceneWeaponLoweringSpeedOverride = new();
			IgnoreBarbedWireStateEnterTime = new();
			IsInLoreAnimationScene = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
