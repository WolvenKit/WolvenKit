using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCompiledCrowdParkingSpaceNode : worldNode
	{
		private CUInt32 _crowdCreationIndex;
		private CUInt32 _parkingSpaceId;

		[Ordinal(4)] 
		[RED("crowdCreationIndex")] 
		public CUInt32 CrowdCreationIndex
		{
			get => GetProperty(ref _crowdCreationIndex);
			set => SetProperty(ref _crowdCreationIndex, value);
		}

		[Ordinal(5)] 
		[RED("parkingSpaceId")] 
		public CUInt32 ParkingSpaceId
		{
			get => GetProperty(ref _parkingSpaceId);
			set => SetProperty(ref _parkingSpaceId, value);
		}
	}
}
