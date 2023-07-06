using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficLaneCrowdFragment : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("desiredSlotCountsPerTimePeriod", 4)] 
		public CStatic<worldDesiredSlotsCountInfo> DesiredSlotCountsPerTimePeriod
		{
			get => GetPropertyValue<CStatic<worldDesiredSlotsCountInfo>>();
			set => SetPropertyValue<CStatic<worldDesiredSlotsCountInfo>>(value);
		}

		[Ordinal(1)] 
		[RED("crowdCreationDataIndex")] 
		public CUInt32 CrowdCreationDataIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("laneX1")] 
		public CFloat LaneX1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("laneX2")] 
		public CFloat LaneX2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldTrafficLaneCrowdFragment()
		{
			DesiredSlotCountsPerTimePeriod = new(4);
			CrowdCreationDataIndex = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
