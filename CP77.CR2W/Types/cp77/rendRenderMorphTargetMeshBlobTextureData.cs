using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendRenderMorphTargetMeshBlobTextureData : CVariable
	{
		[Ordinal(0)]  [RED("targetDiffOffset")] public CStatic<3,Vector4> TargetDiffOffset { get; set; }
		[Ordinal(1)]  [RED("targetDiffScale")] public CStatic<3,Vector4> TargetDiffScale { get; set; }
		[Ordinal(2)]  [RED("targetDiffsDataOffset")] public CStatic<3,Uint32> TargetDiffsDataOffset { get; set; }
		[Ordinal(3)]  [RED("targetDiffsDataSize")] public CStatic<3,Uint32> TargetDiffsDataSize { get; set; }
		[Ordinal(4)]  [RED("targetDiffsMipLevelCounts")] public CStatic<3,Uint8> TargetDiffsMipLevelCounts { get; set; }
		[Ordinal(5)]  [RED("targetDiffsWidth")] public CStatic<3,Uint16> TargetDiffsWidth { get; set; }

		public rendRenderMorphTargetMeshBlobTextureData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
