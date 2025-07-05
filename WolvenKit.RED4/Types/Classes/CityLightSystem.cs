using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CityLightSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("timeSystemCallbacks")] 
		public CArray<CHandle<TimetableCallbackData>> TimeSystemCallbacks
		{
			get => GetPropertyValue<CArray<CHandle<TimetableCallbackData>>>();
			set => SetPropertyValue<CArray<CHandle<TimetableCallbackData>>>(value);
		}

		[Ordinal(1)] 
		[RED("fuses")] 
		public CArray<FuseData> Fuses
		{
			get => GetPropertyValue<CArray<FuseData>>();
			set => SetPropertyValue<CArray<FuseData>>(value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<ECLSForcedState> State
		{
			get => GetPropertyValue<CEnum<ECLSForcedState>>();
			set => SetPropertyValue<CEnum<ECLSForcedState>>(value);
		}

		[Ordinal(3)] 
		[RED("forcedStateSource")] 
		public CName ForcedStateSource
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("forcedStatesStack")] 
		public CArray<ForcedStateData> ForcedStatesStack
		{
			get => GetPropertyValue<CArray<ForcedStateData>>();
			set => SetPropertyValue<CArray<ForcedStateData>>(value);
		}

		[Ordinal(5)] 
		[RED("weatherListener")] 
		public CHandle<CLSWeatherListener> WeatherListener
		{
			get => GetPropertyValue<CHandle<CLSWeatherListener>>();
			set => SetPropertyValue<CHandle<CLSWeatherListener>>(value);
		}

		[Ordinal(6)] 
		[RED("turnOffLisenerID")] 
		public CName TurnOffLisenerID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("turnOnLisenerID")] 
		public CName TurnOnLisenerID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("resetLisenerID")] 
		public CName ResetLisenerID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("weatherCallbackId")] 
		public CUInt32 WeatherCallbackId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public CityLightSystem()
		{
			TimeSystemCallbacks = new();
			Fuses = new();
			ForcedStatesStack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
