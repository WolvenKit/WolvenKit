using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questWeather_ConditionType : questISystemConditionType
	{
		private CName _weather;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("weather")] 
		public CName Weather
		{
			get => GetProperty(ref _weather);
			set => SetProperty(ref _weather, value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}
	}
}
