using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questWeather_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("weather")] 
		public CName Weather
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questWeather_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
