using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkButtonTintController : inkButtonController
	{
		[Ordinal(10)] [RED("NormalColor")] public CColor NormalColor { get; set; }
		[Ordinal(11)] [RED("HoverColor")] public CColor HoverColor { get; set; }
		[Ordinal(12)] [RED("PressColor")] public CColor PressColor { get; set; }
		[Ordinal(13)] [RED("DisableColor")] public CColor DisableColor { get; set; }
		[Ordinal(14)] [RED("TintControlRef")] public inkWidgetReference TintControlRef { get; set; }

		public inkButtonTintController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
