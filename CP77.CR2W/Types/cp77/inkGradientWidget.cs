using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkGradientWidget : inkBaseShapeWidget
	{
		[Ordinal(0)]  [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(1)]  [RED("endColor")] public HDRColor EndColor { get; set; }
		[Ordinal(2)]  [RED("gradientMode")] public CEnum<inkGradientMode> GradientMode { get; set; }
		[Ordinal(3)]  [RED("startColor")] public HDRColor StartColor { get; set; }

		public inkGradientWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
