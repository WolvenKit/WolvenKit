using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimProfilerData_Timings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("avarageExclusiveTimeMS")] 
		public CFloat AvarageExclusiveTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("avarageInclusiveTimeMS")] 
		public CFloat AvarageInclusiveTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimProfilerData_Timings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
