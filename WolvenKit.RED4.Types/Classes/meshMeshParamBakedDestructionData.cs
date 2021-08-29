using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamBakedDestructionData : meshMeshParameter
	{
		private CArray<meshRegionData> _regionData;
		private CArray<DataBuffer> _indices;

		[Ordinal(0)] 
		[RED("regionData")] 
		public CArray<meshRegionData> RegionData
		{
			get => GetProperty(ref _regionData);
			set => SetProperty(ref _regionData, value);
		}

		[Ordinal(1)] 
		[RED("indices")] 
		public CArray<DataBuffer> Indices
		{
			get => GetProperty(ref _indices);
			set => SetProperty(ref _indices, value);
		}
	}
}
