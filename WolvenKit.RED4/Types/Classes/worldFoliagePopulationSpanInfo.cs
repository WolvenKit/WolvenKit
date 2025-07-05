using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldFoliagePopulationSpanInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stancesBegin")] 
		public CUInt32 StancesBegin
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("cketBegin")] 
		public CUInt32 CketBegin
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("stancesCount")] 
		public CUInt32 StancesCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("cketCount")] 
		public CUInt32 CketCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldFoliagePopulationSpanInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
