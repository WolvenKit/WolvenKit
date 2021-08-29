using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamTopologyMetadata : meshMeshParameter
	{
		private DataBuffer _data;
		private CArray<CUInt32> _offsets;
		private CArray<CUInt32> _sizes;

		[Ordinal(0)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("offsets")] 
		public CArray<CUInt32> Offsets
		{
			get => GetProperty(ref _offsets);
			set => SetProperty(ref _offsets, value);
		}

		[Ordinal(2)] 
		[RED("sizes")] 
		public CArray<CUInt32> Sizes
		{
			get => GetProperty(ref _sizes);
			set => SetProperty(ref _sizes, value);
		}
	}
}
