using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamBakedDestructionData : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("regionData")] 
		public CArray<meshRegionData> RegionData
		{
			get => GetPropertyValue<CArray<meshRegionData>>();
			set => SetPropertyValue<CArray<meshRegionData>>(value);
		}

		[Ordinal(1)] 
		[RED("indices")] 
		public CArray<DataBuffer> Indices
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		public meshMeshParamBakedDestructionData()
		{
			RegionData = new();
			Indices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
