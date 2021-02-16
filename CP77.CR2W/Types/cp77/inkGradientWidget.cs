using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkGradientWidget : inkBaseShapeWidget
	{
		[Ordinal(20)] [RED("gradientMode")] public CEnum<inkGradientMode> GradientMode { get; set; }
		[Ordinal(21)] [RED("startColor")] public HDRColor StartColor { get; set; }
		[Ordinal(22)] [RED("endColor")] public HDRColor EndColor { get; set; }
		[Ordinal(23)] [RED("angle")] public CFloat Angle { get; set; }

		public inkGradientWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
