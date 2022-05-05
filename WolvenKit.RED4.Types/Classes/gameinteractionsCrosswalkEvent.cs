using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsCrosswalkEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("trafficLightColor")] 
		public CEnum<worldTrafficLightColor> TrafficLightColor
		{
			get => GetPropertyValue<CEnum<worldTrafficLightColor>>();
			set => SetPropertyValue<CEnum<worldTrafficLightColor>>(value);
		}

		[Ordinal(1)] 
		[RED("oldTrafficLightColor")] 
		public CEnum<worldTrafficLightColor> OldTrafficLightColor
		{
			get => GetPropertyValue<CEnum<worldTrafficLightColor>>();
			set => SetPropertyValue<CEnum<worldTrafficLightColor>>(value);
		}

		[Ordinal(2)] 
		[RED("totalDistance")] 
		public CFloat TotalDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("distanceLeft")] 
		public CFloat DistanceLeft
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameinteractionsCrosswalkEvent()
		{
			TrafficLightColor = Enums.worldTrafficLightColor.INVALID;
			OldTrafficLightColor = Enums.worldTrafficLightColor.INVALID;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
