using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entGarmentParameterComponentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("compiledTriangleIndsData")] 
		public DataBuffer CompiledTriangleIndsData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(1)] 
		[RED("componentID")] 
		public CRUID ComponentID
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(2)] 
		[RED("meshGeometryHash")] 
		public CUInt64 MeshGeometryHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("visibleTrangleIndexBufferHash")] 
		public CUInt64 VisibleTrangleIndexBufferHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(4)] 
		[RED("chunks")] 
		public CArray<entGarmentParameterChunkData> Chunks
		{
			get => GetPropertyValue<CArray<entGarmentParameterChunkData>>();
			set => SetPropertyValue<CArray<entGarmentParameterChunkData>>(value);
		}

		[Ordinal(5)] 
		[RED("chunksCount")] 
		public CUInt32 ChunksCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("hideComponent")] 
		public CBool HideComponent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("bendPowerMultiplier")] 
		public CFloat BendPowerMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("bendPowerOffset")] 
		public CFloat BendPowerOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("smoothingStrength")] 
		public CFloat SmoothingStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("smoothingThreshold")] 
		public CFloat SmoothingThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("smoothingExponent")] 
		public CFloat SmoothingExponent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("smoothingNumNeighbours")] 
		public CUInt32 SmoothingNumNeighbours
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(13)] 
		[RED("garmentBorderThreshold")] 
		public CFloat GarmentBorderThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("removeHiddenTriangles")] 
		public CBool RemoveHiddenTriangles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("disableGarment")] 
		public CBool DisableGarment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("mergeWithInnerLayer")] 
		public CBool MergeWithInnerLayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("numIndices")] 
		public CUInt32 NumIndices
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(18)] 
		[RED("numOffsets")] 
		public CUInt32 NumOffsets
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public entGarmentParameterComponentData()
		{
			Chunks = new();
			BendPowerMultiplier = 1.000000F;
			SmoothingStrength = 1.000000F;
			SmoothingThreshold = 0.100000F;
			SmoothingExponent = 1.000000F;
			SmoothingNumNeighbours = 1;
			GarmentBorderThreshold = 0.500000F;
			RemoveHiddenTriangles = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
