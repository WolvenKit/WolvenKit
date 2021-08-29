using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStreamingQueryDataResource : CResource
	{
		private CArray<worldStreamingQueryRoadData> _roadDatas;
		private CArray<CUInt16> _connectedRoadDataIndices;

		[Ordinal(1)] 
		[RED("roadDatas")] 
		public CArray<worldStreamingQueryRoadData> RoadDatas
		{
			get => GetProperty(ref _roadDatas);
			set => SetProperty(ref _roadDatas, value);
		}

		[Ordinal(2)] 
		[RED("connectedRoadDataIndices")] 
		public CArray<CUInt16> ConnectedRoadDataIndices
		{
			get => GetProperty(ref _connectedRoadDataIndices);
			set => SetProperty(ref _connectedRoadDataIndices, value);
		}
	}
}
