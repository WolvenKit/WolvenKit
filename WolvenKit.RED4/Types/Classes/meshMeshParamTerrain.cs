using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamTerrain : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("chunkBoundingBoxes")] 
		public CArray<Box> ChunkBoundingBoxes
		{
			get => GetPropertyValue<CArray<Box>>();
			set => SetPropertyValue<CArray<Box>>(value);
		}

		public meshMeshParamTerrain()
		{
			ChunkBoundingBoxes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
