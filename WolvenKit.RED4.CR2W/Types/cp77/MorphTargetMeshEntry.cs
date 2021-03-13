using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MorphTargetMeshEntry : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("regionName")] public CName RegionName { get; set; }
		[Ordinal(2)] [RED("faceRegion")] public CEnum<MorphTargetsFaceRegion> FaceRegion { get; set; }
		[Ordinal(3)] [RED("boneNames")] public CArray<CName> BoneNames { get; set; }
		[Ordinal(4)] [RED("boneRigMatrices")] public CArray<CMatrix> BoneRigMatrices { get; set; }

		public MorphTargetMeshEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
