using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamGarmentSupport : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("chunkCapVertices")] 
		public CArray<CArray<CUInt32>> ChunkCapVertices
		{
			get => GetPropertyValue<CArray<CArray<CUInt32>>>();
			set => SetPropertyValue<CArray<CArray<CUInt32>>>(value);
		}

		[Ordinal(1)] 
		[RED("customMorph")] 
		public CBool CustomMorph
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public meshMeshParamGarmentSupport()
		{
			ChunkCapVertices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
