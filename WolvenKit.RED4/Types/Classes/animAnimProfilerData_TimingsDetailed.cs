using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimProfilerData_TimingsDetailed : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("avarageExclusiveUpdateTimeMS")] 
		public CFloat AvarageExclusiveUpdateTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("avarageInclusiveUpdateTimeMS")] 
		public CFloat AvarageInclusiveUpdateTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("avarageExclusiveSampleTimeMS")] 
		public CFloat AvarageExclusiveSampleTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("avarageInclusiveSampleTimeMS")] 
		public CFloat AvarageInclusiveSampleTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("totalExclusiveUpdateTimeMS")] 
		public CFloat TotalExclusiveUpdateTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("totalInclusiveUpdateTimeMS")] 
		public CFloat TotalInclusiveUpdateTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("totalExclusiveSampleTimeMS")] 
		public CFloat TotalExclusiveSampleTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("totalInclusiveSampleTimeMS")] 
		public CFloat TotalInclusiveSampleTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("updatesCount")] 
		public CUInt32 UpdatesCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("samplesCount")] 
		public CUInt32 SamplesCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animAnimProfilerData_TimingsDetailed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
