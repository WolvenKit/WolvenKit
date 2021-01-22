using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MorphTargetMeshEntry : CVariable
	{
		[Ordinal(0)]  [RED("boneNames")] public CArray<CName> BoneNames { get; set; }
		[Ordinal(1)]  [RED("boneRigMatrices")] public CArray<CMatrix> BoneRigMatrices { get; set; }
		[Ordinal(2)]  [RED("faceRegion")] public CEnum<MorphTargetsFaceRegion> FaceRegion { get; set; }
		[Ordinal(3)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(4)]  [RED("regionName")] public CName RegionName { get; set; }

		public MorphTargetMeshEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
