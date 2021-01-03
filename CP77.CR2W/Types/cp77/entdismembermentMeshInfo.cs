using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entdismembermentMeshInfo : CVariable
	{
		[Ordinal(0)]  [RED("AppearanceMap")] public CArray<entdismembermentAppearanceMatch> AppearanceMap { get; set; }
		[Ordinal(1)]  [RED("BodyPartMask")] public physicsRagdollBodyPartE BodyPartMask { get; set; }
		[Ordinal(2)]  [RED("CullMesh")] public entdismembermentWoundTypeE CullMesh { get; set; }
		[Ordinal(3)]  [RED("Mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(4)]  [RED("MeshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(5)]  [RED("Offset")] public Transform Offset { get; set; }
		[Ordinal(6)]  [RED("Physics")] public entdismembermentPhysicsInfo Physics { get; set; }
		[Ordinal(7)]  [RED("Scale")] public Vector3 Scale { get; set; }
		[Ordinal(8)]  [RED("ShouldReceiveDecal")] public CBool ShouldReceiveDecal { get; set; }
		[Ordinal(9)]  [RED("WoundType")] public entdismembermentWoundTypeE WoundType { get; set; }

		public entdismembermentMeshInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
