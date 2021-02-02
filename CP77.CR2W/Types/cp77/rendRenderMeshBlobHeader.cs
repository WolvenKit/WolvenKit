using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderMeshBlobHeader : CVariable
	{
		[Ordinal(0)]  [RED("version")] public CUInt32 Version { get; set; }
		[Ordinal(1)]  [RED("dataProcessing")] public CUInt32 DataProcessing { get; set; }
		[Ordinal(2)]  [RED("bonePositions")] public CArray<Vector4> BonePositions { get; set; }
		[Ordinal(3)]  [RED("renderLODs")] public CArray<CFloat> RenderLODs { get; set; }
		[Ordinal(4)]  [RED("renderChunks")] public CArray<CUInt8> RenderChunks { get; set; }
		[Ordinal(5)]  [RED("renderChunkInfos")] public CArray<rendChunk> RenderChunkInfos { get; set; }
		[Ordinal(6)]  [RED("speedTreeWind")] public CArray<CUInt8> SpeedTreeWind { get; set; }
		[Ordinal(7)]  [RED("customData")] public CArray<CUInt8> CustomData { get; set; }
		[Ordinal(8)]  [RED("topologyData")] public CArray<CUInt8> TopologyData { get; set; }
		[Ordinal(9)]  [RED("topologyMetadata")] public CArray<CUInt8> TopologyMetadata { get; set; }
		[Ordinal(10)]  [RED("topology")] public CArray<rendTopologyData> Topology { get; set; }
		[Ordinal(11)]  [RED("customDataElemStride")] public CUInt32 CustomDataElemStride { get; set; }
		[Ordinal(12)]  [RED("topologyDataStride")] public CUInt32 TopologyDataStride { get; set; }
		[Ordinal(13)]  [RED("topologyMetadataStride")] public CUInt32 TopologyMetadataStride { get; set; }
		[Ordinal(14)]  [RED("vertexBufferSize")] public CUInt32 VertexBufferSize { get; set; }
		[Ordinal(15)]  [RED("indexBufferSize")] public CUInt32 IndexBufferSize { get; set; }
		[Ordinal(16)]  [RED("indexBufferOffset")] public CUInt32 IndexBufferOffset { get; set; }
		[Ordinal(17)]  [RED("quantizationScale")] public Vector4 QuantizationScale { get; set; }
		[Ordinal(18)]  [RED("quantizationOffset")] public Vector4 QuantizationOffset { get; set; }

		public rendRenderMeshBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
