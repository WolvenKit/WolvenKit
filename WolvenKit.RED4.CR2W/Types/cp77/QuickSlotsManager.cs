using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsManager : gameScriptableComponent
	{
		private wCHandle<PlayerPuppet> _player;
		private CHandle<gameIBlackboard> _quickSlotsBB;
		private CBool _isPlayerInCar;
		private entEntityID _playerVehicleID;
		private CArray<QuickSlotCommand> _quickDpadCommands;
		private CArray<QuickSlotCommand> _quickDpadCommands_Vehicle;
		private CArray<QuickSlotCommand> _defaultHoldCommands;
		private CArray<QuickSlotCommand> _defaultHoldCommands_Vehicle;
		private CInt32 _numberOfItemsPerWheel;
		private CArray<QuickSlotCommand> _quickKeyboardCommands;
		private CArray<QuickSlotCommand> _quickKeyboardCommands_Vehicle;
		private CHandle<QuickSlotButtonHoldEndEvent> _lastPressAndHoldBtn;
		private CArray<QuickSlotCommand> _wheelList_Vehicles;
		private QuickSlotCommand _currentWheelItem;
		private QuickSlotCommand _currentWeaponWheelItem;
		private QuickSlotCommand _currentGadgetWheelConsumable;
		private QuickSlotCommand _currentGadgetWheelGadget;
		private QuickSlotCommand _currentVehicleWheelItem;
		private QuickSlotCommand _currentGadgetWheelItem;
		private QuickSlotCommand _currentInteractionWheelItem;

		[Ordinal(5)] 
		[RED("Player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(6)] 
		[RED("QuickSlotsBB")] 
		public CHandle<gameIBlackboard> QuickSlotsBB
		{
			get => GetProperty(ref _quickSlotsBB);
			set => SetProperty(ref _quickSlotsBB, value);
		}

		[Ordinal(7)] 
		[RED("IsPlayerInCar")] 
		public CBool IsPlayerInCar
		{
			get => GetProperty(ref _isPlayerInCar);
			set => SetProperty(ref _isPlayerInCar, value);
		}

		[Ordinal(8)] 
		[RED("PlayerVehicleID")] 
		public entEntityID PlayerVehicleID
		{
			get => GetProperty(ref _playerVehicleID);
			set => SetProperty(ref _playerVehicleID, value);
		}

		[Ordinal(9)] 
		[RED("QuickDpadCommands")] 
		public CArray<QuickSlotCommand> QuickDpadCommands
		{
			get => GetProperty(ref _quickDpadCommands);
			set => SetProperty(ref _quickDpadCommands, value);
		}

		[Ordinal(10)] 
		[RED("QuickDpadCommands_Vehicle")] 
		public CArray<QuickSlotCommand> QuickDpadCommands_Vehicle
		{
			get => GetProperty(ref _quickDpadCommands_Vehicle);
			set => SetProperty(ref _quickDpadCommands_Vehicle, value);
		}

		[Ordinal(11)] 
		[RED("DefaultHoldCommands")] 
		public CArray<QuickSlotCommand> DefaultHoldCommands
		{
			get => GetProperty(ref _defaultHoldCommands);
			set => SetProperty(ref _defaultHoldCommands, value);
		}

		[Ordinal(12)] 
		[RED("DefaultHoldCommands_Vehicle")] 
		public CArray<QuickSlotCommand> DefaultHoldCommands_Vehicle
		{
			get => GetProperty(ref _defaultHoldCommands_Vehicle);
			set => SetProperty(ref _defaultHoldCommands_Vehicle, value);
		}

		[Ordinal(13)] 
		[RED("NumberOfItemsPerWheel")] 
		public CInt32 NumberOfItemsPerWheel
		{
			get => GetProperty(ref _numberOfItemsPerWheel);
			set => SetProperty(ref _numberOfItemsPerWheel, value);
		}

		[Ordinal(14)] 
		[RED("QuickKeyboardCommands")] 
		public CArray<QuickSlotCommand> QuickKeyboardCommands
		{
			get => GetProperty(ref _quickKeyboardCommands);
			set => SetProperty(ref _quickKeyboardCommands, value);
		}

		[Ordinal(15)] 
		[RED("QuickKeyboardCommands_Vehicle")] 
		public CArray<QuickSlotCommand> QuickKeyboardCommands_Vehicle
		{
			get => GetProperty(ref _quickKeyboardCommands_Vehicle);
			set => SetProperty(ref _quickKeyboardCommands_Vehicle, value);
		}

		[Ordinal(16)] 
		[RED("lastPressAndHoldBtn")] 
		public CHandle<QuickSlotButtonHoldEndEvent> LastPressAndHoldBtn
		{
			get => GetProperty(ref _lastPressAndHoldBtn);
			set => SetProperty(ref _lastPressAndHoldBtn, value);
		}

		[Ordinal(17)] 
		[RED("WheelList_Vehicles")] 
		public CArray<QuickSlotCommand> WheelList_Vehicles
		{
			get => GetProperty(ref _wheelList_Vehicles);
			set => SetProperty(ref _wheelList_Vehicles, value);
		}

		[Ordinal(18)] 
		[RED("currentWheelItem")] 
		public QuickSlotCommand CurrentWheelItem
		{
			get => GetProperty(ref _currentWheelItem);
			set => SetProperty(ref _currentWheelItem, value);
		}

		[Ordinal(19)] 
		[RED("currentWeaponWheelItem")] 
		public QuickSlotCommand CurrentWeaponWheelItem
		{
			get => GetProperty(ref _currentWeaponWheelItem);
			set => SetProperty(ref _currentWeaponWheelItem, value);
		}

		[Ordinal(20)] 
		[RED("currentGadgetWheelConsumable")] 
		public QuickSlotCommand CurrentGadgetWheelConsumable
		{
			get => GetProperty(ref _currentGadgetWheelConsumable);
			set => SetProperty(ref _currentGadgetWheelConsumable, value);
		}

		[Ordinal(21)] 
		[RED("currentGadgetWheelGadget")] 
		public QuickSlotCommand CurrentGadgetWheelGadget
		{
			get => GetProperty(ref _currentGadgetWheelGadget);
			set => SetProperty(ref _currentGadgetWheelGadget, value);
		}

		[Ordinal(22)] 
		[RED("currentVehicleWheelItem")] 
		public QuickSlotCommand CurrentVehicleWheelItem
		{
			get => GetProperty(ref _currentVehicleWheelItem);
			set => SetProperty(ref _currentVehicleWheelItem, value);
		}

		[Ordinal(23)] 
		[RED("currentGadgetWheelItem")] 
		public QuickSlotCommand CurrentGadgetWheelItem
		{
			get => GetProperty(ref _currentGadgetWheelItem);
			set => SetProperty(ref _currentGadgetWheelItem, value);
		}

		[Ordinal(24)] 
		[RED("currentInteractionWheelItem")] 
		public QuickSlotCommand CurrentInteractionWheelItem
		{
			get => GetProperty(ref _currentInteractionWheelItem);
			set => SetProperty(ref _currentInteractionWheelItem, value);
		}

		public QuickSlotsManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
