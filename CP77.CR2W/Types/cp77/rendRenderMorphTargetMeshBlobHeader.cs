using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderMorphTargetMeshBlobHeader : CVariable
	{
		[Ordinal(0)]  [RED("version")] public CUInt32 Version { get; set; }
		[Ordinal(1)]  [RED("numDiffs")] public CUInt32 NumDiffs { get; set; }
		[Ordinal(2)]  [RED("numDiffsMapping")] public CUInt32 NumDiffsMapping { get; set; }
		[Ordinal(3)]  [RED("numTargets")] public CUInt32 NumTargets { get; set; }
		[Ordinal(4)]  [RED("targetStartsInVertexDiffs")] public CArray<CUInt32> TargetStartsInVertexDiffs { get; set; }
		[Ordinal(5)]  [RED("targetStartsInVertexDiffsMapping")] public CArray<CUInt32> TargetStartsInVertexDiffsMapping { get; set; }
		[Ordinal(6)]  [RED("targetPositionDiffScale")] public CArray<Vector4> TargetPositionDiffScale { get; set; }
		[Ordinal(7)]  [RED("targetPositionDiffOffset")] public CArray<Vector4> TargetPositionDiffOffset { get; set; }
		[Ordinal(8)]  [RED("numVertexDiffsInEachChunk")] public CArray<CArray<CUInt32>> NumVertexDiffsInEachChunk { get; set; }
		[Ordinal(9)]  [RED("numVertexDiffsMappingInEachChunk")] public CArray<CArray<CUInt32>> NumVertexDiffsMappingInEachChunk { get; set; }
		[Ordinal(10)]  [RED("targetTextureDiffsData")] public CArray<rendRenderMorphTargetMeshBlobTextureData> TargetTextureDiffsData { get; set; }

		public rendRenderMorphTargetMeshBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
