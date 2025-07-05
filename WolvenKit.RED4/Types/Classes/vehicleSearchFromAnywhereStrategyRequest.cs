using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleSearchFromAnywhereStrategyRequest : vehicleBaseStrategyRequest
	{
		[Ordinal(4)] 
		[RED("angleRange")] 
		public Vector2 AngleRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public vehicleSearchFromAnywhereStrategyRequest()
		{
			Strategy = Enums.vehiclePoliceStrategy.SearchFromAnywhere;
			AngleRange = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
