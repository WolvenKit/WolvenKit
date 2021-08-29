using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldFoliagePopulationSpanInfo : RedBaseClass
	{
		private CUInt32 _stancesBegin;
		private CUInt32 _cketBegin;
		private CUInt32 _stancesCount;
		private CUInt32 _cketCount;

		[Ordinal(0)] 
		[RED("stancesBegin")] 
		public CUInt32 StancesBegin
		{
			get => GetProperty(ref _stancesBegin);
			set => SetProperty(ref _stancesBegin, value);
		}

		[Ordinal(1)] 
		[RED("cketBegin")] 
		public CUInt32 CketBegin
		{
			get => GetProperty(ref _cketBegin);
			set => SetProperty(ref _cketBegin, value);
		}

		[Ordinal(2)] 
		[RED("stancesCount")] 
		public CUInt32 StancesCount
		{
			get => GetProperty(ref _stancesCount);
			set => SetProperty(ref _stancesCount, value);
		}

		[Ordinal(3)] 
		[RED("cketCount")] 
		public CUInt32 CketCount
		{
			get => GetProperty(ref _cketCount);
			set => SetProperty(ref _cketCount, value);
		}
	}
}
