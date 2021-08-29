using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderMorphTargetMeshBlobHeader : RedBaseClass
	{
		private CUInt32 _version;
		private CUInt32 _numDiffs;
		private CUInt32 _numDiffsMapping;
		private CUInt32 _numTargets;
		private CArray<CUInt32> _targetStartsInVertexDiffs;
		private CArray<CUInt32> _targetStartsInVertexDiffsMapping;
		private CArray<Vector4> _targetPositionDiffScale;
		private CArray<Vector4> _targetPositionDiffOffset;
		private CArray<CArray<CUInt32>> _numVertexDiffsInEachChunk;
		private CArray<CArray<CUInt32>> _numVertexDiffsMappingInEachChunk;
		private CArray<rendRenderMorphTargetMeshBlobTextureData> _targetTextureDiffsData;

		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(1)] 
		[RED("numDiffs")] 
		public CUInt32 NumDiffs
		{
			get => GetProperty(ref _numDiffs);
			set => SetProperty(ref _numDiffs, value);
		}

		[Ordinal(2)] 
		[RED("numDiffsMapping")] 
		public CUInt32 NumDiffsMapping
		{
			get => GetProperty(ref _numDiffsMapping);
			set => SetProperty(ref _numDiffsMapping, value);
		}

		[Ordinal(3)] 
		[RED("numTargets")] 
		public CUInt32 NumTargets
		{
			get => GetProperty(ref _numTargets);
			set => SetProperty(ref _numTargets, value);
		}

		[Ordinal(4)] 
		[RED("targetStartsInVertexDiffs")] 
		public CArray<CUInt32> TargetStartsInVertexDiffs
		{
			get => GetProperty(ref _targetStartsInVertexDiffs);
			set => SetProperty(ref _targetStartsInVertexDiffs, value);
		}

		[Ordinal(5)] 
		[RED("targetStartsInVertexDiffsMapping")] 
		public CArray<CUInt32> TargetStartsInVertexDiffsMapping
		{
			get => GetProperty(ref _targetStartsInVertexDiffsMapping);
			set => SetProperty(ref _targetStartsInVertexDiffsMapping, value);
		}

		[Ordinal(6)] 
		[RED("targetPositionDiffScale")] 
		public CArray<Vector4> TargetPositionDiffScale
		{
			get => GetProperty(ref _targetPositionDiffScale);
			set => SetProperty(ref _targetPositionDiffScale, value);
		}

		[Ordinal(7)] 
		[RED("targetPositionDiffOffset")] 
		public CArray<Vector4> TargetPositionDiffOffset
		{
			get => GetProperty(ref _targetPositionDiffOffset);
			set => SetProperty(ref _targetPositionDiffOffset, value);
		}

		[Ordinal(8)] 
		[RED("numVertexDiffsInEachChunk")] 
		public CArray<CArray<CUInt32>> NumVertexDiffsInEachChunk
		{
			get => GetProperty(ref _numVertexDiffsInEachChunk);
			set => SetProperty(ref _numVertexDiffsInEachChunk, value);
		}

		[Ordinal(9)] 
		[RED("numVertexDiffsMappingInEachChunk")] 
		public CArray<CArray<CUInt32>> NumVertexDiffsMappingInEachChunk
		{
			get => GetProperty(ref _numVertexDiffsMappingInEachChunk);
			set => SetProperty(ref _numVertexDiffsMappingInEachChunk, value);
		}

		[Ordinal(10)] 
		[RED("targetTextureDiffsData")] 
		public CArray<rendRenderMorphTargetMeshBlobTextureData> TargetTextureDiffsData
		{
			get => GetProperty(ref _targetTextureDiffsData);
			set => SetProperty(ref _targetTextureDiffsData, value);
		}
	}
}
