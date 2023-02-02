using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimProfilerData_SectionTimings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sectionName")] 
		public CName SectionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("updateTimeMS")] 
		public CFloat UpdateTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("sampleTimeMS")] 
		public CFloat SampleTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimProfilerData_SectionTimings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
