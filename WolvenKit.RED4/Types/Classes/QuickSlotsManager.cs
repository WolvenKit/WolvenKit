using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickSlotsManager : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("Player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(6)] 
		[RED("QuickSlotsBB")] 
		public CWeakHandle<gameIBlackboard> QuickSlotsBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(7)] 
		[RED("IsPlayerInCar")] 
		public CBool IsPlayerInCar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("PlayerVehicleID")] 
		public entEntityID PlayerVehicleID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(9)] 
		[RED("QuickDpadCommands")] 
		public CArray<QuickSlotCommand> QuickDpadCommands
		{
			get => GetPropertyValue<CArray<QuickSlotCommand>>();
			set => SetPropertyValue<CArray<QuickSlotCommand>>(value);
		}

		[Ordinal(10)] 
		[RED("QuickDpadCommands_Vehicle")] 
		public CArray<QuickSlotCommand> QuickDpadCommands_Vehicle
		{
			get => GetPropertyValue<CArray<QuickSlotCommand>>();
			set => SetPropertyValue<CArray<QuickSlotCommand>>(value);
		}

		[Ordinal(11)] 
		[RED("DefaultHoldCommands")] 
		public CArray<QuickSlotCommand> DefaultHoldCommands
		{
			get => GetPropertyValue<CArray<QuickSlotCommand>>();
			set => SetPropertyValue<CArray<QuickSlotCommand>>(value);
		}

		[Ordinal(12)] 
		[RED("DefaultHoldCommands_Vehicle")] 
		public CArray<QuickSlotCommand> DefaultHoldCommands_Vehicle
		{
			get => GetPropertyValue<CArray<QuickSlotCommand>>();
			set => SetPropertyValue<CArray<QuickSlotCommand>>(value);
		}

		[Ordinal(13)] 
		[RED("NumberOfItemsPerWheel")] 
		public CInt32 NumberOfItemsPerWheel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("QuickKeyboardCommands")] 
		public CArray<QuickSlotCommand> QuickKeyboardCommands
		{
			get => GetPropertyValue<CArray<QuickSlotCommand>>();
			set => SetPropertyValue<CArray<QuickSlotCommand>>(value);
		}

		[Ordinal(15)] 
		[RED("QuickKeyboardCommands_Vehicle")] 
		public CArray<QuickSlotCommand> QuickKeyboardCommands_Vehicle
		{
			get => GetPropertyValue<CArray<QuickSlotCommand>>();
			set => SetPropertyValue<CArray<QuickSlotCommand>>(value);
		}

		[Ordinal(16)] 
		[RED("lastPressAndHoldBtn")] 
		public CHandle<QuickSlotButtonHoldEndEvent> LastPressAndHoldBtn
		{
			get => GetPropertyValue<CHandle<QuickSlotButtonHoldEndEvent>>();
			set => SetPropertyValue<CHandle<QuickSlotButtonHoldEndEvent>>(value);
		}

		[Ordinal(17)] 
		[RED("WheelList_Vehicles")] 
		public CArray<QuickSlotCommand> WheelList_Vehicles
		{
			get => GetPropertyValue<CArray<QuickSlotCommand>>();
			set => SetPropertyValue<CArray<QuickSlotCommand>>(value);
		}

		[Ordinal(18)] 
		[RED("currentWheelItem")] 
		public QuickSlotCommand CurrentWheelItem
		{
			get => GetPropertyValue<QuickSlotCommand>();
			set => SetPropertyValue<QuickSlotCommand>(value);
		}

		[Ordinal(19)] 
		[RED("currentWeaponWheelItem")] 
		public QuickSlotCommand CurrentWeaponWheelItem
		{
			get => GetPropertyValue<QuickSlotCommand>();
			set => SetPropertyValue<QuickSlotCommand>(value);
		}

		[Ordinal(20)] 
		[RED("currentGadgetWheelConsumable")] 
		public QuickSlotCommand CurrentGadgetWheelConsumable
		{
			get => GetPropertyValue<QuickSlotCommand>();
			set => SetPropertyValue<QuickSlotCommand>(value);
		}

		[Ordinal(21)] 
		[RED("currentGadgetWheelGadget")] 
		public QuickSlotCommand CurrentGadgetWheelGadget
		{
			get => GetPropertyValue<QuickSlotCommand>();
			set => SetPropertyValue<QuickSlotCommand>(value);
		}

		[Ordinal(22)] 
		[RED("currentVehicleWheelItem")] 
		public QuickSlotCommand CurrentVehicleWheelItem
		{
			get => GetPropertyValue<QuickSlotCommand>();
			set => SetPropertyValue<QuickSlotCommand>(value);
		}

		[Ordinal(23)] 
		[RED("currentGadgetWheelItem")] 
		public QuickSlotCommand CurrentGadgetWheelItem
		{
			get => GetPropertyValue<QuickSlotCommand>();
			set => SetPropertyValue<QuickSlotCommand>(value);
		}

		[Ordinal(24)] 
		[RED("currentInteractionWheelItem")] 
		public QuickSlotCommand CurrentInteractionWheelItem
		{
			get => GetPropertyValue<QuickSlotCommand>();
			set => SetPropertyValue<QuickSlotCommand>(value);
		}

		[Ordinal(25)] 
		[RED("OnVehPlayerStateDataChangedCallback")] 
		public CHandle<redCallbackObject> OnVehPlayerStateDataChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public QuickSlotsManager()
		{
			PlayerVehicleID = new entEntityID();
			QuickDpadCommands = new();
			QuickDpadCommands_Vehicle = new();
			DefaultHoldCommands = new();
			DefaultHoldCommands_Vehicle = new();
			NumberOfItemsPerWheel = 8;
			QuickKeyboardCommands = new();
			QuickKeyboardCommands_Vehicle = new();
			WheelList_Vehicles = new();
			CurrentWheelItem = new QuickSlotCommand { IsSlotUnlocked = true, ItemId = new gameItemID(), PlayerVehicleData = new vehiclePlayerVehicle { VehicleType = Enums.gamedataVehicleType.Invalid, UiFavoriteIndex = -1, DestructionTimeStamp = new EngineTime() }, InteractiveActionOwner = new entEntityID() };
			CurrentWeaponWheelItem = new QuickSlotCommand { IsSlotUnlocked = true, ItemId = new gameItemID(), PlayerVehicleData = new vehiclePlayerVehicle { VehicleType = Enums.gamedataVehicleType.Invalid, UiFavoriteIndex = -1, DestructionTimeStamp = new EngineTime() }, InteractiveActionOwner = new entEntityID() };
			CurrentGadgetWheelConsumable = new QuickSlotCommand { IsSlotUnlocked = true, ItemId = new gameItemID(), PlayerVehicleData = new vehiclePlayerVehicle { VehicleType = Enums.gamedataVehicleType.Invalid, UiFavoriteIndex = -1, DestructionTimeStamp = new EngineTime() }, InteractiveActionOwner = new entEntityID() };
			CurrentGadgetWheelGadget = new QuickSlotCommand { IsSlotUnlocked = true, ItemId = new gameItemID(), PlayerVehicleData = new vehiclePlayerVehicle { VehicleType = Enums.gamedataVehicleType.Invalid, UiFavoriteIndex = -1, DestructionTimeStamp = new EngineTime() }, InteractiveActionOwner = new entEntityID() };
			CurrentVehicleWheelItem = new QuickSlotCommand { IsSlotUnlocked = true, ItemId = new gameItemID(), PlayerVehicleData = new vehiclePlayerVehicle { VehicleType = Enums.gamedataVehicleType.Invalid, UiFavoriteIndex = -1, DestructionTimeStamp = new EngineTime() }, InteractiveActionOwner = new entEntityID() };
			CurrentGadgetWheelItem = new QuickSlotCommand { IsSlotUnlocked = true, ItemId = new gameItemID(), PlayerVehicleData = new vehiclePlayerVehicle { VehicleType = Enums.gamedataVehicleType.Invalid, UiFavoriteIndex = -1, DestructionTimeStamp = new EngineTime() }, InteractiveActionOwner = new entEntityID() };
			CurrentInteractionWheelItem = new QuickSlotCommand { IsSlotUnlocked = true, ItemId = new gameItemID(), PlayerVehicleData = new vehiclePlayerVehicle { VehicleType = Enums.gamedataVehicleType.Invalid, UiFavoriteIndex = -1, DestructionTimeStamp = new EngineTime() }, InteractiveActionOwner = new entEntityID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
