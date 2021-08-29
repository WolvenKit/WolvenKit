using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CityLightSystem : gameScriptableSystem
	{
		private CArray<CHandle<TimetableCallbackData>> _timeSystemCallbacks;
		private CArray<FuseData> _fuses;
		private CEnum<ECLSForcedState> _state;
		private CName _forcedStateSource;
		private CArray<ForcedStateData> _forcedStatesStack;
		private CHandle<CLSWeatherListener> _weatherListener;
		private CName _turnOffLisenerID;
		private CName _turnOnLisenerID;
		private CName _resetLisenerID;
		private CUInt32 _weatherCallbackId;

		[Ordinal(0)] 
		[RED("timeSystemCallbacks")] 
		public CArray<CHandle<TimetableCallbackData>> TimeSystemCallbacks
		{
			get => GetProperty(ref _timeSystemCallbacks);
			set => SetProperty(ref _timeSystemCallbacks, value);
		}

		[Ordinal(1)] 
		[RED("fuses")] 
		public CArray<FuseData> Fuses
		{
			get => GetProperty(ref _fuses);
			set => SetProperty(ref _fuses, value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<ECLSForcedState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(3)] 
		[RED("forcedStateSource")] 
		public CName ForcedStateSource
		{
			get => GetProperty(ref _forcedStateSource);
			set => SetProperty(ref _forcedStateSource, value);
		}

		[Ordinal(4)] 
		[RED("forcedStatesStack")] 
		public CArray<ForcedStateData> ForcedStatesStack
		{
			get => GetProperty(ref _forcedStatesStack);
			set => SetProperty(ref _forcedStatesStack, value);
		}

		[Ordinal(5)] 
		[RED("weatherListener")] 
		public CHandle<CLSWeatherListener> WeatherListener
		{
			get => GetProperty(ref _weatherListener);
			set => SetProperty(ref _weatherListener, value);
		}

		[Ordinal(6)] 
		[RED("turnOffLisenerID")] 
		public CName TurnOffLisenerID
		{
			get => GetProperty(ref _turnOffLisenerID);
			set => SetProperty(ref _turnOffLisenerID, value);
		}

		[Ordinal(7)] 
		[RED("turnOnLisenerID")] 
		public CName TurnOnLisenerID
		{
			get => GetProperty(ref _turnOnLisenerID);
			set => SetProperty(ref _turnOnLisenerID, value);
		}

		[Ordinal(8)] 
		[RED("resetLisenerID")] 
		public CName ResetLisenerID
		{
			get => GetProperty(ref _resetLisenerID);
			set => SetProperty(ref _resetLisenerID, value);
		}

		[Ordinal(9)] 
		[RED("weatherCallbackId")] 
		public CUInt32 WeatherCallbackId
		{
			get => GetProperty(ref _weatherCallbackId);
			set => SetProperty(ref _weatherCallbackId, value);
		}
	}
}
