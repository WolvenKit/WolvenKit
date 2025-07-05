using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamCloth_Graphical : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("lodChunkIndices")] 
		public CArray<CArray<CUInt16>> LodChunkIndices
		{
			get => GetPropertyValue<CArray<CArray<CUInt16>>>();
			set => SetPropertyValue<CArray<CArray<CUInt16>>>(value);
		}

		[Ordinal(1)] 
		[RED("chunks")] 
		public CArray<meshGfxClothChunkData> Chunks
		{
			get => GetPropertyValue<CArray<meshGfxClothChunkData>>();
			set => SetPropertyValue<CArray<meshGfxClothChunkData>>(value);
		}

		[Ordinal(2)] 
		[RED("latchers")] 
		public CArray<CArray<CArray<CUInt16>>> Latchers
		{
			get => GetPropertyValue<CArray<CArray<CArray<CUInt16>>>>();
			set => SetPropertyValue<CArray<CArray<CArray<CUInt16>>>>(value);
		}

		public meshMeshParamCloth_Graphical()
		{
			LodChunkIndices = new();
			Chunks = new();
			Latchers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
