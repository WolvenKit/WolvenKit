using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class STonemappingACESParams : CVariable
	{
		[Ordinal(0)]  [RED("minStops")] public CFloat MinStops { get; set; }
		[Ordinal(1)]  [RED("maxStops")] public CFloat MaxStops { get; set; }
		[Ordinal(2)]  [RED("midGrayScale")] public CFloat MidGrayScale { get; set; }
		[Ordinal(3)]  [RED("surroundGamma")] public CFloat SurroundGamma { get; set; }
		[Ordinal(4)]  [RED("toneCurveSaturation")] public CFloat ToneCurveSaturation { get; set; }
		[Ordinal(5)]  [RED("adjustWhitePoint")] public CBool AdjustWhitePoint { get; set; }
		[Ordinal(6)]  [RED("desaturate")] public CBool Desaturate { get; set; }
		[Ordinal(7)]  [RED("dimSurround")] public CBool DimSurround { get; set; }
		[Ordinal(8)]  [RED("tonemapLuminance")] public CBool TonemapLuminance { get; set; }
		[Ordinal(9)]  [RED("applyAfterLUT")] public CBool ApplyAfterLUT { get; set; }

		public STonemappingACESParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
