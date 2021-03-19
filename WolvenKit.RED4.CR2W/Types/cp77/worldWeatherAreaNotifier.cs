using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWeatherAreaNotifier : worldITriggerAreaNotifer
	{
		private CFloat _horizontalFadeDistance;
		private CFloat _verticalFadeDistance;
		private CArray<CName> _weatherStateNames;
		private CArray<CFloat> _weatherStateValues;

		[Ordinal(3)] 
		[RED("horizontalFadeDistance")] 
		public CFloat HorizontalFadeDistance
		{
			get => GetProperty(ref _horizontalFadeDistance);
			set => SetProperty(ref _horizontalFadeDistance, value);
		}

		[Ordinal(4)] 
		[RED("verticalFadeDistance")] 
		public CFloat VerticalFadeDistance
		{
			get => GetProperty(ref _verticalFadeDistance);
			set => SetProperty(ref _verticalFadeDistance, value);
		}

		[Ordinal(5)] 
		[RED("weatherStateNames")] 
		public CArray<CName> WeatherStateNames
		{
			get => GetProperty(ref _weatherStateNames);
			set => SetProperty(ref _weatherStateNames, value);
		}

		[Ordinal(6)] 
		[RED("weatherStateValues")] 
		public CArray<CFloat> WeatherStateValues
		{
			get => GetProperty(ref _weatherStateValues);
			set => SetProperty(ref _weatherStateValues, value);
		}

		public worldWeatherAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
