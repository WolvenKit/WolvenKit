using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldWeatherAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] 
		[RED("horizontalFadeDistance")] 
		public CFloat HorizontalFadeDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("verticalFadeDistance")] 
		public CFloat VerticalFadeDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("weatherStateNames")] 
		public CArray<CName> WeatherStateNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("weatherStateValues")] 
		public CArray<CFloat> WeatherStateValues
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		public worldWeatherAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player | Enums.TriggerChannel.TC_Environment;
			WeatherStateNames = new();
			WeatherStateValues = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
