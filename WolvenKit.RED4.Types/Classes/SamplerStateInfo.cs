using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SamplerStateInfo : RedBaseClass
	{
		private CEnum<ETextureFilteringMin> _filteringMin;
		private CEnum<ETextureFilteringMag> _filteringMag;
		private CEnum<ETextureFilteringMip> _filteringMip;
		private CEnum<ETextureAddressing> _addressU;
		private CEnum<ETextureAddressing> _addressV;
		private CEnum<ETextureAddressing> _addressW;
		private CEnum<ETextureComparisonFunction> _comparisonFunc;
		private CUInt8 _register;

		[Ordinal(0)] 
		[RED("filteringMin")] 
		public CEnum<ETextureFilteringMin> FilteringMin
		{
			get => GetProperty(ref _filteringMin);
			set => SetProperty(ref _filteringMin, value);
		}

		[Ordinal(1)] 
		[RED("filteringMag")] 
		public CEnum<ETextureFilteringMag> FilteringMag
		{
			get => GetProperty(ref _filteringMag);
			set => SetProperty(ref _filteringMag, value);
		}

		[Ordinal(2)] 
		[RED("filteringMip")] 
		public CEnum<ETextureFilteringMip> FilteringMip
		{
			get => GetProperty(ref _filteringMip);
			set => SetProperty(ref _filteringMip, value);
		}

		[Ordinal(3)] 
		[RED("addressU")] 
		public CEnum<ETextureAddressing> AddressU
		{
			get => GetProperty(ref _addressU);
			set => SetProperty(ref _addressU, value);
		}

		[Ordinal(4)] 
		[RED("addressV")] 
		public CEnum<ETextureAddressing> AddressV
		{
			get => GetProperty(ref _addressV);
			set => SetProperty(ref _addressV, value);
		}

		[Ordinal(5)] 
		[RED("addressW")] 
		public CEnum<ETextureAddressing> AddressW
		{
			get => GetProperty(ref _addressW);
			set => SetProperty(ref _addressW, value);
		}

		[Ordinal(6)] 
		[RED("comparisonFunc")] 
		public CEnum<ETextureComparisonFunction> ComparisonFunc
		{
			get => GetProperty(ref _comparisonFunc);
			set => SetProperty(ref _comparisonFunc, value);
		}

		[Ordinal(7)] 
		[RED("register")] 
		public CUInt8 Register
		{
			get => GetProperty(ref _register);
			set => SetProperty(ref _register, value);
		}
	}
}
