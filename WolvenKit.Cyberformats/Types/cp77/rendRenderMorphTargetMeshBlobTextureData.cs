using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderMorphTargetMeshBlobTextureData : CVariable
	{
		[Ordinal(0)] [RED("targetDiffScale", 3)] public CStatic<Vector4> TargetDiffScale { get; set; }
		[Ordinal(1)] [RED("targetDiffOffset", 3)] public CStatic<Vector4> TargetDiffOffset { get; set; }
		[Ordinal(2)] [RED("targetDiffsDataOffset", 3)] public CStatic<CUInt32> TargetDiffsDataOffset { get; set; }
		[Ordinal(3)] [RED("targetDiffsDataSize", 3)] public CStatic<CUInt32> TargetDiffsDataSize { get; set; }
		[Ordinal(4)] [RED("targetDiffsWidth", 3)] public CStatic<CUInt16> TargetDiffsWidth { get; set; }
		[Ordinal(5)] [RED("targetDiffsMipLevelCounts", 3)] public CStatic<CUInt8> TargetDiffsMipLevelCounts { get; set; }

		public rendRenderMorphTargetMeshBlobTextureData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
