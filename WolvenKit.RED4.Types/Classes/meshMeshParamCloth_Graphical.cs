using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamCloth_Graphical : meshMeshParameter
	{
		private CArray<CArray<CUInt16>> _lodChunkIndices;
		private CArray<meshGfxClothChunkData> _chunks;
		private CArray<CArray<CArray<CUInt16>>> _latchers;

		[Ordinal(0)] 
		[RED("lodChunkIndices")] 
		public CArray<CArray<CUInt16>> LodChunkIndices
		{
			get => GetProperty(ref _lodChunkIndices);
			set => SetProperty(ref _lodChunkIndices, value);
		}

		[Ordinal(1)] 
		[RED("chunks")] 
		public CArray<meshGfxClothChunkData> Chunks
		{
			get => GetProperty(ref _chunks);
			set => SetProperty(ref _chunks, value);
		}

		[Ordinal(2)] 
		[RED("latchers")] 
		public CArray<CArray<CArray<CUInt16>>> Latchers
		{
			get => GetProperty(ref _latchers);
			set => SetProperty(ref _latchers, value);
		}
	}
}
