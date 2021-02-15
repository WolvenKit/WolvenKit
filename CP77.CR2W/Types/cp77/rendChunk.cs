using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendChunk : CVariable
	{
		[Ordinal(0)] [RED("chunkVertices")] public rendVertexBufferChunk ChunkVertices { get; set; }
		[Ordinal(1)] [RED("chunkIndices")] public rendIndexBufferChunk ChunkIndices { get; set; }
		[Ordinal(2)] [RED("numVertices")] public CUInt16 NumVertices { get; set; }
		[Ordinal(3)] [RED("numIndices")] public CUInt32 NumIndices { get; set; }
		[Ordinal(4)] [RED("materialId")] public CArray<CName> MaterialId { get; set; }
		[Ordinal(5)] [RED("vertexFactory")] public CUInt8 VertexFactory { get; set; }
		[Ordinal(6)] [RED("baseRenderMask")] public CUInt16 BaseRenderMask { get; set; }
		[Ordinal(7)] [RED("mergedRenderMask")] public CUInt16 MergedRenderMask { get; set; }
		[Ordinal(8)] [RED("renderMask")] public CEnum<EMeshChunkFlags> RenderMask { get; set; }
		[Ordinal(9)] [RED("lodMask")] public CUInt8 LodMask { get; set; }

		public rendChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
