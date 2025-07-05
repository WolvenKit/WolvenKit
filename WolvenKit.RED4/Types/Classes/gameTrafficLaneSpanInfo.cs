using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTrafficLaneSpanInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("laneId")] 
		public worldTrafficLaneUID LaneId
		{
			get => GetPropertyValue<worldTrafficLaneUID>();
			set => SetPropertyValue<worldTrafficLaneUID>(value);
		}

		[Ordinal(1)] 
		[RED("laneX1")] 
		public CFloat LaneX1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("laneX2")] 
		public CFloat LaneX2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameTrafficLaneSpanInfo()
		{
			LaneId = new worldTrafficLaneUID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
