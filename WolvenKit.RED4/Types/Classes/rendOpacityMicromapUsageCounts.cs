using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendOpacityMicromapUsageCounts : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bdivisionLevel")] 
		public CUInt32 BdivisionLevel
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("rmat")] 
		public CUInt32 Rmat
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("unt")] 
		public CUInt32 Unt
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public rendOpacityMicromapUsageCounts()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
