using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class appearanceChunkMaskSettings : RedBaseClass
	{
		private CArray<CUInt64> _chunksIds;
		private CArray<CUInt32> _meshLayout;
		private CUInt64 _meshGeometryHash;

		[Ordinal(0)] 
		[RED("chunksIds")] 
		public CArray<CUInt64> ChunksIds
		{
			get => GetProperty(ref _chunksIds);
			set => SetProperty(ref _chunksIds, value);
		}

		[Ordinal(1)] 
		[RED("meshLayout")] 
		public CArray<CUInt32> MeshLayout
		{
			get => GetProperty(ref _meshLayout);
			set => SetProperty(ref _meshLayout, value);
		}

		[Ordinal(2)] 
		[RED("meshGeometryHash")] 
		public CUInt64 MeshGeometryHash
		{
			get => GetProperty(ref _meshGeometryHash);
			set => SetProperty(ref _meshGeometryHash, value);
		}
	}
}
