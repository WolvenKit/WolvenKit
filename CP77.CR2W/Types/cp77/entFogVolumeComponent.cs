using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entFogVolumeComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("densityFalloff")] public CFloat DensityFalloff { get; set; }
		[Ordinal(1)]  [RED("blendFalloff")] public CFloat BlendFalloff { get; set; }
		[Ordinal(2)]  [RED("densityFactor")] public CFloat DensityFactor { get; set; }
		[Ordinal(3)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(4)]  [RED("absorption")] public CFloat Absorption { get; set; }
		[Ordinal(5)]  [RED("size")] public Vector3 Size { get; set; }

		public entFogVolumeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
