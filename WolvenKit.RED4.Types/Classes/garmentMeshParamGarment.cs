using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class garmentMeshParamGarment : meshMeshParameter
	{
		private CArray<garmentMeshParamGarmentChunkData> _chunks;

		[Ordinal(0)] 
		[RED("chunks")] 
		public CArray<garmentMeshParamGarmentChunkData> Chunks
		{
			get => GetProperty(ref _chunks);
			set => SetProperty(ref _chunks, value);
		}
	}
}
