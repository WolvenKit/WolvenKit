using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioRadioStationJingleMetadata : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("introJingleEvent")] 
		public CName IntroJingleEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("introDuration")] 
		public CFloat IntroDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("middleJingleEvent")] 
		public CName MiddleJingleEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("endJingleEvent")] 
		public CName EndJingleEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("outroDuration")] 
		public CFloat OutroDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioRadioStationJingleMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
