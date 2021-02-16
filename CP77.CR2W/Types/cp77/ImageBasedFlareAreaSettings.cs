using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ImageBasedFlareAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("treshold")] public CFloat Treshold { get; set; }
		[Ordinal(3)] [RED("dispersal")] public CFloat Dispersal { get; set; }
		[Ordinal(4)] [RED("haloWidth")] public CFloat HaloWidth { get; set; }
		[Ordinal(5)] [RED("distortion")] public CFloat Distortion { get; set; }
		[Ordinal(6)] [RED("curve")] public CFloat Curve { get; set; }
		[Ordinal(7)] [RED("tint", 8)] public CArrayFixedSize<CColor> Tint { get; set; }
		[Ordinal(8)] [RED("scale")] public curveData<CFloat> Scale { get; set; }
		[Ordinal(9)] [RED("saturation")] public curveData<CFloat> Saturation { get; set; }

		public ImageBasedFlareAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
