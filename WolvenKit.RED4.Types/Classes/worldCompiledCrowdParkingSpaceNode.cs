using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCompiledCrowdParkingSpaceNode : worldNode
	{
		[Ordinal(4)] 
		[RED("crowdCreationIndex")] 
		public CUInt32 CrowdCreationIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("parkingSpaceId")] 
		public CUInt32 ParkingSpaceId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldCompiledCrowdParkingSpaceNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
