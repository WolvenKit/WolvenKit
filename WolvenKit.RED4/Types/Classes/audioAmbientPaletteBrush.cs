using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAmbientPaletteBrush : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("distributionBucketSize")] 
		public CFloat DistributionBucketSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("virtualHearingRadius")] 
		public CFloat VirtualHearingRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("hearingDistanceCooldown")] 
		public CFloat HearingDistanceCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("eventsPool")] 
		public CArray<CName> EventsPool
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("radioStationMetadata")] 
		public CName RadioStationMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioAmbientPaletteBrush()
		{
			DistributionBucketSize = 10.000000F;
			VirtualHearingRadius = 10.000000F;
			HearingDistanceCooldown = 1.000000F;
			EventsPool = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
