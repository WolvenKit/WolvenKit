using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SamplerStateInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("filteringMin")] 
		public CEnum<ETextureFilteringMin> FilteringMin
		{
			get => GetPropertyValue<CEnum<ETextureFilteringMin>>();
			set => SetPropertyValue<CEnum<ETextureFilteringMin>>(value);
		}

		[Ordinal(1)] 
		[RED("filteringMag")] 
		public CEnum<ETextureFilteringMag> FilteringMag
		{
			get => GetPropertyValue<CEnum<ETextureFilteringMag>>();
			set => SetPropertyValue<CEnum<ETextureFilteringMag>>(value);
		}

		[Ordinal(2)] 
		[RED("filteringMip")] 
		public CEnum<ETextureFilteringMip> FilteringMip
		{
			get => GetPropertyValue<CEnum<ETextureFilteringMip>>();
			set => SetPropertyValue<CEnum<ETextureFilteringMip>>(value);
		}

		[Ordinal(3)] 
		[RED("addressU")] 
		public CEnum<ETextureAddressing> AddressU
		{
			get => GetPropertyValue<CEnum<ETextureAddressing>>();
			set => SetPropertyValue<CEnum<ETextureAddressing>>(value);
		}

		[Ordinal(4)] 
		[RED("addressV")] 
		public CEnum<ETextureAddressing> AddressV
		{
			get => GetPropertyValue<CEnum<ETextureAddressing>>();
			set => SetPropertyValue<CEnum<ETextureAddressing>>(value);
		}

		[Ordinal(5)] 
		[RED("addressW")] 
		public CEnum<ETextureAddressing> AddressW
		{
			get => GetPropertyValue<CEnum<ETextureAddressing>>();
			set => SetPropertyValue<CEnum<ETextureAddressing>>(value);
		}

		[Ordinal(6)] 
		[RED("comparisonFunc")] 
		public CEnum<ETextureComparisonFunction> ComparisonFunc
		{
			get => GetPropertyValue<CEnum<ETextureComparisonFunction>>();
			set => SetPropertyValue<CEnum<ETextureComparisonFunction>>(value);
		}

		[Ordinal(7)] 
		[RED("register")] 
		public CUInt8 Register
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public SamplerStateInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
