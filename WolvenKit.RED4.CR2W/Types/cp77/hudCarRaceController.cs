using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudCarRaceController : gameuiHUDGameController
	{
		private inkCanvasWidgetReference _countdown;
		private inkCanvasWidgetReference _positionCounter;
		private inkTextWidgetReference _racePosition;
		private inkTextWidgetReference _raceTime;
		private inkTextWidgetReference _raceCheckpoint;
		private CInt32 _maxPosition;
		private CInt32 _maxCheckpoint;
		private CInt32 _playerPosition;
		private CInt32 _minute;
		private wCHandle<gameIBlackboard> _activeVehicleUIBlackboard;
		private wCHandle<vehicleBaseObject> _activeVehicle;
		private EngineTime _raceStartEngineTime;
		private CUInt32 _factCallbackID;

		[Ordinal(9)] 
		[RED("Countdown")] 
		public inkCanvasWidgetReference Countdown
		{
			get
			{
				if (_countdown == null)
				{
					_countdown = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "Countdown", cr2w, this);
				}
				return _countdown;
			}
			set
			{
				if (_countdown == value)
				{
					return;
				}
				_countdown = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("PositionCounter")] 
		public inkCanvasWidgetReference PositionCounter
		{
			get
			{
				if (_positionCounter == null)
				{
					_positionCounter = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "PositionCounter", cr2w, this);
				}
				return _positionCounter;
			}
			set
			{
				if (_positionCounter == value)
				{
					return;
				}
				_positionCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("RacePosition")] 
		public inkTextWidgetReference RacePosition
		{
			get
			{
				if (_racePosition == null)
				{
					_racePosition = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "RacePosition", cr2w, this);
				}
				return _racePosition;
			}
			set
			{
				if (_racePosition == value)
				{
					return;
				}
				_racePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("RaceTime")] 
		public inkTextWidgetReference RaceTime
		{
			get
			{
				if (_raceTime == null)
				{
					_raceTime = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "RaceTime", cr2w, this);
				}
				return _raceTime;
			}
			set
			{
				if (_raceTime == value)
				{
					return;
				}
				_raceTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("RaceCheckpoint")] 
		public inkTextWidgetReference RaceCheckpoint
		{
			get
			{
				if (_raceCheckpoint == null)
				{
					_raceCheckpoint = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "RaceCheckpoint", cr2w, this);
				}
				return _raceCheckpoint;
			}
			set
			{
				if (_raceCheckpoint == value)
				{
					return;
				}
				_raceCheckpoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("maxPosition")] 
		public CInt32 MaxPosition
		{
			get
			{
				if (_maxPosition == null)
				{
					_maxPosition = (CInt32) CR2WTypeManager.Create("Int32", "maxPosition", cr2w, this);
				}
				return _maxPosition;
			}
			set
			{
				if (_maxPosition == value)
				{
					return;
				}
				_maxPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("maxCheckpoint")] 
		public CInt32 MaxCheckpoint
		{
			get
			{
				if (_maxCheckpoint == null)
				{
					_maxCheckpoint = (CInt32) CR2WTypeManager.Create("Int32", "maxCheckpoint", cr2w, this);
				}
				return _maxCheckpoint;
			}
			set
			{
				if (_maxCheckpoint == value)
				{
					return;
				}
				_maxCheckpoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("playerPosition")] 
		public CInt32 PlayerPosition
		{
			get
			{
				if (_playerPosition == null)
				{
					_playerPosition = (CInt32) CR2WTypeManager.Create("Int32", "playerPosition", cr2w, this);
				}
				return _playerPosition;
			}
			set
			{
				if (_playerPosition == value)
				{
					return;
				}
				_playerPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("minute")] 
		public CInt32 Minute
		{
			get
			{
				if (_minute == null)
				{
					_minute = (CInt32) CR2WTypeManager.Create("Int32", "minute", cr2w, this);
				}
				return _minute;
			}
			set
			{
				if (_minute == value)
				{
					return;
				}
				_minute = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("activeVehicleUIBlackboard")] 
		public wCHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get
			{
				if (_activeVehicleUIBlackboard == null)
				{
					_activeVehicleUIBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "activeVehicleUIBlackboard", cr2w, this);
				}
				return _activeVehicleUIBlackboard;
			}
			set
			{
				if (_activeVehicleUIBlackboard == value)
				{
					return;
				}
				_activeVehicleUIBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("activeVehicle")] 
		public wCHandle<vehicleBaseObject> ActiveVehicle
		{
			get
			{
				if (_activeVehicle == null)
				{
					_activeVehicle = (wCHandle<vehicleBaseObject>) CR2WTypeManager.Create("whandle:vehicleBaseObject", "activeVehicle", cr2w, this);
				}
				return _activeVehicle;
			}
			set
			{
				if (_activeVehicle == value)
				{
					return;
				}
				_activeVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("raceStartEngineTime")] 
		public EngineTime RaceStartEngineTime
		{
			get
			{
				if (_raceStartEngineTime == null)
				{
					_raceStartEngineTime = (EngineTime) CR2WTypeManager.Create("EngineTime", "raceStartEngineTime", cr2w, this);
				}
				return _raceStartEngineTime;
			}
			set
			{
				if (_raceStartEngineTime == value)
				{
					return;
				}
				_raceStartEngineTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("factCallbackID")] 
		public CUInt32 FactCallbackID
		{
			get
			{
				if (_factCallbackID == null)
				{
					_factCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "factCallbackID", cr2w, this);
				}
				return _factCallbackID;
			}
			set
			{
				if (_factCallbackID == value)
				{
					return;
				}
				_factCallbackID = value;
				PropertySet(this);
			}
		}

		public hudCarRaceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
