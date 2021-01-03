using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerFacingBeam : IParticleDrawer
	{
		[Ordinal(0)]  [RED("debugTargetTranslation")] public Vector3 DebugTargetTranslation { get; set; }
		[Ordinal(1)]  [RED("dynamicTexCoords")] public CBool DynamicTexCoords { get; set; }
		[Ordinal(2)]  [RED("numSegments")] public CUInt32 NumSegments { get; set; }
		[Ordinal(3)]  [RED("sourceTangent")] public Vector4 SourceTangent { get; set; }
		[Ordinal(4)]  [RED("targetTangent")] public Vector4 TargetTangent { get; set; }
		[Ordinal(5)]  [RED("texturesPerUnit")] public CFloat TexturesPerUnit { get; set; }
		[Ordinal(6)]  [RED("transparencyLength")] public CFloat TransparencyLength { get; set; }
		[Ordinal(7)]  [RED("transparencyOffset")] public CFloat TransparencyOffset { get; set; }

		public CParticleDrawerFacingBeam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
