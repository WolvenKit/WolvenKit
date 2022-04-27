using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficLaneUID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeRefHash")] 
		public CUInt64 NodeRefHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("laneNumber")] 
		public CUInt16 LaneNumber
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("seqNumber")] 
		public CUInt16 SeqNumber
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(3)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldTrafficLaneUID()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
