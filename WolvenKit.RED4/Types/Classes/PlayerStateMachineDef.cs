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
		[RED("LatestWeaponReloadTime")] 
		public gamebbScriptID_Float LatestWeaponReloadTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(7)] 
		[RED("Melee")] 
		public gamebbScriptID_Int32 Melee
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(8)] 
		[RED("UI")] 
		public gamebbScriptID_Int32 UI
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(9)] 
		[RED("Crosshair")] 
		public gamebbScriptID_Int32 Crosshair
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(10)] 
		[RED("Reaction")] 
		public gamebbScriptID_Int32 Reaction
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(11)] 
		[RED("Zones")] 
		public gamebbScriptID_Int32 Zones
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(12)] 
		[RED("SecurityZoneData")] 
		public gamebbScriptID_Variant SecurityZoneData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(13)] 
		[RED("Vision")] 
		public gamebbScriptID_Int32 Vision
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(14)] 
		[RED("VisionDebug")] 
		public gamebbScriptID_Int32 VisionDebug
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(15)] 
		[RED("SceneTier")] 
		public gamebbScriptID_Int32 SceneTier
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(16)] 
		[RED("CombatGadget")] 
		public gamebbScriptID_Int32 CombatGadget
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(17)] 
		[RED("LastCombatGadgetUsed")] 
		public gamebbScriptID_Variant LastCombatGadgetUsed
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(18)] 
		[RED("Consumable")] 
		public gamebbScriptID_Int32 Consumable
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(19)] 
		[RED("Vehicle")] 
		public gamebbScriptID_Int32 Vehicle
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(20)] 
		[RED("MountedToVehicleInDriverSeat")] 
		public gamebbScriptID_Bool MountedToVehicleInDriverSeat
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(21)] 
		[RED("MountedToCombatVehicle")] 
		public gamebbScriptID_Bool MountedToCombatVehicle
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(22)] 
		[RED("MountedToVehicle")] 
		public gamebbScriptID_Bool MountedToVehicle
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(23)] 
		[RED("InArmoredVehicle")] 
		public gamebbScriptID_Bool InArmoredVehicle
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(24)] 
		[RED("ZoomLevel")] 
		public gamebbScriptID_Float ZoomLevel
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(25)] 
		[RED("MaxZoomLevel")] 
		public gamebbScriptID_Int32 MaxZoomLevel
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(26)] 
		[RED("ToggleFireMode")] 
		public gamebbScriptID_Bool ToggleFireMode
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(27)] 
		[RED("SwitchWeapon")] 
		public gamebbScriptID_Bool SwitchWeapon
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(28)] 
		[RED("IsDoorInteractionActive")] 
		public gamebbScriptID_Bool IsDoorInteractionActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(29)] 
		[RED("FinisherTarget")] 
		public gamebbScriptID_EntityID FinisherTarget
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(30)] 
		[RED("IsInteractingWithDevice")] 
		public gamebbScriptID_Bool IsInteractingWithDevice
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(31)] 
		[RED("IsInteractingViaPersonalLink")] 
		public gamebbScriptID_Bool IsInteractingViaPersonalLink
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(32)] 
		[RED("IsForceOpeningDoor")] 
		public gamebbScriptID_Bool IsForceOpeningDoor
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(33)] 
		[RED("IsControllingDevice")] 
		public gamebbScriptID_Bool IsControllingDevice
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(34)] 
		[RED("IsControllingCamera")] 
		public gamebbScriptID_Bool IsControllingCamera
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(35)] 
		[RED("IsUIZoomDevice")] 
		public gamebbScriptID_Bool IsUIZoomDevice
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(36)] 
		[RED("UIZoomDeviceID")] 
		public gamebbScriptID_EntityID UIZoomDeviceID
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(37)] 
		[RED("UseUnarmed")] 
		public gamebbScriptID_Bool UseUnarmed
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(38)] 
		[RED("Berserk")] 
		public gamebbScriptID_Int32 Berserk
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(39)] 
		[RED("ActiveCyberware")] 
		public gamebbScriptID_Int32 ActiveCyberware
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(40)] 
		[RED("Whip")] 
		public gamebbScriptID_Int32 Whip
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(41)] 
		[RED("DEBUG_SilencedWeapon")] 
		public gamebbScriptID_Bool DEBUG_SilencedWeapon
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(42)] 
		[RED("LeftHandCyberware")] 
		public gamebbScriptID_Int32 LeftHandCyberware
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(43)] 
		[RED("UseLeftHand")] 
		public gamebbScriptID_Bool UseLeftHand
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(44)] 
		[RED("MeleeWeapon")] 
		public gamebbScriptID_Int32 MeleeWeapon
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(45)] 
		[RED("Carrying")] 
		public gamebbScriptID_Bool Carrying
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(46)] 
		[RED("CarryingDisposal")] 
		public gamebbScriptID_Bool CarryingDisposal
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(47)] 
		[RED("CurrentElevator")] 
		public gamebbScriptID_Variant CurrentElevator
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(48)] 
		[RED("IsPlayerInsideElevator")] 
		public gamebbScriptID_Bool IsPlayerInsideElevator
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(49)] 
		[RED("IsPlayerInsideMovingElevator")] 
		public gamebbScriptID_Bool IsPlayerInsideMovingElevator
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(50)] 
		[RED("Combat")] 
		public gamebbScriptID_Int32 Combat
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(51)] 
		[RED("Stamina")] 
		public gamebbScriptID_Int32 Stamina
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(52)] 
		[RED("Vitals")] 
		public gamebbScriptID_Int32 Vitals
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(53)] 
		[RED("Takedown")] 
		public gamebbScriptID_Int32 Takedown
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(54)] 
		[RED("TakedownTargetID")] 
		public gamebbScriptID_EntityID TakedownTargetID
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(55)] 
		[RED("Fall")] 
		public gamebbScriptID_Int32 Fall
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(56)] 
		[RED("Landing")] 
		public gamebbScriptID_Int32 Landing
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(57)] 
		[RED("UsingCover")] 
		public gamebbScriptID_Bool UsingCover
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(58)] 
		[RED("IsInMinigame")] 
		public gamebbScriptID_Bool IsInMinigame
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(59)] 
		[RED("UploadingQuickHackIDs")] 
		public gamebbScriptID_Variant UploadingQuickHackIDs
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(60)] 
		[RED("CostFreeActionID")] 
		public gamebbScriptID_Variant CostFreeActionID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(61)] 
		[RED("AmountOfCostFreeActions")] 
		public gamebbScriptID_Int32 AmountOfCostFreeActions
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(62)] 
		[RED("MeleeSpreadableQuickhackActionID")] 
		public gamebbScriptID_Variant MeleeSpreadableQuickhackActionID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(63)] 
		[RED("EntityIDTargetingPlayer")] 
		public gamebbScriptID_EntityID EntityIDTargetingPlayer
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(64)] 
		[RED("EntityIDVehicleRemoteControlled")] 
		public gamebbScriptID_EntityID EntityIDVehicleRemoteControlled
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(65)] 
		[RED("IsVehicleRemoteControlCameraTPP")] 
		public gamebbScriptID_Bool IsVehicleRemoteControlCameraTPP
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(66)] 
		[RED("Swimming")] 
		public gamebbScriptID_Int32 Swimming
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(67)] 
		[RED("BodyCarrying")] 
		public gamebbScriptID_Int32 BodyCarrying
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(68)] 
		[RED("BodyDisposalDetailed")] 
		public gamebbScriptID_Int32 BodyDisposalDetailed
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(69)] 
		[RED("DisplayDeathMenu")] 
		public gamebbScriptID_Bool DisplayDeathMenu
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(70)] 
		[RED("OverrideQuickHackPanelDilation")] 
		public gamebbScriptID_Bool OverrideQuickHackPanelDilation
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(71)] 
		[RED("NanoWireLaunchMode")] 
		public gamebbScriptID_Int32 NanoWireLaunchMode
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(72)] 
		[RED("IsMovingHorizontally")] 
		public gamebbScriptID_Bool IsMovingHorizontally
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(73)] 
		[RED("IsMovingVertically")] 
		public gamebbScriptID_Bool IsMovingVertically
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(74)] 
		[RED("IsOnGround")] 
		public gamebbScriptID_Bool IsOnGround
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(75)] 
		[RED("MinElevation")] 
		public gamebbScriptID_Float MinElevation
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(76)] 
		[RED("MaxElevation")] 
		public gamebbScriptID_Float MaxElevation
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(77)] 
		[RED("ActionRestriction")] 
		public gamebbScriptID_Variant ActionRestriction
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(78)] 
		[RED("MeleeLeap")] 
		public gamebbScriptID_Bool MeleeLeap
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(79)] 
		[RED("IsInWorkspot")] 
		public gamebbScriptID_Int32 IsInWorkspot
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(80)] 
		[RED("QuestForceShoot")] 
		public gamebbScriptID_Bool QuestForceShoot
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(81)] 
		[RED("LadderCameraParams")] 
		public gamebbScriptID_Int32 LadderCameraParams
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(82)] 
		[RED("DodgeTimeStamp")] 
		public gamebbScriptID_Float DodgeTimeStamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(83)] 
		[RED("CanOnePunch")] 
		public gamebbScriptID_Bool CanOnePunch
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(84)] 
		[RED("HasSmartGunLockedOnTarget")] 
		public gamebbScriptID_Bool HasSmartGunLockedOnTarget
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(85)] 
		[RED("SceneAimForced")] 
		public gamebbScriptID_Bool SceneAimForced
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(86)] 
		[RED("SceneSafeForced")] 
		public gamebbScriptID_Bool SceneSafeForced
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(87)] 
		[RED("SceneWeaponLoweringSpeedOverride")] 
		public gamebbScriptID_Float SceneWeaponLoweringSpeedOverride
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(88)] 
		[RED("ScenePreventFirstEquip")] 
		public gamebbScriptID_Bool ScenePreventFirstEquip
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(89)] 
		[RED("MountedPreventFirstEquip")] 
		public gamebbScriptID_Bool MountedPreventFirstEquip
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(90)] 
		[RED("IgnoreBarbedWireStateEnterTime")] 
		public gamebbScriptID_Float IgnoreBarbedWireStateEnterTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(91)] 
		[RED("IsInLoreAnimationScene")] 
		public gamebbScriptID_Bool IsInLoreAnimationScene
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(92)] 
		[RED("Felled")] 
		public gamebbScriptID_Bool Felled
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(93)] 
		[RED("IsVehicleInTPP")] 
		public gamebbScriptID_Bool IsVehicleInTPP
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(94)] 
		[RED("IsDriverCombatInTPP")] 
		public gamebbScriptID_Bool IsDriverCombatInTPP
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(95)] 
		[RED("DriverCombatWeaponType")] 
		public gamebbScriptID_Int32 DriverCombatWeaponType
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(96)] 
		[RED("TrackedTarget")] 
		public gamebbScriptID_Variant TrackedTarget
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(97)] 
		[RED("TPPAimPosition")] 
		public gamebbScriptID_Vector4 TPPAimPosition
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(98)] 
		[RED("BodySlamBump")] 
		public gamebbScriptID_Int32 BodySlamBump
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(99)] 
		[RED("IsInBodySlamState")] 
		public gamebbScriptID_Bool IsInBodySlamState
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(100)] 
		[RED("AimInTimeRemaining")] 
		public gamebbScriptID_Float AimInTimeRemaining
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(101)] 
		[RED("AimInTime")] 
		public gamebbScriptID_Float AimInTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(102)] 
		[RED("CanThrowCarriedNPC")] 
		public gamebbScriptID_Bool CanThrowCarriedNPC
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(103)] 
		[RED("IsWeaponFirstEquip")] 
		public gamebbScriptID_Bool IsWeaponFirstEquip
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public PlayerStateMachineDef()
		{
			Locomotion = new gamebbScriptID_Int32();
			LocomotionDetailed = new gamebbScriptID_Int32();
			HighLevel = new gamebbScriptID_Int32();
			UpperBody = new gamebbScriptID_Int32();
			TimeDilation = new gamebbScriptID_Int32();
			Weapon = new gamebbScriptID_Int32();
			LatestWeaponReloadTime = new gamebbScriptID_Float();
			Melee = new gamebbScriptID_Int32();
			UI = new gamebbScriptID_Int32();
			Crosshair = new gamebbScriptID_Int32();
			Reaction = new gamebbScriptID_Int32();
			Zones = new gamebbScriptID_Int32();
			SecurityZoneData = new gamebbScriptID_Variant();
			Vision = new gamebbScriptID_Int32();
			VisionDebug = new gamebbScriptID_Int32();
			SceneTier = new gamebbScriptID_Int32();
			CombatGadget = new gamebbScriptID_Int32();
			LastCombatGadgetUsed = new gamebbScriptID_Variant();
			Consumable = new gamebbScriptID_Int32();
			Vehicle = new gamebbScriptID_Int32();
			MountedToVehicleInDriverSeat = new gamebbScriptID_Bool();
			MountedToCombatVehicle = new gamebbScriptID_Bool();
			MountedToVehicle = new gamebbScriptID_Bool();
			InArmoredVehicle = new gamebbScriptID_Bool();
			ZoomLevel = new gamebbScriptID_Float();
			MaxZoomLevel = new gamebbScriptID_Int32();
			ToggleFireMode = new gamebbScriptID_Bool();
			SwitchWeapon = new gamebbScriptID_Bool();
			IsDoorInteractionActive = new gamebbScriptID_Bool();
			FinisherTarget = new gamebbScriptID_EntityID();
			IsInteractingWithDevice = new gamebbScriptID_Bool();
			IsInteractingViaPersonalLink = new gamebbScriptID_Bool();
			IsForceOpeningDoor = new gamebbScriptID_Bool();
			IsControllingDevice = new gamebbScriptID_Bool();
			IsControllingCamera = new gamebbScriptID_Bool();
			IsUIZoomDevice = new gamebbScriptID_Bool();
			UIZoomDeviceID = new gamebbScriptID_EntityID();
			UseUnarmed = new gamebbScriptID_Bool();
			Berserk = new gamebbScriptID_Int32();
			ActiveCyberware = new gamebbScriptID_Int32();
			Whip = new gamebbScriptID_Int32();
			DEBUG_SilencedWeapon = new gamebbScriptID_Bool();
			LeftHandCyberware = new gamebbScriptID_Int32();
			UseLeftHand = new gamebbScriptID_Bool();
			MeleeWeapon = new gamebbScriptID_Int32();
			Carrying = new gamebbScriptID_Bool();
			CarryingDisposal = new gamebbScriptID_Bool();
			CurrentElevator = new gamebbScriptID_Variant();
			IsPlayerInsideElevator = new gamebbScriptID_Bool();
			IsPlayerInsideMovingElevator = new gamebbScriptID_Bool();
			Combat = new gamebbScriptID_Int32();
			Stamina = new gamebbScriptID_Int32();
			Vitals = new gamebbScriptID_Int32();
			Takedown = new gamebbScriptID_Int32();
			TakedownTargetID = new gamebbScriptID_EntityID();
			Fall = new gamebbScriptID_Int32();
			Landing = new gamebbScriptID_Int32();
			UsingCover = new gamebbScriptID_Bool();
			IsInMinigame = new gamebbScriptID_Bool();
			UploadingQuickHackIDs = new gamebbScriptID_Variant();
			CostFreeActionID = new gamebbScriptID_Variant();
			AmountOfCostFreeActions = new gamebbScriptID_Int32();
			MeleeSpreadableQuickhackActionID = new gamebbScriptID_Variant();
			EntityIDTargetingPlayer = new gamebbScriptID_EntityID();
			EntityIDVehicleRemoteControlled = new gamebbScriptID_EntityID();
			IsVehicleRemoteControlCameraTPP = new gamebbScriptID_Bool();
			Swimming = new gamebbScriptID_Int32();
			BodyCarrying = new gamebbScriptID_Int32();
			BodyDisposalDetailed = new gamebbScriptID_Int32();
			DisplayDeathMenu = new gamebbScriptID_Bool();
			OverrideQuickHackPanelDilation = new gamebbScriptID_Bool();
			NanoWireLaunchMode = new gamebbScriptID_Int32();
			IsMovingHorizontally = new gamebbScriptID_Bool();
			IsMovingVertically = new gamebbScriptID_Bool();
			IsOnGround = new gamebbScriptID_Bool();
			MinElevation = new gamebbScriptID_Float();
			MaxElevation = new gamebbScriptID_Float();
			ActionRestriction = new gamebbScriptID_Variant();
			MeleeLeap = new gamebbScriptID_Bool();
			IsInWorkspot = new gamebbScriptID_Int32();
			QuestForceShoot = new gamebbScriptID_Bool();
			LadderCameraParams = new gamebbScriptID_Int32();
			DodgeTimeStamp = new gamebbScriptID_Float();
			CanOnePunch = new gamebbScriptID_Bool();
			HasSmartGunLockedOnTarget = new gamebbScriptID_Bool();
			SceneAimForced = new gamebbScriptID_Bool();
			SceneSafeForced = new gamebbScriptID_Bool();
			SceneWeaponLoweringSpeedOverride = new gamebbScriptID_Float();
			ScenePreventFirstEquip = new gamebbScriptID_Bool();
			MountedPreventFirstEquip = new gamebbScriptID_Bool();
			IgnoreBarbedWireStateEnterTime = new gamebbScriptID_Float();
			IsInLoreAnimationScene = new gamebbScriptID_Bool();
			Felled = new gamebbScriptID_Bool();
			IsVehicleInTPP = new gamebbScriptID_Bool();
			IsDriverCombatInTPP = new gamebbScriptID_Bool();
			DriverCombatWeaponType = new gamebbScriptID_Int32();
			TrackedTarget = new gamebbScriptID_Variant();
			TPPAimPosition = new gamebbScriptID_Vector4();
			BodySlamBump = new gamebbScriptID_Int32();
			IsInBodySlamState = new gamebbScriptID_Bool();
			AimInTimeRemaining = new gamebbScriptID_Float();
			AimInTime = new gamebbScriptID_Float();
			CanThrowCarriedNPC = new gamebbScriptID_Bool();
			IsWeaponFirstEquip = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
