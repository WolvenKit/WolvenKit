using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsSoundParameter : redEvent
	{
		[Ordinal(0)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("parameterValue")] 
		public CFloat ParameterValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameaudioeventsSoundParameter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
