using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerFacingBeam : IParticleDrawer
	{
		[Ordinal(0)]  [RED("texturesPerUnit")] public CFloat TexturesPerUnit { get; set; }
		[Ordinal(1)]  [RED("dynamicTexCoords")] public CBool DynamicTexCoords { get; set; }
		[Ordinal(2)]  [RED("transparencyOffset")] public CFloat TransparencyOffset { get; set; }
		[Ordinal(3)]  [RED("transparencyLength")] public CFloat TransparencyLength { get; set; }
		[Ordinal(4)]  [RED("numSegments")] public CUInt32 NumSegments { get; set; }
		[Ordinal(5)]  [RED("sourceTangent")] public Vector4 SourceTangent { get; set; }
		[Ordinal(6)]  [RED("targetTangent")] public Vector4 TargetTangent { get; set; }
		[Ordinal(7)]  [RED("debugTargetTranslation")] public Vector3 DebugTargetTranslation { get; set; }

		public CParticleDrawerFacingBeam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
