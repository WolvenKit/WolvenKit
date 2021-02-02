using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ImageBasedFlareAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("treshold")] public CFloat Treshold { get; set; }
		[Ordinal(1)]  [RED("dispersal")] public CFloat Dispersal { get; set; }
		[Ordinal(2)]  [RED("haloWidth")] public CFloat HaloWidth { get; set; }
		[Ordinal(3)]  [RED("distortion")] public CFloat Distortion { get; set; }
		[Ordinal(4)]  [RED("curve")] public CFloat Curve { get; set; }
		[Ordinal(5)]  [RED("tint", 8)] public CArrayFixedSize<CColor> Tint { get; set; }
		[Ordinal(6)]  [RED("scale")] public curveData<CFloat> Scale { get; set; }
		[Ordinal(7)]  [RED("saturation")] public curveData<CFloat> Saturation { get; set; }

		public ImageBasedFlareAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
