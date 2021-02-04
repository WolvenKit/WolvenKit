using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundResource : ISerializable
	{
		[Ordinal(0)]  [RED("Name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("WoundType")] public CEnum<entdismembermentWoundTypeE> WoundType { get; set; }
		[Ordinal(2)]  [RED("BodyPart")] public CEnum<physicsRagdollBodyPartE> BodyPart { get; set; }
		[Ordinal(3)]  [RED("CullObject")] public entdismembermentCullObject CullObject { get; set; }
		[Ordinal(4)]  [RED("GarmentMorphStrength")] public CFloat GarmentMorphStrength { get; set; }
		[Ordinal(5)]  [RED("UseProceduralCut")] public CBool UseProceduralCut { get; set; }
		[Ordinal(6)]  [RED("UseSingleMeshForRagdoll")] public CBool UseSingleMeshForRagdoll { get; set; }
		[Ordinal(7)]  [RED("IsCritical")] public CBool IsCritical { get; set; }
		[Ordinal(8)]  [RED("Resources")] public CArray<entdismembermentWoundMeshes> Resources { get; set; }
		[Ordinal(9)]  [RED("Decals")] public CArray<entdismembermentWoundDecal> Decals { get; set; }
		[Ordinal(10)]  [RED("CensoredPaths")] public CArray<CUInt64> CensoredPaths { get; set; }
		[Ordinal(11)]  [RED("CensoredCookedPaths")] public CArray<raRef<CResource>> CensoredCookedPaths { get; set; }
		[Ordinal(12)]  [RED("CensorshipValid")] public CBool CensorshipValid { get; set; }

		public entdismembermentWoundResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
