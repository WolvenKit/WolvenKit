using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class garmentMeshParamGarment : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("chunks")] 
		public CArray<garmentMeshParamGarmentChunkData> Chunks
		{
			get => GetPropertyValue<CArray<garmentMeshParamGarmentChunkData>>();
			set => SetPropertyValue<CArray<garmentMeshParamGarmentChunkData>>(value);
		}

		public garmentMeshParamGarment()
		{
			Chunks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
