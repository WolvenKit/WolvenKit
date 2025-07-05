using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamCloth : meshMeshParameter
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
		public CArray<meshPhxClothChunkData> Chunks
		{
			get => GetPropertyValue<CArray<meshPhxClothChunkData>>();
			set => SetPropertyValue<CArray<meshPhxClothChunkData>>(value);
		}

		[Ordinal(2)] 
		[RED("drivers")] 
		public CArray<CArray<CUInt16>> Drivers
		{
			get => GetPropertyValue<CArray<CArray<CUInt16>>>();
			set => SetPropertyValue<CArray<CArray<CUInt16>>>(value);
		}

		[Ordinal(3)] 
		[RED("capsules")] 
		public CHandle<physicsclothClothCapsuleExportData> Capsules
		{
			get => GetPropertyValue<CHandle<physicsclothClothCapsuleExportData>>();
			set => SetPropertyValue<CHandle<physicsclothClothCapsuleExportData>>(value);
		}

		public meshMeshParamCloth()
		{
			LodChunkIndices = new();
			Chunks = new();
			Drivers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
