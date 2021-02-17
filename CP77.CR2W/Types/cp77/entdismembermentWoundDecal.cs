using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundDecal : CVariable
	{
		[Ordinal(0)] [RED("OffsetA")] public Vector3 OffsetA { get; set; }
		[Ordinal(1)] [RED("OffsetB")] public Vector3 OffsetB { get; set; }
		[Ordinal(2)] [RED("Scale")] public CFloat Scale { get; set; }
		[Ordinal(3)] [RED("FadeOrigin")] public CFloat FadeOrigin { get; set; }
		[Ordinal(4)] [RED("FadePower")] public CFloat FadePower { get; set; }
		[Ordinal(5)] [RED("ResourceSets")] public CEnum<entdismembermentResourceSetMask> ResourceSets { get; set; }
		[Ordinal(6)] [RED("Material")] public raRef<IMaterial> Material { get; set; }

		public entdismembermentWoundDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
