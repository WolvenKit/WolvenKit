using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerStateMachineDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("VisionDebug")] public gamebbScriptID_Int32 VisionDebug { get; set; }
		[Ordinal(1)]  [RED("DEBUG_SilencedWeapon")] public gamebbScriptID_Bool DEBUG_SilencedWeapon { get; set; }
		[Ordinal(2)]  [RED("Locomotion")] public gamebbScriptID_Int32 Locomotion { get; set; }
		[Ordinal(3)]  [RED("LocomotionDetailed")] public gamebbScriptID_Int32 LocomotionDetailed { get; set; }
		[Ordinal(4)]  [RED("HighLevel")] public gamebbScriptID_Int32 HighLevel { get; set; }
		[Ordinal(5)]  [RED("UpperBody")] public gamebbScriptID_Int32 UpperBody { get; set; }
		[Ordinal(6)]  [RED("TimeDilation")] public gamebbScriptID_Int32 TimeDilation { get; set; }
		[Ordinal(7)]  [RED("Weapon")] public gamebbScriptID_Int32 Weapon { get; set; }
		[Ordinal(8)]  [RED("Melee")] public gamebbScriptID_Int32 Melee { get; set; }
		[Ordinal(9)]  [RED("UI")] public gamebbScriptID_Int32 UI { get; set; }
		[Ordinal(10)]  [RED("Crosshair")] public gamebbScriptID_Int32 Crosshair { get; set; }
		[Ordinal(11)]  [RED("Reaction")] public gamebbScriptID_Int32 Reaction { get; set; }
		[Ordinal(12)]  [RED("Zones")] public gamebbScriptID_Int32 Zones { get; set; }
		[Ordinal(13)]  [RED("SecurityZoneData")] public gamebbScriptID_Variant SecurityZoneData { get; set; }
		[Ordinal(14)]  [RED("Vision")] public gamebbScriptID_Int32 Vision { get; set; }
		[Ordinal(15)]  [RED("SceneTier")] public gamebbScriptID_Int32 SceneTier { get; set; }
		[Ordinal(16)]  [RED("CombatGadget")] public gamebbScriptID_Int32 CombatGadget { get; set; }
		[Ordinal(17)]  [RED("LastCombatGadgetUsed")] public gamebbScriptID_Variant LastCombatGadgetUsed { get; set; }
		[Ordinal(18)]  [RED("Consumable")] public gamebbScriptID_Int32 Consumable { get; set; }
		[Ordinal(19)]  [RED("Vehicle")] public gamebbScriptID_Int32 Vehicle { get; set; }
		[Ordinal(20)]  [RED("ZoomLevel")] public gamebbScriptID_Float ZoomLevel { get; set; }
		[Ordinal(21)]  [RED("MaxZoomLevel")] public gamebbScriptID_Int32 MaxZoomLevel { get; set; }
		[Ordinal(22)]  [RED("ToggleFireMode")] public gamebbScriptID_Bool ToggleFireMode { get; set; }
		[Ordinal(23)]  [RED("SwitchWeapon")] public gamebbScriptID_Bool SwitchWeapon { get; set; }
		[Ordinal(24)]  [RED("IsDoorInteractionActive")] public gamebbScriptID_Bool IsDoorInteractionActive { get; set; }
		[Ordinal(25)]  [RED("IsInteractingWithDevice")] public gamebbScriptID_Bool IsInteractingWithDevice { get; set; }
		[Ordinal(26)]  [RED("IsForceOpeningDoor")] public gamebbScriptID_Bool IsForceOpeningDoor { get; set; }
		[Ordinal(27)]  [RED("IsControllingDevice")] public gamebbScriptID_Bool IsControllingDevice { get; set; }
		[Ordinal(28)]  [RED("IsUIZoomDevice")] public gamebbScriptID_Bool IsUIZoomDevice { get; set; }
		[Ordinal(29)]  [RED("UseUnarmed")] public gamebbScriptID_Bool UseUnarmed { get; set; }
		[Ordinal(30)]  [RED("Berserk")] public gamebbScriptID_Int32 Berserk { get; set; }
		[Ordinal(31)]  [RED("ActiveCyberware")] public gamebbScriptID_Int32 ActiveCyberware { get; set; }
		[Ordinal(32)]  [RED("Whip")] public gamebbScriptID_Int32 Whip { get; set; }
		[Ordinal(33)]  [RED("LeftHandCyberware")] public gamebbScriptID_Int32 LeftHandCyberware { get; set; }
		[Ordinal(34)]  [RED("UseLeftHand")] public gamebbScriptID_Bool UseLeftHand { get; set; }
		[Ordinal(35)]  [RED("MeleeWeapon")] public gamebbScriptID_Int32 MeleeWeapon { get; set; }
		[Ordinal(36)]  [RED("Carrying")] public gamebbScriptID_Bool Carrying { get; set; }
		[Ordinal(37)]  [RED("CarryingDisposal")] public gamebbScriptID_Bool CarryingDisposal { get; set; }
		[Ordinal(38)]  [RED("CurrentElevator")] public gamebbScriptID_Variant CurrentElevator { get; set; }
		[Ordinal(39)]  [RED("IsPlayerInsideElevator")] public gamebbScriptID_Bool IsPlayerInsideElevator { get; set; }
		[Ordinal(40)]  [RED("IsPlayerInsideMovingElevator")] public gamebbScriptID_Bool IsPlayerInsideMovingElevator { get; set; }
		[Ordinal(41)]  [RED("Combat")] public gamebbScriptID_Int32 Combat { get; set; }
		[Ordinal(42)]  [RED("Stamina")] public gamebbScriptID_Int32 Stamina { get; set; }
		[Ordinal(43)]  [RED("Vitals")] public gamebbScriptID_Int32 Vitals { get; set; }
		[Ordinal(44)]  [RED("Takedown")] public gamebbScriptID_Int32 Takedown { get; set; }
		[Ordinal(45)]  [RED("Fall")] public gamebbScriptID_Int32 Fall { get; set; }
		[Ordinal(46)]  [RED("Landing")] public gamebbScriptID_Int32 Landing { get; set; }
		[Ordinal(47)]  [RED("UsingCover")] public gamebbScriptID_Bool UsingCover { get; set; }
		[Ordinal(48)]  [RED("IsInMinigame")] public gamebbScriptID_Bool IsInMinigame { get; set; }
		[Ordinal(49)]  [RED("IsUploadingQuickHack")] public gamebbScriptID_Int32 IsUploadingQuickHack { get; set; }
		[Ordinal(50)]  [RED("EntityIDTargetingPlayer")] public gamebbScriptID_EntityID EntityIDTargetingPlayer { get; set; }
		[Ordinal(51)]  [RED("Swimming")] public gamebbScriptID_Int32 Swimming { get; set; }
		[Ordinal(52)]  [RED("BodyCarrying")] public gamebbScriptID_Int32 BodyCarrying { get; set; }
		[Ordinal(53)]  [RED("BodyCarryingLocomotion")] public gamebbScriptID_Int32 BodyCarryingLocomotion { get; set; }
		[Ordinal(54)]  [RED("BodyDisposalDetailed")] public gamebbScriptID_Int32 BodyDisposalDetailed { get; set; }
		[Ordinal(55)]  [RED("DisplayDeathMenu")] public gamebbScriptID_Bool DisplayDeathMenu { get; set; }
		[Ordinal(56)]  [RED("OverrideQuickHackPanelDilation")] public gamebbScriptID_Bool OverrideQuickHackPanelDilation { get; set; }
		[Ordinal(57)]  [RED("NanoWireLaunchMode")] public gamebbScriptID_Int32 NanoWireLaunchMode { get; set; }
		[Ordinal(58)]  [RED("IsMovingHorizontally")] public gamebbScriptID_Bool IsMovingHorizontally { get; set; }
		[Ordinal(59)]  [RED("IsMovingVertically")] public gamebbScriptID_Bool IsMovingVertically { get; set; }
		[Ordinal(60)]  [RED("ActionRestriction")] public gamebbScriptID_Variant ActionRestriction { get; set; }
		[Ordinal(61)]  [RED("MeleeLeap")] public gamebbScriptID_Bool MeleeLeap { get; set; }
		[Ordinal(62)]  [RED("IsInWorkspot")] public gamebbScriptID_Int32 IsInWorkspot { get; set; }

		public PlayerStateMachineDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
