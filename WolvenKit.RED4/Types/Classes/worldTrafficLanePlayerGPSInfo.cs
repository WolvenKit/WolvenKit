using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficLanePlayerGPSInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("subGraphId")] 
		public CUInt16 SubGraphId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("stronglyConnectedComponentId")] 
		public CUInt16 StronglyConnectedComponentId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public worldTrafficLanePlayerGPSInfo()
		{
			SubGraphId = ushort.MaxValue;
			StronglyConnectedComponentId = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
