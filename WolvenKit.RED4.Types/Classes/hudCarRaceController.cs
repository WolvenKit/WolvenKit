using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class hudCarRaceController : gameuiHUDGameController
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
		private CWeakHandle<gameIBlackboard> _activeVehicleUIBlackboard;
		private CWeakHandle<vehicleBaseObject> _activeVehicle;
		private EngineTime _raceStartEngineTime;
		private CUInt32 _factCallbackID;

		[Ordinal(9)] 
		[RED("Countdown")] 
		public inkCanvasWidgetReference Countdown
		{
			get => GetProperty(ref _countdown);
			set => SetProperty(ref _countdown, value);
		}

		[Ordinal(10)] 
		[RED("PositionCounter")] 
		public inkCanvasWidgetReference PositionCounter
		{
			get => GetProperty(ref _positionCounter);
			set => SetProperty(ref _positionCounter, value);
		}

		[Ordinal(11)] 
		[RED("RacePosition")] 
		public inkTextWidgetReference RacePosition
		{
			get => GetProperty(ref _racePosition);
			set => SetProperty(ref _racePosition, value);
		}

		[Ordinal(12)] 
		[RED("RaceTime")] 
		public inkTextWidgetReference RaceTime
		{
			get => GetProperty(ref _raceTime);
			set => SetProperty(ref _raceTime, value);
		}

		[Ordinal(13)] 
		[RED("RaceCheckpoint")] 
		public inkTextWidgetReference RaceCheckpoint
		{
			get => GetProperty(ref _raceCheckpoint);
			set => SetProperty(ref _raceCheckpoint, value);
		}

		[Ordinal(14)] 
		[RED("maxPosition")] 
		public CInt32 MaxPosition
		{
			get => GetProperty(ref _maxPosition);
			set => SetProperty(ref _maxPosition, value);
		}

		[Ordinal(15)] 
		[RED("maxCheckpoint")] 
		public CInt32 MaxCheckpoint
		{
			get => GetProperty(ref _maxCheckpoint);
			set => SetProperty(ref _maxCheckpoint, value);
		}

		[Ordinal(16)] 
		[RED("playerPosition")] 
		public CInt32 PlayerPosition
		{
			get => GetProperty(ref _playerPosition);
			set => SetProperty(ref _playerPosition, value);
		}

		[Ordinal(17)] 
		[RED("minute")] 
		public CInt32 Minute
		{
			get => GetProperty(ref _minute);
			set => SetProperty(ref _minute, value);
		}

		[Ordinal(18)] 
		[RED("activeVehicleUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get => GetProperty(ref _activeVehicleUIBlackboard);
			set => SetProperty(ref _activeVehicleUIBlackboard, value);
		}

		[Ordinal(19)] 
		[RED("activeVehicle")] 
		public CWeakHandle<vehicleBaseObject> ActiveVehicle
		{
			get => GetProperty(ref _activeVehicle);
			set => SetProperty(ref _activeVehicle, value);
		}

		[Ordinal(20)] 
		[RED("raceStartEngineTime")] 
		public EngineTime RaceStartEngineTime
		{
			get => GetProperty(ref _raceStartEngineTime);
			set => SetProperty(ref _raceStartEngineTime, value);
		}

		[Ordinal(21)] 
		[RED("factCallbackID")] 
		public CUInt32 FactCallbackID
		{
			get => GetProperty(ref _factCallbackID);
			set => SetProperty(ref _factCallbackID, value);
		}
	}
}
