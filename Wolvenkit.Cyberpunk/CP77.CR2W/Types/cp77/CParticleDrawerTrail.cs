using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerTrail : IParticleDrawer
	{
		[Ordinal(0)]  [RED("dynamicTexCoords")] public CBool DynamicTexCoords { get; set; }
		[Ordinal(1)]  [RED("minSegmentsPer360Degrees")] public CInt32 MinSegmentsPer360Degrees { get; set; }
		[Ordinal(2)]  [RED("ribbonTesselationDelta")] public CFloat RibbonTesselationDelta { get; set; }
		[Ordinal(3)]  [RED("ribbonize")] public CBool Ribbonize { get; set; }
		[Ordinal(4)]  [RED("texturesPerUnit")] public CFloat TexturesPerUnit { get; set; }

		public CParticleDrawerTrail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
