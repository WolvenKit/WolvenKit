using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamTerrain : meshMeshParameter
	{
		private CArray<Box> _chunkBoundingBoxes;

		[Ordinal(0)] 
		[RED("chunkBoundingBoxes")] 
		public CArray<Box> ChunkBoundingBoxes
		{
			get => GetProperty(ref _chunkBoundingBoxes);
			set => SetProperty(ref _chunkBoundingBoxes, value);
		}
	}
}
