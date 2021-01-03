using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkButtonTintController : inkButtonController
	{
		[Ordinal(0)]  [RED("DisableColor")] public CColor DisableColor { get; set; }
		[Ordinal(1)]  [RED("HoverColor")] public CColor HoverColor { get; set; }
		[Ordinal(2)]  [RED("NormalColor")] public CColor NormalColor { get; set; }
		[Ordinal(3)]  [RED("PressColor")] public CColor PressColor { get; set; }
		[Ordinal(4)]  [RED("TintControlRef")] public inkWidgetReference TintControlRef { get; set; }

		public inkButtonTintController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
