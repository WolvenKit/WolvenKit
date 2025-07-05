using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehiclePatrolNearbyStrategyRequest : vehicleBaseStrategyRequest
	{
		[Ordinal(4)] 
		[RED("angleRange")] 
		public Vector2 AngleRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public vehiclePatrolNearbyStrategyRequest()
		{
			Strategy = Enums.vehiclePoliceStrategy.PatrolNearby;
			AngleRange = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
