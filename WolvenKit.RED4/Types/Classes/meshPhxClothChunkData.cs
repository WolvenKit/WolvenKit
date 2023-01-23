using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshPhxClothChunkData : RedBaseClass
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
		[RED("cookedData")] 
		public DataBuffer CookedData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(7)] 
		[RED("normals")] 
		public DataBuffer Normals
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public meshPhxClothChunkData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
