using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentEffectResource : ISerializable
	{
		[Ordinal(0)] [RED("Name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("AppearanceNames")] public CArray<CName> AppearanceNames { get; set; }
		[Ordinal(2)] [RED("BodyPartMask")] public CEnum<physicsRagdollBodyPartE> BodyPartMask { get; set; }
		[Ordinal(3)] [RED("Offset")] public Transform Offset { get; set; }
		[Ordinal(4)] [RED("Placement")] public CEnum<entdismembermentPlacementE> Placement { get; set; }
		[Ordinal(5)] [RED("ResourceSets")] public CEnum<entdismembermentResourceSetMask> ResourceSets { get; set; }
		[Ordinal(6)] [RED("WoundType")] public CEnum<entdismembermentWoundTypeE> WoundType { get; set; }
		[Ordinal(7)] [RED("Effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(8)] [RED("MatchToWoundByName")] public CBool MatchToWoundByName { get; set; }

		public entdismembermentEffectResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
