using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimTrackParameter : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animTrackName")] 
		public CName AnimTrackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entAnimTrackParameter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
