using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleBaseStrategyRequest : IScriptable
	{
		[Ordinal(0)] 
		[RED("strategy")] 
		public CEnum<vehiclePoliceStrategy> Strategy
		{
			get => GetPropertyValue<CEnum<vehiclePoliceStrategy>>();
			set => SetPropertyValue<CEnum<vehiclePoliceStrategy>>(value);
		}

		[Ordinal(1)] 
		[RED("distanceRange")] 
		public Vector2 DistanceRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(2)] 
		[RED("minDirectDistance")] 
		public CFloat MinDirectDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("forceArriveFromBehind")] 
		public CBool ForceArriveFromBehind
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleBaseStrategyRequest()
		{
			DistanceRange = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
