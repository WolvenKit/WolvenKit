using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entGarmentParameterComponentData : RedBaseClass
	{
		private DataBuffer _compiledTriangleIndsData;
		private CRUID _componentID;
		private CUInt64 _meshGeometryHash;
		private CUInt64 _visibleTrangleIndexBufferHash;
		private CArray<entGarmentParameterChunkData> _chunks;
		private CUInt32 _chunksCount;
		private CBool _hideComponent;
		private CFloat _bendPowerMultiplier;
		private CFloat _bendPowerOffset;
		private CFloat _smoothingStrength;
		private CFloat _smoothingThreshold;
		private CFloat _smoothingExponent;
		private CUInt32 _smoothingNumNeighbours;
		private CFloat _garmentBorderThreshold;
		private CBool _removeHiddenTriangles;
		private CBool _disableGarment;
		private CBool _mergeWithInnerLayer;
		private CUInt32 _numIndices;
		private CUInt32 _numOffsets;

		[Ordinal(0)] 
		[RED("compiledTriangleIndsData")] 
		public DataBuffer CompiledTriangleIndsData
		{
			get => GetProperty(ref _compiledTriangleIndsData);
			set => SetProperty(ref _compiledTriangleIndsData, value);
		}

		[Ordinal(1)] 
		[RED("componentID")] 
		public CRUID ComponentID
		{
			get => GetProperty(ref _componentID);
			set => SetProperty(ref _componentID, value);
		}

		[Ordinal(2)] 
		[RED("meshGeometryHash")] 
		public CUInt64 MeshGeometryHash
		{
			get => GetProperty(ref _meshGeometryHash);
			set => SetProperty(ref _meshGeometryHash, value);
		}

		[Ordinal(3)] 
		[RED("visibleTrangleIndexBufferHash")] 
		public CUInt64 VisibleTrangleIndexBufferHash
		{
			get => GetProperty(ref _visibleTrangleIndexBufferHash);
			set => SetProperty(ref _visibleTrangleIndexBufferHash, value);
		}

		[Ordinal(4)] 
		[RED("chunks")] 
		public CArray<entGarmentParameterChunkData> Chunks
		{
			get => GetProperty(ref _chunks);
			set => SetProperty(ref _chunks, value);
		}

		[Ordinal(5)] 
		[RED("chunksCount")] 
		public CUInt32 ChunksCount
		{
			get => GetProperty(ref _chunksCount);
			set => SetProperty(ref _chunksCount, value);
		}

		[Ordinal(6)] 
		[RED("hideComponent")] 
		public CBool HideComponent
		{
			get => GetProperty(ref _hideComponent);
			set => SetProperty(ref _hideComponent, value);
		}

		[Ordinal(7)] 
		[RED("bendPowerMultiplier")] 
		public CFloat BendPowerMultiplier
		{
			get => GetProperty(ref _bendPowerMultiplier);
			set => SetProperty(ref _bendPowerMultiplier, value);
		}

		[Ordinal(8)] 
		[RED("bendPowerOffset")] 
		public CFloat BendPowerOffset
		{
			get => GetProperty(ref _bendPowerOffset);
			set => SetProperty(ref _bendPowerOffset, value);
		}

		[Ordinal(9)] 
		[RED("smoothingStrength")] 
		public CFloat SmoothingStrength
		{
			get => GetProperty(ref _smoothingStrength);
			set => SetProperty(ref _smoothingStrength, value);
		}

		[Ordinal(10)] 
		[RED("smoothingThreshold")] 
		public CFloat SmoothingThreshold
		{
			get => GetProperty(ref _smoothingThreshold);
			set => SetProperty(ref _smoothingThreshold, value);
		}

		[Ordinal(11)] 
		[RED("smoothingExponent")] 
		public CFloat SmoothingExponent
		{
			get => GetProperty(ref _smoothingExponent);
			set => SetProperty(ref _smoothingExponent, value);
		}

		[Ordinal(12)] 
		[RED("smoothingNumNeighbours")] 
		public CUInt32 SmoothingNumNeighbours
		{
			get => GetProperty(ref _smoothingNumNeighbours);
			set => SetProperty(ref _smoothingNumNeighbours, value);
		}

		[Ordinal(13)] 
		[RED("garmentBorderThreshold")] 
		public CFloat GarmentBorderThreshold
		{
			get => GetProperty(ref _garmentBorderThreshold);
			set => SetProperty(ref _garmentBorderThreshold, value);
		}

		[Ordinal(14)] 
		[RED("removeHiddenTriangles")] 
		public CBool RemoveHiddenTriangles
		{
			get => GetProperty(ref _removeHiddenTriangles);
			set => SetProperty(ref _removeHiddenTriangles, value);
		}

		[Ordinal(15)] 
		[RED("disableGarment")] 
		public CBool DisableGarment
		{
			get => GetProperty(ref _disableGarment);
			set => SetProperty(ref _disableGarment, value);
		}

		[Ordinal(16)] 
		[RED("mergeWithInnerLayer")] 
		public CBool MergeWithInnerLayer
		{
			get => GetProperty(ref _mergeWithInnerLayer);
			set => SetProperty(ref _mergeWithInnerLayer, value);
		}

		[Ordinal(17)] 
		[RED("numIndices")] 
		public CUInt32 NumIndices
		{
			get => GetProperty(ref _numIndices);
			set => SetProperty(ref _numIndices, value);
		}

		[Ordinal(18)] 
		[RED("numOffsets")] 
		public CUInt32 NumOffsets
		{
			get => GetProperty(ref _numOffsets);
			set => SetProperty(ref _numOffsets, value);
		}
	}
}
