using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimProfilerData_TimingsDetailed : RedBaseClass
	{
		private CName _className;
		private CFloat _avarageExclusiveUpdateTimeMS;
		private CFloat _avarageInclusiveUpdateTimeMS;
		private CFloat _avarageExclusiveSampleTimeMS;
		private CFloat _avarageInclusiveSampleTimeMS;
		private CFloat _totalExclusiveUpdateTimeMS;
		private CFloat _totalInclusiveUpdateTimeMS;
		private CFloat _totalExclusiveSampleTimeMS;
		private CFloat _totalInclusiveSampleTimeMS;
		private CUInt32 _updatesCount;
		private CUInt32 _samplesCount;

		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(1)] 
		[RED("avarageExclusiveUpdateTimeMS")] 
		public CFloat AvarageExclusiveUpdateTimeMS
		{
			get => GetProperty(ref _avarageExclusiveUpdateTimeMS);
			set => SetProperty(ref _avarageExclusiveUpdateTimeMS, value);
		}

		[Ordinal(2)] 
		[RED("avarageInclusiveUpdateTimeMS")] 
		public CFloat AvarageInclusiveUpdateTimeMS
		{
			get => GetProperty(ref _avarageInclusiveUpdateTimeMS);
			set => SetProperty(ref _avarageInclusiveUpdateTimeMS, value);
		}

		[Ordinal(3)] 
		[RED("avarageExclusiveSampleTimeMS")] 
		public CFloat AvarageExclusiveSampleTimeMS
		{
			get => GetProperty(ref _avarageExclusiveSampleTimeMS);
			set => SetProperty(ref _avarageExclusiveSampleTimeMS, value);
		}

		[Ordinal(4)] 
		[RED("avarageInclusiveSampleTimeMS")] 
		public CFloat AvarageInclusiveSampleTimeMS
		{
			get => GetProperty(ref _avarageInclusiveSampleTimeMS);
			set => SetProperty(ref _avarageInclusiveSampleTimeMS, value);
		}

		[Ordinal(5)] 
		[RED("totalExclusiveUpdateTimeMS")] 
		public CFloat TotalExclusiveUpdateTimeMS
		{
			get => GetProperty(ref _totalExclusiveUpdateTimeMS);
			set => SetProperty(ref _totalExclusiveUpdateTimeMS, value);
		}

		[Ordinal(6)] 
		[RED("totalInclusiveUpdateTimeMS")] 
		public CFloat TotalInclusiveUpdateTimeMS
		{
			get => GetProperty(ref _totalInclusiveUpdateTimeMS);
			set => SetProperty(ref _totalInclusiveUpdateTimeMS, value);
		}

		[Ordinal(7)] 
		[RED("totalExclusiveSampleTimeMS")] 
		public CFloat TotalExclusiveSampleTimeMS
		{
			get => GetProperty(ref _totalExclusiveSampleTimeMS);
			set => SetProperty(ref _totalExclusiveSampleTimeMS, value);
		}

		[Ordinal(8)] 
		[RED("totalInclusiveSampleTimeMS")] 
		public CFloat TotalInclusiveSampleTimeMS
		{
			get => GetProperty(ref _totalInclusiveSampleTimeMS);
			set => SetProperty(ref _totalInclusiveSampleTimeMS, value);
		}

		[Ordinal(9)] 
		[RED("updatesCount")] 
		public CUInt32 UpdatesCount
		{
			get => GetProperty(ref _updatesCount);
			set => SetProperty(ref _updatesCount, value);
		}

		[Ordinal(10)] 
		[RED("samplesCount")] 
		public CUInt32 SamplesCount
		{
			get => GetProperty(ref _samplesCount);
			set => SetProperty(ref _samplesCount, value);
		}
	}
}
