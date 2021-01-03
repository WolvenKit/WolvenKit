using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
