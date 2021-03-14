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
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "Player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("QuickSlotsBB")] 
		public CHandle<gameIBlackboard> QuickSlotsBB
		{
			get
			{
				if (_quickSlotsBB == null)
				{
					_quickSlotsBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "QuickSlotsBB", cr2w, this);
				}
				return _quickSlotsBB;
			}
			set
			{
				if (_quickSlotsBB == value)
				{
					return;
				}
				_quickSlotsBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("IsPlayerInCar")] 
		public CBool IsPlayerInCar
		{
			get
			{
				if (_isPlayerInCar == null)
				{
					_isPlayerInCar = (CBool) CR2WTypeManager.Create("Bool", "IsPlayerInCar", cr2w, this);
				}
				return _isPlayerInCar;
			}
			set
			{
				if (_isPlayerInCar == value)
				{
					return;
				}
				_isPlayerInCar = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("PlayerVehicleID")] 
		public entEntityID PlayerVehicleID
		{
			get
			{
				if (_playerVehicleID == null)
				{
					_playerVehicleID = (entEntityID) CR2WTypeManager.Create("entEntityID", "PlayerVehicleID", cr2w, this);
				}
				return _playerVehicleID;
			}
			set
			{
				if (_playerVehicleID == value)
				{
					return;
				}
				_playerVehicleID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("QuickDpadCommands")] 
		public CArray<QuickSlotCommand> QuickDpadCommands
		{
			get
			{
				if (_quickDpadCommands == null)
				{
					_quickDpadCommands = (CArray<QuickSlotCommand>) CR2WTypeManager.Create("array:QuickSlotCommand", "QuickDpadCommands", cr2w, this);
				}
				return _quickDpadCommands;
			}
			set
			{
				if (_quickDpadCommands == value)
				{
					return;
				}
				_quickDpadCommands = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("QuickDpadCommands_Vehicle")] 
		public CArray<QuickSlotCommand> QuickDpadCommands_Vehicle
		{
			get
			{
				if (_quickDpadCommands_Vehicle == null)
				{
					_quickDpadCommands_Vehicle = (CArray<QuickSlotCommand>) CR2WTypeManager.Create("array:QuickSlotCommand", "QuickDpadCommands_Vehicle", cr2w, this);
				}
				return _quickDpadCommands_Vehicle;
			}
			set
			{
				if (_quickDpadCommands_Vehicle == value)
				{
					return;
				}
				_quickDpadCommands_Vehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("DefaultHoldCommands")] 
		public CArray<QuickSlotCommand> DefaultHoldCommands
		{
			get
			{
				if (_defaultHoldCommands == null)
				{
					_defaultHoldCommands = (CArray<QuickSlotCommand>) CR2WTypeManager.Create("array:QuickSlotCommand", "DefaultHoldCommands", cr2w, this);
				}
				return _defaultHoldCommands;
			}
			set
			{
				if (_defaultHoldCommands == value)
				{
					return;
				}
				_defaultHoldCommands = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("DefaultHoldCommands_Vehicle")] 
		public CArray<QuickSlotCommand> DefaultHoldCommands_Vehicle
		{
			get
			{
				if (_defaultHoldCommands_Vehicle == null)
				{
					_defaultHoldCommands_Vehicle = (CArray<QuickSlotCommand>) CR2WTypeManager.Create("array:QuickSlotCommand", "DefaultHoldCommands_Vehicle", cr2w, this);
				}
				return _defaultHoldCommands_Vehicle;
			}
			set
			{
				if (_defaultHoldCommands_Vehicle == value)
				{
					return;
				}
				_defaultHoldCommands_Vehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("NumberOfItemsPerWheel")] 
		public CInt32 NumberOfItemsPerWheel
		{
			get
			{
				if (_numberOfItemsPerWheel == null)
				{
					_numberOfItemsPerWheel = (CInt32) CR2WTypeManager.Create("Int32", "NumberOfItemsPerWheel", cr2w, this);
				}
				return _numberOfItemsPerWheel;
			}
			set
			{
				if (_numberOfItemsPerWheel == value)
				{
					return;
				}
				_numberOfItemsPerWheel = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("QuickKeyboardCommands")] 
		public CArray<QuickSlotCommand> QuickKeyboardCommands
		{
			get
			{
				if (_quickKeyboardCommands == null)
				{
					_quickKeyboardCommands = (CArray<QuickSlotCommand>) CR2WTypeManager.Create("array:QuickSlotCommand", "QuickKeyboardCommands", cr2w, this);
				}
				return _quickKeyboardCommands;
			}
			set
			{
				if (_quickKeyboardCommands == value)
				{
					return;
				}
				_quickKeyboardCommands = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("QuickKeyboardCommands_Vehicle")] 
		public CArray<QuickSlotCommand> QuickKeyboardCommands_Vehicle
		{
			get
			{
				if (_quickKeyboardCommands_Vehicle == null)
				{
					_quickKeyboardCommands_Vehicle = (CArray<QuickSlotCommand>) CR2WTypeManager.Create("array:QuickSlotCommand", "QuickKeyboardCommands_Vehicle", cr2w, this);
				}
				return _quickKeyboardCommands_Vehicle;
			}
			set
			{
				if (_quickKeyboardCommands_Vehicle == value)
				{
					return;
				}
				_quickKeyboardCommands_Vehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("lastPressAndHoldBtn")] 
		public CHandle<QuickSlotButtonHoldEndEvent> LastPressAndHoldBtn
		{
			get
			{
				if (_lastPressAndHoldBtn == null)
				{
					_lastPressAndHoldBtn = (CHandle<QuickSlotButtonHoldEndEvent>) CR2WTypeManager.Create("handle:QuickSlotButtonHoldEndEvent", "lastPressAndHoldBtn", cr2w, this);
				}
				return _lastPressAndHoldBtn;
			}
			set
			{
				if (_lastPressAndHoldBtn == value)
				{
					return;
				}
				_lastPressAndHoldBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("WheelList_Vehicles")] 
		public CArray<QuickSlotCommand> WheelList_Vehicles
		{
			get
			{
				if (_wheelList_Vehicles == null)
				{
					_wheelList_Vehicles = (CArray<QuickSlotCommand>) CR2WTypeManager.Create("array:QuickSlotCommand", "WheelList_Vehicles", cr2w, this);
				}
				return _wheelList_Vehicles;
			}
			set
			{
				if (_wheelList_Vehicles == value)
				{
					return;
				}
				_wheelList_Vehicles = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("currentWheelItem")] 
		public QuickSlotCommand CurrentWheelItem
		{
			get
			{
				if (_currentWheelItem == null)
				{
					_currentWheelItem = (QuickSlotCommand) CR2WTypeManager.Create("QuickSlotCommand", "currentWheelItem", cr2w, this);
				}
				return _currentWheelItem;
			}
			set
			{
				if (_currentWheelItem == value)
				{
					return;
				}
				_currentWheelItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("currentWeaponWheelItem")] 
		public QuickSlotCommand CurrentWeaponWheelItem
		{
			get
			{
				if (_currentWeaponWheelItem == null)
				{
					_currentWeaponWheelItem = (QuickSlotCommand) CR2WTypeManager.Create("QuickSlotCommand", "currentWeaponWheelItem", cr2w, this);
				}
				return _currentWeaponWheelItem;
			}
			set
			{
				if (_currentWeaponWheelItem == value)
				{
					return;
				}
				_currentWeaponWheelItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("currentGadgetWheelConsumable")] 
		public QuickSlotCommand CurrentGadgetWheelConsumable
		{
			get
			{
				if (_currentGadgetWheelConsumable == null)
				{
					_currentGadgetWheelConsumable = (QuickSlotCommand) CR2WTypeManager.Create("QuickSlotCommand", "currentGadgetWheelConsumable", cr2w, this);
				}
				return _currentGadgetWheelConsumable;
			}
			set
			{
				if (_currentGadgetWheelConsumable == value)
				{
					return;
				}
				_currentGadgetWheelConsumable = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("currentGadgetWheelGadget")] 
		public QuickSlotCommand CurrentGadgetWheelGadget
		{
			get
			{
				if (_currentGadgetWheelGadget == null)
				{
					_currentGadgetWheelGadget = (QuickSlotCommand) CR2WTypeManager.Create("QuickSlotCommand", "currentGadgetWheelGadget", cr2w, this);
				}
				return _currentGadgetWheelGadget;
			}
			set
			{
				if (_currentGadgetWheelGadget == value)
				{
					return;
				}
				_currentGadgetWheelGadget = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("currentVehicleWheelItem")] 
		public QuickSlotCommand CurrentVehicleWheelItem
		{
			get
			{
				if (_currentVehicleWheelItem == null)
				{
					_currentVehicleWheelItem = (QuickSlotCommand) CR2WTypeManager.Create("QuickSlotCommand", "currentVehicleWheelItem", cr2w, this);
				}
				return _currentVehicleWheelItem;
			}
			set
			{
				if (_currentVehicleWheelItem == value)
				{
					return;
				}
				_currentVehicleWheelItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("currentGadgetWheelItem")] 
		public QuickSlotCommand CurrentGadgetWheelItem
		{
			get
			{
				if (_currentGadgetWheelItem == null)
				{
					_currentGadgetWheelItem = (QuickSlotCommand) CR2WTypeManager.Create("QuickSlotCommand", "currentGadgetWheelItem", cr2w, this);
				}
				return _currentGadgetWheelItem;
			}
			set
			{
				if (_currentGadgetWheelItem == value)
				{
					return;
				}
				_currentGadgetWheelItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("currentInteractionWheelItem")] 
		public QuickSlotCommand CurrentInteractionWheelItem
		{
			get
			{
				if (_currentInteractionWheelItem == null)
				{
					_currentInteractionWheelItem = (QuickSlotCommand) CR2WTypeManager.Create("QuickSlotCommand", "currentInteractionWheelItem", cr2w, this);
				}
				return _currentInteractionWheelItem;
			}
			set
			{
				if (_currentInteractionWheelItem == value)
				{
					return;
				}
				_currentInteractionWheelItem = value;
				PropertySet(this);
			}
		}

		public QuickSlotsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
