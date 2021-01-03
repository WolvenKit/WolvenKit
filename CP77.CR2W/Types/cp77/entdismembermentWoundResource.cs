using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundResource : ISerializable
	{
		[Ordinal(0)]  [RED("BodyPart")] public physicsRagdollBodyPartE BodyPart { get; set; }
		[Ordinal(1)]  [RED("CensoredCookedPaths")] public CArray<raRef<CResource>> CensoredCookedPaths { get; set; }
		[Ordinal(2)]  [RED("CensoredPaths")] public CArray<CUInt64> CensoredPaths { get; set; }
		[Ordinal(3)]  [RED("CensorshipValid")] public CBool CensorshipValid { get; set; }
		[Ordinal(4)]  [RED("CullObject")] public entdismembermentCullObject CullObject { get; set; }
		[Ordinal(5)]  [RED("Decals")] public CArray<entdismembermentWoundDecal> Decals { get; set; }
		[Ordinal(6)]  [RED("GarmentMorphStrength")] public CFloat GarmentMorphStrength { get; set; }
		[Ordinal(7)]  [RED("IsCritical")] public CBool IsCritical { get; set; }
		[Ordinal(8)]  [RED("Name")] public CName Name { get; set; }
		[Ordinal(9)]  [RED("Resources")] public CArray<entdismembermentWoundMeshes> Resources { get; set; }
		[Ordinal(10)]  [RED("UseProceduralCut")] public CBool UseProceduralCut { get; set; }
		[Ordinal(11)]  [RED("UseSingleMeshForRagdoll")] public CBool UseSingleMeshForRagdoll { get; set; }
		[Ordinal(12)]  [RED("WoundType")] public entdismembermentWoundTypeE WoundType { get; set; }

		public entdismembermentWoundResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
