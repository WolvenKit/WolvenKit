using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerFacingBeam : IParticleDrawer
	{
		[Ordinal(1)] [RED("texturesPerUnit")] public CFloat TexturesPerUnit { get; set; }
		[Ordinal(2)] [RED("dynamicTexCoords")] public CBool DynamicTexCoords { get; set; }
		[Ordinal(3)] [RED("transparencyOffset")] public CFloat TransparencyOffset { get; set; }
		[Ordinal(4)] [RED("transparencyLength")] public CFloat TransparencyLength { get; set; }
		[Ordinal(5)] [RED("numSegments")] public CUInt32 NumSegments { get; set; }
		[Ordinal(6)] [RED("sourceTangent")] public Vector4 SourceTangent { get; set; }
		[Ordinal(7)] [RED("targetTangent")] public Vector4 TargetTangent { get; set; }
		[Ordinal(8)] [RED("debugTargetTranslation")] public Vector3 DebugTargetTranslation { get; set; }

		public CParticleDrawerFacingBeam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
