using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class garmentMeshParamGarmentChunkData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("numVertices")] 
		public CUInt32 NumVertices
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("lodMask")] 
		public CUInt8 LodMask
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("isTwoSided")] 
		public CBool IsTwoSided
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("vertices")] 
		public DataBuffer Vertices
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(4)] 
		[RED("indices")] 
		public DataBuffer Indices
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(5)] 
		[RED("morphOffsets")] 
		public DataBuffer MorphOffsets
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(6)] 
		[RED("garmentFlags")] 
		public DataBuffer GarmentFlags
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public garmentMeshParamGarmentChunkData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
