using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshGfxClothChunkData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("positions")] 
		public DataBuffer Positions
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(1)] 
		[RED("indices")] 
		public DataBuffer Indices
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(2)] 
		[RED("skinWeights")] 
		public DataBuffer SkinWeights
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(3)] 
		[RED("skinIndices")] 
		public DataBuffer SkinIndices
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(4)] 
		[RED("skinWeightsExt")] 
		public DataBuffer SkinWeightsExt
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(5)] 
		[RED("skinIndicesExt")] 
		public DataBuffer SkinIndicesExt
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(6)] 
		[RED("simulation")] 
		public CArray<CUInt16> Simulation
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		public meshGfxClothChunkData()
		{
			Simulation = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
