using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ImageBasedFlareAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("curve")] public CFloat Curve { get; set; }
		[Ordinal(1)]  [RED("dispersal")] public CFloat Dispersal { get; set; }
		[Ordinal(2)]  [RED("distortion")] public CFloat Distortion { get; set; }
		[Ordinal(3)]  [RED("haloWidth")] public CFloat HaloWidth { get; set; }
		[Ordinal(4)]  [RED("saturation")] public curveData<CFloat> Saturation { get; set; }
		[Ordinal(5)]  [RED("scale")] public curveData<CFloat> Scale { get; set; }
		[Ordinal(6)]  [RED("tint", 8)] public CArrayFixedSize<CColor> Tint { get; set; }
		[Ordinal(7)]  [RED("treshold")] public CFloat Treshold { get; set; }

		public ImageBasedFlareAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
