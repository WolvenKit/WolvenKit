using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRuntimeSystemWeather : worldIRuntimeSystem
	{
		private CFloat _timeOfDay;
		private CUInt32 _weatherStateIndex;
		private CUInt32 _previousWeatherStateIndex;
		private CUInt32 _forcedWeatherStateIndex;
		private CBool _isForcedWeatherState;

		[Ordinal(0)] 
		[RED("timeOfDay")] 
		public CFloat TimeOfDay
		{
			get => GetProperty(ref _timeOfDay);
			set => SetProperty(ref _timeOfDay, value);
		}

		[Ordinal(1)] 
		[RED("weatherStateIndex")] 
		public CUInt32 WeatherStateIndex
		{
			get => GetProperty(ref _weatherStateIndex);
			set => SetProperty(ref _weatherStateIndex, value);
		}

		[Ordinal(2)] 
		[RED("previousWeatherStateIndex")] 
		public CUInt32 PreviousWeatherStateIndex
		{
			get => GetProperty(ref _previousWeatherStateIndex);
			set => SetProperty(ref _previousWeatherStateIndex, value);
		}

		[Ordinal(3)] 
		[RED("forcedWeatherStateIndex")] 
		public CUInt32 ForcedWeatherStateIndex
		{
			get => GetProperty(ref _forcedWeatherStateIndex);
			set => SetProperty(ref _forcedWeatherStateIndex, value);
		}

		[Ordinal(4)] 
		[RED("isForcedWeatherState")] 
		public CBool IsForcedWeatherState
		{
			get => GetProperty(ref _isForcedWeatherState);
			set => SetProperty(ref _isForcedWeatherState, value);
		}

		public worldRuntimeSystemWeather(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
