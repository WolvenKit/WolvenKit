using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ColorGradingAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("contrast")] public CFloat Contrast { get; set; }
		[Ordinal(3)] [RED("contrastPivot")] public CFloat ContrastPivot { get; set; }
		[Ordinal(4)] [RED("saturation")] public CFloat Saturation { get; set; }
		[Ordinal(5)] [RED("hue")] public CFloat Hue { get; set; }
		[Ordinal(6)] [RED("brightness")] public CFloat Brightness { get; set; }
		[Ordinal(7)] [RED("lift")] public ColorBalance Lift { get; set; }
		[Ordinal(8)] [RED("gammaValue")] public ColorBalance GammaValue { get; set; }
		[Ordinal(9)] [RED("gain")] public ColorBalance Gain { get; set; }
		[Ordinal(10)] [RED("offset")] public ColorBalance Offset { get; set; }
		[Ordinal(11)] [RED("lowRange")] public CFloat LowRange { get; set; }
		[Ordinal(12)] [RED("shadowOffset")] public ColorBalance ShadowOffset { get; set; }
		[Ordinal(13)] [RED("midtoneOffset")] public ColorBalance MidtoneOffset { get; set; }
		[Ordinal(14)] [RED("highRange")] public CFloat HighRange { get; set; }
		[Ordinal(15)] [RED("highlightOffset")] public ColorBalance HighlightOffset { get; set; }
		[Ordinal(16)] [RED("ldrLut")] public ColorGradingLutParams LdrLut { get; set; }
		[Ordinal(17)] [RED("hdrLut")] public ColorGradingLutParams HdrLut { get; set; }
		[Ordinal(18)] [RED("forceHdrLut")] public CBool ForceHdrLut { get; set; }

		public ColorGradingAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
