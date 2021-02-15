using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentMeshInfo : CVariable
	{
		[Ordinal(0)] [RED("Mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(1)] [RED("MeshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(2)] [RED("AppearanceMap")] public CArray<entdismembermentAppearanceMatch> AppearanceMap { get; set; }
		[Ordinal(3)] [RED("ShouldReceiveDecal")] public CBool ShouldReceiveDecal { get; set; }
		[Ordinal(4)] [RED("BodyPartMask")] public CEnum<physicsRagdollBodyPartE> BodyPartMask { get; set; }
		[Ordinal(5)] [RED("WoundType")] public CEnum<entdismembermentWoundTypeE> WoundType { get; set; }
		[Ordinal(6)] [RED("CullMesh")] public CEnum<entdismembermentWoundTypeE> CullMesh { get; set; }
		[Ordinal(7)] [RED("Offset")] public Transform Offset { get; set; }
		[Ordinal(8)] [RED("Scale")] public Vector3 Scale { get; set; }
		[Ordinal(9)] [RED("Physics")] public entdismembermentPhysicsInfo Physics { get; set; }

		public entdismembermentMeshInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
