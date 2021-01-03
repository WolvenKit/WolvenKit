using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ColorGradingAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("brightness")] public CFloat Brightness { get; set; }
		[Ordinal(1)]  [RED("contrast")] public CFloat Contrast { get; set; }
		[Ordinal(2)]  [RED("contrastPivot")] public CFloat ContrastPivot { get; set; }
		[Ordinal(3)]  [RED("forceHdrLut")] public CBool ForceHdrLut { get; set; }
		[Ordinal(4)]  [RED("gain")] public ColorBalance Gain { get; set; }
		[Ordinal(5)]  [RED("gammaValue")] public ColorBalance GammaValue { get; set; }
		[Ordinal(6)]  [RED("hdrLut")] public ColorGradingLutParams HdrLut { get; set; }
		[Ordinal(7)]  [RED("highRange")] public CFloat HighRange { get; set; }
		[Ordinal(8)]  [RED("highlightOffset")] public ColorBalance HighlightOffset { get; set; }
		[Ordinal(9)]  [RED("hue")] public CFloat Hue { get; set; }
		[Ordinal(10)]  [RED("ldrLut")] public ColorGradingLutParams LdrLut { get; set; }
		[Ordinal(11)]  [RED("lift")] public ColorBalance Lift { get; set; }
		[Ordinal(12)]  [RED("lowRange")] public CFloat LowRange { get; set; }
		[Ordinal(13)]  [RED("midtoneOffset")] public ColorBalance MidtoneOffset { get; set; }
		[Ordinal(14)]  [RED("offset")] public ColorBalance Offset { get; set; }
		[Ordinal(15)]  [RED("saturation")] public CFloat Saturation { get; set; }
		[Ordinal(16)]  [RED("shadowOffset")] public ColorBalance ShadowOffset { get; set; }

		public ColorGradingAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
