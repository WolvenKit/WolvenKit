using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMorphTargetMeshBlobHeader : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("numDiffs")] 
		public CUInt32 NumDiffs
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("numDiffsMapping")] 
		public CUInt32 NumDiffsMapping
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("numTargets")] 
		public CUInt32 NumTargets
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("targetStartsInVertexDiffs")] 
		public CArray<CUInt32> TargetStartsInVertexDiffs
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(5)] 
		[RED("targetStartsInVertexDiffsMapping")] 
		public CArray<CUInt32> TargetStartsInVertexDiffsMapping
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(6)] 
		[RED("targetPositionDiffScale")] 
		public CArray<Vector4> TargetPositionDiffScale
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(7)] 
		[RED("targetPositionDiffOffset")] 
		public CArray<Vector4> TargetPositionDiffOffset
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(8)] 
		[RED("numVertexDiffsInEachChunk")] 
		public CArray<CArray<CUInt32>> NumVertexDiffsInEachChunk
		{
			get => GetPropertyValue<CArray<CArray<CUInt32>>>();
			set => SetPropertyValue<CArray<CArray<CUInt32>>>(value);
		}

		[Ordinal(9)] 
		[RED("numVertexDiffsMappingInEachChunk")] 
		public CArray<CArray<CUInt32>> NumVertexDiffsMappingInEachChunk
		{
			get => GetPropertyValue<CArray<CArray<CUInt32>>>();
			set => SetPropertyValue<CArray<CArray<CUInt32>>>(value);
		}

		[Ordinal(10)] 
		[RED("targetTextureDiffsData")] 
		public CArray<rendRenderMorphTargetMeshBlobTextureData> TargetTextureDiffsData
		{
			get => GetPropertyValue<CArray<rendRenderMorphTargetMeshBlobTextureData>>();
			set => SetPropertyValue<CArray<rendRenderMorphTargetMeshBlobTextureData>>(value);
		}

		public rendRenderMorphTargetMeshBlobHeader()
		{
			TargetStartsInVertexDiffs = new();
			TargetStartsInVertexDiffsMapping = new();
			TargetPositionDiffScale = new();
			TargetPositionDiffOffset = new();
			NumVertexDiffsInEachChunk = new();
			NumVertexDiffsMappingInEachChunk = new();
			TargetTextureDiffsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
