using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDesiredSlotsCountInfo : RedBaseClass
	{
		private CFloat _siredSlotsCount;
		private CFloat _nCoeff;

		[Ordinal(0)] 
		[RED("siredSlotsCount")] 
		public CFloat SiredSlotsCount
		{
			get => GetProperty(ref _siredSlotsCount);
			set => SetProperty(ref _siredSlotsCount, value);
		}

		[Ordinal(1)] 
		[RED("nCoeff")] 
		public CFloat NCoeff
		{
			get => GetProperty(ref _nCoeff);
			set => SetProperty(ref _nCoeff, value);
		}
	}
}
