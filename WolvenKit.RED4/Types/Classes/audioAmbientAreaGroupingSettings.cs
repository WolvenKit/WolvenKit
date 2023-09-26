using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAmbientAreaGroupingSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("GroupCountTag")] 
		public CName GroupCountTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("GroupCountRtpc")] 
		public CName GroupCountRtpc
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("GroupAvgDistanceRtpc")] 
		public CName GroupAvgDistanceRtpc
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("groupingVariant")] 
		public CEnum<audioAmbientGroupingVariant> GroupingVariant
		{
			get => GetPropertyValue<CEnum<audioAmbientGroupingVariant>>();
			set => SetPropertyValue<CEnum<audioAmbientGroupingVariant>>(value);
		}

		[Ordinal(4)] 
		[RED("MinDistance")] 
		public CFloat MinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("MaxDistance")] 
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("GroupingVerticallimit")] 
		public CFloat GroupingVerticallimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioAmbientAreaGroupingSettings()
		{
			MaxDistance = 100.000000F;
			GroupingVerticallimit = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
