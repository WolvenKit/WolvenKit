using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsManager : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("DefaultHoldCommands")] public CArray<QuickSlotCommand> DefaultHoldCommands { get; set; }
		[Ordinal(1)]  [RED("DefaultHoldCommands_Vehicle")] public CArray<QuickSlotCommand> DefaultHoldCommands_Vehicle { get; set; }
		[Ordinal(2)]  [RED("IsPlayerInCar")] public CBool IsPlayerInCar { get; set; }
		[Ordinal(3)]  [RED("NumberOfItemsPerWheel")] public CInt32 NumberOfItemsPerWheel { get; set; }
		[Ordinal(4)]  [RED("Player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(5)]  [RED("PlayerVehicleID")] public entEntityID PlayerVehicleID { get; set; }
		[Ordinal(6)]  [RED("QuickDpadCommands")] public CArray<QuickSlotCommand> QuickDpadCommands { get; set; }
		[Ordinal(7)]  [RED("QuickDpadCommands_Vehicle")] public CArray<QuickSlotCommand> QuickDpadCommands_Vehicle { get; set; }
		[Ordinal(8)]  [RED("QuickKeyboardCommands")] public CArray<QuickSlotCommand> QuickKeyboardCommands { get; set; }
		[Ordinal(9)]  [RED("QuickKeyboardCommands_Vehicle")] public CArray<QuickSlotCommand> QuickKeyboardCommands_Vehicle { get; set; }
		[Ordinal(10)]  [RED("QuickSlotsBB")] public CHandle<gameIBlackboard> QuickSlotsBB { get; set; }
		[Ordinal(11)]  [RED("WheelList_Vehicles")] public CArray<QuickSlotCommand> WheelList_Vehicles { get; set; }
		[Ordinal(12)]  [RED("currentGadgetWheelConsumable")] public QuickSlotCommand CurrentGadgetWheelConsumable { get; set; }
		[Ordinal(13)]  [RED("currentGadgetWheelGadget")] public QuickSlotCommand CurrentGadgetWheelGadget { get; set; }
		[Ordinal(14)]  [RED("currentGadgetWheelItem")] public QuickSlotCommand CurrentGadgetWheelItem { get; set; }
		[Ordinal(15)]  [RED("currentInteractionWheelItem")] public QuickSlotCommand CurrentInteractionWheelItem { get; set; }
		[Ordinal(16)]  [RED("currentVehicleWheelItem")] public QuickSlotCommand CurrentVehicleWheelItem { get; set; }
		[Ordinal(17)]  [RED("currentWeaponWheelItem")] public QuickSlotCommand CurrentWeaponWheelItem { get; set; }
		[Ordinal(18)]  [RED("currentWheelItem")] public QuickSlotCommand CurrentWheelItem { get; set; }
		[Ordinal(19)]  [RED("lastPressAndHoldBtn")] public CHandle<QuickSlotButtonHoldEndEvent> LastPressAndHoldBtn { get; set; }

		public QuickSlotsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
