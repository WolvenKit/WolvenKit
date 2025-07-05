using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStreamingQueryDataResource : CResource
	{
		[Ordinal(1)] 
		[RED("roadDatas")] 
		public CArray<worldStreamingQueryRoadData> RoadDatas
		{
			get => GetPropertyValue<CArray<worldStreamingQueryRoadData>>();
			set => SetPropertyValue<CArray<worldStreamingQueryRoadData>>(value);
		}

		[Ordinal(2)] 
		[RED("connectedRoadDataIndices")] 
		public CArray<CUInt16> ConnectedRoadDataIndices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		public worldStreamingQueryDataResource()
		{
			RoadDatas = new();
			ConnectedRoadDataIndices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
