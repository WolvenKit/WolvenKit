using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleInterceptAtNextIntersectionStrategyRequest : vehicleBaseStrategyRequest
	{
		[Ordinal(4)] 
		[RED("distancesToIntersectionRatio")] 
		public CFloat DistancesToIntersectionRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleInterceptAtNextIntersectionStrategyRequest()
		{
			Strategy = Enums.vehiclePoliceStrategy.InterceptAtNextIntersection;
			DistancesToIntersectionRatio = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
